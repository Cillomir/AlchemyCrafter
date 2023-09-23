/* **************************************************
* Alchemy Crafter - Effects Form v0.1.0
* Author: Joel Leckie
* Created: Sep. 2023
*  v0.1.0 - Created effects form.
************************************************** */
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlchemyCrafter
{
    public partial class EffectsForm : Form
    {
        public EffectsForm()
        {
            InitializeComponent();
            IngredientEffectRank test = new IngredientEffectRank("Test1");
            test = new IngredientEffectRank("Test2");
            test = new IngredientEffectRank("Test3");
            GenerateGrids();
            RefreshGrids();
        }

        private void GenerateGrids()
        {
            gridViewIngredientRank.Rows.Clear();
            gridViewIngredientRank.Columns.Clear();
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.Name = "Name";
            column.DataPropertyName = "Name";
            column.Width = 112;
            DataGridViewColumn column1 = (DataGridViewColumn)column.Clone();
            DataGridViewColumn column2 = (DataGridViewColumn)column.Clone();
            gridViewIngredientRank.Columns.Add(column);
            gridViewPotionRank.Columns.Add(column1);
            gridViewEffectType.Columns.Add(column2);

            DataGridViewImageColumn image = new DataGridViewImageColumn();
            image.Image = Properties.Resources.arrow_upward;
            image.Width = 24;
            //image.ValuesAreIcons = true;
            DataGridViewImageColumn image1 = (DataGridViewImageColumn)image.Clone();
            DataGridViewImageColumn image2 = (DataGridViewImageColumn)image.Clone();
            gridViewIngredientRank.Columns.Add(image);
            gridViewPotionRank.Columns.Add(image1);
            gridViewEffectType.Columns.Add(image2);

            image = new DataGridViewImageColumn();
            image.Image = Properties.Resources.arrow_downward;
            image.Width = 24;
            //image.ValuesAreIcons = true;
            image1 = (DataGridViewImageColumn)image.Clone();
            image2 = (DataGridViewImageColumn)image.Clone();
            gridViewIngredientRank.Columns.Add(image);
            gridViewPotionRank.Columns.Add(image1);
            gridViewEffectType.Columns.Add(image2);

            //DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            //button.Text = "^";
            //button.Width = 16;
            //button.UseColumnTextForButtonValue = true;
            //gridViewIngredientRank.Columns.Add(button);
            //gridViewPotionRank.Columns.Add(button);
            //gridViewEffectType.Columns.Add(button);

            //button = new DataGridViewButtonColumn();
            //button.Text = "v";
            //button.Width = 16;
            //button.UseColumnTextForButtonValue = true;
            //gridViewIngredientRank.Columns.Add(button);
            //gridViewPotionRank.Columns.Add(button);
            //gridViewEffectType.Columns.Add(button);

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            //button.Name = "C";
            button.Text = "Del";
            button.Width = 36;
            button.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn button1 = (DataGridViewButtonColumn)button.Clone();
            DataGridViewButtonColumn button2 = (DataGridViewButtonColumn)button.Clone();
            gridViewIngredientRank.Columns.Add(button);
            gridViewPotionRank.Columns.Add(button1);
            gridViewEffectType.Columns.Add(button2);

            gridViewIngredientRank.RowHeadersVisible = false;
            gridViewPotionRank.RowHeadersVisible = false;
            gridViewEffectType.RowHeadersVisible = false;
            gridViewEffects.RowHeadersVisible = false;
            //gridViewIngredientRank.AllowUserToAddRows = true;
        }

        private void RefreshGrids()
        {
            foreach(IngredientEffectRank r in IngredientEffectRank.All)
            {
                gridViewIngredientRank.Rows.Add(r.Name);
            }
            //gridViewIngredientRank.DataSource = IngredientEffectRank.All;
            DataGridViewRow addRow = new DataGridViewRow();
            DataGridViewTextBoxCell text = new DataGridViewTextBoxCell();
            addRow.Cells.Add(text);
            DataGridViewImageCell empty = new DataGridViewImageCell();
            addRow.Cells.Add(empty);
            empty = new DataGridViewImageCell();
            addRow.Cells.Add(empty);
            DataGridViewButtonCell button = new DataGridViewButtonCell();
            button.Value = "Add";
            addRow.Cells.Add(button);
            gridViewIngredientRank.Rows.Add(addRow);
        }

        private void btn_loadEffects_Click(object sender, EventArgs e)
        {
            if (openEffectDialog.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void btn_saveEffects_Click(object sender, EventArgs e)
        {
            if (saveEffectDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(saveEffectDialog.FileName);
                    var options = new JsonSerializerOptions { WriteIndented = true };
                    string jsonRank = JsonSerializer.Serialize(PotionEffectRank.All, options);
                    string jsonCategory = JsonSerializer.Serialize(PotionEffectCategory.All, options);
                    string jsonEffect = JsonSerializer.Serialize(PotionEffect.All, options);
                    string jsonString = jsonRank + jsonCategory + jsonEffect;
                    sw.WriteLine(jsonString);
                }
                catch (Exception er)
                {
                    Console.WriteLine("Error saving Effects to JSON");
                    Console.WriteLine(er.Message);
                }
            }
        }

        private void gridViewIngredientRank_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //IngredientEffectRank rank = new IngredientEffectRank(e.Row.Cells[0].Value.ToString());
        }

        private void gridViewIngredientRank_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void gridViewIngredientRank_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = gridViewIngredientRank.Rows[e.RowIndex];
            DataGridViewColumn col = gridViewIngredientRank.Columns[e.ColumnIndex];
            DataGridViewCell cell = gridViewIngredientRank.Rows[e.RowIndex].Cells[e.ColumnIndex];
            Console.WriteLine("Break Here");
        }
    }
}
