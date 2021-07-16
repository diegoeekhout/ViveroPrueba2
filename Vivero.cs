using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViveroPrueba2
{
    class Vivero
    {
        public int id { get; set; }
        public String address { get; set; }
        public String city { get; set; }
        public String region { get; set; }
        public static string[] regiones = { "RM", "Valparaiso", "Arica", "Araucania",
                "Spain", "Italy", "United states" };
        public static string[] cities = { "Santiago", "Viña del Mar", "Arica",
                "Temuco" };
        public Vivero()
        {

        }
        public Vivero(int viveroId, String viveroRegion, String viveroCity, String viveroAddress)
        {
            id = viveroId;
            region = viveroRegion;
            city = viveroCity;
            address = viveroAddress;
        }
        public static Vivero DataVivero(int index)
        {
            Vivero vivero = new Vivero();
            int range = (index + 1) * 570;
            String address = "El vivero " + range;
            vivero = new Vivero(index, regiones[index], cities[index], address);
            return vivero;
        }
        public override string ToString()
        {
            string toString = "Id: " + id + " | Region: " + region + " | Ciudad: " + city + " | Direccion: " + address;
            return toString;
        }
    }
}
