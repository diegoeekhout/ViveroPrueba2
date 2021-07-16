using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViveroPrueba2
{
    class Plant
    {
        public static List<Plant> plants = new List<Plant>();
        static Random r = new Random();
        public int id { get; set; }
        public int price { get; set; }
        public String name { get; set; }
        public String type { get; set; }
        static string[] names = {"Fucus Benjamina", "Peperomia Cucharita", "Mostrera", "Lazos de Amor", "Peperomia Caperata", "Lavanda Francesa",
                "Suzuki", "Suculenta Sedum", "Brachicome", "Rayo de Sol", "Porcelana", "Violeta Persa"};
        static string[] types = { "Interios", "Exterior", "Florales"};
        public Plant()
        {

        }
        public Plant(int plantId, String plantName, int plantPrice, String plantType)
        {
            id = plantId;
            name = plantName;
            price = plantPrice;
            type = plantType;
        }
        public static Plant DataPlant(int index)
        {
            Plant plant = new Plant();
            int rName = r.Next(0, names.Length);
            int rType = r.Next(0, types.Length);
            int rangePrice = r.Next(1, 11);
            int basePrice = 91;
            int prices = basePrice * rangePrice;
            plant = new Plant(index, names[rName], prices, types[rType]);
            plants.Add(plant);
            return plant;
        }
        public override string ToString()
        {
            string toString = "Id: " + id + " | NOmbre: " + name + " | Tipo: " + type + " | Valor: " + price;
            return toString;
        }
        public Plant IsNullOrEmpty(Plant plant)
        {
            return plant;
        }
        public void LinqDescending()
        {
            Console.WriteLine("Valores Descendientes");
            var queryDe = from plant in plants
                          orderby plant.price descending
                          select plant;
            foreach (var obj in queryDe)
            {
                Console.WriteLine(obj.ToString());
            }
        }
        public void LinqAscending()
        {
            Console.WriteLine("Valores Ascendientes");
            var queryAsc = from plant in plants
                           orderby plant.price ascending
                           select plant;
            foreach (var obj in queryAsc)
            {
                Console.WriteLine(obj.ToString());
            }
        }
        public void LinqAmmount()
        {
            Console.WriteLine("Valor Menor a");
            int ammount = Optimize.ValInt();
            var queryPBase = from plant in plants
                             where plant.price <= ammount
                             orderby plant.id
                             select (plant);
            foreach (var obj in queryPBase)
            {
                Console.WriteLine(obj.ToString());
            }
        }
        public void ListView()
        {
            foreach (var obj in plants)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}
