/* **************************************************
* Alchemy Crafter - Ingredient Form v0.1.0
* Author: Joel Leckie
* Created: Sep. 2023
*  v0.1.0 - Created ingredient form.
************************************************** */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlchemyCrafter
{
    internal delegate void del_addIngredient(Ingredient x);

    public partial class IngredientForm : Form
    {
        internal del_addIngredient AddIngredientCallback;

        internal Ingredient pIngredient {
            get { return pIngredient; }
            set { pIngredient = value; }
        }

        public IngredientForm()
        {
            InitializeComponent();
        }

        private void btn_addContinue_Click(object sender, EventArgs e)
        {
            if (tb_name.Text.Length <= 0) return;
            if ((tb_effect1.Text.Length <= 0)
                    && (tb_effect2.Text.Length <= 0)
                    && (tb_effect3.Text.Length <= 0)) return;
            AddItem();
            ClearForm();
        }

        private void btn_addReturn_Click(object sender, EventArgs e)
        {
            AddItem();
            QuitForm();
        }

        private void AddItem()
        {
            List<Regions> regions = new List<Regions>();
            foreach (int x in chklb_regions.SelectedIndices)
                regions.Add((Regions)x);
            Ingredient item = new Ingredient(
                tb_name.Text, cbo_rank.Text,
                tb_effect1.Text, tb_effect2.Text, tb_effect3.Text,
                tb_shortDesc.Text, tb_longDesc.Text,
                (TypeIngredient)cbo_ingredientType.SelectedIndex, 
                (TypeComponent)cbo_componentType.SelectedIndex,
                regions
                );
            if (AddIngredientCallback != null)
                AddIngredientCallback(item);
        }

        private void ClearForm()
        {
            tb_name.Text = "";
            tb_shortDesc.Text = "";
            tb_longDesc.Text = "";
            tb_effect1.Text = "";
            tb_effect2.Text = "";
            tb_effect3.Text = "";
            chklb_regions.SelectedIndices.Clear();
            chklb_regions.ClearSelected();
            tb_name.Focus();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            QuitForm();
        }

        private void QuitForm()
        {
            this.Close();
        }
    }
}
