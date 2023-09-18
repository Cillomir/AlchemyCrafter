using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using AlchemyCrafter.Properties;

namespace AlchemyCrafter
{
    public partial class Form1 : Form
    {
        internal List<Ingredient> ingredientList;
        internal List<PotionEffects> effectsList;
        //internal Ingredient hingredient;
        //static del_ingredient handleIngredient = HandleIngredient;
        //internal List<Potion> potionList

        public Form1()
        {
            InitializeComponent();
            ingredientList = new List<Ingredient>();
            if (Settings.Default.UseEffectList)
            {
                btn_effectList.Visible = true;
                btn_effectList.Enabled = true;
            }
            else
            {
                btn_effectList.Visible = false;
                btn_effectList.Enabled = false;
            }
        }

        private void btn_newIngredient_Click(object sender, EventArgs e)
        {
            IngredientForm form = new IngredientForm();
            form.AddIngredientCallback = new del_addIngredient(AddIngredient);
            form.ShowDialog();
        }

        private void btn_newPotion_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

        }

        private void AddIngredient(Ingredient x)
        {
            ingredientList.Add(x);
        }

        private void btn_effectList_Click(object sender, EventArgs e)
        {

        }
    }
}
