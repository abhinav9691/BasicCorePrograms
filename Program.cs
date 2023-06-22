using BasicCorePrograms1;

while (true)
{
    Console.WriteLine("Enter the Choice \n 1)Filp Coin");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            FlipCoin flipcoin = new FlipCoin();
            flipcoin.HeadTails();
            break;
    }
}
