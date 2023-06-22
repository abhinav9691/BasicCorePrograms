using BasicCorePrograms1;

while (true)
{
    Console.WriteLine("Enter the Choice \n 1)Filp Coin\n2)Leap Year");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            FlipCoin flipcoin = new FlipCoin();
            flipcoin.HeadTails();
            break;
        case 2:
            LeapYear leapYear = new LeapYear();
            leapYear.Year();
            break;
    }
}