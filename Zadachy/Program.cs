using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        
    }

    //1.6
    private static void Zadacha1()
    {
        Console.WriteLine("7 15 100");
    }

    //1.43
    private static void Zadacha2()
    {
        int a1 = 2, a2 = 3;
        Console.WriteLine($"Ariphmetic:{(a1 + a2) / 2} Geometric: {Math.Sqrt(a1 * a2)}");
    }

    //1.26
    private void Zadacha3()
    {
        int r = 3;
        Console.WriteLine(r * 2);
    }

    //1.60
    private static void Zadacha4()
    {
        int a160 = 1, b160 = 2, c160 = 3, tmp;
        //a
        tmp = a160;
        a160 = b160;
        b160 = c160;
        c160 = tmp;
        Console.WriteLine($"{a160} {b160} {c160}");
        //b
        a160 = 1; b160 = 2; c160 = 3;

        tmp = b160;
        b160 = a160;
        a160 = c160;
        c160 = tmp;
        Console.WriteLine($"{a160} {b160} {c160}");
    }

    //2.6
    private static void Zadacha5()
    {
        //a
        int hour = 5;
        Console.WriteLine(24 / hour);

        //b
        var n = 5000;
        var ts = new TimeSpan(0, 0, 0, n, 0);
        Console.WriteLine(ts.Minutes);

        //c
        n = 245;
        var result = n % 3600 / 60;
        Console.WriteLine(result);
    }

    //2.15
    private static void Zadacha6()
    {
        int inp = 322, a, outp;
        a = inp / 100;
        outp = (inp % 100) * 10 + a;
        Console.WriteLine(outp);
    }

    //2.29
    private static void Zadacha7()
    {
        int n = 404;
        int x = n % 10 + n % 100 * 10 + n % 100 % 10 * 100;
        Console.WriteLine(x);
    }

    //2.35
    private static void Zadacha8()
    {
        int h = 1, m = 60;
        Console.WriteLine((h % 24) * 30 + m / 60 + h / 3600);
    }

    //3.6
    private static void Zadacha9()
    {
        bool x = false, y = false, z = true;
        Console.WriteLine((x || y) && !z);
        Console.WriteLine(!x && !y);
        Console.WriteLine(!(x && z) || y);
        Console.WriteLine(x && !y || z);
        Console.WriteLine(x && !(y || z));
        Console.WriteLine(x || (!(y || z)));
    }

    //4.6
    private static void Zadacha10()
    {
        int a = 1, b = -2;
        if (a > b)
            Console.WriteLine(a);
        else
            Console.WriteLine(b);
    }

    //4.26
    private static void Zadacha11()
    {
        int b = 33;
        int a = int.Parse(Console.ReadLine());
        if (b % 3 == 0)
            Console.WriteLine("Кратна");
        if (b % a == 0)
            Console.WriteLine("Кратна");
    }

    //4.42
    private static void Zadacha12()
    {
        float a = 22.4f, b = 1.32f, c = 3.14f;
        if (a < b && b < c)
            Console.WriteLine("a < b && b < c выполняется");
        a = 1.4f; b = 28.14f; c = 3.32f;
        if (b > a && b > c)
            Console.WriteLine("b > a && b > c выполняется");
    }

    //4.59
    private static void Zadacha13()
    {
        bool flag = false;
        string s = Console.ReadLine();
        char a = char.Parse(Console.ReadLine());
        for (int i = 0; i < s.Length; i++)
            if (s[i] == a) flag = true;
        Console.WriteLine((flag) ? "Входит" : "Не входит");
    }

    //4.75
    private static void Zadacha14()
    {
        float p, q;
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if (x > 0 && y > 0) { }
        else if (x < 0 && y > 0)
            x *= -1;
        else if (x > 0 && y < 0)
            y *= -1;
        else if (x < 0 && y < 0)
        {
            x *= -1;
            y *= -1;
        }

        Console.WriteLine($"Полусумма: {(x + y) / 2}");
        Console.WriteLine($"Квадратный корень: {Math.Sqrt(x * y)}");

    }

    //4.109
    private static void Zadacha15()
    {
        int card = 0;
        while (card < 5 || 14 < card)
            card = int.Parse(Console.ReadLine());

        switch (card)
        {
            case 6:
                Console.WriteLine("Шестерка");
                break;
            case 7:
                Console.WriteLine("Семерка");
                break;
            case 8:
                Console.WriteLine("Восьмерка");
                break;
            case 9:
                Console.WriteLine("Девятка");
                break;
            case 10:
                Console.WriteLine("Десятка");
                break;
            case 11:
                Console.WriteLine("Валет");
                break;
            case 12:
                Console.WriteLine("Дама");
                break;
            case 13:
                Console.WriteLine("Король");
                break;
            case 14:
                Console.WriteLine("Туз");
                break;
        }
    }

    //4.121
    private static void Zadacha16()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        if ((a % 2 == 0 && b % 2 == 0) && (c % 2 == 0 && d % 2 == 0))
            Console.WriteLine("Поля темного  цвета");
        else if ((a % 2 != 0 && b % 2 != 0) && (c % 2 != 0 && d % 2 != 0))
            Console.WriteLine("Поля светлого цвета");
        else
            Console.WriteLine("Поля разных цветов");
    }

    //5.6
    private static void Zadacha17()
    {
        float a = 20, b = 19.4f, c = 15.8f;

        //a
        Console.WriteLine("A");
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine($"{a += 1} {b += 1}");
        }

        //b
        Console.WriteLine("B");
        a = 15; b = 14.5f;
        for (int i = 0; i < 9; i++)
        {
            Console.WriteLine($"{a += 1} {b += 1} {c += 1}");
        }
    }

    //5.32
    private static void Zadacha18()
    {
        int n = int.Parse(Console.ReadLine());
        double tmp = 1;

        for (int i = 1; i <= n; i++)
            tmp += 1.0 / i;
        Console.WriteLine(tmp);
    }

    //5.44
    private static void Zadacha19()
    {
        int res = 0;
        int[] a = new int[5];
        for (int i = 0; i < a.Length; i++)
            a[i] = int.Parse(Console.ReadLine());
        foreach (int item in a)
            res += item;
        Console.WriteLine(res);
    }

    //5.71
    private static void Zadacha20()
    {
        int cash = 1000;

        //a
        for (int i = 0; i < 10; i++)
        {
            int precentOfMounth = (cash / 100) * 2;
            cash += precentOfMounth;
            Console.WriteLine(precentOfMounth);
        }
        Console.WriteLine("----");
        //b
        for (int i = 0; i < 12; i++)
        {
            int precentOfMounth = (cash / 100) * 2;
            cash += precentOfMounth;
            Console.WriteLine(cash);
        }
    }

    //5.89
    private static int Zadacha21(int n)
    {
        int s = 0, f = 1;
        for (int i = 1; i <= n; i++)
        {
            s += f *= i;
        }
        return s;
    }

    //6.26
    private static void Zadacha22()
    {
        Console.Write("Число = ");
        //a
        Console.WriteLine("Ответ = {0}", Console.ReadLine().ToArray().Min() - '0');

        //b
        Console.WriteLine("Ответ = {0}", Console.ReadLine().ToArray().Max() - '0');
    }


    //6.51
    private static void Zadacha23()
    {
        string k = Console.ReadLine();
        int length = k.Length;
        int l = 4;
        int sov = 0;

        for (int i = 0; sov < l; i++)
        {
            if (k[i] == k[length - 1])
            {
                sov += 2;
                length--;
            }
        }

        if (sov == l) Console.WriteLine("Палиндром");
        else Console.WriteLine("Не является палиндромом");
    }

    //6.68
    private static void Zadacha24()
    {
        int[] arr = { 2, 4, 345, 43, 2, 454, 5, 2, 032, 5, 753, 8, 9, 57, 456, 34, 136, 536, 6, 9999 };

        int count = 0, lastIndexEvenElement = 0;

        int index = 0;

        do
        {
            if (arr[index] % 2 == 0 && arr[index + 1] % 2 == 0)
            {
                count++;

                lastIndexEvenElement = index;
            }
            index++;
        }
        while (index < arr.Length);

        if (count > 0)
            Console.WriteLine($" {arr[lastIndexEvenElement]} и {arr[lastIndexEvenElement + 1]} номера: {lastIndexEvenElement} и {lastIndexEvenElement + 1}");
        else
            Console.WriteLine("Нет пары соседних четных чисел");
    }

    //6.86
    private static void Zadacha25(int c)
    {
        int a = 2, b = 5;


        if (c % 10 == a)
        {
            Console.WriteLine(b);
            return;
        }

        if (c % 10 == a)
        {
            Console.WriteLine(a);
            return;
        }

        Zadacha25(c / 10);
    }

    //6.103
    private static void Zadacha26()
    {
        Console.WriteLine("Введите числитель дроби:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите знаминатель дроби:");
        int b = int.Parse(Console.ReadLine());

        int p = a;
        int q = b;

        for (int i = 2; a == p; i++)
        {
            if (a % i == 0 && b % i == 0)
            {
                p = a / i;
                q = b / i;
            }
        }
        Console.WriteLine(p);

        Console.WriteLine("--");

        Console.WriteLine(q);
    }

    //7.6 = 266
    private static void Zadacha27()
    {
        int[] a = { 2557, 5322, 3434, 3040 };

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 133 == 125)
            {
                Console.WriteLine($"{a[i]} / 133 %= 125");
            }
            if (a[i] % 134 == 111)
            {
                Console.WriteLine($"{a[i]} / 134 %= 111");
            }
        }
    }

    //7.23
    private static void Zadacha28()
    {
        int[] arr = new int[31];
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Введите количество осадков в {i + 1} день:");
            arr[i] = int.Parse(Console.ReadLine());
        }

        foreach (var el in arr)
            sum += el;

        Console.WriteLine($"Среднее количество осадков в месяц: {sum / arr.Length}");
    }

    //7.57
    private static void Zadacha29()
    {
        Random random = new Random();

        int[] speeds = Enumerable.Repeat(random, 20).Select(x => x.Next(2, 20)).ToArray();
        foreach (int speed in speeds)
            Console.Write($"{speed} ");
        Console.WriteLine();
        Console.WriteLine(speeds.Max());
    }

    //7.74
    private static void Zadacha30()
    {
        int counterMax = 0;
        int counterMin = 0;
        Random random = new Random();
        int[] speeds = Enumerable.Repeat(random, 20).Select(x => x.Next(2, 20)).ToArray();

        for (int i = 0; i < speeds.Length; i++)
        {
            //a
            if (speeds.Max() == speeds[i])
                counterMax++;

            //b
            if (speeds.Min() == speeds[i])
                counterMin++;

        }
        Console.WriteLine(counterMax);
        Console.WriteLine(counterMin);
    }

    //7.91
    private static void Zadacha31()
    {
        int car = 30;
        int value = 0;

        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            value += random.Next(1, 10); ;
        }
        if (car >= value)
            Console.WriteLine("Масса груза не превышена");
        else
            Console.WriteLine("Масса груза превышена");

    }

    //7.101
    private static void Zadacha32()
    {
        Random random = new Random();
        ValueTuple<int, int> value = new(0, 0);
        int[] precipitation = Enumerable.Repeat(random, 28).Select(x => x.Next(0, 20)).ToArray();

        for (int i = 0; i < precipitation.Length; i++)
        {
            if (i % 2 == 0)
                value.Item1 += precipitation[i];
            else
                value.Item2 += precipitation[i];
        }
        if (value.Item1 > value.Item2)
            Console.WriteLine("По четным дням осадков больше");
        else if (value.Item2 > value.Item1)
            Console.WriteLine("По нечетным дням осадков больше");
        else
            Console.WriteLine("Осадков поровну");
    }

    //8.6
    private static void Zadacha33()
    {
        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                Console.Write($"{i} + {j} = {i + j}\t");
            }
            Console.WriteLine();
        }
    }

    //8.30
    private static void Zadacha34()
    {
        int max = 0, min = int.MaxValue, otvMax = 0, otvMin = 0;
        Console.WriteLine("Введите а");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите b");
        int b = Convert.ToInt32(Console.ReadLine());
        for (int i = a; i <= b; i++)
        {
            int kol = 1, max_col = 0;
            for (int del = 2; del <= i; del++)
            {
                if (i % del == 0) kol++;
            }
            if (i == a) max = kol;

            if (max <= kol)
            {
                max = kol;
                otvMax = i;
            }
            if (min > kol)
            {
                min = kol;
                otvMin = i;
            }
        }
        Console.WriteLine($"max {max}, min {min}, ResultMax {otvMax} ResultMin {otvMin}");
    }

    //8.47
    private static void Zadacha35()
    {
        int vv, count = 0;
        int[] g = new int[] { 100, 200, 300, 500, 1000, 1200, 1400, 1500, 2000, 3000 };
        int v = int.Parse(Console.ReadLine());
        vv = v;
        for (int j = 9; j >= 0; j--)
        {
            vv = v;
            if (g[j] > vv)
                continue;
            vv -= g[j];
            if (vv == 0)
            {
                count++;
                continue;
            }
            for (int i = j - 1; i >= 0; i--)
            {
                if (g[i] > vv)
                    continue;
                vv -= g[i];
                if (vv == 0)
                {
                    count++;
                    if (g[i] > 200)
                        vv = g[i];
                }
                for (int k = i - 1; k >= 0; k--)
                {
                    if (g[k] > vv)
                        continue;
                    vv -= g[k];

                    if (vv == 0)
                    {
                        count++;
                        if (g[i] > 200)
                            vv = g[k];
                    }
                }
            }
        }
        Console.WriteLine(count);
    }

    //9.6
    private static void Zadacha36()
    {
        string s1 = "Russia";
        string s2 = "USA";

        string t1 = s2;
        string t2 = s1;
    }

    //9.18
    private static void Zadacha37()
    {
        string str1 = "Abcd";
        string str2 = "dcbA";
        if (str1[0] == str2[str2.Length-1])
        {
            Console.WriteLine("Верно");
        }
    }

    //9.46
    private static void Zadacha38()
    {
        for (int i = 0; i < 8; i++)
        {
            Console.Write("_");
        }
    }

    //9.53
    private static void Zadacha39()
    {
        string str = "Hello my friends. I'm Fine";

        for (int i = 0; i < str.Length; i++)
        {
            if (i % 3 ==0)
            {
                Console.WriteLine(str[i]);
            }
        }
    }

    //9.80
    private static void Zadacha40()
    {
        string str = "ssssfffdslkxcc";
        int counter = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == str[0])
                counter++;
            else if(str[i + 1] != str[0])
                break;
        }
        Console.WriteLine(counter);
    }

    //9.96
    private static void Zadacha41()
    {
        string str = "прочитал промотал перемотал прогрохал";

        str.Replace("про", "нет");
        Console.WriteLine(str);
    }

    //9.103
    private static void Zadacha42()
    {
        string str = "утро";
        char[] m = str.ToCharArray();

        for (int i = 0; i < m.Length - 1; i += 2)
        {

            char tmp1 = m[i];
            char tmp2 = m[i + 1];

            m[i] = tmp2;
            m[i + 1] = tmp1;

        }

        foreach (var item in m)
        {
            Console.Write(item);
        }
    }


    //9.120
    private static void Zadacha43()
    {
        string str = "Script_";
        char[] m = str.ToCharArray();

        for (int i = 0; i < m.Length; i++)
        {
            if (m[i] == '_')
                m[i] = 'm';
        }
        foreach (var item in m)
            Console.Write(item);
    }


    //9.143
    private static void Zadacha44()
    {
        string pattern = "[0-9]";
        Console.WriteLine("");
        string str = Console.ReadLine();
        if (Regex.IsMatch(str, pattern))
            Console.WriteLine($"Текст {str} является правильной записью целого числа");
        else
            Console.WriteLine($"Текст {str} неявляется правильной записью целого числа");
    }


    //9.157
    private static void Zadacha45()
    {
        string str1 = "процессор";
        string str2 = "информация";
        string result = string.Empty;

        for (int i = 0; i <= str1.Length - 2; i++)
        {
            for (int j = i + 1; j <= str1.Length - 1; j++)
            {
                if (str1[i] == str1[j])
                    str1 = str1.Remove(j, 1);
            }
        }

        for (int i = 0; i < str1.Length; i++)
        {
            if (str2.Contains(str1[i]))
                result += "да ";
            else
                result += "нет ";
        }
        Console.WriteLine(result);
    }

    //10.6 MAIN = Console.WriteLine(Zadacha46(Zadacha46(20, 15), 25));
    private static double Zadacha46(double a, double b) => Math.Sqrt(a * a + b * b);


    //10.38 MAIN = Console.WriteLine(Zadacha47(47,20));
    private static ValueTuple<double, double> Zadacha47(double a, double b)
    {
        double tmp = a;
        a = b;
        b = tmp;
        return new ValueTuple<double, double>(a, b);
    }
}
