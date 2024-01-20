using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTest.AbstractFactory
{
    /// <summary>
    /// клиент - сам супергерой
    /// </summary>
    class Hero
    {
        private Weapon weapon;

        private Movement movement;
        public Hero(HeroFactory factory)
        {
            movement = factory.CreateMovement();
            weapon = factory.CreateWeapon();
        }

        public void Run()
        {
            movement.Move();
        }
        public void Hit()
        {
            weapon.Hit();
        }
    }
}
