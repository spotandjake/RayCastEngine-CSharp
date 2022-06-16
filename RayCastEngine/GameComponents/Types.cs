namespace RayCastEngine.GameComponents {
  public enum Texture {
    // Block Textures
    Air,
    EagleWall,
    RedBrickWall,
    PurpleStoneWall,
    GreyStoneWall,
    BlueStoneWall,
    MossyWall,
    WoodWall,
    ColorStoneWall,
    // Entity Texture
    BarrelEntity,
    PillarEntity,
    GreenLight,
    // Enemy Texture
    Enemy_1,
    // Boss Texture
    Boss_1,
    Boss_2,
    Boss_3,
    // Boss Minion Texture
    Boss_3_Minion_1,
    // Weapons
    Pistol_1_1,
    Pistol_1_2,
    Pistol_1_3,
    Pistol_1_4,
    // Bullet
    Bullet,
    // Power Ups
    BulletPowerUp,
    HeartPowerUp,
  }
  public enum PowerUp {
    MaxHealth,
    Ammo
  }
  struct WorldUpdateResult {
    public bool SceneUpdate;
    public bool SpriteUpdate;
    public bool UiUpdate;
    public bool removeSelf;
  }
}
