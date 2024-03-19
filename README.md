# CS596-First-Multiplayer-Game
First Multiplayer Game with unity
Name:
Michael Lee
825402520

Assignment:
Multiplayer Project

Game:
2 Player Coin Collecting

Setup:
When game loads either press Server or Host button
If server you need 3 windows, 1 for server and 2 for players
If host you only need one other window and press client for 2nd window
Restart application once game is over

Goal:
Collect coins and reach 3 points to win
Beware all coins don't look the same
If no one gets 3 points in 2 minutes then Game Over

Movement:
WASD movement
Space bar jump
Wall jumping

Controls:
WASD controls for movement
Space to jump

Sounds:
1. Walking
2. Jumping
3. Colliding with other player
4. Plus point
5. Minus point
6. Winning

README:
I originally attempted to create it so each player gets their own POV camera but no guides online were helpful in that regard and I attempted the assignment too late to ask for assistance on the each player has their own camera.
Sadly the wall climbing feature I originally implemented no longer worked but I was able to fix the wall jumping mechanic. The walking sound should not play during wall climbing or air time. 

Other than that it's a standard coin collecting game. The three buttons on the top right are for connection options being Server, Host, Client.
For server it requires 3 windows of the game. If not server then one can host then the other can join.

The text on the top left show the points of each respective player. A timer at the bottom right, 2 minutes. 

I didn't specify who's the winner on the winner screen, not because I am lazy but you're all winners in my heart. Goal was to reach 3 points, never said you had to beat your appoint.

Problems:
I didn't implement a system for when more than 2 players join, no limiter or robust system. If more than two players join it's the client player(s) vs the host player.
The timer starts the moment every loads in not when the actual game starts, pressing Host or Client. I could have fixed it but I was too burned out from doing everything in 3 days.
The two different coins are bronze and red color. Very hard to tell at the camera distance I set, but I guess it's now part of the experience.

What did I learn:
It was easy making the game mechanics under the idea of a single player game. The hard part wasn't making the game mechanics but the multiplayer aspect.
Being able to distuingish each player to know which player gets which points. Trying to have a first person POV for each player was nightware and had to opt to a still camera looking on the field.
Fortunately I could salvage the wall jumping but the wall climbing was gone. You can technically still climb if climb with the W key but not a flushed out feature any more.
