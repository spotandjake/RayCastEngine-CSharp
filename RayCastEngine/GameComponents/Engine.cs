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
    // Methods
    public void Load(GameType gameType) {
      // Initialize
    }
    public void Update(TimeSpan gameTime) {
      // Gametime elapsed
      double gameTimeElapsed = gameTime.TotalMilliseconds / 1000;
      // Draw Frame Into Buffer
      // Set Cached Vars
      int screenWidth = engine.w;
      int screenHeight = engine.h;
      int screenHeight2 = screenHeight * 0.5;
      // rayDir for leftmost ray (x = 0) and rightmost ray (x = w)
      float rayDirX0 = dirX - planeX;
      float rayDirY0 = dirY - planeY;
      float rayDirX1 = dirX + planeX;
      float rayDirY1 = dirY + planeY;
      //move forward if no wall in front of you
      int intPosX = (int)posX;
      int intPosY = (int)posY;
      //FLOOR CASTING
      for (int y = 0; y < screenHeight; y++) {
        // whether this section is floor or ceiling
        Boolean is_floor = y > screenHeight2 + camPitch;
        // Current y position compared to the center of the screen (the horizon)
        int p = (int)(is_floor ? (y - screenHeight2 - camPitch) : (screenHeight2 - y + camPitch));
        // Vertical position of the camera.
        // NOTE: with 0.5, it's exactly in the center between floor and ceiling,
        // matching also how the walls are being raycasted. For different values
        // than 0.5, a separate loop must be done for ceiling and floor since
        // they're no longer symmetrical.
        float camZ = is_floor ? (screenHeight2 + posZ) : (screenHeight2 - posZ);
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
        float rowDistance = camZ / p;
        // calculate the real world step vector we have to add for each x (parallel to camera plane)
        // adding step by step avoids multiplications with a weight in the inner loop
        float floorStepX = rowDistance * (rayDirX1 - rayDirX0) / screenWidth;
        float floorStepY = rowDistance * (rayDirY1 - rayDirY0) / screenWidth;
        // real world coordinates of the leftmost column. This will be updated as we step to the right.
        float floorX = posX + rowDistance * rayDirX0;
        float floorY = posY + rowDistance * rayDirY0;
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
          int floorTexture = (((cellX + cellY) & 1) == 0) ? 3 : 4;
          int ceilingTexture = 6;
          int[] pixel = getPixel(texture[is_floor ? floorTexture : ceilingTexture], tx, ty, texWidth);
          pixel[0] = (pixel[0] >> 1) & 8355711; // make a bit darker
          pixel[1] = (pixel[1] >> 1) & 8355711;
          pixel[2] = (pixel[2] >> 1) & 8355711;
          buffer.set(x, y, pixel);
        }
      }
      // WALL CASTING
      for (int x = 0; x < screenWidth; x++) {
        //calculate ray position and direction
        float cameraX = 2 * x / screenWidth - 1; //x-coordinate in camera space
        float rayDirX = dirX + planeX * cameraX;
        float rayDirY = dirY + planeY * cameraX;
        //which box of the map we're in
        float mapX = intPosX;
        float mapY = intPosY;
        //length of ray from current position to next x or y-side
        double sideDistX;
        double sideDistY;
        //length of ray from one x or y-side to next x or y-side
        double deltaDistX = (rayDirX == 0) ? 1e30 : Math.Abs(1 / rayDirX);
        double deltaDistY = (rayDirY == 0) ? 1e30 : Math.Abs(1 / rayDirY);
        float perpWallDist;
        //what direction to step in x or y-direction (either +1 or -1)
        float stepX;
        float stepY;
        Boolean hit = false; //was there a wall hit?
        int side = 1; //was a NS or a EW wall hit?
                  //calculate step and initial sideDist
        if (rayDirX < 0) {
          stepX = -1;
          sideDistX = (posX - mapX) * deltaDistX;
        } else {
          stepX = 1;
          sideDistX = (mapX + 1.0 - posX) * deltaDistX;
        }
        if (rayDirY < 0) {
          stepY = -1;
          sideDistY = (posY - mapY) * deltaDistY;
        } else {
          stepY = 1;
          sideDistY = (mapY + 1.0 - posY) * deltaDistY;
        }
        //perform DDA
        while (hit == false) {
          //jump to next map square, either in x-direction, or in y-direction
          if (sideDistX < sideDistY) {
            sideDistX += deltaDistX;
            mapX += stepX;
            side = 0;
          } else {
            sideDistY += deltaDistY;
            mapY += stepY;
            side = 1;
          }
          //Check if ray has hit a wall
          if (worldMap[mapX][mapY] > 0) hit = true;
        }
        //Calculate distance of perpendicular ray (Euclidean distance would give fisheye effect!)
        if (side == 0) perpWallDist = (sideDistX - deltaDistX);
        else perpWallDist = (sideDistY - deltaDistY);
        // Calculate height of line to draw on screen
        int lineHeight = (int)(screenHeight / perpWallDist);
        // calculate lowest and highest pixel to fill in current stripe
        float drawStart = -lineHeight / 2 + screenHeight2 + camPitch + (posZ / perpWallDist);
        if (drawStart < 0) drawStart = 0;
        float drawEnd = lineHeight / 2 + screenHeight2 + camPitch + (posZ / perpWallDist);
        if (drawEnd >= screenHeight) drawEnd = screenHeight - 1;
        // texturing calculations
        int texNum = worldMap[mapX][mapY] - 1; // 1 subtracted from it so that texture 0 can be used!
                                               //calculate value of wallX
        double wallX; //where exactly the wall was hit
        if (side == 0) wallX = posY + perpWallDist * rayDirY;
        else wallX = posX + perpWallDist * rayDirX;
        wallX -= Math.Floor(wallX);
        //x coordinate on the texture
        int texX = (int)(wallX * texWidth);
        if (side == 0 && rayDirX > 0) texX = texWidth - texX - 1;
        if (side == 1 && rayDirY < 0) texX = texWidth - texX - 1;
        // TODO: an integer-only bresenham or DDA like algorithm could make the texture coordinate stepping faster
        // How much to increase the texture coordinate per screen pixel
        float step = 1.0 * texHeight / lineHeight;
        // Starting texture coordinate
        float texPos = (drawStart - camPitch - (posZ / perpWallDist) - screenHeight2 + lineHeight / 2) * step;
        for (int y = (int)(drawStart); y < drawEnd; y++) {
          // Cast the texture coordinate to integer, and mask with (texHeight - 1) in case of overflow
          int texY = (int)(texPos) & (texHeight - 1); // TODO: Figure this out
          texPos += step;
          int[] pixel = getPixel(texture[texNum], texX, texY, texWidth);
          //make color darker for y-sides: R, G and B byte each divided through two with a "shift" and an "and"
          if (side == 1) {
            pixel[0] = (pixel[0] >> 1) & 8355711;
            pixel[1] = (pixel[1] >> 1) & 8355711;
            pixel[2] = (pixel[2] >> 1) & 8355711;
          }
          buffer.set(x, y, pixel);
        }
        //SET THE ZBUFFER FOR THE SPRITE CASTING
        ZBuffer[x] = perpWallDist; //perpendicular distance is used
      }
      //SPRITE CASTING
      int[] spriteOrder = new int[sprite.length];
      //sort sprites from far to close
      for (int i = 0; i < sprite.length; i++) {
        spriteOrder[i] = {
          sprite: sprite[i],
          depth: ((posX - sprite[i].x) * (posX - sprite[i].x) + (posY - sprite[i].y) * (posY - sprite[i].y)),
        }
      }
      spriteOrder = spriteOrder.sort((a, b) => b.depth - a.depth);
      //after sorting the sprites, do the projection and draw them
      for (let i = 0; i < sprite.length; i++) {
        Sprite currentSprite = spriteOrder[i].sprite;
        //translate sprite position to relative to camera
        double spriteX = currentSprite.x - posX;
        double spriteY = currentSprite.y - posY;
        // transform sprite with the inverse camera matrix
        // [ planeX   dirX ] -1                                       [ dirY      -dirX ]
        // [               ]       =  1/(planeX*dirY-dirX*planeY) *   [                 ]
        // [ planeY   dirY ]                                          [ -planeY  planeX ]
        float invDet = 1.0 / (planeX * dirY - dirX * planeY); //required for correct matrix multiplication
        float transformX = invDet * (dirY * spriteX - dirX * spriteY);
        float transformY = invDet * (-planeY * spriteX + planeX * spriteY); //this is actually the depth inside the screen, that what Z is in 3D, the distance of sprite to player, matching sqrt(spriteDistance[i])
        int spriteScreenX = (int)((screenWidth * 0.5) * (1 + transformX / transformY));
        //parameters for scaling and moving the sprites
        // TODO: Convert These To Constants
        int uDiv = 1;
        int vDiv = 1;
        float vMove = 0.0f;
        int vMoveScreen = (int)((int)(vMove / transformY) + camPitch + posZ / transformY);
        //calculate height of the sprite on screen
        int spriteHeight = Math.Abs((int)(screenHeight / transformY)) / vDiv; //using "transformY" instead of the real distance prevents fisheye
                                                                                   //calculate lowest and highest pixel to fill in current stripe
        float drawStartY = -spriteHeight / 2 + screenHeight2 + vMoveScreen;
        if (drawStartY < 0) drawStartY = 0;
        float drawEndY = spriteHeight / 2 + screenHeight2 + vMoveScreen;
        if (drawEndY >= screenHeight) drawEndY = screenHeight - 1;
        //calculate width of the sprite
        int spriteWidth = Math.Abs((int)(screenHeight / transformY)) / uDiv;
        float drawStartX = -spriteWidth / 2 + spriteScreenX;
        if (drawStartX < 0) drawStartX = 0;
        float drawEndX = spriteWidth / 2 + spriteScreenX;
        if (drawEndX >= screenWidth) drawEndX = screenWidth - 1;
        //loop through every vertical stripe of the sprite on screen
        for (int stripe = (int)drawStartX; stripe < drawEndX; stripe++) {
          int texX = (int)((stripe - (-spriteWidth / 2 + spriteScreenX)) * texWidth / spriteWidth);
          //the conditions in the if are:
          //1) it's in front of camera plane so you don't see things behind you
          //2) it's on the screen (left)
          //3) it's on the screen (right)
          //4) ZBuffer, with perpendicular distance
          if (transformY > 0 && stripe > 0 && stripe < screenWidth && transformY < ZBuffer[stripe])
            for (int y = drawStartY; y < drawEndY; y++) {//for every pixel of the current stripe
              float d = (y - vMoveScreen) * 256 - screenHeight * 128 + spriteHeight * 128; //256 and 128 factors to avoid floats
              int texY = (int)(((d * texHeight) / spriteHeight) / 256);
              const pixel = getPixel(texture[currentSprite.texture], texX, texY, texWidth);
              if (pixel[3] == 0) continue;
              buffer.set(stripe, y, pixel); //paint pixel if it isn't black, black is the invisible color
            }
        }
      }
      engine.drawBuffer(buffer);
      // No need to clear the screen here, since everything is overdrawn with floor and ceiling
      //timing for input and FPS counter
      float frameTime = engine.deltaTime() / 1000.0f; //frametime is the time this frame has taken, in seconds
                                                 //speed modifiers
      float moveSpeed = frameTime * 3; //the constant value is in squares/second
      float rotSpeed = frameTime * 2; //the constant value is in radians/second
                                    // TODO: We should do the math on the movement both forward and backward and then check if it works
      if (keyIsDown(87)) {
        float projectedX = posX + dirX * moveSpeed;
        float projectedY = posY + dirY * moveSpeed;
        if (worldMap[Math.trunc(projectedX)] == undefined) projectedX = mapWidth - 1;
        if (worldMap[Math.trunc(projectedX)][Math.trunc(projectedY)] == undefined) projectedY = mapHeight - 1;
        if (worldMap[Math.trunc(projectedX)][intPosY] == 0) posX = projectedX;
        if (worldMap[intPosX][Math.trunc(projectedY)] == 0) posY = projectedY;
      }
      //move backwards if no wall behind you
      if (keyIsDown(83)) {
        float projectedX = posX - dirX * moveSpeed;
        float projectedY = posY - dirY * moveSpeed;
        if (worldMap[Math.trunc(projectedX)] == undefined) projectedX = mapWidth - 1;
        if (worldMap[Math.trunc(projectedX)][Math.trunc(projectedY)] == undefined) projectedY = mapHeight - 1;
        if (worldMap[Math.trunc(projectedX)][intPosY] == 0) posX = projectedX;
        if (worldMap[intPosX][Math.trunc(projectedY)] == 0) posY = projectedY;
      }
      // Strafe Left
      // if (keyIsDown(68)) {
      //   let projectedX = posX + (dirX + 1) * moveSpeed;
      //   let projectedY = posY + (dirY - 1) * moveSpeed;
      //   if (worldMap[Math.trunc(projectedX)] == undefined) projectedX = mapWidth-1;
      //   if (worldMap[Math.trunc(projectedX)][Math.trunc(projectedY)] == undefined) projectedY = mapHeight-1;
      //   if (worldMap[Math.trunc(projectedX)][intPosY] == 0) posX = projectedX;
      //   if (worldMap[intPosX][Math.trunc(projectedY)] == 0) posY = projectedY;
      // }
      // // Strafe Right
      // if (keyIsDown(65)) {
      //   let projectedX = posX + (dirX + 1) * moveSpeed;
      //   let projectedY = posY + (dirY + 1) * moveSpeed;
      //   if (worldMap[Math.trunc(projectedX)] == undefined) projectedX = mapWidth-1;
      //   if (worldMap[Math.trunc(projectedX)][Math.trunc(projectedY)] == undefined) projectedY = mapHeight-1;
      //   if (worldMap[Math.trunc(projectedX)][intPosY] == 0) posX = projectedX;
      //   if (worldMap[intPosX][Math.trunc(projectedY)] == 0) posY = projectedY;
      // }
      // TODO: We Want To Use The Mouse
      float cosRotSpeed = Math.cos(rotSpeed);
      float sinRotSpeed = Math.sin(rotSpeed);
      //rotate to the right
      if (keyIsDown(39)) {
        //both camera direction and camera plane must be rotated
        let oldDirX = dirX;
        dirX = dirX * cosRotSpeed - dirY * -sinRotSpeed;
        dirY = oldDirX * -sinRotSpeed + dirY * cosRotSpeed;
        let oldPlaneX = planeX;
        planeX = planeX * cosRotSpeed - planeY * -sinRotSpeed;
        planeY = oldPlaneX * -sinRotSpeed + planeY * cosRotSpeed;
      }
      //rotate to the left
      if (keyIsDown(37)) {
        //both camera direction and camera plane must be rotated
        let oldDirX = dirX;
        dirX = dirX * cosRotSpeed - dirY * sinRotSpeed;
        dirY = oldDirX * sinRotSpeed + dirY * cosRotSpeed;
        let oldPlaneX = planeX;
        planeX = planeX * cosRotSpeed - planeY * sinRotSpeed;
        planeY = oldPlaneX * sinRotSpeed + planeY * cosRotSpeed;
      }
      // Very simple demonstration jump/pitch controls
      // look up
      if (keyIsDown(38)) camPitch += 400 * moveSpeed;
      // look down
      if (keyIsDown(40)) camPitch -= 400 * moveSpeed;
      // jump
      if (keyIsDown(32) && posZ == 0) posZ = 200;
      // crouch
      if (keyIsDown(16) && posZ == 0) posZ = -200;
      if (camPitch > 0) camPitch = Math.Max(0, camPitch - 100 * moveSpeed);
      if (camPitch < 0) camPitch = Math.Min(0, camPitch + 100 * moveSpeed);
      if (posZ > 0) posZ = Math.Max(0, posZ - 100 * moveSpeed);
      if (posZ < 0) posZ = Math.Min(0, posZ + 100 * moveSpeed);
      // Print text
      fill(255, 255, 255);
      textSize(32);
      text(`frameRate: ${ Math.round(1 / frameTime)}, x: ${ posX}, y: ${ posY}, z: ${ posZ}`, 0, 32);
      text(`pitch: ${ camPitch}, dir: ${ Math.atan2(dirX, dirY) * 180 / Math.PI}`, 0, 64);
    }
    public void Draw(Graphics gfx) {
      // Draw UI
      // Draw Game
      // Draw Our New Buffer
      gfx.FillRectangle(new SolidBrush(Color.CornflowerBlue), new Rectangle(0, 0, Resolution.Width, Resolution.Height));
    }
  }
}
