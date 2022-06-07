Start;
CreateWorld(RandomSeed);
CreatePlayer(atSpawnPoint);
GameLoop();
End;
// Create World
function createWorld(seed) {
  // Generate World Using Seed Implemntation isnt important
  generateRooms();
  // Map Rooms
  for (room of rooms) {
    // Develop some rules to pick the room
    match (room) {
      Rule1 => room.type = enemy;
      Rule2 => room.type = spawn;
    }
    // Spawn Enemys In Room
    if (room.type == enemy) {
      spawnEnemy(Corner);
      spawnEnemy(Corner);
      spawnEnemy(Corner);
      spawnEnemy(Corner);
    }
    // If spawn set the spawn point
  }
}
function createPlayer() {
  // Return a class with position, direction and inventory
  // Implementation doesnt matter
}
// Game Loop
function GameLoop() {
  // Handle Inputs
  handleInput();
  // Apply Physcis
  applyPhyscis();
  // Draw Rays
  for (let i = 0; i < screenWidth; i++) {
    castRay(i);
    drawPixel(dist);
  }
}
// Movement
function handleInput () {
  // Handle Input
  if (w) moveForward(); // methods are for simplification
  if (s) moveBackward();
  if (a) moveLeft();
  if (d) moveRight();
}
function applyPhysics() {
  // Handle Physics
  if (our position is in a matrix item) dont let move forward to that item.
}
// Cast Ray
function castRay() {} // Ray Cast Implementation is not yet implemented but it doesnt really matter.
function drawPixel(distance) {
  Takes the distance and projects it; 
  into 2d then draws with the correct color;
  at the correct height and size;
}