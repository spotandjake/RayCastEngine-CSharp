using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCastEngine.GameComponents {
  // Room Class
  class Room {
    public int x;
    public int y;
    public int w;
    public int h;
    public Vector3 center;
    public Room(int x, int y, int width, int height) {
      this.x = (x - 1); //column
      this.y = (y - 1); //row
      w = width; //width
      h = height; //height
      center = new Vector3(this.x + width / 2, this.y + height / 2, 0); //center
    }
  }
  // Cell Class
  class Cell {
    public int x;
    public int y;
    public bool empty = false; // Is this cell empty
    public Cell(int xPos, int yPos) {
      x = xPos; //x coord
      y = yPos; //y coord
    }
    public void carve(List<Room> rooms) {
      for (int i = 0; i < rooms.Count; i++) {
        if (
          x >= rooms[i].y &&
          x < rooms[i].y + rooms[i].h &&
          y >= rooms[i].x &&
          y < rooms[i].x + rooms[i].w
        ) {
          empty = true;
        }
      }
    }
    public void carveH(int dis, int x, int y) {
      if (this.x >= x && this.x < x + dis && this.y < y + 1 && this.y > y - 1) {
        empty = true;
      }
    }
    public void carveV(int dis, int x, int y) {
      if (this.y >= y && this.y < y + dis && this.x < x + 1 && this.x > x - 1) {
        empty = true;
      }
    }
    public bool isEmpty() {
      return empty;
    }
  }
  // Main Generator
  class DungeonGenerator {
    private int width;
    private int height;
    private Cell[] grid;
    private List<Room> rooms = new List<Room>();
    private int disX = 0;
    private Random RandomNumberGenerator = new Random();
    public DungeonGenerator(
      int mapWidth,
      int mapHeight
    ) {
      // Intialize Variables
      width = mapWidth;
      height = mapHeight;
      // Create Our World Grid
      grid = new Cell[mapWidth* mapHeight];
      for (int x = 0; x < mapWidth; x++) {
        for (int y = 0; y < mapHeight; y++) {
          grid[x * mapHeight + y] = new Cell(x, y); // TODO: Verify this index formula
        }
      }
      // Create Rooms
      createRooms();
    }
    // Export Map
    public int[,] exportMap() {
      int[,] map = new int[width,height];
      for (int i = 0; i < grid.Length; i++) {
        Cell currentCell = grid[i];
        map[currentCell.x, currentCell.y] = currentCell.isEmpty() ? 0 : 1;
      }
      return map;
    }
    public Vector3 getStartPosition() {
      return rooms[0].center;
    }
    // Methods
    private void createRooms() { // Create The Rooms
        const int size = 10;  //the actuall size will be a number bettween 5 and 10 | e.g: size+sizeMin
        const int sizeMin = 5;
        const int ammount = 20; // Number of rooms
        for (int i = 0; i < ammount; i++) {
          Room room = new Room(
            RandomNumberGenerator.Next(0, width),
            RandomNumberGenerator.Next(0, height),
            RandomNumberGenerator.Next(sizeMin, size),
            RandomNumberGenerator.Next(sizeMin, size)
          );
          bool collide = false; // They are not colliding
          if (i > 0) { // If Not The First Room
                       // TODO: Remove this possibility
            if (
              rooms[0].x + rooms[0].w >= width ||
              rooms[0].x <= 0 ||
              rooms[0].y + rooms[0].h >= height ||
              rooms[0].y <= 0
            ) { // If the first room is outside the canvas
              rooms = new List<Room>(); // Restart
              createRooms();
              break;
            }
            for (int e = 0; e < rooms.Count; e++) { // For all prevous rooms
              if (
                room.x <= rooms[e].x + rooms[e].w &&
                room.x + room.w >= rooms[e].x &&
                room.y <= rooms[e].y + rooms[e].h &&
                room.y + room.h >= rooms[e].y
              ) { // If colliding with teh prevous room
                collide = true; // kill Room
                i--;
                break;
              } else if (
                room.x + room.w >= width ||
                room.x <= 0 ||
                room.y + room.h >= height ||
                room.y <= 0
              ) { // If outside of canvas
                collide = true;
                i--;
                break;
              }
            }
          }
          if (!collide) {
          rooms.Add(room); // Add room to the array
            if (i > 0) { // Make Corridors
              hCorridor(
                (int)rooms[i - 1].center.x,
                (int)room.center.x,
                (int)rooms[i - 1].center.y,
                (int)room.center.y
              );
              vCorridor(
                (int)rooms[i - 1].center.x,
                (int)room.center.x,
                (int)rooms[i - 1].center.y,
                (int)room.center.y
              );
            }
          }
        }
        for (int i = 0; i < grid.Length; i++) {
          grid[i].carve(rooms);//carve out the rooms
        }
      }
    private void hCorridor(int x1, int x2, int y1, int y2) {//horizontal corridor creator
        if (x1 > x2) {//if the first room is further towards the right then the second one
          disX = x1 - x2; //find the distance between rooms
          disX += 1;
          for (int i = 0; i < grid.Length; i++) {
          grid[i].carveH(disX, x2, y2); //carve out the corridor
          }
        } else {//if the second room is further towards the right then the first one
          disX = x2 - x1; //find the distance between rooms
          disX += 1;
          for (int i = 0; i < grid.Length; i++) {
            grid[i].carveH(disX, x1, y1); //carve out corridor
          }
        }
      }

    private void vCorridor(int x1, int x2, int y1, int y2) {//vertical corridor creator
        int x;
        if (y1 > y2) { //if the first room is further towards the bottom then the second one
          int disY = y1 - y2; //find the distance between rooms
          disY += 1;

          if (x2 + (disX - 1) > x1 + (disX - 1)) {//find the correct x coord
            x = x2;
          } else {
            x = x2 + (disX - 1);
          }

          for (var i = 0; i < grid.Length; i++) {
            grid[i].carveV(disY, x, y2); //carve out corridor
          }
        } else {//if the second room is further towards the bottom then the first one
          int disY = y2 - y1; //find the distance between rooms
          disY += 1;
          if (x1 + (disX - 1) > x2 + (disX - 1)) {//find the correct x coord
            x = x1;
          } else {
            x = x1 + (disX - 1);
          }
          for (int i = 0; i < grid.Length; i++) {
            grid[i].carveV(disY, x, y1); //carve out corridor
          }
        }
      }
    }
}
