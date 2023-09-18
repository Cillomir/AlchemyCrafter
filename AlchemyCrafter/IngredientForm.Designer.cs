namespace AlchemyCrafter
{
    partial class IngredientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientForm));
            this.cbo_rank = new System.Windows.Forms.ComboBox();
            this.btn_addContinue = new System.Windows.Forms.Button();
            this.btn_addReturn = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_rank = new System.Windows.Forms.Label();
            this.lbl_effect1 = new System.Windows.Forms.Label();
            this.lbl_effect2 = new System.Windows.Forms.Label();
            this.lbl_effect3 = new System.Windows.Forms.Label();
            this.tb_effect1 = new System.Windows.Forms.TextBox();
            this.tb_effect2 = new System.Windows.Forms.TextBox();
            this.tb_effect3 = new System.Windows.Forms.TextBox();
            this.lbl_ingredientType = new System.Windows.Forms.Label();
            this.cbo_ingredientType = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_shortDesc = new System.Windows.Forms.Label();
            this.lbl_longDesc = new System.Windows.Forms.Label();
            this.tb_shortDesc = new System.Windows.Forms.TextBox();
            this.tb_longDesc = new System.Windows.Forms.TextBox();
            this.chklb_regions = new System.Windows.Forms.CheckedListBox();
            this.lbl_region = new System.Windows.Forms.Label();
            this.lbl_componentType = new System.Windows.Forms.Label();
            this.cbo_componentType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbo_rank
            // 
            this.cbo_rank.FormattingEnabled = true;
            this.cbo_rank.Items.AddRange(new object[] {
            "Rank 1",
            "Rank 2",
            "Rank 3",
            "Rank 4",
            "Rank 5",
            "Rank 6",
            "Rank 7",
            "Rank 8",
            "Rank 9",
            "Rank S"});
            this.cbo_rank.Location = new System.Drawing.Point(140, 104);
            this.cbo_rank.Name = "cbo_rank";
            this.cbo_rank.Size = new System.Drawing.Size(64, 21);
            this.cbo_rank.TabIndex = 7;
            this.cbo_rank.Text = "Rank 1";
            // 
            // btn_addContinue
            // 
            this.btn_addContinue.Location = new System.Drawing.Point(12, 276);
            this.btn_addContinue.Name = "btn_addContinue";
            this.btn_addContinue.Size = new System.Drawing.Size(144, 24);
            this.btn_addContinue.TabIndex = 20;
            this.btn_addContinue.Text = "Add and Continue";
            this.btn_addContinue.UseVisualStyleBackColor = true;
            this.btn_addContinue.Click += new System.EventHandler(this.btn_addContinue_Click);
            // 
            // btn_addReturn
            // 
            this.btn_addReturn.Location = new System.Drawing.Point(238, 276);
            this.btn_addReturn.Name = "btn_addReturn";
            this.btn_addReturn.Size = new System.Drawing.Size(144, 24);
            this.btn_addReturn.TabIndex = 21;
            this.btn_addReturn.Text = "Add and Return";
            this.btn_addReturn.UseVisualStyleBackColor = true;
            this.btn_addReturn.Click += new System.EventHandler(this.btn_addReturn_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(12, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(52, 18);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name:";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(68, 8);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(256, 21);
            this.tb_name.TabIndex = 1;
            // 
            // lbl_rank
            // 
            this.lbl_rank.AutoSize = true;
            this.lbl_rank.Location = new System.Drawing.Point(140, 88);
            this.lbl_rank.Name = "lbl_rank";
            this.lbl_rank.Size = new System.Drawing.Size(36, 13);
            this.lbl_rank.TabIndex = 6;
            this.lbl_rank.Text = "Rank:";
            // 
            // lbl_effect1
            // 
            this.lbl_effect1.AutoSize = true;
            this.lbl_effect1.Location = new System.Drawing.Point(12, 136);
            this.lbl_effect1.Name = "lbl_effect1";
            this.lbl_effect1.Size = new System.Drawing.Size(47, 13);
            this.lbl_effect1.TabIndex = 10;
            this.lbl_effect1.Text = "Effect 1:";
            // 
            // lbl_effect2
            // 
            this.lbl_effect2.AutoSize = true;
            this.lbl_effect2.Location = new System.Drawing.Point(210, 136);
            this.lbl_effect2.Name = "lbl_effect2";
            this.lbl_effect2.Size = new System.Drawing.Size(47, 13);
            this.lbl_effect2.TabIndex = 12;
            this.lbl_effect2.Text = "Effect 2:";
            // 
            // lbl_effect3
            // 
            this.lbl_effect3.AutoSize = true;
            this.lbl_effect3.Location = new System.Drawing.Point(408, 136);
            this.lbl_effect3.Name = "lbl_effect3";
            this.lbl_effect3.Size = new System.Drawing.Size(47, 13);
            this.lbl_effect3.TabIndex = 14;
            this.lbl_effect3.Text = "Effect 3:";
            // 
            // tb_effect1
            // 
            this.tb_effect1.Location = new System.Drawing.Point(12, 152);
            this.tb_effect1.Name = "tb_effect1";
            this.tb_effect1.Size = new System.Drawing.Size(176, 20);
            this.tb_effect1.TabIndex = 11;
            // 
            // tb_effect2
            // 
            this.tb_effect2.Location = new System.Drawing.Point(210, 152);
            this.tb_effect2.Name = "tb_effect2";
            this.tb_effect2.Size = new System.Drawing.Size(176, 20);
            this.tb_effect2.TabIndex = 13;
            // 
            // tb_effect3
            // 
            this.tb_effect3.Location = new System.Drawing.Point(408, 152);
            this.tb_effect3.Name = "tb_effect3";
            this.tb_effect3.Size = new System.Drawing.Size(176, 20);
            this.tb_effect3.TabIndex = 15;
            // 
            // lbl_ingredientType
            // 
            this.lbl_ingredientType.AutoSize = true;
            this.lbl_ingredientType.Location = new System.Drawing.Point(12, 88);
            this.lbl_ingredientType.Name = "lbl_ingredientType";
            this.lbl_ingredientType.Size = new System.Drawing.Size(84, 13);
            this.lbl_ingredientType.TabIndex = 4;
            this.lbl_ingredientType.Text = "Ingredient Type:";
            // 
            // cbo_ingredientType
            // 
            this.cbo_ingredientType.FormattingEnabled = true;
            this.cbo_ingredientType.Items.AddRange(new object[] {
            "Component",
            "Reagent"});
            this.cbo_ingredientType.Location = new System.Drawing.Point(12, 104);
            this.cbo_ingredientType.Name = "cbo_ingredientType";
            this.cbo_ingredientType.Size = new System.Drawing.Size(96, 21);
            this.cbo_ingredientType.TabIndex = 5;
            this.cbo_ingredientType.Text = "Component";
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(472, 276);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(112, 24);
            this.btn_cancel.TabIndex = 22;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_shortDesc
            // 
            this.lbl_shortDesc.AutoSize = true;
            this.lbl_shortDesc.Location = new System.Drawing.Point(12, 40);
            this.lbl_shortDesc.Name = "lbl_shortDesc";
            this.lbl_shortDesc.Size = new System.Drawing.Size(91, 13);
            this.lbl_shortDesc.TabIndex = 2;
            this.lbl_shortDesc.Text = "Short Description:";
            // 
            // lbl_longDesc
            // 
            this.lbl_longDesc.AutoSize = true;
            this.lbl_longDesc.Location = new System.Drawing.Point(12, 184);
            this.lbl_longDesc.Name = "lbl_longDesc";
            this.lbl_longDesc.Size = new System.Drawing.Size(90, 13);
            this.lbl_longDesc.TabIndex = 18;
            this.lbl_longDesc.Text = "Long Description:";
            // 
            // tb_shortDesc
            // 
            this.tb_shortDesc.Location = new System.Drawing.Point(12, 56);
            this.tb_shortDesc.Name = "tb_shortDesc";
            this.tb_shortDesc.Size = new System.Drawing.Size(312, 20);
            this.tb_shortDesc.TabIndex = 3;
            // 
            // tb_longDesc
            // 
            this.tb_longDesc.AcceptsReturn = true;
            this.tb_longDesc.Location = new System.Drawing.Point(12, 200);
            this.tb_longDesc.Multiline = true;
            this.tb_longDesc.Name = "tb_longDesc";
            this.tb_longDesc.Size = new System.Drawing.Size(572, 64);
            this.tb_longDesc.TabIndex = 19;
            // 
            // chklb_regions
            // 
            this.chklb_regions.ColumnWidth = 96;
            this.chklb_regions.FormattingEnabled = true;
            this.chklb_regions.Items.AddRange(new object[] {
            "Urban",
            "Grassland",
            "Hillside",
            "Forest",
            "Mountain",
            "Cavern",
            "Swamp",
            "Desert",
            "Arctic",
            "Coast",
            "Water",
            "Underocean",
            "Underdark"});
            this.chklb_regions.Location = new System.Drawing.Point(384, 12);
            this.chklb_regions.MultiColumn = true;
            this.chklb_regions.Name = "chklb_regions";
            this.chklb_regions.Size = new System.Drawing.Size(200, 109);
            this.chklb_regions.TabIndex = 17;
            // 
            // lbl_region
            // 
            this.lbl_region.AutoSize = true;
            this.lbl_region.Location = new System.Drawing.Point(336, 12);
            this.lbl_region.Name = "lbl_region";
            this.lbl_region.Size = new System.Drawing.Size(44, 13);
            this.lbl_region.TabIndex = 16;
            this.lbl_region.Text = "Region:";
            // 
            // lbl_componentType
            // 
            this.lbl_componentType.AutoSize = true;
            this.lbl_componentType.Location = new System.Drawing.Point(228, 88);
            this.lbl_componentType.Name = "lbl_componentType";
            this.lbl_componentType.Size = new System.Drawing.Size(91, 13);
            this.lbl_componentType.TabIndex = 8;
            this.lbl_componentType.Text = "Component Type:";
            // 
            // cbo_componentType
            // 
            this.cbo_componentType.FormattingEnabled = true;
            this.cbo_componentType.Items.AddRange(new object[] {
            "Herb",
            "Fungi",
            "Part",
            "Other"});
            this.cbo_componentType.Location = new System.Drawing.Point(228, 104);
            this.cbo_componentType.Name = "cbo_componentType";
            this.cbo_componentType.Size = new System.Drawing.Size(96, 21);
            this.cbo_componentType.TabIndex = 9;
            this.cbo_componentType.Text = "Herb";
            // 
            // IngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(596, 309);
            this.Controls.Add(this.cbo_componentType);
            this.Controls.Add(this.lbl_componentType);
            this.Controls.Add(this.lbl_region);
            this.Controls.Add(this.chklb_regions);
            this.Controls.Add(this.tb_longDesc);
            this.Controls.Add(this.tb_shortDesc);
            this.Controls.Add(this.lbl_longDesc);
            this.Controls.Add(this.lbl_shortDesc);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cbo_ingredientType);
            this.Controls.Add(this.lbl_ingredientType);
            this.Controls.Add(this.tb_effect3);
            this.Controls.Add(this.tb_effect2);
            this.Controls.Add(this.tb_effect1);
            this.Controls.Add(this.lbl_effect3);
            this.Controls.Add(this.lbl_effect2);
            this.Controls.Add(this.lbl_effect1);
            this.Controls.Add(this.lbl_rank);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_addReturn);
            this.Controls.Add(this.btn_addContinue);
            this.Controls.Add(this.cbo_rank);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(612, 348);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(612, 348);
            this.Name = "IngredientForm";
            this.ShowInTaskbar = false;
            this.Text = "Create New Ingredients";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_rank;
        private System.Windows.Forms.Button btn_addContinue;
        private System.Windows.Forms.Button btn_addReturn;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_rank;
        private System.Windows.Forms.Label lbl_effect1;
        private System.Windows.Forms.Label lbl_effect2;
        private System.Windows.Forms.Label lbl_effect3;
        private System.Windows.Forms.TextBox tb_effect1;
        private System.Windows.Forms.TextBox tb_effect2;
        private System.Windows.Forms.TextBox tb_effect3;
        private System.Windows.Forms.Label lbl_ingredientType;
        private System.Windows.Forms.ComboBox cbo_ingredientType;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_shortDesc;
        private System.Windows.Forms.Label lbl_longDesc;
        private System.Windows.Forms.TextBox tb_shortDesc;
        private System.Windows.Forms.TextBox tb_longDesc;
        private System.Windows.Forms.CheckedListBox chklb_regions;
        private System.Windows.Forms.Label lbl_region;
        private System.Windows.Forms.Label lbl_componentType;
        private System.Windows.Forms.ComboBox cbo_componentType;
    }
}