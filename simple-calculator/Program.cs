namespace simple_calculator;

class Program
{
    static float result;

    static void Main(string[] args)
    {
        System.Console.WriteLine("=====SIMPLE-CALCULATOR=====");
        System.Console.Write("Podaj pierwsza liczbe: ");

        float firstNumber = int.Parse(Console.ReadLine());

        System.Console.Write("Podaj druga liczbe: ");

        float secondNumber = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Co chcesz zrobic?");
        System.Console.WriteLine("[1] Dodawanie");
        System.Console.WriteLine("[2] Odejmowanie");
        System.Console.WriteLine("[3] Mnożenie");
        System.Console.WriteLine("[4] Dzielenie");
        Console.Write("Wybor: ");
        int operatorChoice = int.Parse(Console.ReadLine());

        if(operatorChoice == 1)
        {
            result = firstNumber + secondNumber;
        }
        else if(operatorChoice == 2)
        {
            result = firstNumber - secondNumber;
        }
        else if(operatorChoice == 3)
        {
            result = firstNumber * secondNumber;
        }
        else if(operatorChoice == 4)
        {
            result = firstNumber / secondNumber;
        }
        
        System.Console.WriteLine("Wynik to: " + result);


    }
}
