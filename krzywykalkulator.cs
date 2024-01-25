using System;
using System.Threading;
using System.Threading.Tasks;


class Program
{
    static void Main() 
    {
        Console.WriteLine(" Ostrzezenie! ze względu na kiepski kod \n najpierw musisz dodać bądz odjąc jakaś liczbe od wartości początkowej czyli zera \n jeśli jesteś gotów kliknij dowolny klawisz \n \n \n \n \n");
        Console.ReadKey();
        

            while (true)

            {


                Console.WriteLine("Krzywy kalkulator");
                double wynik = 0;

                while (true)
                {
                    Console.WriteLine($"Aktualna wartość: {wynik}");
                    Console.Write("wprowadz liczbe (lub wpisz '=' jak chcesz zakonczyc): ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "=")
                    {
                        break;
                    }

                    if (double.TryParse(input, out double liczba))
                    {
                        Console.WriteLine("Wybierz działanie arytmetyczne:");
                        Console.WriteLine("1. Dodawanie");
                        Console.WriteLine("2. Odejmowanie");
                        Console.WriteLine("3. Mnożenie");
                        Console.WriteLine("4. Dzielenie");
                        Console.WriteLine("5. Pierwiastek kwadratowy");
                        Console.WriteLine("6. Potęga");
                        Console.WriteLine("7. Zakończ");

                        string operacja = Console.ReadLine();

                        switch (operacja)
                        {
                            case "1":
                                wynik += liczba;
                                break;
                            case "2":
                                wynik -= liczba;
                                break;
                            case "3":
                                wynik *= liczba;
                                break;
                            case "4":
                                if (liczba != 0)
                                {
                                    wynik /= liczba;
                                }
                                else
                                {
                                    Console.WriteLine("nie mozna dzielic przez 0 .");
                                }
                                break;
                            case "5":
                                if (wynik >= 0)
                                {
                                    wynik = Math.Sqrt(liczba);
                                }
                                else
                                {
                                    Console.WriteLine("nie mozna liczyc pierwiastka z liczby ujemnej ):.");
                                }
                                break;
                            case "6":
                                wynik = Math.Pow(liczba, 2);
                                break;
                            case "7":
                                return;
                            default:
                                Console.WriteLine("cos ty kliknął.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Błąd , prawdopodobnie wpisano złego inputa");
                    }
                }

                Console.WriteLine("Wynik: " + wynik + " chcesz obliczyc ponownie? wcisnij enter! ");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }


