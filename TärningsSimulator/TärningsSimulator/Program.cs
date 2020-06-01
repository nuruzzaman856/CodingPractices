using System;

namespace TärningsSimulator
{
    class Program
    {
        static Random rnd = new Random();
        static int TotalSum = 0;
        static int DiceCount = 0;
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Welcome to Dice game.Please Enter your Name:");
               

                string Name = Console.ReadLine();
                // int you = Convert.ToInt32(Name);
                if (string.IsNullOrEmpty(Name))
                {
                    Console.WriteLine("Name can't be empty! Input your name once more");
                    Name = Console.ReadLine();
                }
                try
                {
                    Console.WriteLine("Please Enter the date(e.g. 2020/05/29):");
                    DateTime Date = DateTime.Parse(Console.ReadLine());
                    //if ()
                    //{

                    //}
                    Console.WriteLine("Welcome {0}: ", Name + " Today is {1}: " + Date);


                    Boolean KeepPlaying = true;
                    Console.WriteLine("How many Dice you want to throw: Chose between 1-5: Enter 6 to quit");
                    while (KeepPlaying)
                    {
                       
                        int userchoice = Convert.ToInt32(Console.ReadLine());

                        if (userchoice < 1 || userchoice > 6)
                        {
                            Console.WriteLine("invalid choice,chose between 1-6");
                        }
                        else if (userchoice == 1)
                        {
                            TotalSum = 0;
                            DiceCount = 0;
                            int d1 = rnd.Next(1, 7);
                            if (d1 == 6)
                            {
                                Console.WriteLine("You get a Six: " + d1 + " : Two more dice Rolling.");
                                int sumtotal1 = IfSix();
                                DiceCount = DiceCount + 1;
                                Console.WriteLine(Name + " : Sum of Dice: " + sumtotal1 + " : Dice Count: " + DiceCount + " : Time : " + Date);

                            }
                            else
                            {

                                DiceCount = DiceCount + 1;
                                Console.WriteLine(Name + " Your dice  number " + d1 + " : Sum of Dice: " + d1 + " : Dice Count: " + DiceCount + " : Time : " + Date);
                            }
                            Console.WriteLine("Want to continue playing, Chose between 1-5 or Enter 6 to quit");
                        }
                        else if (userchoice == 2)
                        {
                            TotalSum = 0;
                            DiceCount = 0;
                            int d1 = rnd.Next(1, 7);
                            for (int z = 0; z <= userchoice; z++)
                            {
                                if (d1==6) 
                                {
                                    Console.WriteLine("You get a Six: " + d1 + " : Two more dice Rolling.");
                                    int sumtotal2 = IfSix();
                                    DiceCount = DiceCount + 1;
                                    Console.WriteLine(Name + " : Sum of Dice: " + sumtotal2 + " : Dice Count: " + DiceCount + " : Time : " + Date);
                                }
                                else
                                {

                                    TotalSum = TotalSum + d1;
                                    DiceCount += 1;
                                    Console.WriteLine(Name + " Your dice  number " + d1 + " : Sum of Dice: " + TotalSum + " : Dice Count: " + DiceCount + " : Time : " + Date);

                                }
                            }

                        }
                        else if (userchoice == 6)
                        {
                            KeepPlaying = false;
                        }
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invaild formate,try again");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid formate. {0}", ex.Message);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        static int IfSix()
        {


            int a = rnd.Next(1, 7);
            int b = rnd.Next(1, 7);
            Console.WriteLine("num...." + a + " ," + b);
            //Console.WriteLine("TotalSum out side in after recurrsion = " + TotalSum);
            if (a == 6)
            {

                DiceCount = DiceCount + 2;
                Console.WriteLine("Wow 6 again!!, so again 2 times:");
                if (b != 6)
                    TotalSum = TotalSum + b;
               // Console.WriteLine("TotalSume in 1....." + TotalSum);
                IfSix();
                //Console.WriteLine("TotalSume in 2....." + TotalSum);


            }
            else if (b == 6)
            {

                DiceCount = DiceCount + 2;
                Console.WriteLine("Wow 6 again!!, so again 2 times:");
                if (a != 6)
                    TotalSum = TotalSum + a;
               // Console.WriteLine("TotalSume in 3....." + TotalSum);
                IfSix();
               // Console.WriteLine("TotalSume in 4....." + TotalSum);
            }
            else
            {

                TotalSum = TotalSum + a + b;
                DiceCount = DiceCount + 2;

            }
            // totalSum += sum;
            return TotalSum;

        }

    }

    

}
