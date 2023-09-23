/* **************************************************
* Alchemy Crafter - Potion v0.1.0
* Author: Joel Leckie
* Created: Sep. 2023
*  v0.1.0 - Created potion class with classes for ranks
*           and effects.
************************************************** */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlchemyCrafter
{
    internal class Potion
    {
    }

    public class PotionEffectCategory
    {
        private static int nextID = 0;
        private static List<PotionEffectCategory> allCategories = new List<PotionEffectCategory>();
        public static List<PotionEffectCategory> All { get { return allCategories; } }
        private int ID;
        private string name;
        public string Name { get { return name; } set { name = value; } }
        public PotionEffectCategory(string name) 
        {
            this.ID = nextID++;
            this.name = Name;
            if (this.name == null) return;
            if (InList(this)) return;
            allCategories.Add(this);
        }
        public static bool InList(PotionEffectCategory category)
        {
            if (allCategories.Exists(r => r.Name.Equals(category.Name))) return true;
            else return false;
        }
    }

    public class PotionEffectRank
    {
        private static int nextID = 0;
        private static List<PotionEffectRank> allRanks = new List<PotionEffectRank>();
        public static List<PotionEffectRank> All { get { return allRanks; } }
        private int ID;
        private string name;
        public string Name { get { return name; } set { name = value; } }
        public PotionEffectRank(string name)
        {
            this.ID = nextID++;
            this.name = name;
            if (this.name == null) return;
            if (InList(this)) return;
            allRanks.Add(this);
        }
        public static bool InList(PotionEffectRank rank)
        {
            if (allRanks.Exists(r => r.Name.Equals(rank.Name))) return true;
            else return false;
        }
    }

    public class PotionEffect
    {
        private static int nextID = 0;
        private static List<PotionEffect> allEffects = new List<PotionEffect>();
        public static List<PotionEffect> All { get { return allEffects; } }
        private int ID;
        private string name;
        public string Name { get { return name; } set { name = value; } }
        private PotionEffectCategory category;
        public PotionEffectCategory Category { get { return category; } set { category = value; } }
        private PotionEffectRank rank;
        public PotionEffectRank Rank { get { return rank; } set { rank = value; } }

        public PotionEffect(string name, PotionEffectCategory category, PotionEffectRank rank)
        {
            this.ID = nextID++;
            this.name = name;
            this.category = category;
            this.rank = rank;
            if ((this.Name == null) || (this.category == null) || (this.rank == null)) return;
            if (!PotionEffectRank.InList(this.rank)) return;
            if (!PotionEffectCategory.InList(this.category)) return;
            if (InList(this)) return;
            allEffects.Add(this);
        }
        public static bool InList(PotionEffect effect)
        {
            if (allEffects.Exists(r => r.Name.Equals(effect.Name))) return true;
            else return false;
        }

    }
}
