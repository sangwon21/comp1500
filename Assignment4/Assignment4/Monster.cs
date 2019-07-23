namespace Assignment4
{
    public class Monster
    {
        public Monster(string name, EElementType elementType, int health, int attack, int defense)
        {
            Name = name;
            ElementType = elementType;
            Health = health;
            AttackStat = attack;
            DefenseStat = defense;
        }
        private int mHealth;
        private int mAttack;
        private int mDefense;

        public string Name
        {
            get; private set;
        }

        public EElementType ElementType
        {
            get; private set;
        }

        public int Health
        {
            get
            {
                return mHealth;
            }
            private set
            {
                if (value >= 0)
                {
                    mHealth = value;
                }
                else
                {
                    mHealth = 0;
                }

            }
        }

        public int AttackStat
        {
            get
            {
                return mAttack;
            }
            private set
            {
                if (value >= 0)
                {
                    mAttack = value;
                }
                else
                {
                    mAttack = 0;
                }

            }
        }

        public int DefenseStat
        {
            get
            {
                return mDefense;
            }
            private set
            {
                if (value > 0)
                {
                    mDefense = value;
                }
                else
                {
                    mDefense = 0;
                }
            }
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
        }

        public void Attack(Monster otherMonster)
        {
            int basicAttack = AttackStat - otherMonster.DefenseStat;
            if (basicAttack < 1)
            {
                basicAttack = 1;
            }

            if (otherMonster.ElementType == ElementType || ((ElementType == EElementType.Water || ElementType == EElementType.Earth)
                && (otherMonster.ElementType == EElementType.Water || otherMonster.ElementType == EElementType.Earth)))
            {
                otherMonster.Health -= basicAttack;
                return;
            }
            else if ((ElementType == EElementType.Fire && otherMonster.ElementType == EElementType.Wind) || (ElementType == EElementType.Water && otherMonster.ElementType == EElementType.Fire)
                || (ElementType == EElementType.Earth && otherMonster.ElementType == EElementType.Fire) ||
                (ElementType == EElementType.Wind && (otherMonster.ElementType == EElementType.Water || otherMonster.ElementType == EElementType.Earth)))
            {
                double changedAttack = basicAttack * 1.5;
                otherMonster.Health -= (int)changedAttack;
                return;
            }
            else
            {
                double changedAttack = basicAttack * 0.5;
                otherMonster.Health -= (int)changedAttack;
                return;
            }
        }
    }
}