 using System;


class Program
{

    static void Main(string[] args)
    }

    static void IndianRupee()
    {
        string value = Console.ReadLine();
        int length = value.Length;

        if (length == 4)
        {
            Console.WriteLine(value[0] + "Thousand" + " " + value[1] + value[2] + value[3]);
        }
        else if (length == 5)
        {
            Console.WriteLine(value[0] + "" + value[1] + "" + "Thousand" + " " + value[2] + value[3] + value[4]);
        }
        else if (length == 6)
        {
            Console.WriteLine(value[0] + "" + value[1] + "" + value[2] + "Thousand" + " " + value[3] + value[4] + value[5]);
        }
    }
    static void PolarCoordinatesFAlse()
    {
        Console.WriteLine("Polar coordinates! ");
        Console.WriteLine("Write 2 axis (x & y) :");

        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double r = Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)), 4);

        double sinTheta = y / r;




        Console.Clear();

        Console.WriteLine(sinTheta );
        

    }
    static void SortingOfThree()
    {
        Console.WriteLine("Write 3 numbers: ");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int[] array = { a, b, c };
        Array.Sort(array);

        Console.WriteLine(array[0] + " " + array[1] + " " + array[2]);

    }
    static void Reverse() {
        string s = Console.ReadLine();
        string[] arr = s.Split(" ");

        Array.Reverse(arr);

        for (int i = 0; i != arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    static void NumCount()
    {

        Console.WriteLine("Enter the number:");

        string number = Console.ReadLine();

        Console.WriteLine("Enter the number to search:");

        char searchnumber = char.Parse(Console.ReadLine());
        int sum = 0;


        for (int i = 0; i != number.Length; i++)
        {
            if (searchnumber == number[i])
            {
                sum++;
            }
        }


        Console.WriteLine("Number of occurence of given number is:");
        Console.WriteLine(sum);
    }

}
