using System.Diagnostics;

namespace BasicProgramming;

class Program
{
    static int Sum(int x)
    {
        int[] myArray = new int[x];
        int sum = 0;
        int index = 1;
        foreach (int i in myArray)
        {
            Console.Write("Input {0}: ", index++);
            myArray[i] = Convert.ToInt32(Console.ReadLine());
            sum += myArray[i];
        }
        return sum;
    }

    static float Div(float x, float y)
    {
        return x / y;
    }

    static int Sub(int x)
    {
        int[] myArray = new int[x];
        int index = 1;
        int result = 0;

        

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("Input {0}: ", index);
            result = Convert.ToInt32(Console.ReadLine());
            myArray[i] = result;

            if (i == 0)
            {
                result = myArray[i];
            }
            else
            {
                result -= myArray[i];
            }
        }
        return result;
    }

    static int Mul(int x) 
    {
        int[] myArray = new int[x];
        int total = 1;
        int index = 1;
        foreach (int i in myArray)
        {
            Console.Write("Input {0}: ", index++);
            myArray[i] = Convert.ToInt32(Console.ReadLine());
            total *= myArray[i];
        }
        return total;  
    }

    static double Celsius_to_Fahrenheit(double x)
    {
        return (x * 9) / 5 + 32;
    }
    static double Fahrenheit_to_Celsius(double x)
    {
        return (x - 32) * 5 / 9;
    }

    static void Title ()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("||         CALCULATOR          ||");
        Console.WriteLine("=================================");
        Console.WriteLine();
    }

    static void MainMenu()
    {
        Console.WriteLine("Main Menu:");

        for(int i = 1; i <= 3; i++)
        {
            if(i == 1)
            {
                Console.WriteLine("1. Calculator Standar");
            }
            else if(i == 2) 
            {
                Console.WriteLine("2. Calculator Temperature");
            }
            else
            {
                Console.WriteLine("3. Exit");
            }
        }

        Console.WriteLine("Pilih Main Menu:");
    }

    static void ConverterMenu()
    {
        Console.WriteLine("Calculator Temperature:");

        for (int i = 1; i <= 3; i++)
        {
            if (i == 1)
            {
                Console.WriteLine("1. Celsius to Fahrenheit");
            }
            else if (i == 2)
            {
                Console.WriteLine("2. Fahrenheit to Celsius");
            }
            else
            {
                Console.WriteLine("3. Back");
            }
        }

        Console.WriteLine("Pilih Menu:");
    }

    static void Calculator_Standar(string jenis)
    {
        Console.WriteLine("=====================");
        Console.WriteLine(jenis);
        
        
    }

    static void Cal_Input()
    {
        Console.Write("Nomor 1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nomor 2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

    }

    static void CalculatorMenu()
    {
        int[] menu = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Menu:");


        foreach (int i in menu)
        {
            if (i == 1)
            {
                Console.WriteLine("1. Penjumlahan");
            }
            else if (i == 2)
            {
                Console.WriteLine("2. Pengurangan");
            }
            else if (i == 3)
            {
                Console.WriteLine("3. Perkalian");
            }
            else if (i == 4)
            {
                Console.WriteLine("4. Pembagian");
            }
            else if (i == 5)
            {
                Console.WriteLine("5. Back");
            }

            
            
        }
        Console.Write("Pilih Menu:");
    }
    static void Main(string[] args)
    {
        bool bktop = true;
        while (bktop)
        {
            Title(); // Memanggil Title Function / Method
            MainMenu();
            //CalculatorMenu(); //Memanggil Menu Function / Method

            int opt_main = Convert.ToInt32(Console.ReadLine());
            
            if (opt_main == 1)
            {
                bool cal_std_menu = true;
                while(cal_std_menu)
                {
                    Console.Clear();
                    bktop = false;

                    Title();
                    CalculatorMenu();

                    int cal_std = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (cal_std)
                    {
                        case 1:
                            bool cs1 = true;
                            while (cs1)
                            {
                                Title();

                                Console.WriteLine("=====================");
                                Console.WriteLine("Penjumlahan");

                                Console.WriteLine("Berapa proses?");
                                int proses = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Hasil :" + Sum(proses));

                                Console.WriteLine("continue? enter Y/N");
                                string opt = Console.ReadLine();
                                if (opt.ToUpper() == "N")
                                {
                                    cs1 = false;
                                    cal_std_menu = true;
                                }
                                else if (opt.ToUpper() == "Y")
                                {
                                    cs1 = true;
                                }
                                Console.Clear();
                            }
                            break;
                        case 2:
                            bool cs2 = true;
                            while (cs2)
                            {
                                Title();
                                Console.WriteLine("=====================");
                                Console.WriteLine("Pengurangan");

                                Console.WriteLine("Berapa proses?");
                                int proses = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Hasil :" + Sub(proses));

                                Console.WriteLine("continue? enter Y/N");
                                string opt = Console.ReadLine();
                                if (opt.ToUpper() == "N")
                                {
                                    cs2 = false;
                                    cal_std_menu = true;
                                }
                                else if (opt.ToUpper() == "Y")
                                {
                                    cs2 = true;
                                }
                                Console.Clear();
                            }
                            break;
                        case 3:
                            bool cs3 = true;
                            while (cs3)
                            {
                                Title();
                                Console.WriteLine("=====================");
                                Console.WriteLine("Perkalian");

                                Console.WriteLine("Berapa proses?");
                                int proses = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Hasil :" + Mul(proses));

                                Console.WriteLine("continue? enter Y/N");
                                string opt = Console.ReadLine();
                                if (opt.ToUpper() == "N")
                                {
                                    cs3 = false;
                                    cal_std_menu = true;
                                }
                                else if (opt.ToUpper() == "Y")
                                {
                                    cs3 = true;
                                }
                                Console.Clear();
                            }
                            break;
                        case 4:
                            bool cs4 = true;
                            while (cs4)
                            {
                                Title();
                                Console.WriteLine("=====================");
                                Console.WriteLine("Pebagian");
                                Console.Write("Nomor 1: ");
                                int number1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Nomor 2: ");
                                int number2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Hasil : " + Div(number1, number2));


                                Console.WriteLine("continue? enter Y/N");
                                string opt = Console.ReadLine();
                                if (opt.ToUpper() == "N")
                                {
                                    cs4 = false;
                                    cal_std_menu = true;
                                }
                                else if (opt.ToUpper() == "Y")
                                {
                                    cs4 = true;
                                }
                                Console.Clear();
                            }
                            break;
                        case 5:
                            cal_std_menu = false;
                            bktop = true;
                            Console.Clear();
                            break;
                    }
                }

                
            }
            
            else if (opt_main == 2)
            {
                bool cal_temp_menu = true;
                Console.Clear();
                while (cal_temp_menu)
                {
                    Title();
                    ConverterMenu();

                    bktop= false;

                    int cal_temp = Convert.ToInt32(Console.ReadLine());
                    

                    switch (cal_temp)
                    {
                        case 1:
                            bool temp1 = true;
                            while (temp1)
                            {
                                Console.Clear();
                                Console.WriteLine("=====================");
                                Console.WriteLine("Celsius to Fahrenheit");
                                Console.Write("Degree: ");
                                int deg1 = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Hasil : " + Celsius_to_Fahrenheit(deg1));

                                Console.WriteLine("continue? enter Y/N");
                                string opt = Console.ReadLine();
                                if (opt.ToUpper() == "N")
                                {
                                    temp1 = false;
                                    cal_temp_menu = true;
                                }
                                else if (opt.ToUpper() == "Y")
                                {
                                    temp1 = true;
                                }
                                Console.Clear();
                            }
                            break;
                        case 2:
                            bool temp2 = true;
                            while (temp2)
                            {
                                Console.Clear();
                                Console.WriteLine("=====================");
                                Console.WriteLine("Fahrenheit to Celsius");
                                Console.Write("Degree: ");
                                int deg1 = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Hasil : " + Fahrenheit_to_Celsius(deg1));

                                Console.WriteLine("continue? enter Y/N");
                                string opt = Console.ReadLine();
                                if (opt.ToUpper() == "N")
                                {
                                    temp2 = false;
                                    cal_temp_menu = true;
                                }
                                else if (opt.ToUpper() == "Y")
                                {
                                    temp2 = true;
                                }
                                Console.Clear();
                            }
                            break;
                        case 3:
                            cal_temp_menu = false;
                            bktop = true;
                            Console.Clear();
                            break;
                    }

                }
                    
            }
            else if (opt_main == 3)
            {
                Environment.Exit(0);
                Console.Clear();
            }
            
            
        }
    }
}