using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        private static int countPowerUps;

        static Enemy()
        {
            countPowerUps = 0;
        }

        public static int GetCountPowerUps()
        {
            return countPowerUps;
        }

        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void SetName(string name)
        {
            if (name.Length > 8)
            {
                this.name = name.Substring(0, 8);
            } 
            else
            {
                this.name = name;
            }
        }

        public void PickupPowerUp(PowerUp power, float p)
        {
            countPowerUps++;

            if (power == PowerUp.Health)
            {
                health += p;

                if (health > 100f)
                {
                    health = 100;
                }
            }
            else if (power == PowerUp.Shield)
            {
                shield += p;

                if (shield > 100f)
                {
                    shield = 100;
                }

            }
        }
    }
}