Unity
=====

We'll be making a basic game in Unity.

Scene: The main place where you see the game
Animator: Where you define the transitions for each of the items on the Scene - for example Player. 

1. What we're starting with is a basic animation for our player. We also have an idle animation ready that we'll be able to use and link later on.
2. All this has are sprites: sprite is a two-dimensional image or animation (2D computer graphics) that is integrated into a larger scene. In this project we have a collection of sprites that we will use to build our game.
3. Rename to player-sprite to Player
4. There is a clear structure to the folders. There is an Assets Folder with Animations, Artwork, Scenes, and Scripts
5. We have to make the animations to allow the player to fly, move, and just interact with his surroundings.
6. We also have to build those surroundings.
7. There are two ways to animate any particular thing.
8. We go into the folder Artwork -> sprite-sheets, and here is a collection of sprite images.
9. We select the player-sprites in the folder.
10. The slider at the bottom controls how much we are able to see of the image, so slide it to the right!
11. Sprites-sheet is just a sequence of sprite images that help us create an animation. They are images that allow you to animate things like movement.
12. Select sprites starting at player-sprite_5, hold shift, and click sprite player-sprite_14.
13. Call it PlayerWaitAnimation and save it inside Assets/Animations folder and *NOT* inside the folder it saves in defaultly.
14. Select sprites starting at player-sprite_15, hold shift and click sprite player-sprite_22. 
15. Call it PlayerMoveAnimation and save it inside Assets/Animations folder and *NOT* inside the folder it saves in defaultly.
14. Click play, and you should see it animate. You have successfully created two animations!!
15. We don't need them in the game because they are different players, but how the player reacts in the game.
16. So we can remove them. Right click them on the left window and click delete!
17. Now if you look in the Animation folder you should see both of your Animations there.
18. Make a Prefab folder in the Assets by right clicking on the Assets.
19. From the left hand window of Hierarchy drag your Player into the Prefab folder. Note that you can't drag a player from the Game scene.
20. Now lets talk about the Animator. Click the Animator on the top window.
21. Now if we select on Player on the left hand side we can see The JetAnimation and the IdleAnimation, which were included.
22. Now click the Animations folder on the bottom, and drag the Animations onto the Animator window. Doesn't matter where you place them just drag them onto the Animations.
23. If you click the 2D bottom you can see our game on there.
24. Lets add more sprites onto the scene!!
25. Now find the block-sprites in the sprites folder.
26. Now drag the block-sprites_4 onto the main Scene.
27. Now we have the platform on there. Now click on it and zoom and expand the platform using the keys. If you press Shift then you can see the controls.
28. Now that we have a platform and you've sized it correctly we can begin to add gravity.
29. If you click play right now the person will just fall right through
