#[allow(unused_imports)]
use crate::table::deck::Deck;

#[cfg(test)]

#[test]
fn test_building_a_deck() {
    let deck = Deck::new(1);
    assert!(!deck.cards.is_empty());
    assert_eq!(deck.cards.len(), 52);

    let first_card = deck.cards.first().unwrap();
    let second_card = deck.cards.get(1).unwrap();

    // Test randomizing/shuffling of decks
    if first_card.name == "Ace of Spades" {
        // it's possible first card remains as Ace of Spades, in this instance 2nd card shouldn't be Two of Spades.
        // Very, Very small possibility this occurs legitimately.
        assert_ne!(second_card.name, "Two of Spades");
    } else {
        assert_ne!(first_card.name, "Ace of Spades");
    }
}

#[test]
fn test_shuffle_deck() {
    let mut deck = Deck::new(1);
    let first_card = deck.cards.get(0).unwrap().clone();
    deck.shuffle_deck();
    let shuffled_first_card = deck.cards.get(0).unwrap().clone();

    assert_ne!(first_card, shuffled_first_card)
}