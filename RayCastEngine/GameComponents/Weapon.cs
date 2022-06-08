using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    // Initiailizer
    public Weapon(WeaponType weapon, float shootRate) {
      // Set Properties
      this.weaponType = weapon;
      this.shootRate = shootRate;
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
      world.SpritePool.Add(new Sprite(position, direction, Texture.Boss_1, true, new BulletController(25)));
    }
  }
}
