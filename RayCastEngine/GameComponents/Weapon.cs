using Microsoft.Xna.Framework;

namespace RayCastEngine.GameComponents {
  enum WeaponType {
    Pistol,
  }
  // Different Gun Types
  class Weapon {
    // Properties
    public WeaponType weaponType;
    public float shootRate;
    public bool hitPlayer;
    // Initiailizer
    public Weapon(WeaponType weapon, float shootRate, bool hitPlayer) {
      // Set Properties
      this.weaponType = weapon;
      this.shootRate = shootRate;
      this.hitPlayer = hitPlayer;
    }
    // Get Texture
    public Texture getTexture() {
      switch (this.weaponType) {
        case WeaponType.Pistol:
          return Texture.Pistol_1_1;
        default:
          return Texture.Pistol_1_1;
      }
    }
    // Spawn Bullet
    public void spawnBullet(Vector3 position, Vector3 direction, World world) {
      // Try To Play Sound
      world.sound.ShootNoise();
      // TODO: Use Bullet Texture
      world.SpritePool.Add(new Sprite(position, direction, Texture.Bullet, true, new BulletController(25, hitPlayer)));
    }
  }
}
