namespace Topic_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sides = 0;
            int account = 100;
            int bet;
            string guess;
            bool validBet = false;
            ClassDie die1, die2;
           
            Console.WriteLine("Welcome to the dice game, How big do you want your dice to be?(6-9)");
            sides = Convert.ToInt32(Console.ReadLine());
           
            
            while (account > 0)
            {
                die1 = new ClassDie(sides);
                die2 = new ClassDie(sides);
                Console.WriteLine("How much would you like to bet?");
                if (int.TryParse(Console.ReadLine(), out bet))
                {
                    if (bet <= 0)
                    {
                        bet = 0;
                        validBet = true;
                    }
                    if (bet > account)
                    {
                        bet = account;
                        validBet = true;
                    }
                    else
                    {
                        validBet = true;
                    }
                    if (validBet)
                    {
                        Console.WriteLine("Pick an outcome for the dice \n Doubles (2x), Not doubles (1/2), Even sum (1x), Odd sum (1x).");
                        guess = Console.ReadLine();
                        guess = guess.ToLower();
                        if (guess == "doubles")
                        {
                            if (die1.Roll == die2.Roll)
                            {
                                bet *= 2;
                                account += bet;
                                Console.WriteLine("You win. you have " + account.ToString("C"));
                            }
                            else
                            {
                                account -= bet;
                                Console.WriteLine("You lose. you have " + account.ToString("C"));
                            }
                            die1.DrawRoll();
                            die2.DrawRoll();
                        }
                        else if (guess == "not doubles")
                        {
                            if (die1.Roll != die2.Roll)
                            {
                                bet /= 2;
                                account += bet;
                                Console.WriteLine("You win. you have " + account.ToString("C"));
                            }
                            else
                            {
                                account -= bet;
                                Console.WriteLine("You lose. you have " + account.ToString("C"));
                            }
                            die1.DrawRoll();
                            die2.DrawRoll();
                        }
                        else if (guess == "even sum")
                        {

                            if ((die1.Roll + die2.Roll) %2 == 0)
                            {

                                account += bet;
                                Console.WriteLine("You win. you have " + account.ToString("C"));
                            }
                            else
                            {
                                account -= bet;
                                Console.WriteLine("You lose. you have " + account.ToString("C"));
                            }
                            die1.DrawRoll();
                            die2.DrawRoll();
                        }
                        else if (guess == "odd sum")
                        {
                            if ((die1.Roll + die2.Roll) % 2 != 0)
                            {

                                account += bet;
                                Console.WriteLine("You win. you have " + account.ToString("C"));
                            }
                            else
                            {
                                account -= bet;
                                Console.WriteLine("You lose. you have " + account.ToString("C"));
                            }
                            die1.DrawRoll();
                            die2.DrawRoll();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid bet");
                }
            }
            


        }
    }
}