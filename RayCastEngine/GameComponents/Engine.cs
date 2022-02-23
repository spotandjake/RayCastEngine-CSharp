﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using RayCastEngine.Views;
namespace RayCastEngine.GameComponents {
  // Our Main Engine
  class Engine {
    // Properties
    public bool GameStateChanged = true;
    public Size Resolution;
    public Dictionary<int, bool> keys = new Dictionary<int, bool>();
    // Temporary Engine Variables
    private int texWidth = 64;
    private int texHeight = 64;
    private static int worldSizeX = 240;
    private static int worldSizeY = 240;
    //private int[,] worldMap = new int[,] {
    //    { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
    //    { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
    //    { 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5 }
    //};
    private int[,] worldMap;
    private Dictionary<Texture, DirectBitmap> textures = new Dictionary<Texture, DirectBitmap>();
    private double[] ZBuffer;
    private DirectBitmap buffer;
    private Vector3 position = new Vector3(22.0, 11.5, 0.0);
    private Vector3 direction = new Vector3(-1.0, 0.0, 0.0); // dirX, dirY, camPitch
    private Vector3 plane = new Vector3(0.0, 0.66, 0.0); // planeX, planeY
    private Sprite[] sprites;
    // Methods
    public void Load(GameType gameType) {
      // Initialize
      // Load Map
      DungeonGenerator dungeonBuilder = new DungeonGenerator(worldSizeX, worldSizeY);
      worldMap = dungeonBuilder.exportMap();
      position = dungeonBuilder.getStartPosition();
      // Load Images
      textures.Add(Texture.EagleWall, DirectBitmap.fromBitmap(RayCastEngine.Properties.Resources.eagle));
      textures.Add(Texture.RedBrickWall, DirectBitmap.fromBitmap(RayCastEngine.Properties.Resources.redbrick));
      textures.Add(Texture.PurpleStoneWall, DirectBitmap.fromBitmap(RayCastEngine.Properties.Resources.purplestone));
      textures.Add(Texture.GreyStoneWall, DirectBitmap.fromBitmap(RayCastEngine.Properties.Resources.greystone));
      textures.Add(Texture.BlueStoneWall, DirectBitmap.fromBitmap(RayCastEngine.Properties.Resources.bluestone));
      textures.Add(Texture.MossyWall, DirectBitmap.fromBitmap(RayCastEngine.Properties.Resources.mossy));
      textures.Add(Texture.WoodWall, DirectBitmap.fromBitmap(RayCastEngine.Properties.Resources.wood));
      textures.Add(Texture.ColorStoneWall, DirectBitmap.fromBitmap(RayCastEngine.Properties.Resources.colorstone));
      textures.Add(Texture.BarrelEntity, DirectBitmap.fromBitmap(RayCastEngine.Properties.Resources.barrel));
      textures.Add(Texture.PillarEntity, DirectBitmap.fromBitmap(RayCastEngine.Properties.Resources.pillar));
      textures.Add(Texture.GreenLight, DirectBitmap.fromBitmap(RayCastEngine.Properties.Resources.greenlight));
      // Load Sprites
      sprites = new Sprite[]{
        new Sprite(20.5, 11.5, Texture.GreenLight), //green light in front of playerstart
        //green lights in every room
        new Sprite(18.5, 4.5, Texture.GreenLight),
        new Sprite(10.0, 4.5, Texture.GreenLight),
        new Sprite(10.0, 12.5, Texture.GreenLight),
        new Sprite(3.5, 6.5, Texture.GreenLight),
        new Sprite(3.5, 20.5, Texture.GreenLight),
        new Sprite(3.5, 14.5, Texture.GreenLight),
        new Sprite(14.5, 20.5, Texture.GreenLight),
        //row of pillars in front of wall: fisheye test
        new Sprite(18.5, 10.5, Texture.PillarEntity),
        new Sprite(18.5, 11.5, Texture.PillarEntity),
        new Sprite(18.5, 12.5, Texture.PillarEntity),
        //some barrels around the map
        new Sprite(21.5, 1.5,  Texture.BarrelEntity),
        new Sprite(15.5, 1.5,  Texture.BarrelEntity),
        new Sprite(16.0, 1.8,  Texture.BarrelEntity),
        new Sprite(16.2, 1.2,  Texture.BarrelEntity),
        new Sprite(3.5,  2.5,  Texture.BarrelEntity),
        new Sprite(9.5,  15.5, Texture.BarrelEntity),
        new Sprite(10.0, 15.1, Texture.BarrelEntity),
        new Sprite(10.5, 15.8, Texture.BarrelEntity)
      };
    }
    public void Resize(int width, int height) {
      Resolution = new Size(width, height);
      // Create Our Buffer
      ZBuffer = new double[width];
      buffer = new DirectBitmap(width, height);
      // Say Game Has Updated
      GameStateChanged = true;
    }
    public void Update(TimeSpan gameTime) {
      Vector3 oldPosition = position.copy();
      Vector3 oldDirection = direction.copy();
      Vector3 Velocity = new Vector3(0, 0, 0);
      int intPosX = (int)position.x;
      int intPosY = (int)position.y;
      // No need to clear the screen here, since everything is overdrawn with floor and ceiling
      //timing for input and FPS counter
      double frameTime = gameTime.Milliseconds / 1000.0; //frametime is the time this frame has taken, in seconds
      //speed modifiers
      double moveSpeed = frameTime * 3; //the constant value is in squares/second
      double rotSpeed = frameTime * 2; //the constant value is in radians/second
      // TODO: We should do the math on the movement both forward and backward and then check if it works
      if (keyIsDown(87)) {
        Velocity.addX(direction.x * moveSpeed);
        Velocity.addY(direction.y * moveSpeed);
      }
      //move backwards if no wall behind you
      if (keyIsDown(83)) {
        Velocity.subX(direction.x * moveSpeed);
        Velocity.subY(direction.y * moveSpeed);
      }
      // Strafe Right
      if (keyIsDown(68)) {
        double theta = Math.Atan2(direction.x, direction.y) + Math.PI / 2;
        double dirX = Math.Sin(theta);
        double dirY = Math.Cos(theta);
        Velocity.addX(dirX * moveSpeed);
        Velocity.addY(dirY * moveSpeed);
      }
      //// Strafe Left
      if (keyIsDown(65)) {
        double theta = Math.Atan2(direction.x, direction.y) - Math.PI / 2;
        double dirX = Math.Sin(theta);
        double dirY = Math.Cos(theta);
        Velocity.addX(dirX * moveSpeed);
        Velocity.addY(dirY * moveSpeed);
      }
      // TODO: We Want To Use The Mouse
      double cosRotSpeed = Math.Cos(rotSpeed);
      double sinRotSpeed = Math.Sin(rotSpeed);
      //rotate to the right
      if (keyIsDown(39)) {
        //both camera direction and camera plane must be rotated
        double oldDirX = direction.x;
        direction.setX(direction.x * cosRotSpeed - direction.y * -sinRotSpeed);
        direction.setY(oldDirX * -sinRotSpeed + direction.y * cosRotSpeed);
        double oldPlaneX = plane.x;
        plane.setX(plane.x * cosRotSpeed - plane.y * -sinRotSpeed);
        plane.setY(oldPlaneX * -sinRotSpeed + plane.y * cosRotSpeed);
      }
      //rotate to the left
      if (keyIsDown(37)) {
        //both camera direction and camera plane must be rotated
        double oldDirX = direction.x;
        direction.setX(direction.x * cosRotSpeed - direction.y * sinRotSpeed);
        direction.setY(oldDirX * sinRotSpeed + direction.y * cosRotSpeed);
        double oldPlaneX = plane.x;
        plane.setX(plane.x * cosRotSpeed - plane.y * sinRotSpeed);
        plane.setY(oldPlaneX * sinRotSpeed + plane.y * cosRotSpeed);
      }
      // Determine projected Move
      if (!Velocity.equals(new Vector3(0, 0, 0))) {
        double projectedX = position.x + Velocity.x;
        double projectedY = position.y + Velocity.y;
        if (worldMap[(int)projectedX, intPosY] == 0) position.setX(projectedX);
        if (worldMap[intPosX, (int)projectedY] == 0) position.setY(projectedY);
      }
      // Very simple demonstration jump/pitch controls
      // look up
      if (keyIsDown(38)) direction.addZ(400 * moveSpeed);
      // look down
      if (keyIsDown(40)) direction.subZ(400* moveSpeed);
      // jump
      if (keyIsDown(32) && position.z == 0) position.setZ(200);
      // crouch
      if (keyIsDown(16) && position.z == 0) position.setZ(-200);
      if (direction.z > 0) direction.setZ(Math.Max(0, direction.z - 100 * moveSpeed));
      if (direction.z < 0) direction.setZ(Math.Min(0, direction.z + 100 * moveSpeed));
      if (position.z > 0) position.setZ(Math.Max(0, position.z - 100 * moveSpeed));
      if (position.z < 0) position.setZ(Math.Min(0, position.z + 100 * moveSpeed));
      // TODO: Calculate Enemy Movements
      // Determine if game has updated
      if (!oldPosition.equals(position) || !oldDirection.equals(direction)) {
        GameStateChanged = true;
      }
    }
    public void UpdateScreen(TimeSpan gameTime, int interlaceAmmount) {
      buffer.fillColor(-16777216);
      // Set Cached Vars
      int screenWidth = Resolution.Width;
      int screenHeight = Resolution.Height;
      int screenHeight2 = screenHeight / 2;
      // rayDir for leftmost ray (x = 0) and rightmost ray (x = w)
      double rayDirX0 = direction.x - plane.x;
      double rayDirY0 = direction.y - plane.y;
      double rayDirX1 = direction.x + plane.x;
      double rayDirY1 = direction.y + plane.y;
      //move forward if no wall in front of you
      int intPosX = (int)position.x;
      int intPosY = (int)position.y;
      // TODO: The Floor And Roof Are Symetrical so we only need to run through half the screen though we need to deal with occlusion when you are not looking forward
      // TODO: we may be able to optimize this by precomputing more stuff
      //FLOOR CASTING
      int currentTileSection = (int)(screenHeight2 + direction.z);
      double floorStepXBase = (rayDirX1 - rayDirX0) / screenWidth;
      double floorStepYBase = (rayDirY1 - rayDirY0) / screenWidth;
      for (int y = 0; y < screenHeight; y += interlaceAmmount) {
        // whether this section is floor or ceiling
        bool is_floor = y > currentTileSection;
        // Current y position compared to the center of the screen (the horizon)
        int p = (int)(is_floor ? (y - screenHeight2 - direction.z) : (screenHeight2 - y + direction.z));
        // Vertical position of the camera.
        // NOTE: with 0.5, it's exactly in the center between floor and ceiling,
        // matching also how the walls are being raycasted. For different values
        // than 0.5, a separate loop must be done for ceiling and floor since
        // they're no longer symmetrical.
        double camZ = is_floor ? (screenHeight2 + position.z) : (screenHeight2 - position.z);
        // Horizontal distance from the camera to the floor for the current row.
        // 0.5 is the z position exactly in the middle between floor and ceiling.
        // NOTE: this is affine texture mapping, which is not perspective correct
        // except for perfectly horizontal and vertical surfaces like the floor.
        // NOTE: this formula is explained as follows: The camera ray goes through
        // the following two points: the camera itself, which is at a certain
        // height (posZ), and a point in front of the camera (through an imagined
        // vertical plane containing the screen pixels) with horizontal distance
        // 1 from the camera, and vertical position p lower than posZ (posZ - p). When going
        // through that point, the line has vertically traveled by p units and
        // horizontally by 1 unit. To hit the floor, it instead needs to travel by
        // posZ units. It will travel the same ratio horizontally. The ratio was
        // 1 / p for going through the camera plane, so to go posZ times farther
        // to reach the floor, we get that the total horizontal distance is posZ / p.
        double rowDistance = camZ / p;
        // calculate the real world step vector we have to add for each x (parallel to camera plane)
        // adding step by step avoids multiplications with a weight in the inner loop
        double floorStepX = rowDistance * floorStepXBase * interlaceAmmount;
        double floorStepY = rowDistance * floorStepYBase * interlaceAmmount;
        // real world coordinates of the leftmost column. This will be updated as we step to the right.
        double floorX = position.x + rowDistance * rayDirX0;
        double floorY = position.y + rowDistance * rayDirY0;
        // choose texture and draw the pixel
        const Texture ceilingtexture = Texture.WoodWall;
        for (int x = 0; x < screenWidth; x += interlaceAmmount) {
          // the cell coord is simply got from the integer parts of floorX and floorY
          int cellX = (int)floorX;
          int cellY = (int)floorY;
          // get the texture coordinate from the fractional part
          int tx = (int)(texWidth * (floorX - cellX)) & (texWidth - 1);
          int ty = (int)(texHeight * (floorY - cellY)) & (texHeight - 1);
          floorX += floorStepX;
          floorY += floorStepY;
          Texture floortexture = (((cellX + cellY) & 1) == 0) ? Texture.GreyStoneWall : Texture.BlueStoneWall;
          if (interlaceAmmount == 1) {
            Color pixel = textures[is_floor ? floortexture : ceilingtexture].GetPixel(tx, ty);
            buffer.SetPixel(
              x,
              y,
              (byte)(pixel.R / 2),
              (byte)(pixel.G / 2),
              (byte)(pixel.B / 2)
            );
          } else {
            int pixel = textures[is_floor ? floortexture : ceilingtexture].GetPixelInteger(tx, ty);
            buffer.SetPixel(x, y, pixel);
          }
        }
      }
      #region WallCasting
      // WALL CASTING
      for (int x = 0; x < screenWidth; x++) {
        //calculate ray position and direction
        double cameraX = 2 * x / (double)screenWidth - 1; //x-coordinate in camera space
        double rayDirX = direction.x + plane.x * cameraX;
        double rayDirY = direction.y + plane.y * cameraX;
        //which box of the map we're in
        int mapX = intPosX;
        int mapY = intPosY;
        //length of ray from one x or y-side to next x or y-side
        double deltaDistX = (rayDirX == 0) ? 1e30 : Math.Abs(1.0 / rayDirX);
        double deltaDistY = (rayDirY == 0) ? 1e30 : Math.Abs(1.0 / rayDirY);
        //length of ray from current position to next x or y-side
        double sideDistX;
        double sideDistY;
        //what direction to step in x or y-direction (either +1 or -1)
        int stepX = 1;
        int stepY = 1;
        //calculate step and initial sideDist
        if (rayDirX < 0) {
          stepX = -1;
          sideDistX = (position.x - mapX) * deltaDistX;
        } else {
          sideDistX = (mapX + 1.0 - position.x) * deltaDistX;
        }
        if (rayDirY < 0) {
          stepY = -1;
          sideDistY = (position.y - mapY) * deltaDistY;
        } else {
          sideDistY = (mapY + 1.0 - position.y) * deltaDistY;
        }
        bool hit = false; //was there a wall hit?
        bool side1 = true; //was a NS or a EW wall hit?
        //perform DDA
        while (!hit) {
          //jump to next map square, either in x-direction, or in y-direction
          if (sideDistX < sideDistY) {
            sideDistX += deltaDistX;
            mapX += stepX;
            side1 = false;
          } else {
            sideDistY += deltaDistY;
            mapY += stepY;
            side1 = true;
          }
          //Check if ray has hit a wall
          if (worldMap[mapX, mapY] != 0) hit = true;
        }
        // texturing calculations
        Texture texNum = (Texture)worldMap[mapX, mapY];
        if (texNum == Texture.Air) continue;
        //Calculate distance of perpendicular ray (Euclidean distance would give fisheye effect!)
        double perpWallDist = !side1 ? (sideDistX - deltaDistX) : (sideDistY - deltaDistY);
        // Calculate height of line to draw on screen
        int lineHeight = (int)(screenHeight / perpWallDist);
        // calculate lowest and highest pixel to fill in current stripe
        int drawStart = (int)(-lineHeight / 2 + screenHeight2 + direction.z + (position.z / perpWallDist));
        if (drawStart < 0) drawStart = 0;
        int drawEnd = (int)(lineHeight / 2 + screenHeight2 + direction.z + (position.z / perpWallDist));
        if (drawEnd >= screenHeight) drawEnd = screenHeight - 1;
        //calculate value of wallX
        double wallX = (!side1 ? (position.y + perpWallDist * rayDirY) : (position.x + perpWallDist * rayDirX)) % 1; //where exactly the wall was hit
        //x coordinate on the texture
        int texX = (int)(wallX * texWidth);
        if (!side1 && rayDirX > 0) texX = texWidth - texX - 1;
        if (side1 && rayDirY < 0) texX = texWidth - texX - 1;
        // TODO: an integer-only bresenham or DDA like algorithm could make the texture coordinate stepping faster
        // How much to increase the texture coordinate per screen pixel
        double step = 1.0 * texHeight / lineHeight;
        // Starting texture coordinate
        double texPos = (drawStart - direction.z - (position.z / perpWallDist) - screenHeight2 + lineHeight / 2) * step;
        for (int y = drawStart; y < drawEnd; y++) {
          // Cast the texture coordinate to integer, and mask with (texHeight - 1) in case of overflow
          int texY = (int)(texPos) & (texHeight - 1); // TODO: Figure this out
          texPos += step;
          //make color darker for y-sides: R, G and B byte each divided through two with a "shift" and an "and"
          if (side1) {
            Color pixel = textures[texNum].GetPixel(texX, texY);
            buffer.SetPixel(x, y, (byte)((pixel.R >> 1) & 8355711), (byte)((pixel.G >> 1) & 8355711), (byte)((pixel.B >> 1) & 8355711));
          } else {
            int pixel = textures[texNum].GetPixelInteger(texX, texY);
            buffer.SetPixel(x, y, pixel);
          }
        }
        //SET THE ZBUFFER FOR THE SPRITE CASTING
        ZBuffer[x] = perpWallDist; //perpendicular distance is used
      }
      #endregion
      //SPRITE CASTING
      //sort sprites from far to close
      for (int i = 0; i < sprites.Length; i++) {
        sprites[i].distance = ((position.x - sprites[i].x) * (position.x - sprites[i].x) + (position.y - sprites[i].y) * (position.y - sprites[i].y));
      }
      Array.Sort(sprites, new Comparison<Sprite>((a, b) => b.distance.CompareTo(a.distance)));
      //parameters for scaling and moving the sprites
      const int uDiv = 1;
      const int vDiv = 1;
      const float vMove = 0.0f;
      //after sorting the sprites, do the projection and draw them
      for (int i = 0; i < sprites.Length; i++) {
        Sprite currentSprite = sprites[i];
        //translate sprite position relative to camera
        double spriteX = currentSprite.x - position.x;
        double spriteY = currentSprite.y - position.y;
        // transform sprite with the inverse camera matrix
        // [ planeX   dirX ] -1                                       [ dirY      -dirX ]
        // [               ]       =  1/(planeX*dirY-dirX*planeY) *   [                 ]
        // [ planeY   dirY ]                                          [ -planeY  planeX ]
        double invDet = 1.0 / (plane.x * direction.y - direction.x * plane.y); //required for correct matrix multiplication
        double transformX = invDet * (direction.y * spriteX - direction.x * spriteY);
        double transformY = invDet * (-plane.y * spriteX + plane.x * spriteY); //this is actually the depth inside the screen, that what Z is in 3D, the distance of sprite to player, matching sqrt(spriteDistance[i])
        int spriteScreenX = (int)((screenWidth / 2) * (1 + transformX / transformY));
        int vMoveScreen = (int)((int)(vMove / transformY) + direction.z + position.z / transformY);
        //calculate height of the sprite on screen
        int spriteScale = Math.Abs((int)(screenHeight / transformY));
        int spriteHeight = spriteScale / vDiv; //using "transformY" instead of the real distance prevents fisheye
        //calculate lowest and highest pixel to fill in current stripe
        int drawStartY = -spriteHeight / 2 + screenHeight2 + vMoveScreen;
        if (drawStartY < 0) drawStartY = 0;
        int drawEndY = spriteHeight / 2 + screenHeight2 + vMoveScreen;
        if (drawEndY >= screenHeight) drawEndY = screenHeight - 1;
        //calculate width of the sprite
        int spriteWidth = spriteScale / uDiv;
        int drawStartX = -spriteWidth / 2 + spriteScreenX;
        if (drawStartX < 0) drawStartX = 0;
        int drawEndX = spriteWidth / 2 + spriteScreenX;
        if (drawEndX >= screenWidth) drawEndX = screenWidth - 1;
        //loop through every vertical stripe of the sprite on screen
        for (int stripe = drawStartX; stripe < drawEndX; stripe++) {
          if (transformY > 0 && stripe > 0 && stripe < screenWidth && transformY < ZBuffer[stripe]) {
            int texX = (stripe - (-spriteWidth / 2 + spriteScreenX)) * texWidth / spriteWidth;
            /*
              the conditions in the if are:
              1) it's in front of camera plane so you don't see things behind you
              2) it's on the screen (left)
              3) it's on the screen (right)
              4) ZBuffer, with perpendicular distance
            */
            for (int y = drawStartY; y < drawEndY; y++) {//for every pixel of the current stripe
              // Displaying Code
              int d = (y - vMoveScreen) * 256 - screenHeight * 128 + spriteHeight * 128; //256 and 128 factors to avoid floats
              int texY = ((d * texHeight) / spriteHeight) / 256;
              int pixel = textures[currentSprite.texture].GetPixelInteger(texX, texY);
              if (pixel != 0) buffer.SetPixel(stripe, y, pixel); //paint pixel if it is visible
            }
          }
        }
      }
    }
    private bool keyIsDown(int keycode) {
      return keys.ContainsKey(keycode) && keys[keycode] == true;
    }
    public void Draw(Graphics gfx, TimeSpan gameTime) {
      Bitmap frameBuffer = buffer.Bitmap;
      // Draw UI
      // Draw Game
      gfx.DrawImage(frameBuffer, new Point(0, 0));
    }
    public string getDataText(TimeSpan gameTime) {
      double frameTime = gameTime.Milliseconds / 1000.0;
      return (
$@"frameRate: {(int)(1 / frameTime)}, x: {position.x - (position.x % 0.01)}, y: {position.y - (position.y % 0.01)}, z: {position.z - (position.z % 0.01)}
pitch: { Math.Round(direction.z, 3)}, dir: { Math.Atan2(direction.x, direction.y) * 180 / Math.PI}
dirX: {direction.x}, dirY: {direction.y}"
      );
    }
  }
}
