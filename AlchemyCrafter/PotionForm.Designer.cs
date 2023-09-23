namespace AlchemyCrafter
{
    partial class PotionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PotionForm));
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_shortDesc = new System.Windows.Forms.Label();
            this.lbl_potionType = new System.Windows.Forms.Label();
            this.lbl_longDesc = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_shortDesc = new System.Windows.Forms.TextBox();
            this.lbl_rank = new System.Windows.Forms.Label();
            this.lbl_rarity = new System.Windows.Forms.Label();
            this.lbl_value = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_container = new System.Windows.Forms.Label();
            this.lbl_application = new System.Windows.Forms.Label();
            this.cbo_potionType = new System.Windows.Forms.ComboBox();
            this.cbo_rank = new System.Windows.Forms.ComboBox();
            this.cbo_container = new System.Windows.Forms.ComboBox();
            this.cbo_application = new System.Windows.Forms.ComboBox();
            this.num_weight = new System.Windows.Forms.NumericUpDown();
            this.num_value = new System.Windows.Forms.NumericUpDown();
            this.cbo_rarity = new System.Windows.Forms.ComboBox();
            this.cbo_coinage = new System.Windows.Forms.ComboBox();
            this.tb_longDesc = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_addReturn = new System.Windows.Forms.Button();
            this.btn_addContinue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_value)).BeginInit();
            this.SuspendLayout();
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
            // lbl_shortDesc
            // 
            this.lbl_shortDesc.AutoSize = true;
            this.lbl_shortDesc.Location = new System.Drawing.Point(12, 40);
            this.lbl_shortDesc.Name = "lbl_shortDesc";
            this.lbl_shortDesc.Size = new System.Drawing.Size(91, 13);
            this.lbl_shortDesc.TabIndex = 2;
            this.lbl_shortDesc.Text = "Short Description:";
            // 
            // lbl_potionType
            // 
            this.lbl_potionType.AutoSize = true;
            this.lbl_potionType.Location = new System.Drawing.Point(12, 88);
            this.lbl_potionType.Name = "lbl_potionType";
            this.lbl_potionType.Size = new System.Drawing.Size(67, 13);
            this.lbl_potionType.TabIndex = 4;
            this.lbl_potionType.Text = "Potion Type:";
            // 
            // lbl_longDesc
            // 
            this.lbl_longDesc.AutoSize = true;
            this.lbl_longDesc.Location = new System.Drawing.Point(12, 184);
            this.lbl_longDesc.Name = "lbl_longDesc";
            this.lbl_longDesc.Size = new System.Drawing.Size(90, 13);
            this.lbl_longDesc.TabIndex = 19;
            this.lbl_longDesc.Text = "Long Description:";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(68, 8);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(256, 21);
            this.tb_name.TabIndex = 1;
            // 
            // tb_shortDesc
            // 
            this.tb_shortDesc.Location = new System.Drawing.Point(12, 56);
            this.tb_shortDesc.Name = "tb_shortDesc";
            this.tb_shortDesc.Size = new System.Drawing.Size(312, 20);
            this.tb_shortDesc.TabIndex = 3;
            // 
            // lbl_rank
            // 
            this.lbl_rank.AutoSize = true;
            this.lbl_rank.Location = new System.Drawing.Point(136, 88);
            this.lbl_rank.Name = "lbl_rank";
            this.lbl_rank.Size = new System.Drawing.Size(36, 13);
            this.lbl_rank.TabIndex = 6;
            this.lbl_rank.Text = "Rank:";
            // 
            // lbl_rarity
            // 
            this.lbl_rarity.AutoSize = true;
            this.lbl_rarity.Location = new System.Drawing.Point(260, 88);
            this.lbl_rarity.Name = "lbl_rarity";
            this.lbl_rarity.Size = new System.Drawing.Size(37, 13);
            this.lbl_rarity.TabIndex = 8;
            this.lbl_rarity.Text = "Rarity:";
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Location = new System.Drawing.Point(340, 136);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(37, 13);
            this.lbl_value.TabIndex = 16;
            this.lbl_value.Text = "Value:";
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Location = new System.Drawing.Point(260, 136);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(44, 13);
            this.lbl_weight.TabIndex = 14;
            this.lbl_weight.Text = "Weight:";
            // 
            // lbl_container
            // 
            this.lbl_container.AutoSize = true;
            this.lbl_container.Location = new System.Drawing.Point(136, 136);
            this.lbl_container.Name = "lbl_container";
            this.lbl_container.Size = new System.Drawing.Size(55, 13);
            this.lbl_container.TabIndex = 12;
            this.lbl_container.Text = "Container:";
            // 
            // lbl_application
            // 
            this.lbl_application.AutoSize = true;
            this.lbl_application.Location = new System.Drawing.Point(12, 136);
            this.lbl_application.Name = "lbl_application";
            this.lbl_application.Size = new System.Drawing.Size(62, 13);
            this.lbl_application.TabIndex = 10;
            this.lbl_application.Text = "Application:";
            // 
            // cbo_potionType
            // 
            this.cbo_potionType.FormattingEnabled = true;
            this.cbo_potionType.Items.AddRange(new object[] {
            "Cure",
            "Boon",
            "Boost",
            "Resist",
            "Poison",
            "Elemental",
            "Detriment"});
            this.cbo_potionType.Location = new System.Drawing.Point(12, 104);
            this.cbo_potionType.Name = "cbo_potionType";
            this.cbo_potionType.Size = new System.Drawing.Size(112, 21);
            this.cbo_potionType.TabIndex = 5;
            this.cbo_potionType.Text = "Cure";
            // 
            // cbo_rank
            // 
            this.cbo_rank.FormattingEnabled = true;
            this.cbo_rank.Items.AddRange(new object[] {
            "Rank 0 - Cantrip",
            "Rank 1 - Level 1",
            "Rank 2 - Level 2",
            "Rank 3 - Level 3",
            "Rank 4 - Level 4",
            "Rank 5 - Level 5",
            "Rank 6 - Level 6",
            "Rank 7 - Level 7",
            "Rank 8 - Level 8",
            "Rank 9 - Level 9",
            "Rank S - Other"});
            this.cbo_rank.Location = new System.Drawing.Point(136, 104);
            this.cbo_rank.Name = "cbo_rank";
            this.cbo_rank.Size = new System.Drawing.Size(112, 21);
            this.cbo_rank.TabIndex = 7;
            this.cbo_rank.Text = "Rank 0 - Cantrip";
            // 
            // cbo_container
            // 
            this.cbo_container.FormattingEnabled = true;
            this.cbo_container.Items.AddRange(new object[] {
            "Vial",
            "Potion Bottle",
            "Flask",
            "Other"});
            this.cbo_container.Location = new System.Drawing.Point(136, 152);
            this.cbo_container.Name = "cbo_container";
            this.cbo_container.Size = new System.Drawing.Size(112, 21);
            this.cbo_container.TabIndex = 13;
            this.cbo_container.Text = "Potion Bottle";
            // 
            // cbo_application
            // 
            this.cbo_application.FormattingEnabled = true;
            this.cbo_application.Items.AddRange(new object[] {
            "Consume",
            "Splash",
            "Other"});
            this.cbo_application.Location = new System.Drawing.Point(12, 152);
            this.cbo_application.Name = "cbo_application";
            this.cbo_application.Size = new System.Drawing.Size(112, 21);
            this.cbo_application.TabIndex = 11;
            this.cbo_application.Text = "Consume";
            // 
            // num_weight
            // 
            this.num_weight.Location = new System.Drawing.Point(260, 153);
            this.num_weight.Name = "num_weight";
            this.num_weight.Size = new System.Drawing.Size(64, 20);
            this.num_weight.TabIndex = 15;
            // 
            // num_value
            // 
            this.num_value.Location = new System.Drawing.Point(340, 153);
            this.num_value.Name = "num_value";
            this.num_value.Size = new System.Drawing.Size(80, 20);
            this.num_value.TabIndex = 17;
            // 
            // cbo_rarity
            // 
            this.cbo_rarity.FormattingEnabled = true;
            this.cbo_rarity.Items.AddRange(new object[] {
            "Common",
            "Uncommon",
            "Rare",
            "Very Rare",
            "Legendary"});
            this.cbo_rarity.Location = new System.Drawing.Point(260, 104);
            this.cbo_rarity.Name = "cbo_rarity";
            this.cbo_rarity.Size = new System.Drawing.Size(112, 21);
            this.cbo_rarity.TabIndex = 9;
            this.cbo_rarity.Text = "Common";
            // 
            // cbo_coinage
            // 
            this.cbo_coinage.FormattingEnabled = true;
            this.cbo_coinage.Items.AddRange(new object[] {
            "CP",
            "SP",
            "GP",
            "EP",
            "PP"});
            this.cbo_coinage.Location = new System.Drawing.Point(424, 152);
            this.cbo_coinage.Name = "cbo_coinage";
            this.cbo_coinage.Size = new System.Drawing.Size(48, 21);
            this.cbo_coinage.TabIndex = 18;
            this.cbo_coinage.Text = "GP";
            // 
            // tb_longDesc
            // 
            this.tb_longDesc.AcceptsReturn = true;
            this.tb_longDesc.Location = new System.Drawing.Point(12, 200);
            this.tb_longDesc.Multiline = true;
            this.tb_longDesc.Name = "tb_longDesc";
            this.tb_longDesc.Size = new System.Drawing.Size(572, 64);
            this.tb_longDesc.TabIndex = 20;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(472, 276);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(112, 24);
            this.btn_cancel.TabIndex = 23;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_addReturn
            // 
            this.btn_addReturn.Location = new System.Drawing.Point(238, 276);
            this.btn_addReturn.Name = "btn_addReturn";
            this.btn_addReturn.Size = new System.Drawing.Size(144, 24);
            this.btn_addReturn.TabIndex = 22;
            this.btn_addReturn.Text = "Add and Return";
            this.btn_addReturn.UseVisualStyleBackColor = true;
            // 
            // btn_addContinue
            // 
            this.btn_addContinue.Location = new System.Drawing.Point(12, 276);
            this.btn_addContinue.Name = "btn_addContinue";
            this.btn_addContinue.Size = new System.Drawing.Size(144, 24);
            this.btn_addContinue.TabIndex = 21;
            this.btn_addContinue.Text = "Add and Continue";
            this.btn_addContinue.UseVisualStyleBackColor = true;
            // 
            // PotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(596, 309);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_addReturn);
            this.Controls.Add(this.btn_addContinue);
            this.Controls.Add(this.tb_longDesc);
            this.Controls.Add(this.cbo_coinage);
            this.Controls.Add(this.cbo_rarity);
            this.Controls.Add(this.num_value);
            this.Controls.Add(this.num_weight);
            this.Controls.Add(this.cbo_application);
            this.Controls.Add(this.cbo_container);
            this.Controls.Add(this.cbo_rank);
            this.Controls.Add(this.cbo_potionType);
            this.Controls.Add(this.lbl_application);
            this.Controls.Add(this.lbl_container);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.lbl_rarity);
            this.Controls.Add(this.lbl_rank);
            this.Controls.Add(this.tb_shortDesc);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_longDesc);
            this.Controls.Add(this.lbl_potionType);
            this.Controls.Add(this.lbl_shortDesc);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(616, 352);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(616, 352);
            this.Name = "PotionForm";
            this.ShowInTaskbar = false;
            this.Text = "Create New Potions";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.num_weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_shortDesc;
        private System.Windows.Forms.Label lbl_potionType;
        private System.Windows.Forms.Label lbl_rank;
        private System.Windows.Forms.Label lbl_rarity;
        private System.Windows.Forms.Label lbl_application;
        private System.Windows.Forms.Label lbl_container;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.Label lbl_longDesc;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_shortDesc;
        private System.Windows.Forms.ComboBox cbo_potionType;
        private System.Windows.Forms.ComboBox cbo_rank;
        private System.Windows.Forms.ComboBox cbo_rarity;
        private System.Windows.Forms.ComboBox cbo_application;
        private System.Windows.Forms.ComboBox cbo_container;
        private System.Windows.Forms.NumericUpDown num_weight;
        private System.Windows.Forms.NumericUpDown num_value;
        private System.Windows.Forms.ComboBox cbo_coinage;
        private System.Windows.Forms.TextBox tb_longDesc;
        private System.Windows.Forms.Button btn_addContinue;
        private System.Windows.Forms.Button btn_addReturn;
        private System.Windows.Forms.Button btn_cancel;
    }
}