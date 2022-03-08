using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;

namespace RayCastEngine.GameComponents {
  // Room Types
  enum RoomTypes {
    Unknown,
    Empty,
    Spawn,
    Loot,
    NormalFight,
    Boss
  }
  // Room Class
  class Room {
    public int x;
    public int y;
    public int w;
    public int h;
    public Vector3 center;
    public RoomTypes RoomType = RoomTypes.Unknown;
    public Room(int x, int y, int width, int height) {
      this.x = (x - 1); //column
      this.y = (y - 1); //row
      w = width; //width
      h = height; //height
      center = new Vector3(this.x + width / 2.0f, this.y + height / 2.0f, 0); //center
    }
  }
  // Cell Class
  class Cell {
    public int x;
    public int y;
    public Texture texture = Texture.ColorStoneWall; // Is this cell empty
    public Cell(int xPos, int yPos) {
      x = xPos; //x coord
      y = yPos; //y coord
    }
    public void carve(List<Room> rooms) {
      for (int i = 0; i < rooms.Count; i++) {
        Room room = rooms[i];
        if (
          y >= room.y &&
          y < room.y + room.h &&
          x >= room.x &&
          x < room.x + room.w
        ) {
          texture = Texture.Air;
        } else if (
          y >= room.y - 1 &&
          y < room.y + room.h + 1 &&
          x >= room.x - 1 &&
          x < room.x + room.w + 1 &&
          texture != Texture.Air
         ) {
          texture = Texture.RedBrickWall;
          if (
            (
              x % 2 == 0 &&
              x == (int)room.center.X
            ) ||
            (
              y % 2 == 0 &&
              y == (int)room.center.Y
            )
          ) {
            texture = Texture.EagleWall;
          }
        }
      }
    }
    public void carveH(Random randomGenerator, int dis, int x, int y) {
      if (this.x >= x && this.x < x + dis && this.y < y + 1 && this.y > y - 1) {
        texture = Texture.Air;
      } else if (randomGenerator.Next(0, 10) == 1 && texture != Texture.Air) {
        texture = Texture.MossyWall;
      } else if (randomGenerator.Next(0, 10) != 1 && texture != Texture.Air) {
        texture = Texture.ColorStoneWall;
      }
    }
    public void carveV(Random randomGenerator, int dis, int x, int y) {
      if (this.y >= y && this.y < y + dis && this.x < x + 1 && this.x > x - 1) {
        texture = Texture.Air;
      } else if (randomGenerator.Next(0, 10) == 1 && texture != Texture.Air) {
        texture = Texture.MossyWall;
      } else if (randomGenerator.Next(0, 10) != 1 && texture != Texture.Air) {
        texture = Texture.ColorStoneWall;
      }
    }
    public bool isEmpty() {
      return texture == Texture.Air;
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
      grid = new Cell[mapWidth * mapHeight];
      for (int x = 0; x < mapWidth; x++) {
        for (int y = 0; y < mapHeight; y++) {
          grid[x * mapHeight + y] = new Cell(x, y); // TODO: Verify this index formula
        }
      }
      // Create Rooms
      createRooms();
    }
    // Export Map
    public Texture[,] exportMap() {
      Texture[,] map = new Texture[width, height];
      for (int i = 0; i < grid.Length; i++) {
        Cell currentCell = grid[i];
        map[currentCell.x, currentCell.y] = currentCell.texture;
      }
      return map;
    }
    public Sprite[] getEntityPositions() {
      List<Sprite> sprites = new List<Sprite>();
      // TODO: Optimize this
      // Generate Light Positions
      for (int roomIndex = 0; roomIndex < rooms.Count; roomIndex++) {
        Vector3 roomCenter = rooms[roomIndex].center;
        sprites.Add(new Sprite(new Vector3(roomCenter.X, roomCenter.Y, 0), Vector3.Zero, Texture.GreenLight)
        );
      }
      // Generate Barrel Positions
      for (int roomIndex = 0; roomIndex < rooms.Count; roomIndex++) {
        Room currentRoom = rooms[roomIndex];
        if (currentRoom.RoomType == RoomTypes.Loot) {
          sprites.Add(new Sprite(new Vector3(currentRoom.x + 1, currentRoom.center.Y - 1, 0), Vector3.Zero, Texture.BarrelEntity));
          sprites.Add(new Sprite(new Vector3(currentRoom.x + 1, currentRoom.center.Y, 0), Vector3.Zero, Texture.BarrelEntity));
          sprites.Add(new Sprite(new Vector3(currentRoom.x + 1, currentRoom.center.Y + 1, 0), Vector3.Zero, Texture.BarrelEntity));

          sprites.Add(new Sprite(new Vector3(currentRoom.x + currentRoom.w - 1, currentRoom.center.Y - 1, 0), Vector3.Zero, Texture.BarrelEntity));
          sprites.Add(new Sprite(new Vector3(currentRoom.x + currentRoom.w - 1, currentRoom.center.Y, 0), Vector3.Zero, Texture.BarrelEntity));
          sprites.Add(new Sprite(new Vector3(currentRoom.x + currentRoom.w - 1, currentRoom.center.Y + 1, 0), Vector3.Zero, Texture.BarrelEntity));
        }
      }
      // Generate Column Positions
      for (int roomIndex = 0; roomIndex < rooms.Count; roomIndex++) {
        Room currentRoom = rooms[roomIndex];
        if (currentRoom.w >= 8 && currentRoom.h >= 8) {
          sprites.Add(new Sprite(new Vector3(currentRoom.x + 1, currentRoom.y + 1, 0), Vector3.Zero, Texture.PillarEntity));
          sprites.Add(new Sprite(new Vector3(currentRoom.x + currentRoom.w - 1, currentRoom.y + 1, 0), Vector3.Zero, Texture.PillarEntity));

          sprites.Add(new Sprite(new Vector3(currentRoom.x + 1, currentRoom.y + currentRoom.h - 1, 0), Vector3.Zero, Texture.PillarEntity));
          sprites.Add(new Sprite(new Vector3(currentRoom.x + currentRoom.w - 1, currentRoom.y + currentRoom.h - 1, 0), Vector3.Zero, Texture.PillarEntity));
        }
      }
      // Return The Sprites As An Array
      return sprites.ToArray();

    }
    // Spawn Enemys
    public List<Enemy> getEnemyPositions() {
      List<Enemy> enemys = new List<Enemy>();
      // Set Enemy Positions
      for (int roomIndex = 1; roomIndex < rooms.Count; roomIndex++) { // We Start at 1 because the spawn room should be safe
        Room currentRoom = rooms[roomIndex];
        // Spawn Stuff Based On Room Type
        if (currentRoom.RoomType == RoomTypes.NormalFight) {
          // TODO: Work On Enemy Spawn pattern
          const Texture EnemyTexture = Texture.Boss_1; // TODO: Add Enemy Texture
          enemys.Add(new Enemy(currentRoom.x + 3, currentRoom.y + 3, EnemyTexture, false));
          enemys.Add(new Enemy(currentRoom.x + currentRoom.w - 3, currentRoom.y + 3, EnemyTexture, false));

          enemys.Add(new Enemy((int)currentRoom.center.X, (int)currentRoom.center.Y, EnemyTexture, false));

          enemys.Add(new Enemy(currentRoom.x + 3, currentRoom.y + currentRoom.h - 3, EnemyTexture, false));
          enemys.Add(new Enemy(currentRoom.x + currentRoom.w - 3, currentRoom.y + currentRoom.h - 3, EnemyTexture, false));
        } else if (currentRoom.RoomType == RoomTypes.Boss) {
          Texture EnemyTexture;
          int RoomProbability = RandomNumberGenerator.Next(0, 2);
          if (RoomProbability == 1) {
            EnemyTexture = Texture.Boss_2;
          } else if (RoomProbability == 2) {
            EnemyTexture = Texture.Boss_3;
          } else {
            EnemyTexture = Texture.Boss_1;
          }
          // TODO: Work On Enemy Spawn pattern
          enemys.Add(new Enemy(currentRoom.x + 3, currentRoom.y + 3, Texture.Boss_3_Minion_1, false));
          enemys.Add(new Enemy(currentRoom.x + currentRoom.w - 3, currentRoom.y + 3, Texture.Boss_3_Minion_1, false));

          enemys.Add(new Enemy((int)currentRoom.center.X, (int)currentRoom.center.Y, EnemyTexture, true));

          enemys.Add(new Enemy(currentRoom.x + 3, currentRoom.y + currentRoom.h - 3, Texture.Boss_3_Minion_1, false));
          enemys.Add(new Enemy(currentRoom.x + currentRoom.w - 3, currentRoom.y + currentRoom.h - 3, Texture.Boss_3_Minion_1, false));
        }
      }
      // Return Enemys
      return enemys;
    }
    public Vector3 getStartPosition() {
      return rooms[0].center;
    }
    // Methods
    private void createRooms() { // Create The Rooms
      const int size = 20;  //the actuall size will be a number bettween 5 and 10 | e.g: size+sizeMin
      const int sizeMin = 5;
      const int ammount = 50; // Number of rooms
      int BossRoomCount = 0;
      for (int i = 0; i < ammount; i++) {
        int roomWidth = RandomNumberGenerator.Next(sizeMin, size);
        int roomHeight = RandomNumberGenerator.Next(sizeMin, size);
        Room room = new Room(
          RandomNumberGenerator.Next(1, width - roomWidth - 1),
          RandomNumberGenerator.Next(1, height - roomHeight - 1),
          roomWidth,
          roomHeight
        );
        // Determine Room Type
        int RoomProbability = RandomNumberGenerator.Next(0, 10);
        if (i == 0 || i < 1) {
          room.RoomType = RoomTypes.Spawn;
        } else if (RoomProbability < 3 && roomWidth < 8 && roomHeight < 8) {
          room.RoomType = RoomTypes.Loot;
        } else if (BossRoomCount < 20 && RoomProbability < 10 && roomWidth > 7 && roomHeight > 7) {
          BossRoomCount++;
          room.RoomType = RoomTypes.Boss;
        } else if (RoomProbability < 9 && roomWidth > 5 && roomHeight > 5) {
          room.RoomType = RoomTypes.NormalFight;
        } else {
          room.RoomType = RoomTypes.Empty;
        }
        // Check If Room Is Valid
        bool collide = false; // They are not colliding
        if (i > 0) { // If Not The First Room
          for (int e = 0; e < rooms.Count; e++) { // For all rooms
            if (
              room.x <= rooms[e].x + rooms[e].w &&
              room.x + room.w >= rooms[e].x &&
              room.y <= rooms[e].y + rooms[e].h &&
              room.y + room.h >= rooms[e].y
            ) { // If colliding with another room
              collide = true; // Then this room is invalid
              i--;
              break;
            }
          }
        }
        if (!collide) {
          rooms.Add(room); // Add room to the array
          if (i > 0) { // Make Corridors
            hCorridor(
              (int)rooms[i - 1].center.X,
              (int)room.center.X,
              (int)rooms[i - 1].center.Y,
              (int)room.center.Y
            );
            vCorridor(
              (int)rooms[i - 1].center.X,
              (int)room.center.X,
              (int)rooms[i - 1].center.Y,
              (int)room.center.Y
            );
          }
        }
      }
      for (int i = 0; i < grid.Length; i++) {
        grid[i].carve(rooms);//carve out the rooms
      }
    }
    private void hCorridor(int x1, int x2, int y1, int y2) {//horizontal corridor creator
      disX = (x1 > x2 ? (x1 - x2) : (x2 - x1)) + 1; //find the distance between rooms
      int x = x1 > x2 ? x2 : x1;
      int y = x1 > x2 ? y2 : y1;
      for (int i = 0; i < grid.Length; i++) {
        grid[i].carveH(RandomNumberGenerator, disX, x, y); //carve out corridor
      }
    }

    private void vCorridor(int x1, int x2, int y1, int y2) {//vertical corridor creator
      int disY = (y1 > y2 ? (y1 - y2) : (y2 - y1)) + 1; //find the distance between rooms
      int oppsideX = y1 > y2 ? x1 : x2;
      int x = y1 > y2 ? x2 : x1;
      int y = y1 > y2 ? y2 : y1;
      if (!(x + (disX - 1) > oppsideX + (disX - 1))) x += (disX - 1);
      for (int i = 0; i < grid.Length; i++) {
        grid[i].carveV(RandomNumberGenerator, disY, x, y); //carve out corridor
      }
    }
  }
}
