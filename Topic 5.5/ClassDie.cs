using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_5._5
{
    public class ClassDie
    {
        private int _roll;
        private int _sides;
        private Random _generator;

        public ClassDie()
        {
            _generator = new Random();
            _sides = 6;
            RollDie();
        }

        public ClassDie(int sides)
        {
            _generator = new Random();
            _sides = sides;
            if (sides > 9)
            {
                sides = 9;
            }
            RollDie();
        }

        public int Roll { get { return _roll; } }

        public int Sides { get { return _sides; } }

        public override string ToString()
        {
            return _roll.ToString();
        }
       

        public int RollDie()
        {
            _roll = _generator.Next(1, _sides);
            return _roll;
        }
        

        public void DrawRoll()
        {
            switch (_roll)
            {
                case 1:
                    Console.WriteLine("______________");
                    Console.WriteLine("|            |");
                    Console.WriteLine("|            |");
                    Console.WriteLine("|     ()     |");
                    Console.WriteLine("|            |");
                    Console.WriteLine("|            |");
                    Console.WriteLine("--------------");
                    break;
                case 2:
                    Console.WriteLine("______________");
                    Console.WriteLine("|            |");
                    Console.WriteLine("|  ()        |");
                    Console.WriteLine("|            |");
                    Console.WriteLine("|        ()  |");
                    Console.WriteLine("|            |");
                    Console.WriteLine("--------------");
                    break;
                case 3:
                    Console.WriteLine("______________");
                    Console.WriteLine("|            |");
                    Console.WriteLine("|  ()        |");
                    Console.WriteLine("|     ()     |");
                    Console.WriteLine("|        ()  |");
                    Console.WriteLine("|            |");
                    Console.WriteLine("--------------");
                    break;
                case 4:
                    Console.WriteLine("______________");
                    Console.WriteLine("|            |");
                    Console.WriteLine("|  ()    ()  |");
                    Console.WriteLine("|            |");
                    Console.WriteLine("|  ()    ()  |");
                    Console.WriteLine("|            |");
                    Console.WriteLine("--------------");
                    break;
                case 5:
                    Console.WriteLine("______________");
                    Console.WriteLine("|            |");
                    Console.WriteLine("|  ()    ()  |");
                    Console.WriteLine("|     ()     |");
                    Console.WriteLine("|  ()    ()  |");
                    Console.WriteLine("|            |");
                    Console.WriteLine("--------------");
                    break;
                case 6:
                    Console.WriteLine("______________");
                    Console.WriteLine("|            |");
                    Console.WriteLine("|  ()    ()  |");
                    Console.WriteLine("|  ()    ()  |");
                    Console.WriteLine("|  ()    ()  |");
                    Console.WriteLine("|            |");
                    Console.WriteLine("--------------");
                    break;
                case 7:
                    Console.WriteLine("______________");
                    Console.WriteLine("|            |");
                    Console.WriteLine("|  ()    ()  |");
                    Console.WriteLine("|  () () ()  |");
                    Console.WriteLine("|  ()    ()  |");
                    Console.WriteLine("|            |");
                    Console.WriteLine("--------------");
                    break;
                case 8:
                    Console.WriteLine("______________");
                    Console.WriteLine("|     ()     |");
                    Console.WriteLine("|  ()    ()  |");
                    Console.WriteLine("|  ()    ()  |");
                    Console.WriteLine("|  ()    ()  |");
                    Console.WriteLine("|     ()     |");
                    Console.WriteLine("--------------");
                    break;
                case 9:
                    Console.WriteLine("______________");
                    Console.WriteLine("|            |");
                    Console.WriteLine("|  () () ()  |");
                    Console.WriteLine("|  () () ()  |");
                    Console.WriteLine("|  () () ()  |");
                    Console.WriteLine("|            |");
                    Console.WriteLine("--------------");
                    break;
            }
        }
       

    }
}
