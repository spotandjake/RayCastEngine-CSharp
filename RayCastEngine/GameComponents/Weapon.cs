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
    public Texture texture;
    public WeaponType weaponType;
    public float shootRate;
    // Initiailizer
    public Weapon(WeaponType weapon, float shootRate) {
      // Set Properties
      this.weaponType = weapon;
      this.shootRate = shootRate;
      // Set Texture
      switch (weapon) {

      }
    }
  }
}
