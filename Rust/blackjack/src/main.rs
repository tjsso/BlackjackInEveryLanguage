use std::cmp::min;
use std::io::stdin;
use std::ops::Add;
use std::process::exit;
use std::str::FromStr;
use crate::player::{Dealer, Player};
use crate::table::deck::{Card, Deck};

mod player;
mod table;

fn main() {
    
    //TODO print out rules, i.e. bets limited to 100
    
    let mut deck = Deck::new(3);
    let mut money_pot : usize = 0;

    let mut dealer = Dealer::new();
    let mut player = Player::new(10);

    let num_of_players : u8 = 2;
    let mut player_hand_total : u16 = 0;

    // CAUTION, potentially infinite loop
    // while let game_alive = true  {
    loop {
        //clear terminal between rounds
        for _ignore in 0..num_of_players {
            dealer.hand.push(deck.deal_card());
            player.hand.push(deck.deal_card());
        }

        // let mut lock = stdout().lock();
        println!("Dealer has {} and 1 card face-down.\n You (balance {}) have {} & {}.",
                 dealer.hand.first().unwrap().name,
                 player.balance,
                 player.hand.first().unwrap().name,
                 player.hand.get(1).unwrap().name
            );

        let mut player_input = String::new();
        player_hand_total = calculate_hand(&player.hand);
        money_pot = 0;
        while player_input.to_lowercase().trim() != "stand" {
            player_input.clear();
            //TODO can player bet every turn? good for now, check with rules and adjust accordingly
            println!( "Take Action - hit, stand, bet N, leave :");
            stdin().read_line(&mut player_input).unwrap();

            match player_input.to_lowercase().trim() {
                "hit" => {
                    player.hand.push(deck.deal_card());
                    player.print_hand();
                    player_hand_total = calculate_hand(&player.hand);
                    if player_hand_total > 21 {
                        println!("You have BUST! With a total of {}", player_hand_total);
                        //option to break; or "stand" TODO investigate performance benefit of either option
                        player_input = String::from("stand");
                        // break;
                    }
                },
                bet if bet.starts_with("bet") => {
                    let bet_amount = bet.strip_prefix("bet").unwrap().trim();
                    player.bet(min(u128::from_str(bet_amount).unwrap(), 100));
                    money_pot = money_pot.add(usize::from_str(bet_amount).unwrap());
                },
                "leave" => {
                    println!("Ending Game...");
                    exit(0)
                },
                "stand" => { 
                    //do nothing
                },
                _ => {
                    println!("Unrecognized option. Please try again.");
                }
            }
        }
        
        let mut dealer_hand_total = calculate_hand(&dealer.hand);
        if player_hand_total > 21 || dealer_hand_total >= player_hand_total {
            println!("Dealer has cards {}. \nThis totals to {} vs your {}. Player BUSTS, Dealer wins.",
                dealer.hand.iter().map(|card| card.name.clone()).collect::<Vec<_>>().join(", "), 
                dealer_hand_total, 
                player_hand_total);
            println!("Would you like to keep playing? Y/N: ");
            player_input.clear();
            stdin().read_line(&mut player_input).unwrap();
            if player_input.to_lowercase().trim() == "n" || player_input.to_lowercase().trim() == "no" {
                println!("You are leaving the table with a balance of {}", player.balance);
                exit(1);
            }
        } else {
            println!("Dealer started with cards {}, totaling: {}",
                     dealer.hand.iter().map(|card| card.name.clone()).collect::<Vec<_>>().join(", "),
                     dealer_hand_total);

            //TODO dealer logic just keeps going until it beats or busts. Do better logic to remain within 21.
            while dealer_hand_total < 22 {
                dealer.hand.push(deck.deal_card());
                println!("Dealer draws {}", dealer.hand.last().unwrap().name);
                dealer_hand_total = calculate_hand(&dealer.hand);
                if dealer_hand_total > 21 {
                    println!("Dealer BUST! With a total of {}!", dealer_hand_total);
                    break;
                } else if dealer_hand_total >= player_hand_total {
                    println!("Dealer has a total hand of {}, this beats the players {}. Player loses.", dealer_hand_total, player_hand_total);
                    break;
                }
            }
        }
        
        //If we get this far it means the player the must have the winning hand - TODO do better
        if player_hand_total < 22 && (player_hand_total > dealer_hand_total || dealer_hand_total > 21) {
            println!("Congratulations! You won the hand!, you received {} to your balance.", money_pot*2);
            player.balance = player.balance.add(money_pot as u128 * 2);
        }
        
        //reset game
        player.hand = Vec::new();
        dealer.hand = Vec::new();
    } // end of game loop
}

fn calculate_hand(hand: &Vec<Card>) -> u16 {
    let mut hand_total : u16 = 0;
    for card in hand.iter().filter(|x| x.number != 1) {
        hand_total += card.number as u16;
        if hand_total >= u16::MAX { return u16::MAX }
    }
    
    //Aces can be either 1 or 11. Pick the best outcome.
    for card in hand.iter().filter(|x| x.number == 1) {
        if hand_total < 11 {
            hand_total += 11;
        } else {
            hand_total += card.number as u16;
        }
    }
    hand_total //implicit return
}
