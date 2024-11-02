mod test;

pub(crate) mod deck {
    use rand::seq::SliceRandom;

    #[derive(Debug, Clone)]
    pub(crate) struct Card { pub(crate) name: String, number: u8 }
    pub(crate) struct Deck {
        pub(crate) cards: Vec<Card>
    }

    impl PartialEq for Card {
        fn eq(&self, other: &Self) -> bool {
            self.name == other.name
        }
        fn ne(&self, other: &Self) -> bool {
            !self.eq(other)
        }
    }

    impl Deck {
        pub(crate) fn new(how_many_decks: i8) -> Self {
            Self::build(how_many_decks)
        }

        /// Generates the table's deck build out of a number of decks of 52 cards.
        fn build(mut how_many_decks: i8) -> Deck {
            let suits: [&str; 4] = ["Spades", "Clubs", "Hearts", "Diamonds"];

            let mut deck_of_cards: Vec<Card> = Vec::new();
            while how_many_decks > 0 {
                for suit in suits {
                    for n in 1..14 {
                        let card = Card { name: format!("{0} of {1}", translate_name(n), suit), number: n as u8 };
                        deck_of_cards.push(card);
                    }
                }
                how_many_decks -= 1;
            }

            deck_of_cards.shuffle(&mut rand::thread_rng());

            assert!(!deck_of_cards.is_empty());
            Deck { cards: deck_of_cards }
        }

        pub(crate) fn shuffle_deck(&mut self)  {
            self.cards.shuffle(&mut rand::thread_rng())
        }
    }

    fn translate_name(card_number: i8) -> &'static str {
        match card_number {
            1 => "Ace",
            2 => "Two",
            3 => "Three",
            4 => "Four",
            5 => "Five",
            6 => "Six",
            7 => "Seven",
            8 => "Eight",
            9 => "Nine",
            10 => "Ten",
            11 => "Jack",
            12 => "Queen",
            13 => "King",
            _ => unreachable!("provided a card_number outside of possible values: {}", card_number)
        }
    }
}