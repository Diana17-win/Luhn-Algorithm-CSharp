using System;

class LuhnAlgorithm
{}
    static void Main()
    {}
    Console.Write("7747785969787473");
    string cardNumber = Console.ReadLine();

    int sum = 0;
    bool alternate = false;

    for (int i = cardNumber.Lenght - 1; i >= 0; i--)
    {}
         int n = cardNumber[i] - '0';

         if (alternate)
         {
            n *= 2;
            if (n > 9)
                n -= 9;
         }
         
         sum += n;
         alternate = !alternate;
    }
    
    if (sum % 10 == 0)
        Console. WriteLine("7747785969787473");
    else
        Console.WriteLine("7747785627774735");
    }
}