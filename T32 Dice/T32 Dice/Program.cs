using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T32_Dice
{
    public class Dice
    {
        private Random random;

        public Dice()
        {
            random = new Random();
        }
        public int Roll()
        {
            return random.Next(1, 7);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // One roll
            Dice dice = new Dice();
            int result = dice.Roll();
            Console.WriteLine("One dice roll: " + result);

            // X many rolls
            Console.WriteLine("How many rolls: ");
            int rolls = int.Parse(Console.ReadLine());

            int sum = 0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;

            for (int i = 0; i < rolls; i++)
            {
                int diceRoll = dice.Roll();

                switch (diceRoll)
                {
                    case 1:
                        diceRoll = 1;
                        count1 += 1;
                        sum += diceRoll;
                        break;
                    case 2:
                        diceRoll = 2;
                        count2 += 1;
                        sum += diceRoll;
                        break;
                    case 3:
                        diceRoll = 3;
                        count3 += 1;
                        sum += diceRoll;
                        break;
                    case 4:
                        diceRoll = 4;
                        count4 += 1;
                        sum += diceRoll;
                        break;
                    case 5:
                        diceRoll = 5;
                        count5 += 1;
                        sum += diceRoll;
                        break;
                    case 6:
                        diceRoll = 6;
                        count6 += 1;
                        sum += diceRoll;
                        break;
                }
            }

            double avg = (double)sum / rolls;
            Console.WriteLine("Average of " + rolls + " rolls is: " + avg);
            Console.WriteLine("1 count is: " + count1 + "\n2 count is: " + count2 +
                "\n3 count is: " + count3 + "\n4 count is: " + count4 + "\n5 count is: " + count5 + "\n6 count is: " + count6);


        }
    }
}
