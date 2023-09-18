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
        private int ID;
        private string Name;
        public PotionEffectCategory(string Name) 
        {
            this.ID = nextID++;
            this.Name = Name;
            if (this.Name == null) return;
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
        private int ID;
        private string Name;
        public PotionEffectRank(string Name)
        {
            this.ID = nextID++;
            this.Name = Name;
            if (this.Name == null) return;
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
        private int ID;
        private string Name;
        private PotionEffectCategory category;
        private PotionEffectRank rank;

        public PotionEffect(string Name, PotionEffectCategory category, PotionEffectRank rank)
        {
            this.ID = nextID++;
            this.Name = Name;
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
