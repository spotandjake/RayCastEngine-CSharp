using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using RayCastEngine.Views;

namespace RayCastEngine.GameComponents {
  // Our Main Engine
  class Engine {
    // Properties
    public Size Resolution { get; set; }
    public Dictionary<int, bool> keys = new Dictionary<int, bool>();
    // Temporary Engine Variables
    private int texWidth = 64;
    private int texHeight = 64;
    private int[,] worldMap;
    private Dictionary<Texture, Bitmap> textures = new Dictionary<Texture, Bitmap>();
    private double[] ZBuffer;
    private DirectBitmap buffer;
    private Vector3 position = new Vector3(22.0, 11.5, 0.0);
    private Vector3 direction = new Vector3(-1.0, 0.0, 0.0); // dirX, dirY, camPitch
    private Vector3 plane = new Vector3(0.0, 0.66, 0.0); // planeX, planeY
    private Sprite[] sprites;
    // Methods
    public void Load(GameType gameType) {
      // Initialize
      // Load Images
      textures.Add(Texture.EagleWall, RayCastEngine.Properties.Resources.eagle);
      textures.Add(Texture.RedBrickWall, RayCastEngine.Properties.Resources.redbrick);
      textures.Add(Texture.PurpleStoneWall, RayCastEngine.Properties.Resources.purplestone);
      textures.Add(Texture.GreyStoneWall, RayCastEngine.Properties.Resources.greystone);
      textures.Add(Texture.BlueStoneWall, RayCastEngine.Properties.Resources.bluestone);
      textures.Add(Texture.MossyWall, RayCastEngine.Properties.Resources.mossy);
      textures.Add(Texture.WoodWall, RayCastEngine.Properties.Resources.wood);
      textures.Add(Texture.ColorStoneWall, RayCastEngine.Properties.Resources.colorstone);
      textures.Add(Texture.BarrelEntity, RayCastEngine.Properties.Resources.barrel); ;
      textures.Add(Texture.PillarEntity, RayCastEngine.Properties.Resources.pillar);
      textures.Add(Texture.GreenLight, RayCastEngine.Properties.Resources.greenlight);
      // Load World Map
      worldMap = new int[,] {
        { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
        { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
        { 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5 }
      };
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
      // Create Our Buffer
      ZBuffer = new double[Resolution.Width];
      buffer = new DirectBitmap(Resolution.Width, Resolution.Height);
    }
    public void Update(TimeSpan gameTime) {
      // Gametime elapsed
      double gameTimeElapsed = gameTime.TotalMilliseconds / 1000;
      // Draw Frame Into Buffer
      // Set Cached Vars
      int screenWidth = Resolution.Width;
      int screenHeight = Resolution.Height;
      int screenHeight2 = (int)(screenHeight * 0.5);
      // rayDir for leftmost ray (x = 0) and rightmost ray (x = w)
      double rayDirX0 = direction.x - plane.x;
      double rayDirY0 = direction.y - plane.y;
      double rayDirX1 = direction.x + plane.x;
      double rayDirY1 = direction.y + plane.y;
      //move forward if no wall in front of you
      int intPosX = (int)position.x;
      int intPosY = (int)position.y;
      //FLOOR CASTING
      for (int y = 0; y < screenHeight; y++) {
        // whether this section is floor or ceiling
        bool is_floor = y > screenHeight2 + direction.z;
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
        double floorStepX = rowDistance * (rayDirX1 - rayDirX0) / screenWidth;
        double floorStepY = rowDistance * (rayDirY1 - rayDirY0) / screenWidth;
        // real world coordinates of the leftmost column. This will be updated as we step to the right.
        double floorX = position.x + rowDistance * rayDirX0;
        double floorY = position.y + rowDistance * rayDirY0;
        for (int x = 0; x < screenWidth; x++) {
          // the cell coord is simply got from the integer parts of floorX and floorY
          int cellX = (int)floorX;
          int cellY = (int)floorY;
          // get the texture coordinate from the fractional part
          int tx = (int)(texWidth * (floorX - cellX)) & (texWidth - 1);
          int ty = (int)(texHeight * (floorY - cellY)) & (texHeight - 1);
          floorX += floorStepX;
          floorY += floorStepY;
          // choose texture and draw the pixel
          Texture floorTexture = (((cellX + cellY) & 1) == 0) ? Texture.GreyStoneWall : Texture.BlueStoneWall;
          Texture ceilingTexture = Texture.WoodWall;
          Color pixel = textures[is_floor ? floorTexture : ceilingTexture].GetPixel(tx, ty);
          buffer.SetPixel(
            x,
            y,
            Color.FromArgb(
              (pixel.R >> 1) & 8355711,
              (pixel.G >> 1) & 8355711,
              (pixel.B >> 1) & 8355711
            )
          );
        }
      }
      // WALL CASTING
      for (int x = 0; x < screenWidth; x++) {
        //calculate ray position and direction
        double cameraX = 2 * x / (double)screenWidth - 1; //x-coordinate in camera space
        double rayDirX = direction.x + plane.x * cameraX;
        double rayDirY = direction.y + plane.y * cameraX;
        //which box of the map we're in
        int mapX = intPosX;
        int mapY = intPosY;
        //length of ray from current position to next x or y-side
        double sideDistX;
        double sideDistY;
        //length of ray from one x or y-side to next x or y-side
        double deltaDistX = (rayDirX == 0) ? 1e30 : Math.Abs(1.0 / rayDirX);
        double deltaDistY = (rayDirY == 0) ? 1e30 : Math.Abs(1.0 / rayDirY);
        //what direction to step in x or y-direction (either +1 or -1)
        int stepX;
        int stepY;
        bool hit = false; //was there a wall hit?
        bool side1 = true; //was a NS or a EW wall hit?
        //calculate step and initial sideDist
        if (rayDirX < 0) {
          stepX = -1;
          sideDistX = (position.x - mapX) * deltaDistX;
        } else {
          stepX = 1;
          sideDistX = (mapX + 1.0 - position.x) * deltaDistX;
        }
        if (rayDirY < 0) {
          stepY = -1;
          sideDistY = (position.y - mapY) * deltaDistY;
        } else {
          stepY = 1;
          sideDistY = (mapY + 1.0 - position.y) * deltaDistY;
        }
        //perform DDA
        while (hit == false) {
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
          if (worldMap[mapX, mapY] > 0) hit = true;
        }
        //Calculate distance of perpendicular ray (Euclidean distance would give fisheye effect!)
        double perpWallDist = !side1 ? (sideDistX - deltaDistX) : (sideDistY - deltaDistY);
        // Calculate height of line to draw on screen
        int lineHeight = (int)(screenHeight / perpWallDist);
        // calculate lowest and highest pixel to fill in current stripe
        int drawStart = (int)(-lineHeight / 2 + screenHeight2 + direction.z + (position.z / perpWallDist));
        if (drawStart < 0) drawStart = 0;
        int drawEnd = (int)(lineHeight / 2 + screenHeight2 + direction.z + (position.z / perpWallDist));
        if (drawEnd >= screenHeight) drawEnd = screenHeight - 1;
        // texturing calculations
        int texNum = worldMap[mapX, mapY];
        //calculate value of wallX
        double wallX; //where exactly the wall was hit
        if (!side1) wallX = position.y + perpWallDist * rayDirY;
        else wallX = position.x + perpWallDist * rayDirX;
        wallX -= Math.Floor(wallX);
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
          if (texNum == 0) continue;
          Color pixel = textures[(Texture)texNum].GetPixel(texX, texY);
          //make color darker for y-sides: R, G and B byte each divided through two with a "shift" and an "and"
          if (side1) {
            pixel = Color.FromArgb(
              (pixel.R >> 1) & 8355711,
              (pixel.G >> 1) & 8355711,
              (pixel.B >> 1) & 8355711
            );
          }
          buffer.SetPixel(x, y, pixel);
        }
        //SET THE ZBUFFER FOR THE SPRITE CASTING
        ZBuffer[x] = perpWallDist; //perpendicular distance is used
      }
      //SPRITE CASTING
      //sort sprites from far to close
      // TODO: instead of sorting by distance why dont we use the ZBuffer
      for (int i = 0; i < sprites.Length; i++) {
        sprites[i].distance = ((position.x - sprites[i].x) * (position.x - sprites[i].x) + (position.y - sprites[i].y) * (position.y - sprites[i].y));
      }
      Array.Sort(sprites, new Comparison<Sprite>((a, b) => b.distance.CompareTo(a.distance)));
      //after sorting the sprites, do the projection and draw them
      for (int i = 0; i < sprites.Length; i++) {
        Sprite currentSprite = sprites[i];
        //translate sprite position to relative to camera
        double spriteX = currentSprite.x - position.x;
        double spriteY = currentSprite.y - position.y;
        // transform sprite with the inverse camera matrix
        // [ planeX   dirX ] -1                                       [ dirY      -dirX ]
        // [               ]       =  1/(planeX*dirY-dirX*planeY) *   [                 ]
        // [ planeY   dirY ]                                          [ -planeY  planeX ]
        double invDet = 1.0 / (plane.x * direction.y - direction.x * plane.y); //required for correct matrix multiplication
        double transformX = invDet * (direction.y * spriteX - direction.x * spriteY);
        double transformY = invDet * (-plane.y * spriteX + plane.x * spriteY); //this is actually the depth inside the screen, that what Z is in 3D, the distance of sprite to player, matching sqrt(spriteDistance[i])
        int spriteScreenX = (int)((screenWidth * 0.5) * (1 + transformX / transformY));
        //parameters for scaling and moving the sprites
        // TODO: Convert These To Constants
        int uDiv = 1;
        int vDiv = 1;
        float vMove = 0.0f;
        int vMoveScreen = (int)((int)(vMove / transformY) + direction.z + position.z / transformY);
        //calculate height of the sprite on screen
        int spriteHeight = Math.Abs((int)(screenHeight / transformY)) / vDiv; //using "transformY" instead of the real distance prevents fisheye
                                                                                   //calculate lowest and highest pixel to fill in current stripe
        double drawStartY = -spriteHeight / 2 + screenHeight2 + vMoveScreen;
        if (drawStartY < 0) drawStartY = 0;
        double drawEndY = spriteHeight / 2 + screenHeight2 + vMoveScreen;
        if (drawEndY >= screenHeight) drawEndY = screenHeight - 1;
        //calculate width of the sprite
        int spriteWidth = Math.Abs((int)(screenHeight / transformY)) / uDiv;
        float drawStartX = -spriteWidth / 2 + spriteScreenX;
        if (drawStartX < 0) drawStartX = 0;
        float drawEndX = spriteWidth / 2 + spriteScreenX;
        if (drawEndX >= screenWidth) drawEndX = screenWidth - 1;
        //loop through every vertical stripe of the sprite on screen
        for (int stripe = (int)drawStartX; stripe < drawEndX; stripe++) {
          int texX = (stripe - (-spriteWidth / 2 + spriteScreenX)) * texWidth / spriteWidth;
          //the conditions in the if are:
          //1) it's in front of camera plane so you don't see things behind you
          //2) it's on the screen (left)
          //3) it's on the screen (right)
          //4) ZBuffer, with perpendicular distance
          if (transformY > 0 && stripe > 0 && stripe < screenWidth && transformY < ZBuffer[stripe])
            for (int y = (int)drawStartY; y < drawEndY; y++) {//for every pixel of the current stripe
              float d = (y - vMoveScreen) * 256 - screenHeight * 128 + spriteHeight * 128; //256 and 128 factors to avoid floats
              int texY = (int)(((d * texHeight) / spriteHeight) / 256);
              Color pixel = textures[currentSprite.texture].GetPixel(texX, texY);
              if (pixel.A == 0) continue;
              buffer.SetPixel(stripe, y, pixel); //paint pixel if it isn't black, black is the invisible color
            }
        }
      }
      // No need to clear the screen here, since everything is overdrawn with floor and ceiling
      //timing for input and FPS counter
      double frameTime = gameTime.Milliseconds / 1000.0; //frametime is the time this frame has taken, in seconds
                                                 //speed modifiers
      double moveSpeed = frameTime * 3; //the constant value is in squares/second
      double rotSpeed = frameTime * 2; //the constant value is in radians/second
                                    // TODO: We should do the math on the movement both forward and backward and then check if it works
      if (keyIsDown(87)) {
        double projectedX = position.x + direction.x * moveSpeed;
        double projectedY = position.y + direction.y * moveSpeed;
        // TODO: Fix This
        // if (worldMap[(int)projectedX] == undefined) projectedX = mapWidth - 1;
        // if (worldMap[(int)projectedX, (int)projectedY] == undefined) projectedY = mapHeight - 1;
        if (worldMap[(int)projectedX, intPosY] == 0) position.setX(projectedX);
        if (worldMap[intPosX, (int)projectedY] == 0) position.setY(projectedY);
      }
      //move backwards if no wall behind you
      if (keyIsDown(83)) {
        double projectedX = position.x - direction.x * moveSpeed;
        double projectedY = position.y - direction.y * moveSpeed;
        // TODO: Fix This
        // if (worldMap[(int)projectedX] == undefined) projectedX = mapWidth - 1;
        // if (worldMap[(int)projectedX, (int)projectedY] == undefined) projectedY = mapHeight - 1;
        if (worldMap[(int)projectedX, intPosY] == 0) position.setX(projectedX);
        if (worldMap[intPosX, (int)projectedY] == 0) position.setY(projectedY);
      }
      // Strafe Left
      // if (keyIsDown(68)) {
      //   let projectedX = position.x + (dirX + 1) * moveSpeed;
      //   let projectedY = position.y + (dirY - 1) * moveSpeed;
      //   if (worldMap[Math.trunc(projectedX)] == undefined) projectedX = mapWidth-1;
      //   if (worldMap[Math.trunc(projectedX)][Math.trunc(projectedY)] == undefined) projectedY = mapHeight-1;
      //   if (worldMap[Math.trunc(projectedX)][intPosY] == 0) position.setX(projectedX);
      //   if (worldMap[intPosX][Math.trunc(projectedY)] == 0) position.setY(projectedY);
      // }
      // // Strafe Right
      // if (keyIsDown(65)) {
      //   let projectedX = position.x + (dirX + 1) * moveSpeed;
      //   let projectedY = position.y + (dirY + 1) * moveSpeed;
      //   if (worldMap[Math.trunc(projectedX)] == undefined) projectedX = mapWidth-1;
      //   if (worldMap[Math.trunc(projectedX)][Math.trunc(projectedY)] == undefined) projectedY = mapHeight-1;
      //   if (worldMap[Math.trunc(projectedX)][intPosY] == 0) position.setX(projectedX);
      //   if (worldMap[intPosX][Math.trunc(projectedY)] == 0) position.setY(projectedY);
      // }
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
      // Print text
      // TODO: We want to move this stuff to Draw
      // fill(255, 255, 255);
      // textSize(32);
      // text($"frameRate: {Math.Round(1/frameTime)}, x: {Math.Truncate(posX,3)}, y: {Math.Truncate(posY,3)}, z: {Math.Truncate(posZ,3)}");
      // text($"pitch: {Math.Round(camPitch, 3)}, dir: {Math.atan2(dirX, dirY) * 180 / Math.PI}");
    }

    private bool keyIsDown(int keycode) {
      return keys.ContainsKey(keycode) && keys[keycode] == true;
    }
    public void Draw(Graphics gfx, TimeSpan gameTime) {
      // Draw UI
      // Draw Game
      gfx.DrawImage(buffer.Bitmap, new Point(0, 0));
      // Draw Our New Buffer
      double frameTime = gameTime.Milliseconds / 1000.0;
      gfx.DrawString($"frameRate: {Math.Round(1 / frameTime)}, x: {position.x - (position.x % 0.01)}, y: {position.y - (position.y % 0.01)}, z: {position.z - (position.z % 0.01)}", new Font("Arial", 16), new SolidBrush(Color.White), 0, 0);
      gfx.DrawString($"pitch: {Math.Round(direction.z, 3)}, dir: {Math.Atan2(direction.x, direction.y) * 180 / Math.PI}", new Font("Arial", 16), new SolidBrush(Color.White), 0, 16);
    }
  }
}
