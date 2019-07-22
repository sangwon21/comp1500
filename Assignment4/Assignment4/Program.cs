using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster monster1 = new Monster("Monster1", EElementType.Fire, 80, 5, 0);
            Monster monster2 = new Monster("Monster2", EElementType.Fire, 80, 5, 0);
            Monster monster3 = new Monster("Monster3", EElementType.Wind, 80, 7, 1);

            monster1.Attack(monster2); // monster2.Health가 75이 됨
            Console.WriteLine(monster2.Health);
            monster1.Attack(monster3); // monster3.Health가 74가 됨
            Console.WriteLine(monster3.Health);
            monster3.Attack(monster1); // monster1.Health가 77이 됨
            Console.WriteLine(monster1.Health);
        }
    }
}
