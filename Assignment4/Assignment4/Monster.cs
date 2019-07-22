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
            get; private set;
        }

        public int AttackStat
        {
            get; private set;
        }

        public int DefenseStat
        {
            get; private set;
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
        }

        public void Attack(Monster otherMonster)
        {
            int basicAttack = AttackStat - otherMonster.DefenseStat;

            if(otherMonster.ElementType == ElementType || ((ElementType == EElementType.Water ||ElementType == EElementType.Ground) 
                && (otherMonster.ElementType == EElementType.Water || otherMonster.ElementType == EElementType.Ground)))
            {
                otherMonster.Health -= basicAttack;
                return;
            }
            else if((ElementType == EElementType.Fire && otherMonster.ElementType == EElementType.Wind) || (ElementType == EElementType.Water && otherMonster.ElementType == EElementType.Fire)
                || (ElementType == EElementType.Ground && otherMonster.ElementType == EElementType.Fire) || 
                (ElementType == EElementType.Wind && (otherMonster.ElementType == EElementType.Water || otherMonster.ElementType == EElementType.Ground)))
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