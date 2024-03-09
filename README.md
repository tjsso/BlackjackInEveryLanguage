# BlackjackInEveryLanguage
When I learn a language I like to make the game Blackjack. This repo is where I keep them all.

I am traditionally a back-end developer and so focus on backend languages for this project. I start off with a simple CLI to play the game and upgrade over time to include a GUI if the language has libraries that support a simple GUI. However, in future I am tempted to produce a single Web UI (React or Angular, unless something else comes along) and then have the same web (REST) endpoints in each language so that the web interface in the same across the board and each language is Docker-(or podman)-ised. 

UI & Docker versions are a long-term vision, for the most part these projects will be CLI only or built in UI only.

## Checklist:
- [ ] Model a deck of cards (Array[], List, Map, etc)
- [ ] Create a model of a Player, who can:
  - [ ] Hit
  - [ ] Stand 
- [ ] Use inheritance to create a Player > Dealer:
  - [ ] Deal
  - [ ] shuffles deck
- [ ] create a Player > Gambler:
  - [ ] Bet
  - [ ] Balance
- [ ] Model table:
  - [ ] has a deck of cards (or multiple)
  - [ ] runs game?
### Optional upgrades:
- [ ] Create database (any framework/DB)
  - [ ] Save games?
  - [ ] player login's/tracking
  - [ ] any other gameplay improvements from DB?
- [ ] Create web server
  - [ ] create REST endpoints to allow playing of game via browser console
- [ ] Dockerise
 
## Lanaguages Completed:
- [ ] Java (Done but not in Repo)
- [ ] Visual Basic (Done but not in Repo, i'd be lucky to find this again)
- [ ] Haskell
- [ ] Rust
- [ ] Kotlin
- [ ] C#
- [ ] C++
- [ ] Python
