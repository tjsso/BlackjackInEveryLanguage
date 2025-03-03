use std::ops::Sub;
use crate::table::deck::Card;

pub(crate) struct Dealer { pub(crate) hand: Vec<Card> }

pub(crate) struct Player  { pub(crate) hand: Vec<Card>, pub(crate) balance: u128 }

impl Dealer {
    pub(crate) fn new() -> Self { Dealer { hand: Vec::new() } }

}

impl Player {
    pub(crate) fn new(balance: u128) -> Self {
        Player {
            hand: Vec::new(), balance
        }
    }

    pub(crate) fn bet(&mut self, amount: u128) {
        self.balance = self.balance.sub(amount);
    }
    
    pub(crate) fn print_hand(&self) {
        println!("Cards in hand : {}", self.hand.iter().map(|card| card.name.clone()).collect::<Vec<_>>().join(", ") );
    }
}

