using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fall2020_CSC403_Project.code {
    public class Weapon : Character
    {
        public Image Img { get; set; }

        public Weapon(Vector2 initPos, Collider collider) : base(initPos, collider)
        {

        }

        public void SamehadaAttack()
        {

        }
    }
}