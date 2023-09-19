//Scrieti un program care sa calculeze maximul a trei numere citite de la
//tastatura. Ex: se citeste 3,15,4 Vom afisa 15

using System;

class Prog
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());

        int secondNumber = int.Parse(Console.ReadLine());

        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(MaximumNumerelor(firstNumber, secondNumber, thirdNumber));


    }
    static int MaximumNumerelor(int firstNumber, int secondNumber, int thirdNumber)
    {
        int max = 0;

        if (firstNumber > max)
        {
            max = firstNumber;
        }
        if (max < secondNumber)
        {
            max = secondNumber;
        }
        if (max < thirdNumber)
        {
            max = thirdNumber;
        }

        return max;
    }

    //}
    //• Ex2 Scrieti un program care va citi de la tastatura un numar intreg pozitiv
    //si va afisa valoarea acestuia in baza 2. Ex: se citeste 42, vom afisa 101010

    //• Ex3 Scrieti un program care determina daca un numar n citit de la tastatura
    //este un patrat perfect.
    //9 = 3 ^ 2 = > 9 e patrat perfect 
    //using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PatratPerfect(number);
        }
        static void PatratPerfect(int number)
        {
            if (number == Math.Sqrt(number) * Math.Sqrt(number))
            {
                Console.WriteLine("ESTE PATRAT PERFECT");
            }
            else
            {
                Console.WriteLine("NU ESTE PATRAT PERFEFCT");

            }
        }
    }
}

//• Ex4 Se citesc numere de la tastatură până la apariția lui zero. Să se
//determine suma lor.
//using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(Sum(number));
    }
    static int Sum(int number)
    {
        int sum = 0;


        while (number != 0)
        {
            sum = sum + number;

            number = int.Parse(Console.ReadLine());

        }

        return sum;

    }
}


//• Ex5 Se citesc numere de la tastatură până când se introduc două numere
//consecutive egale. Să se determine suma tuturor numerelor citite

//using System;

//using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[10];

        Sum(nums);
    }
    static void Sum(int[] nums)
    {
        int sum = 0;

        for (int i = 1; i <= nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());

            if (nums[i] == nums[i - 1])
            {
                break;
            }
            else
            {
                sum = sum + nums[i];
            }
        }

        Console.WriteLine(sum);

    }
}

//Ex6 Scrieti un program care va determina daca un numar n este sau numar
//prim, n fiind citit de la tastatura. Daca este numar prim, va afisa “prim”. In
////caz contrar va afisa numarul cu care este divizibil
//using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        NrPrim(number);
    }
    static bool VerificareNumarPrim(int number)
    {
        for (int i = 2; i < number; i = i + 1)

        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static void NrPrim(int number)
    {
        if (VerificareNumarPrim(number))
        {
            Console.WriteLine("Numarul este prim ");
        }
        else
        {
            Console.WriteLine("Numarul nu este prim ");
        }
    }
}



//• Ex7 Se citesc doua numere de la tastatura. Scrieti un program care va
//calcula cel mai mare divizor comun al numerelor

using System;

class Program
{
    static void Main(string[] args)
    {
        int number1 = int.Parse(Console.ReadLine());

        int number2 = int.Parse(Console.ReadLine());

        Cmmd(number1, number2);
    }
    static void Cmmd(int number1, int number2)
    {

        while (number1 != number2)
        {
            if (number1 > number2)
            {
                number1 = number1 - number2;
            }
            else if (number1 < number2)
            {
                number2 = number2 - number1;
            }

        }

        Console.WriteLine(number1);
    }
}

//• Ex8 Scrie un program care afiseaza numerele de la 1 la N. Daca numarul
//este multiplu de 3, sa se afiseze Fizz, daca este multiplu de 3 sa se afiseze
//Buzz, daca e multiplu si de 3 si de 5 (ex: 15) sa se afiseze FizzBuzz, in restul
//cazurilor sa se afiseze numarul.

//Un număr este considerat multiplu de 3 atunci când poate fi împărțit fără rest la 3.
//using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        Multiplu(number);

    }
    static void Multiplu(int number)
    {
        while (number != 0)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuz");
            }

        }
    }


}

//Ex9 Scrieti un program care citind de la tastatura lungimea si latimea unui
//dreptunghi, va afisa diagonala acestuia.

// daca impartim drept un 2 se form 2 triunghiuri drept si diagonale e practic ipotenuza triunghiurilor=>pitagora 

// ip^2 = catata1 ^2 + cateta2^2;

using System;

class Program
{
    static void Main(string[] args)
    {
        int cateta1 = int.Parse(Console.ReadLine());
        int cateta2 = int.Parse(Console.ReadLine());

        DiagonalaUnuiDrept(cateta1, cateta2);

    }
    static void DiagonalaUnuiDrept(int cateta1, int cateta2)
    {
        double diagonala = Math.Sqrt(Math.Pow(cateta1, 2) + Math.Pow(cateta2, 2));

        Console.WriteLine(diagonala);

    }
}