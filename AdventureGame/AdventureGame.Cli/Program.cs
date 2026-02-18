using AdventureGame.Core;

// Create core game systems and entities
RoomGeneration roomGeneration = new RoomGeneration();
Movement move = new Movement();
RecreateRoom update = new RecreateRoom();
Player p = new Player();
Monster m = new Monster();

// Generate the initial 10x10 room and store its 1D map representation
string roomData = roomGeneration.Generate(10, 10);

bool gameRunning = true;

// Initialize player stats
p.Name = "Eli";
p.AttackPower = 10;
p.Health = 100;

// Main game loop — continues until the game ends
while (gameRunning == true)
{
    // Process player movement and update the room data
    roomData = move.move(roomData, 10, 10, p);

    // If movement returns "Completed", end the game loop
    if (roomData == "Completed")
    {
        gameRunning = false;
        break;
    }
}

