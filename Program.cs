using System;
using System.Collections.Generic;
using System.Linq;

namespace ViveroPrueba2
{
    class App
    {
        private static object plants;

        static void Main(string[] args)
        {
            Random r = new Random();
            List<Plant> plants = new List<Plant>();
            List<Vivero> viveros = new List<Vivero>();
            Plant selectedPlant = null;
            Vivero selectedVivero = null;
            int key;
            int iterator = 30;
            int rut = 0;
            bool app = true;
            bool login = false;
            String mAL = "";

            System.Threading.Thread.Sleep(1250);
            for (int i = 0; i < iterator; i++)
            {
                var plant = Plant.DataPlant(i);
                plants.Add(plant);
                if (i < Vivero.regiones.Length)
                {
                    var vivero = Vivero.DataVivero(i);
                    viveros.Add(vivero);
                }
                Console.Clear();
                int z = i * 3;
                Console.Write(z + "%");
                System.Threading.Thread.Sleep(10);
            }
            while (app)
            {
                Console.Clear();
                Console.WriteLine("--DiegoEekhout--");
                Console.Clear();
                Console.WriteLine("---MENU---");
                Console.WriteLine("1-Seleccionar Plata");
                Console.WriteLine("2-Seleccionar Vivero");
                Console.WriteLine("3-Salir");
                if (login)
                {
                    Console.WriteLine("4-Logout");
                    Console.WriteLine("-- ID:"+mAL+"---");
                }
                else
                {
                    Console.WriteLine("No-Usar");
                    Console.WriteLine("-----------");
                }
                try
                {
                    if(login == false)
                    {
                        Console.Clear(); Console.WriteLine("--Identificacion de usuario--");
                        Console.WriteLine("-- Ingrese Rut --");
                        rut = Optimize.ValInt();
                        Console.WriteLine("-- Ingrese Nombre --");
                        mAL = Optimize.ValString();
                        login = true;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Seleccione una opcion:");
                        key = Optimize.ValInt();
                        switch (key)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("--Plantas Disponibles--");
                                Console.WriteLine("--Visualizacion por Precio--");
                                Console.WriteLine("1-Descendiente | 2-Ascendiente | 3-Desde | 4-Lista completa");
                                key = Int32.Parse(Console.ReadLine());
                                try
                                {
                                    Plant LINQ = new Plant();
                                    switch (key)
                                    {
                                        case 1:
                                            LINQ.LinqDescending();
                                            break;
                                        case 2:
                                            LINQ.LinqAscending();
                                            break;
                                        case 3:
                                            LINQ.LinqAmmount();
                                            break;
                                        case 4:
                                            LINQ.ListView();
                                            break;
                                        default:
                                            return;
                                    }
                                }
                                catch (InvalidCastException e)
                                {
                                    Console.WriteLine(e);
                                }
                                Console.WriteLine("--Escriba el Id de la PLanta que quieres comprar--");
                                key = Optimize.ValInt();
                                Console.WriteLine("--Planta agregada--");
                                Console.WriteLine(plants[key].ToString());
                                selectedPlant = plants[key];
                                Console.ReadLine();
                                break;

                            case 2:
                                Console.Clear();
                                Console.WriteLine("--Vivero--");
                                foreach (var obj in viveros)
                                {
                                    Console.WriteLine(obj.ToString());
                                }
                                Console.WriteLine("--Escriba el Id del Vivero donde quiere retirar su planta-");
                                key = Optimize.ValInt();
                                Console.WriteLine("--Vivero agregado--");
                                Console.WriteLine(viveros[key].ToString());
                                selectedVivero = viveros[key];
                                Console.ReadLine();
                                break;

                            case 3:
                                //Cerrar App
                                app = false;
                                Console.WriteLine("--Cerrando--");
                                Environment.Exit(0);
                                break;

                            case 4:
                                //Logout
                                login = false;
                                break;

                            default:
                                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                                Console.WriteLine("Utilice un numero entre 1 y 6");
                                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                                System.Threading.Thread.Sleep(750);
                                break;
                        }
                    }
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
