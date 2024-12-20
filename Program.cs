namespace Practice_6;

class Program
{
    static void Main(string[] args)
    {
        int a = 4;
        int b = 33;
        double c = 21;
        string st = "qwertyui";
        string str = "qqqqweeererterqrtrwertwrrqerqrtqrqrqrt";
        char h = 't';

        //  Простые Задачи на Функции в C#
        Console.WriteLine($"Задание 1: {Sum(a, b)}");
        Console.WriteLine("Задание 2: Введите своё имя :");
        string name = Console.ReadLine();
        Console.WriteLine(Hello_name(name));
        Console.WriteLine($"Задание 3: {Who_big(a, b)}");
        Console.WriteLine($"Задание 4: {Even_numbers(a)}");
        Console.WriteLine($"Задание 5: {Celsius_to_Fahrenheit(c)}");
        Console.WriteLine($"Задание 6: {Flipping_line(st)}");
        Console.WriteLine($"Задание 7: {Counting_characters(str, h)}");
        Console.WriteLine($"Задание 8: {Factorial(a)}"); 
        Console.WriteLine($"Задание 9: {Prime_number(b)}");    
        Console.WriteLine($"Задание 10: {Generate(a, b)}");  
    }

    // Простые Задачи на Функции в C#
    static int Sum(int a, int b)
    {
        return a+b;
    }
    static string Hello_name(string name){
        string STR = "Привет, " + name + "!";
        return STR;
    }
    static string Who_big(int a, int b)
    {
        string st = "Числа одинаковые";
        string a_ = a.ToString();
        string b_ = b.ToString();
        if (a > b)
        {
            return "Число: "+a_+" > "+b_;
        }
        else if (a == b)
        {
            return st;
        }
        else 
        {
            return "Число: "+b_+" > "+a_;
        }
    }

    static bool Even_numbers(int a)
    {
        if (a % 2 == 0){
            return true;
        }
        else{
            return false;
        }
    }

    static double Celsius_to_Fahrenheit(double a)
    {
        double k = 1.8;
        return (a*k)+32;
    }

    static string Flipping_line(string st)
    {
        char[] res = st.ToCharArray();
        Array.Reverse(res);
        string res_s = new string(res);
        return  res_s;
    }

    static int Counting_characters(string s, char h)
    {
        char [] ch_massiv = s.ToCharArray();
        int count = 0;
        foreach (char ch in ch_massiv)
        {
            if (ch == h){
                count++;
            }
        }
        return count;
    }

    static int Factorial(int a)
    {
        int res = 1;
        for (int i = 1; i <= a; i++)
        {
            res = res * i;
        }
        return res;
    }

    static bool Prime_number(int num)
    {
        if(num == 2){
            return true;
        }
        else
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false; 
                }
            }
            return true; 
        }
    }
    static int Generate(int a, int b)
    {
        Random r = new Random();
        int number = r.Next(a, b);
        return number;
    }

}
