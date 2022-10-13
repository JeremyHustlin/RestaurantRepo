using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public enum Dish
    {
        _Menu,
        _Ingredient,
        _Comanda

    }
    public class Menu
    {
        public string Name { get; set; }
        static void Main(string[] args)
        {

            var cook = new Cook();
            var menu = new Menu();
            var ingredient = new Ingredient();
            var dish = new Dishes();



            int nr_ordine;
            Console.WriteLine(Command(Dish._Menu));

             int Command(Dish choice)
            {
                switch (choice)
                {
                    case Dish._Menu:
                        Console.WriteLine("Menu");
                        var cheese = dish.Cheese;
                        var capricioasa = dish.Capricioasa;
                        var rancho = dish.Rancho;
                        var margarita = dish.Margarita;
                        var pret_margarita = dish.Margarita_Price;
                        var pret_capricioasa = dish.Capricioasa_Price;
                        var pret_rancho = dish.Rancho_Price;
                        var pret_cheese = dish.Cheese_Price;
                        var first_cook = cook.First_Cook;
                        var second_cook = cook.Second_Cook;


                        Console.WriteLine("\nAlege pizza:");

                        Console.WriteLine($"\n1.{cheese}==={pret_cheese}");
                        Console.WriteLine($"\n2.{capricioasa}==={pret_capricioasa}");
                        Console.WriteLine($"\n3.{rancho}==={pret_rancho}");
                        Console.WriteLine($"\n4.{margarita}==={pret_margarita}");
                        Console.WriteLine($"\nTap number 1-4");

                        nr_ordine = int.Parse(Console.ReadLine());
                        if (nr_ordine == 1)
                        {
                            Console.WriteLine($"\nAti selectat pizza==={cheese}");
                            Console.WriteLine("\nDoriti ingrediente adugatoare?");
                            Console.WriteLine("Tastati 1 daca Da si 0 daca Nu");

                            int a = int.Parse(Console.ReadLine());

                            if (a == 1)
                            {
                                goto case Dish._Ingredient;
                            }
                            else if (a == 0)
                            {
                                Console.WriteLine($"\n1.Bucatar:{second_cook} casa 2");

                                goto case Dish._Comanda;
                            }
                        }
                        else if (nr_ordine == 2)
                        {
                            Console.WriteLine($"\nAti selectat pizza==={capricioasa}");
                            Console.WriteLine("\nDoriti ingrediente adugatoare?");
                            Console.WriteLine("Tastati 1 daca Da si 0 daca Nu");

                            int a = int.Parse(Console.ReadLine());

                            if (a == 1)
                            {
                                goto case Dish._Ingredient;
                            }
                            else if (a == 0)
                            {
                                Console.WriteLine($"\n1.Bucatar:{first_cook} casa 1");
                                goto case Dish._Comanda;
                            }
                        }
                        else if (nr_ordine == 3)
                        {
                            Console.WriteLine($"\nAti selectat pizza==={rancho}");
                            Console.WriteLine("\nDoriti ingrediente adugatoare?");
                            Console.WriteLine("Tastati 1 daca Da si 0 daca Nu");

                            int a = int.Parse(Console.ReadLine());

                            if (a == 1)
                            {
                                goto case Dish._Ingredient;
                            }
                            else if (a == 0)
                            {
                                Console.WriteLine($"\n1.Bucatar:{first_cook} casa 1");

                                goto case Dish._Comanda;
                            }
                        }
                        else if (nr_ordine == 4)
                        {
                            Console.WriteLine($"\nAti selectat pizza==={margarita}");
                            Console.WriteLine("\nDoriti ingrediente adugatoare?");
                            Console.WriteLine("Tastati 1 daca Da si 0 daca Nu");

                            int a = int.Parse(Console.ReadLine());

                            if (a == 1)
                            {
                                goto case Dish._Ingredient;
                            }
                            else if (a == 0)
                            {
                                Console.WriteLine($"\n1.Bucatar:{second_cook} casa 2");

                                goto case Dish._Comanda;
                            }
                        }

                        else if (nr_ordine > 4) 
                                {
                            Console.WriteLine("Mai incercati");
                            goto case Dish._Menu;

                                }
                        break;


                    case Dish._Ingredient:
                        {

                            Console.WriteLine("Ingrediente");
                            var cascaval = ingredient.Cascaval;
                            var masline = ingredient.Masline;
                            var carne = ingredient.Carne;
                            var pret_cascaval = ingredient.Price_Cascaval;
                            var pret_masline = ingredient.Price_Masline;
                            var pret_carne = ingredient.Price_Carne;
                            var first_cok = cook.First_Cook;
                            var second_cok = cook.Second_Cook;
                            Console.WriteLine($"\n1.{cascaval}==={pret_cascaval}");
                            Console.WriteLine($"\n2.{masline}==={pret_masline}");
                            Console.WriteLine($"\n3.{carne}==={pret_carne}");

                            nr_ordine = int.Parse(Console.ReadLine());
                            if (nr_ordine > 3)
                            {
                                Console.WriteLine("Mai incercati");
                                goto case Dish._Ingredient;
                            }
                            else if (nr_ordine == 1)
                            {
                                Console.WriteLine("\nAti ales cascaval");

                                Console.WriteLine($"\n1.Bucatar:{second_cok} casa 2");

                            }
                            else if (nr_ordine == 2)
                            {
                                Console.WriteLine("\nAti ales masline");
                                Console.WriteLine($"\n1.Bucatar:{second_cok} casa 2");

                            }
                            else if (nr_ordine == 3)
                            {
                                Console.WriteLine("\nAti ales carne");
                                Console.WriteLine($"\n1.Bucatar:{first_cok} casa 1");

                            }
                            Console.WriteLine("\nTastati 0 pentru a accepta comanda");
                            nr_ordine = int.Parse(Console.ReadLine());

                            if ( nr_ordine == 0)
                            {
                                goto case Dish._Comanda;
                            }

                        }
                        break;

                    case Dish._Comanda:
                        {
                            Console.WriteLine("Coamanda a fost acceptata cu succes\nLuati Bonul");
                            

                        }
                
                        break;

                }
                return (int) Dish._Menu;

            }
           
        }
    }
}
