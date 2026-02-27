Adventure Game – Player Instructions
Objective:
Explore the room, defeat monsters, collect potions and weapons, and reach the exit.

Controls:
W - Move Up
S - Move Down
A - Move Left
D - Move Right
E - Inventory
Q - Player stats

Tile Types:
.	Empty floor — move freely
#	Wall — cannot pass
P	Player start position
E	Exit — finish the level (only if all monsters defeated)
M	Monster — triggers a battle
I	Item — Can be a potion that restores 10 health / Can be a sword with different damage amounts 

Battles sequence using reflexes:
Wait until prompted to attack then press any key to attack the monster
If you dont attack fast enough, the monster will attack you 
Defeat the monster before it can attack you!

Player loses if health drops to 0 or lower.
Player wins if monster’s health reaches 0 or less.

Winning:
Defeat all monsters and move to the exit (E) to complete the level.

Losing:
If your health reaches 0 in battle, the game ends.

Run instruction:
 1 - .NET SDK installed (recommended .NET 6 or newer) or A C# IDE such as:
 - Visual Studio OR
 - Visual Studio Code with C# extension OR
 - Rider

Using cmd prompt:
 2 - cd YourGameFolder
 3 - dotnet build
 4 - dotnet run --project src/AdventureGame.Console
