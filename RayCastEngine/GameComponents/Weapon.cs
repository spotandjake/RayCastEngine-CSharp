using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace RayCastEngine.GameComponents {
  enum WeaponType {
    Pistol
  }
  abstract class Weapon {
    // Properties
    public Texture texture;
    public WeaponType weaponType;
    public float shootRate; // the rate of fire in ms
    // Methods
  }
  // Different Gun Types
  class Pistol : Weapon {
    public Texture texture = Texture.Pistol_1_1;
    public WeaponType weaponType = WeaponType.Pistol;
    public float shootRate = 1000 * 60f;
  }
}
