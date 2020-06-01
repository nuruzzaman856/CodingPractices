using System;

namespace Dice
{
    class Program
    {

        static Random rnd = new Random();
        static int sum, sum1, sum2, sum3, sum4, sum5, sum6 = 0;
        static int DiceCount = 1;
        static int DiceCount1 = 1;
        static int totalSum = 0;
        static int SumofDice, SumofDiceIfSix = 0;
        static int[] dice = new int[5];
        static void Main(string[] args)

        {

            Boolean keepPlaying = true;

            DateTime Time = DateTime.Now;
            Console.WriteLine("Welcome to Dice game,Please enter your name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Welcome " + Name + " Current Time: " + Time.ToString());


            while (keepPlaying)
            {
                try
                {


                    Console.WriteLine("");
                    Console.WriteLine("Select from the menu:");
                    Console.WriteLine("");
                    Console.WriteLine("1: roll one dice");
                    Console.WriteLine("2: roll two dice");
                    Console.WriteLine("3: roll three dice");
                    Console.WriteLine("4: roll four dice");
                    Console.WriteLine("5: roll five dice");
                    Console.WriteLine("6: end console");
                    Console.WriteLine("");
                    try
                    {
                        int UserChoice = int.Parse(Console.ReadLine());
                        switch (UserChoice)
                        {
                            case 1:
                                dice[0] = rnd.Next(1, 7);
                                if (dice[0] == 6)
                                {
                                    Console.WriteLine("You get SIX:" + dice[0] + "  :Rolling 2 more dice.");
                                    sum1 = IfSix();
                                    DiceCount +=1;

                                    SumofDice = sum1 ;
                                    Console.WriteLine(Name + " Your dice numbers are: " + dice[0] + " ," + dice[1] + " :Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + "  :Time: " + Time);


                                }



                                else
                                {
                                    DiceCount = +1;
                                    SumofDice = dice[0];
                                    Console.WriteLine(Name + " Your dice number is: " + dice[0] + " :Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + "  :Time: " + Time);

                                }
                                break;

                            case 2:
                                dice[0] = rnd.Next(1, 7);
                                dice[1] = rnd.Next(1, 7);

                                Console.WriteLine(Name + " Your new dice numbers are: " + dice[0] + " ," + dice[1]);


                                    if (dice[0] == 6) {
                                        sum1 = IfSix();
                                    DiceCount +=3;
                                    SumofDice = sum1 + sum2 + totalSum;

                                    Console.WriteLine(Name + " Your new dice numbers are: " + dice[0] + " ," + dice[1] + " :Total Sum of number:" + SumofDiceIfSix + " Dice Count: " + DiceCount + "  :Time: " + Time);

                                }
                               else if (dice[1] == 6)
                                    {
                                        sum2 = IfSix();
                                    DiceCount +=3;
                                    SumofDice = sum1 + sum2 + totalSum;

                                   Console.WriteLine(Name + " Your new dice numbers are: " + dice[0] + " ," + dice[1] + " :Total Sum of number:" + SumofDiceIfSix + " Dice Count: " + DiceCount + "  :Time: " + Time);

                                }
                                //DiceCount = DiceCount + 3;
                                //SumofDice = sum1 + sum2 + totalSum;

                                //Console.WriteLine(Name + " Your new dice numbers are: " + dice[0] + " ," + dice[1] + " :Total Sum of number:" + SumofDiceIfSix + " Dice Count: " + DiceCount + "  :Time: " + Time);



                                else
                                {
                                    DiceCount = +2;
                                    SumofDice = dice[0] + dice[1];
                                    Console.WriteLine(Name + " Your dice numbers are: " + dice[0] + " ," + dice[1] + ": Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + " :Time: " + Time);

                                }
                                break;

                            case 3:
                                dice[0] = rnd.Next(1, 7);
                                dice[1] = rnd.Next(1, 7);
                                dice[2] = rnd.Next(1, 7);
                               

                                    Console.WriteLine("You get SIX:" + dice[0] + " , " + dice[1] + " ," + dice[2]  );



                                    if (dice[0] == 6)
                                    {
                                        sum1 = IfSix();
                                    DiceCount += 3;
                                    SumofDice = sum1 + sum2 + sum3 + totalSum;

                                    Console.WriteLine(Name + " Your new dice numbers are: " + dice[0] + " ," + dice[1] + " :Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + "  :Time: " + Time);

                                }
                               else if (dice[1] == 6)
                                    {
                                        sum2 = IfSix();
                                    DiceCount += 3;
                                    SumofDice = sum1 + sum2 + sum3 + totalSum;

                                    Console.WriteLine(Name + " Your new dice numbers are: " + dice[0] + " ," + dice[1] + " :Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + "  :Time: " + Time);

                                }
                                else if (dice[2] == 6)
                                    {
                                        sum3 = IfSix();
                                    DiceCount += 3;
                                    SumofDice = sum1 + sum2 + sum3 + totalSum;

                                    Console.WriteLine(Name + " Your new dice numbers are: " + dice[0] + " ," + dice[1] + " :Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + "  :Time: " + Time);

                                }

                                //DiceCount +=3;
                                //SumofDice = sum1 + sum2 + sum3 + totalSum;

                                //Console.WriteLine(Name + " Your new dice numbers are: " + dice[0] + " ," + dice[1] + " :Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + "  :Time: " + Time);



                                else
                                {
                                    DiceCount = +3;
                                    SumofDice = dice[0] + dice[1] + dice[2];
                                    Console.WriteLine(Name + " Your dice numbers are: " + dice[0] + " ," + dice[1] + " ," + dice[2] + " : Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + " :Time: " + Time);

                                }
                                break;

                            case 4:
                                dice[0] = rnd.Next(1, 7);
                                dice[1] = rnd.Next(1, 7);
                                dice[2] = rnd.Next(1, 7);
                                dice[3] = rnd.Next(1, 7);
                               

                                    Console.WriteLine("You get SIX:" + dice[0] + " , " + dice[1] + " ," + dice[2] + " ," + dice[3] + " :Rolling 2 more dice.");



                                    if (dice[0] == 6)
                                    {
                                        sum1 = IfSix();
                                    DiceCount = DiceCount + 4;
                                    SumofDice = sum1 + sum2 + sum3 + sum4;
                                    Console.WriteLine(Name + " Your new dice numbers are: " + dice[0] + " ," + dice[1] + " :Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + "  :Time: " + Time);

                                }
                                if (dice[1] == 6)
                                    {
                                        sum2 = IfSix();
                                    DiceCount = DiceCount + 4;
                                    SumofDice = sum1 + sum2 + sum3 + sum4;
                                    Console.WriteLine(Name + " Your new dice numbers are: " + dice[0] + " ," + dice[1] + " :Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + "  :Time: " + Time);

                                }
                                if (dice[2] == 6)
                                    {
                                        sum3 = IfSix();
                                    DiceCount = DiceCount + 4;
                                    SumofDice = sum1 + sum2 + sum3 + sum4;
                                    Console.WriteLine(Name + " Your new dice numbers are: " + dice[0] + " ," + dice[1] + " :Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + "  :Time: " + Time);

                                }
                                if (dice[3] == 6)
                                    {
                                        sum4 = IfSix();
                                    DiceCount = DiceCount + 4;
                                    SumofDice = sum1 + sum2 + sum3 + sum4;
                                    Console.WriteLine(Name + " Your new dice numbers are: " + dice[0] + " ," + dice[1] + " :Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + "  :Time: " + Time);

                                }

                                //DiceCount = DiceCount + 4;
                                //SumofDice = sum1 + sum2 + sum3 + sum4;
                                //Console.WriteLine(Name + " Your new dice numbers are: " + dice[0] + " ," + dice[1] + " :Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + "  :Time: " + Time);



                                else
                                {
                                    DiceCount = +4;
                                    SumofDice = dice[0] + dice[1] + dice[2] + dice[3];
                                    Console.WriteLine(Name + " Your dice numbers are: " + dice[0] + " " + dice[1] + " " + dice[2] + " " + dice[3] + ". Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + " :Time:" + Time);

                                }

                                break;
                            case 5:
                                dice[0] = rnd.Next(1, 7);
                                dice[1] = rnd.Next(1, 7);
                                dice[2] = rnd.Next(1, 7);
                                dice[3] = rnd.Next(1, 7);
                                dice[4] = rnd.Next(1, 7);
                               

                                    Console.WriteLine("You get SIX:" + dice[0] + " , " + dice[1] + " ," + dice[2] + " ," + dice[3] + " ," + dice[4] + " :Rolling 2 more dice.");



                                    if (dice[0] == 6)
                                    {
                                        sum1 = IfSix();
                                    DiceCount = DiceCount + 5;
                                    SumofDice = sum1 + sum2 + sum3 + sum4 + sum5;
                                    Console.WriteLine(Name + " Your new dice numbers are: " + dice[0] + " ," + dice[1] + " :Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + "  :Time: " + Time);

                                }
                                else if (dice[1] == 6)
                                    {
                                        sum2 = IfSix();
                                    DiceCount = DiceCount + 5;
                                     SumofDice = sum1 + sum2 + sum3 + sum4 + sum5;
                                   Console.WriteLine(Name + " Your new dice numbers are: " + dice[0] + " ," + dice[1] + " :Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + "  :Time: " + Time);

                                }
                                else if (dice[2] == 6)
                                    {
                                        sum3 = IfSix();
                                    DiceCount = DiceCount + 5;
                                    SumofDice = sum1 + sum2 + sum3 + sum4 + sum5;
                                   Console.WriteLine(Name + " Your new dice numbers are: " + dice[0] + " ," + dice[1] + " :Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + "  :Time: " + Time);

                                }
                                else if (dice[3] == 6)
                                    {
                                        sum4 = IfSix();
                                    DiceCount = DiceCount + 5;
                                    SumofDice = sum1 + sum2 + sum3 + sum4 + sum5;
                                    Console.WriteLine(Name + " Your new dice numbers are: " + dice[0] + " ," + dice[1] + " :Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + "  :Time: " + Time);

                                }
                                else if(dice[4] == 6)
                                    {
                                        sum5 = IfSix();
                                    DiceCount = DiceCount + 5;
                                    SumofDice = sum1 + sum2 + sum3 + sum4 + sum5;
                                     Console.WriteLine(Name + " Your new dice numbers are: " + dice[0] + " ," + dice[1] + " :Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + "  :Time: " + Time);

                                }

                                // DiceCount = DiceCount + 5;
                                // SumofDice = sum1 + sum2 + sum3 + sum4 + sum5;
                                // Console.WriteLine(Name + " Your new dice numbers are: " + dice[0] + " ," + dice[1] + " :Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + "  :Time: " + Time);
                                else 
                                    {
                                    DiceCount = +5;
                                    SumofDice = dice[0] + dice[1] + dice[2] + dice[3] + dice[4];
                                    Console.WriteLine(Name + " Your dice numbers are: " + dice[0] + " " + dice[1] + " " + dice[2] + " " + dice[3] + " " + dice[4] + " :Total Sum of number:" + SumofDice + " Dice Count: " + DiceCount + " :Time: " + Time);
                                    }
                                break;

                            case 6:
                                Console.WriteLine(Name + " Your total Sum of dice numbers you got:{0}", SumofDice,
                                    "Total dice was thrown: {1}", DiceCount + "  " + Time.ToString());
                                keepPlaying = false;
                                break;
                            default:
                                Console.WriteLine("");
                                Console.WriteLine("Invalid choice!");
                                Console.Clear();
                                break;

                        }
                    }
                    catch (Exception ch)
                    {
                        Console.WriteLine(ch.Message + "Chose between 1-6");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " Please try again");
                }
            }
        }
        static int IfSix()
        {
            
            TwoMore:
                dice[0] = rnd.Next(1, 7);
                dice[1] = rnd.Next(1, 7);
                if (dice[0] == 6 || dice[1] == 6)
                {
                    DiceCount += 2;
                    Console.WriteLine("Wow 6 again!!, so again 2 times:"+dice[0]+" ,"+dice[1]);

                    goto TwoMore;
                }
                else
                {
                    if (dice[0] < 6)
                    {

                        sum += dice[0];


                    }
                    if (dice[1] < 6)
                    {
                        sum += dice[1];

                    }
                }
                totalSum += sum;
            return totalSum;



        }
            
        }


    
}
