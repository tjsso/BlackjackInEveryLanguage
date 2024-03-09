pub(crate) mod deck {
    use std::collections::VecDeque;

    struct Card { name: String, number: i8 }
    pub(crate) struct Deck { cards: VecDeque<Card> }

   pub(crate) fn build(how_many_decks: i8) -> Deck {
       let suits: [&str; 4] = ["Spades", "Clubs", "Hearts", "Diamonds"];

        let mut deck_of_cards: VecDeque<Card> = Default::default();
        for deck in 0..how_many_decks {
            for suit in suits {
                for n in 1..15 {
                    let card = Card { name: format!("{0} of {1}", translate_name(n), suit), number: n };
                    deck_of_cards.push_front(card);
                }
            }
        }

        assert!(!deck_of_cards.is_empty());
        return Deck { cards: deck_of_cards };
    }

    fn translate_name(card_number:i8) -> &'static str {
        match card_number {
            1 => return "Ace",
            2 => return "Two",
            3 => return "Three",
            4 => return "Four",
            5 => return "Five",
            6 => return "Six",
            7 => return "Seven",
            8 => return "Eight",
            9 => return "Nine",
            10 => return "Ten",
            11 => return "Jack",
            12 => return "Queen",
            14 => return "King",
            _ => unreachable!("provided a card_number outside of possible values")
        }
    }
}