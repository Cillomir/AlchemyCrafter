using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyCrafter
{
    public enum TypeIngredient
    {
        Component, Reagent
    };

    public enum TypeComponent
    {
        Herb, Fungi, Part, Other
    };

    public enum Regions
    {
        Urban, Grassland, Hillside, Forest, Mountain, Cavern, Swamp, 
        Desert, Arctic, Coast, Water, Underocean, Underdark
    };

    internal class Ingredient
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private int rank;
        public string Rank { get { return GetRank(rank); } set { rank = SetRank(value); } }

        private string effect1;
        public string Effect1 { get { return effect1; } set { effect1 = value; } }

        private string effect2;
        public string Effect2 { get { return effect2; } set { effect2 = value; } }

        private string effect3;
        public string Effect3 { get { return effect3; } set { effect3 = value; } }

        private string shortDesc;
        public string ShortDescription { get { return shortDesc; } set { shortDesc = value; } }

        private string longDesc;
        public string LongDescription { get { return longDesc; } set { longDesc = value; } }

        private TypeIngredient ingredient;
        public TypeIngredient IngredientType { get { return ingredient; } set { ingredient = value; } }

        private TypeComponent component;
        public TypeComponent ComponentType { get { return component; } set { component = value; } }

        private List<Regions> region;
        public List<Regions> RegionsFound { get { return region; } set { region = value; } }

        public Ingredient(string name, string rank,
            string effect1, string effect2, string effect3,
            string shortDescription, string longDescription,
            TypeIngredient ingredientType, TypeComponent componentType,
            List<Regions> regionsFound)
        {
            Name = name;
            Rank = rank;
            Effect1 = effect1;
            Effect2 = effect2;
            Effect3 = effect3;
            ShortDescription = shortDescription;
            LongDescription = longDescription;
            IngredientType = ingredientType;
            ComponentType = componentType;
            RegionsFound = regionsFound;
        }

        private string GetRank(int x)
        {
            string val = "N/A";
            switch (x)
            {
                case 1:
                    val = "Rank 1";
                    break;
                case 2:
                    val = "Rank 2";
                    break;
                case 3:
                    val = "Rank 3";
                    break;
                case 4:
                    val = "Rank 4";
                    break;
                case 5:
                    val = "Rank 5";
                    break;
                case 6:
                    val = "Rank 6";
                    break;
                case 7:
                    val = "Rank 7";
                    break;
                case 8:
                    val = "Rank 8";
                    break;
                case 9:
                    val = "Rank 9";
                    break;
                case 10:
                    val = "Rank S";
                    break;
            }
            return val;
        }
        private int SetRank(string x)
        {
            int val = 1;
            switch (x)
            {
                case "Rank 1":
                    val = 1;
                    break;
                case "Rank 2":
                    val = 2;
                    break;
                case "Rank 3":
                    val = 3;
                    break;
                case "Rank 4":
                    val = 4;
                    break;
                case "Rank 5":
                    val = 5;
                    break;
                case "Rank 6":
                    val = 6;
                    break;
                case "Rank 7":
                    val = 7;
                    break;
                case "Rank 8":
                    val = 8;
                    break;
                case "Rank 9":
                    val = 9;
                    break;
                case "Rank S":
                    val = 10;
                    break;
            }
            return val;
        }
    }
    internal static class Extensions 
    {
        public static void ToCSV(this Ingredient ingred, string filePath)
        {
            try
            {
                StreamWriter sw;
                if (!File.Exists(filePath))
                {
                    sw = new StreamWriter(filePath, false);
                    // No file, create headers first
                    sw.WriteLine("Name,Rank,Effect1,Effect2,Effect3," +
                        "Ingredient Type,Component Type," +
                        "UR,GR,HL,FO,MO,CA,SW,DE,AR,CO,WA,UO,UD," +
                        "Short Description,Long Description");
                }
                else
                {
                    sw = new StreamWriter(filePath, true);
                }
                string line = "";
                line += ingred.Name + ",";
                line += ingred.Rank + ",";
                line += ingred.Effect1 + ",";
                line += ingred.Effect2 + ",";
                line += ingred.Effect3 + ",";
                line += ingred.IngredientType.ToString() + ",";
                line += ingred.ComponentType.ToString() + ",";
                for (int i = 0; i < Regions.GetNames(typeof(Regions)).Length;)
                {
                    if (ingred.RegionsFound.Contains((Regions)i))
                        line += "1";
                    else
                        line += "0";
                    line += ",";
                }
                line += ingred.ShortDescription + ",";
                line += ingred.LongDescription;
                sw.WriteLine(line);
            }
            catch
            {
                // Unable to open StreamWriter file
            }
        }
    }
}
