using System;
using System.Collections.Generic;
using System.Linq;
using RayCastEngine.Views;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;

namespace RayCastEngine.GameComponents {
  // Our Main Engine
  class Engine {
    // Temporary Engine Variables
    private static int texWidth = 64;
    private static int texHeight = 64;
    private static int worldSizeX = 300;
    private static int worldSizeY = 300;
    private Dictionary<Texture, DirectBitmap> textures = new Dictionary<Texture, DirectBitmap>();
    // World Values
    private World World;
    // Buffers
    private DirectBitmap SceneBuffer;
    private DirectBitmap SpriteBuffer;
    private DirectBitmap UiBiffer;
    private float[] ZBuffer;
    // Update States
    private bool SceneUpdate = true;
    private bool SpriteUpdate = true;
    private bool UiUpdate = true;
    // Screen Size
    private int ScreenWidth;
    private int ScreenHeight;
    // Network Class
    private Network net;
    // Methods
    public void Load(GameType gameType) {
      // Load Images
      textures.Add(Texture.EagleWall, DirectBitmap.fromBitmap(Properties.Resources.eagle));
      textures.Add(Texture.RedBrickWall, DirectBitmap.fromBitmap(Properties.Resources.redbrick));
      textures.Add(Texture.PurpleStoneWall, DirectBitmap.fromBitmap(Properties.Resources.purplestone));
      textures.Add(Texture.GreyStoneWall, DirectBitmap.fromBitmap(Properties.Resources.greystone));
      textures.Add(Texture.BlueStoneWall, DirectBitmap.fromBitmap(Properties.Resources.bluestone));
      textures.Add(Texture.MossyWall, DirectBitmap.fromBitmap(Properties.Resources.mossy));
      textures.Add(Texture.WoodWall, DirectBitmap.fromBitmap(Properties.Resources.wood));
      textures.Add(Texture.ColorStoneWall, DirectBitmap.fromBitmap(Properties.Resources.colorstone));
      textures.Add(Texture.BarrelEntity, DirectBitmap.fromBitmap(Properties.Resources.barrel));
      textures.Add(Texture.PillarEntity, DirectBitmap.fromBitmap(Properties.Resources.pillar));
      textures.Add(Texture.GreenLight, DirectBitmap.fromBitmap(Properties.Resources.greenlight));
      // Load Enemy Sprites
      textures.Add(Texture.Enemy_1, DirectBitmap.fromBitmap(Properties.Resources.Enemy_1));
      // Boss Textures
      textures.Add(Texture.Boss_1, DirectBitmap.fromBitmap(Properties.Resources.Boss_1));
      textures.Add(Texture.Boss_2, DirectBitmap.fromBitmap(Properties.Resources.Boss_2));
      textures.Add(Texture.Boss_3, DirectBitmap.fromBitmap(Properties.Resources.Boss_3));
      // Boss Minions
      textures.Add(Texture.Boss_3_Minion_1, DirectBitmap.fromBitmap(Properties.Resources.Boss_3_Minion_1));
      // Gun Textures
      textures.Add(Texture.Pistol_1_1, DirectBitmap.fromBitmap(Properties.Resources.Pistol_1_1));
      textures.Add(Texture.Pistol_1_2, DirectBitmap.fromBitmap(Properties.Resources.Pistol_1_2));
      textures.Add(Texture.Pistol_1_3, DirectBitmap.fromBitmap(Properties.Resources.Pistol_1_3));
      textures.Add(Texture.Pistol_1_4, DirectBitmap.fromBitmap(Properties.Resources.Pistol_1_4));
      // Bullet Texture
      textures.Add(Texture.Bullet, DirectBitmap.fromBitmap(Properties.Resources.Bullet));
      // Init Network
      // Random Username
      string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
      Random random = new Random();
      string username = string.Join("", Enumerable.Repeat(0, 8).Select(x => chars[random.Next(chars.Length)]));
      net = new Network("wss://socketTest.spotandjake.repl.co/", username);
      // Generate World
      World = new World(worldSizeX, worldSizeY, net);
    }
    public void Resize(int width, int height) {
      // Resize our Buffers
      SceneBuffer = new DirectBitmap(width, height);
      SpriteBuffer = new DirectBitmap(width, height);
      UiBiffer = new DirectBitmap(width, height);
      ZBuffer = new float[width];
      // Update Our Size Vars
      ScreenWidth = width;
      ScreenHeight = height;
      // Say Game Has Updated
      SceneUpdate = true;
      SpriteUpdate = true;
      UiUpdate = true;
    }
    public bool Update(TimeSpan gameTime) {
      // Call World Update
      WorldUpdateResult result = World.Update(gameTime, net);
      SceneUpdate |= result.SceneUpdate;
      SpriteUpdate |= result.SpriteUpdate;
      UiUpdate |= result.UiUpdate;
      return SceneUpdate || SpriteUpdate || UiUpdate;
    }
    public DirectBitmap DrawScene(TimeSpan gameTime) {
      if (!SceneUpdate) return SceneBuffer;
      Vector3 position = World.LocalPlayer.Position;
      Vector3 direction = World.LocalPlayer.Direction;
      Vector2 plane = World.LocalPlayer.Controller.Plane; // TODO: Fix this
      // Set Cached Vars
      int screenHeight2 = ScreenHeight / 2;
      // rayDir for leftmost ray (x = 0) and rightmost ray (x = w)
      float rayDirX0 = direction.X - plane.X;
      float rayDirY0 = direction.Y - plane.Y;
      float rayDirX1 = direction.X + plane.X;
      float rayDirY1 = direction.Y + plane.Y;
      //move forward if no wall in front of you
      int intPosX = (int)position.X;
      int intPosY = (int)position.Y;
      // TODO: The Floor And Roof Are Symetrical so we only need to run through half the screen though we need to deal with occlusion when you are not looking forward
      // TODO: we may be able to optimize this by precomputing more stuff
      #region Floor Casting
      int currentTileSection = (int)(screenHeight2 + direction.Z);
      float floorStepXBase = (rayDirX1 - rayDirX0) / ScreenWidth;
      float floorStepYBase = (rayDirY1 - rayDirY0) / ScreenWidth;
      Parallel.For(0, ScreenHeight, y => {
        // whether this section is floor or ceiling
        bool is_floor = y > currentTileSection;
        // Current y position compared to the center of the screen (the horizon)
        int p = (int)(is_floor ? (y - screenHeight2 - direction.Z) : (screenHeight2 - y + direction.Z));
        /*
         * Vertical position of the camera.
         * NOTE: with 0.5, it's exactly in the center between floor and ceiling,
         * matching also how the walls are being raycasted. For different values
         * than 0.5, a separate loop must be done for ceiling and floor since
         * they're no longer symmetrical.
         */
        float camZ = is_floor ? (screenHeight2 + position.Z) : (screenHeight2 - position.Z);
        /*
         * Horizontal distance from the camera to the floor for the current row.
         * 0.5 is the z position exactly in the middle between floor and ceiling.
         * NOTE: this is affine texture mapping, which is not perspective correct
         * except for perfectly horizontal and vertical surfaces like the floor.
         * NOTE: this formula is explained as follows: The camera ray goes through
         * the following two points: the camera itself, which is at a certain
         * height (posZ), and a point in front of the camera (through an imagined
         * vertical plane containing the screen pixels) with horizontal distance
         * 1 from the camera, and vertical position p lower than posZ (posZ - p). When going
         * through that point, the line has vertically traveled by p units and
         * horizontally by 1 unit. To hit the floor, it instead needs to travel by
         * posZ units. It will travel the same ratio horizontally. The ratio was
         * 1 / p for going through the camera plane, so to go posZ times farther
         * to reach the floor, we get that the total horizontal distance is posZ / p.
         */
        float rowDistance = camZ / p;
        // calculate the real world step vector we have to add for each x (parallel to camera plane)
        // adding step by step avoids multiplications with a weight in the inner loop
        float floorStepX = rowDistance * floorStepXBase;
        float floorStepY = rowDistance * floorStepYBase;
        // real world coordinates of the leftmost column. This will be updated as we step to the right.
        float floorX = position.X + rowDistance * rayDirX0;
        float floorY = position.Y + rowDistance * rayDirY0;
        // choose texture and draw the pixel
        const Texture ceilingtexture = Texture.WoodWall;
        for (int x = 0; x < ScreenWidth; x++) {
          // the cell coord is simply got from the integer parts of floorX and floorY
          int cellX = (int)floorX;
          int cellY = (int)floorY;
          // get the texture coordinate from the fractional part
          int tx = (int)(texWidth * (floorX - cellX)) & (texWidth - 1);
          int ty = (int)(texHeight * (floorY - cellY)) & (texHeight - 1);
          floorX += floorStepX;
          floorY += floorStepY;
          Texture floortexture = (((cellX + cellY) & 1) == 0) ? Texture.GreyStoneWall : Texture.BlueStoneWall;
          Color pixel = textures[is_floor ? floortexture : ceilingtexture].GetPixel(tx, ty);
          SceneBuffer.SetPixel(x, y, pixel);
        }
      });
      #endregion
      #region WallCasting
      Parallel.For(0, ScreenWidth, x => {
        //calculate ray position and direction
        float cameraX = 2 * x / (float)ScreenWidth - 1; //x-coordinate in camera space
        float rayDirX = direction.X + plane.X * cameraX;
        float rayDirY = direction.Y + plane.Y * cameraX;
        //which box of the map we're in
        int mapX = intPosX;
        int mapY = intPosY;
        //length of ray from one x or y-side to next x or y-side
        float deltaDistX = (rayDirX == 0) ? 1e30f : Math.Abs(1.0f / rayDirX);
        float deltaDistY = (rayDirY == 0) ? 1e30f : Math.Abs(1.0f / rayDirY);
        //length of ray from current position to next x or y-side
        float sideDistX;
        float sideDistY;
        //what direction to step in x or y-direction (either +1 or -1)
        int stepX = 1, stepY = 1;
        //calculate step and initial sideDist
        if (rayDirX < 0) {
          stepX = -1;
          sideDistX = (position.X - mapX) * deltaDistX;
        } else {
          sideDistX = (mapX + 1.0f - position.X) * deltaDistX;
        }
        if (rayDirY < 0) {
          stepY = -1;
          sideDistY = (position.Y - mapY) * deltaDistY;
        } else {
          sideDistY = (mapY + 1.0f - position.Y) * deltaDistY;
        }
        bool side1 = true; //was a NS or a EW wall hit?
        //perform DDA
        while (true) {
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
          // Stop From Leaving Map
          if (mapX < 0 || mapY < 0) return;
          // Check if ray has hit a wall
          if (World.getWall(mapX, mapY) != Texture.Air) break;
        }
        // texturing calculations
        Texture texNum = World.getWall(mapX, mapY);
        if (texNum == Texture.Air) return;
        //Calculate distance of perpendicular ray (Euclidean distance would give fisheye effect!)
        float perpWallDist = !side1 ? (sideDistX - deltaDistX) : (sideDistY - deltaDistY);
        // Calculate height of line to draw on screen
        int lineHeight = (int)(ScreenHeight / perpWallDist );
        // calculate lowest and highest pixel to fill in current stripe
        int drawBounds = (int)(screenHeight2 + direction.Z + (position.Z / perpWallDist));
        int drawStart = -lineHeight / 2 + drawBounds;
        if (drawStart < 0) drawStart = 0;
        int drawEnd = lineHeight / 2 + drawBounds;
        if (drawEnd >= ScreenHeight) drawEnd = ScreenHeight - 1;
        //calculate value of wallX
        float wallX = (!side1 ? (position.Y + perpWallDist * rayDirY) : (position.X + perpWallDist * rayDirX)) % 1; //where exactly the wall was hit
        //x coordinate on the texture
        int texX = (int)(wallX * texWidth);
        if ((!side1 && rayDirX > 0) || (side1 && rayDirY < 0)) texX = texWidth - texX - 1;
        // TODO: an integer-only bresenham or DDA like algorithm could make the texture coordinate stepping faster
        // How much to increase the texture coordinate per screen pixel
        float step = 1.0f * texHeight / lineHeight;
        // Starting texture coordinate
        float texPos = (drawStart - direction.Z - (position.Z / perpWallDist) - screenHeight2 + lineHeight / 2) * step;
        for (int y = drawStart; y < drawEnd; y++) {
          // Cast the texture coordinate to integer, and mask with (texHeight - 1) in case of overflow
          int texY = (int)(texPos) & (texHeight - 1); // TODO: Figure this out
          texPos += step;
          //make color darker for y-sides: R, G and B byte each divided through two with a "shift" and an "and"
          Color pixel = textures[texNum].GetPixel(texX, texY);
          if (side1) {
            //TODO: Optimze This
            SceneBuffer.SetPixel(x, y, new Color((pixel.R >> 1) & 8355711, (pixel.G >> 1) & 8355711, (pixel.B >> 1) & 8355711, pixel.A));
          } else {
            SceneBuffer.SetPixel(x, y, pixel);
          }
        }
        //SET THE ZBUFFER FOR THE SPRITE CASTING
        ZBuffer[x] = perpWallDist; //perpendicular distance is used
      });
      #endregion
      // Set Our Update State
      SceneUpdate = false;
      // Return Buffer
      return SceneBuffer;
    }
    public DirectBitmap DrawSprites(TimeSpan gameTime) {
      if (!SpriteUpdate) return SpriteBuffer;
      SpriteBuffer.clearImage();
      Vector3 position = World.LocalPlayer.Position;
      Vector3 direction = World.LocalPlayer.Direction;
      Vector2 plane = World.LocalPlayer.Controller.Plane;
      #region Sprite Casting
      int screenHeight2 = ScreenHeight / 2;
      //SPRITE CASTING
      // TODO: Remove This
      foreach (Sprite currentSprite in World.SpritePool) {
        currentSprite.distance = Vector3.DistanceSquared(position, currentSprite.Position);
      }
      World.SpritePool.Sort(new Comparison<Sprite>((a, b) => b.distance.CompareTo(a.distance)));
      //parameters for scaling and moving the sprites
      const int uDiv = 1;
      const int vDiv = 1;
      const float vMove = 0.0f;
      //after sorting the sprites, do the projection and draw them
      foreach (Sprite currentSprite in World.SpritePool) {
        //translate sprite position relative to camera
        float spriteX = currentSprite.Position.X - position.X;
        float spriteY = currentSprite.Position.Y - position.Y;
        if (spriteX == 0 || spriteY == 0) continue;
        // transform sprite with the inverse camera matrix
        // [ planeX   dirX ] -1                                       [ dirY      -dirX ]
        // [               ]       =  1/(planeX*dirY-dirX*planeY) *   [                 ]
        // [ planeY   dirY ]                                          [ -planeY  planeX ]
        float invDet = 1 / (plane.X * direction.Y - direction.X * plane.Y); //required for correct matrix multiplication
        float transformX = invDet * (direction.Y * spriteX - direction.X * spriteY);
        float transformY = invDet * (-plane.Y * spriteX + plane.X * spriteY); //this is actually the depth inside the screen, that what Z is in 3D, the distance of sprite to player, matching sqrt(spriteDistance[i])
        int spriteScreenX = (int)((ScreenWidth / 2) * (1 + transformX / transformY));
        int vMoveScreen = (int)((int)(vMove / transformY) + direction.Z + position.Z / transformY);
        //calculate height of the sprite on screen
        int spriteScale = Math.Abs((int)(ScreenHeight / transformY));
        int spriteHeight = spriteScale / vDiv; //using "transformY" instead of the real distance prevents fisheye
        //calculate lowest and highest pixel to fill in current stripe
        int drawStartY = -spriteHeight / 2 + screenHeight2 + vMoveScreen;
        if (drawStartY < 0) drawStartY = 0;
        int drawEndY = spriteHeight / 2 + screenHeight2 + vMoveScreen;
        if (drawEndY >= ScreenHeight) drawEndY = ScreenHeight - 1;
        //calculate width of the sprite
        int spriteWidth = spriteScale / uDiv;
        int drawStartX = -spriteWidth / 2 + spriteScreenX;
        if (drawStartX < 0) drawStartX = 0;
        int drawEndX = spriteWidth / 2 + spriteScreenX;
        if (drawEndX >= ScreenWidth) drawEndX = ScreenWidth - 1;
        //loop through every vertical stripe of the sprite on screen
        if (transformY > 0) {
          Parallel.For(drawStartX, drawEndX, stripe => {
            if (stripe < ScreenWidth && transformY < ZBuffer[stripe]) {
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
                int d = (y - vMoveScreen) * 256 - ScreenHeight * 128 + spriteHeight * 128; //256 and 128 factors to avoid floats
                int texY = ((d * texHeight) / spriteHeight) / 256;
                // Protect Agaist out Of Bounds Indexing
                if (texY < 0) continue;
                Color pixel = textures[currentSprite.Texture].GetPixel(texX, texY);
                if (pixel.A != 0) SpriteBuffer.SetPixel(stripe, y, pixel); //paint pixel if it is visible
              }
            }
          });
        }
      }
      #endregion
      SpriteUpdate = false;
      return SpriteBuffer;
    }
    public DirectBitmap DrawUi(TimeSpan gameTime) {
      if (!UiUpdate) return UiBiffer;
      UiBiffer.clearImage();
      Vector3 position = World.LocalPlayer.Position;
      // Draw UI
      for (int x = 1; x < worldSizeX; x++) {
        for (int y = 0; y < worldSizeY; y++) {
          UiBiffer.SetPixel(UiBiffer.Width - x, y, World.getWall(x, y) == Texture.Air ? Color.White : Color.Black);
        }
      }
      foreach (Sprite sprite in World.SpritePool) {
        if (sprite.Controller == null) continue;
        Color color = Color.Red;
        if (sprite.Controller is LocalPlayerController)
          color = Color.Blue;
        for (int x = -1; x < 2; x++) {
          for (int y = -1; y < 2; y++) {
            UiBiffer.SetPixel(UiBiffer.Width - (int)sprite.Position.X - x, (int)sprite.Position.Y - y, color);
          }
        }
      }
      
      // Set our Update State
      UiUpdate = false;
      // Return Buffer
      return UiBiffer;
    }
    public string getDataText(TimeSpan gameTime) {
      float frameTime = gameTime.Milliseconds / 1000.0f;
      Vector3 position = World.LocalPlayer.Position;
      Vector3 direction = World.LocalPlayer.Direction;
      return (
$@"frameRate: {(int)(1 / frameTime)}, x: {position.X - (position.X % 0.01)}, y: {position.Y - (position.Y % 0.01)}, z: {position.Z - (position.Z % 0.01)}
pitch: { Math.Round(direction.Z, 3)}, dir: { Math.Atan2(direction.X, direction.Y) * 180 / Math.PI}
dirX: {direction.X}, dirY: {direction.Y}
Health: {World.LocalPlayer.health}"
      );
    }
  }
}