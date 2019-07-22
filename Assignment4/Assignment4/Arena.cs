using System.IO;
using System.Collections.Generic;
using System;

namespace Assignment4
{
    class Arena
    {
        public Arena(string arenaName, uint capacity)
        {
            ArenaName = arenaName;
            Capacity = capacity;
        }

        public uint Capacity
        {
            get; private set;
        }

        public string ArenaName
        {
            get; private set;
        }

        public uint Turns
        {
            get; private set;
        }

        public uint MonsterCount
        {
            get; private set;
        }

        private List<Monster> mMonsters;

        public void LoadMonsters(string filePath)
        {
            string[] monsters = File.ReadAllLines(filePath);
            foreach(var monster in monsters)
            {
                string[] attribute = monster.Split(',');
                string name = attribute[0];
                EElementType elementType;
                int health;
                int attackStat;
                int defenseStat;
                Enum.TryParse(attribute[1], out elementType);
                int.TryParse(attribute[2], out health);
                int.TryParse(attribute[3], out attackStat);
                int.TryParse(attribute[4], out defenseStat);

                Monster created = new Monster(name, elementType, health, attackStat, defenseStat);
                if(mMonsters.Count <= Capacity)
                {
                    mMonsters.Add(created);
                }
            }
        }
    }
}
