# HW4
## Devlog
In this project, I used the Model-View-Controller approach to separate the player's code from other systems, avoiding confusion and interdependencies between them. The "Bird" class acts as the "controller", responsible only for the player's actions, such as jumping and checking if they have passed through the pipe. However, it does not modify the score itself or interact with the UI. Every time the player scores, Bird does only one thing: it emits an "OnScore" event to inform the outside "I scored!" The part responsible for displaying the score is handled by the "ScoreUI", which is the "view" and only needs to update the number on the screen without needing to know how the player scored or communicate directly with the player's code.

Events and a Singleton further reinforce this decoupling. The ScoreManager acts as the central event subscriber, using its Singleton instance (ScoreManager.Instance) to listen for Bird.OnScore inside OnEnable(). When the event fires, AddScore() updates the score and plays the scoring sound, while the UI simply reads the updated value each frame. Because the controller only broadcasts events and the view only reads from the Singleton, the two layers remain cleanly separated and easy to maintain.



## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
