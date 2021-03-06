using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;

namespace RayCastEngine.GameComponents {
  // World
  class World : IDisposable {
    // Properties
    private bool isDisposed;
    private int SizeX;
    private int SizeY;
    public List<Room> rooms = new List<Room>();
    private Texture[,] WorldMap;
    public List<Sprite> SpritePool;
    private Sprite[] tempSpritePool;
    public Sprite LocalPlayer;
    private DungeonGenerator DungeonBuilder;
    public MidiPlayer sound = new MidiPlayer();
    public Random worldRandomness;
    // Constructor
    public World(int sizeX, int sizeY, Network net) {
      // Set Randomness
      worldRandomness = new Random();
      // Set Properties
      SizeX = sizeX;
      SizeY = sizeY;
      // General World
      DungeonBuilder = new DungeonGenerator(SizeX, SizeY);
      WorldMap = DungeonBuilder.exportMap();
      SpritePool = DungeonBuilder.getEntityPositions();
      rooms = DungeonBuilder.rooms;
      // Generate Local Player
      // TODO: Make A Better Texture
      LocalPlayer = new Sprite(DungeonBuilder.getStartPosition(), new Vector3(-1.0f, 0.0f, 0.0f), Texture.Enemy_1, false, new LocalPlayerController(net));
      // Add Aditional Sprites
      SpritePool.Add(LocalPlayer);
      // Start Music
      sound.ManageMusic();
    }
    // Method
    public WorldUpdateResult Update(TimeSpan gameTime, Network net) {
      WorldUpdateResult worldUpdate = new WorldUpdateResult {
        SceneUpdate = false,
        SpriteUpdate = false,
        UiUpdate = false,
        removeSelf = false
      };
      tempSpritePool = SpritePool.ToArray();
      bool somethingRemoved = false;
      for (int i = 0; i < tempSpritePool.Length; i++) {
        Sprite sprite = tempSpritePool[i];
        WorldUpdateResult updateData = sprite.Update(gameTime, this);
        if (updateData.removeSelf && !somethingRemoved) {
          SpritePool.RemoveAt(i);
          somethingRemoved = true;
          worldUpdate.SpriteUpdate = true;
        }
        worldUpdate.SceneUpdate |= updateData.SceneUpdate;
        worldUpdate.SpriteUpdate |= updateData.SpriteUpdate;
        worldUpdate.UiUpdate |= updateData.UiUpdate;
      }
      return worldUpdate;
    }
    public Texture getWall(int x, int y) {
      // TODO: Implement Infinite Generation
      return WorldMap[x, y];
    }
    public Vector3 getSpawn() {
      return DungeonBuilder.getStartPosition();
    }
    // Dispoable
    public void Dispose() {
      // Dispose of unmanaged resources.
      Dispose(true);
      // Suppress finalization.
      GC.SuppressFinalize(this);
    }
    // The bulk of the clean-up code is implemented in Dispose(bool)
    protected virtual void Dispose(bool disposing) {
      if (isDisposed) return;
      if (disposing) {
        // free managed resources
        sound.Dispose();
      }
      isDisposed = true;
    }
  }
}
