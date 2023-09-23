namespace AlchemyCrafter
{
    partial class EffectsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EffectsForm));
            this.gridViewIngredientRank = new System.Windows.Forms.DataGridView();
            this.gridViewPotionRank = new System.Windows.Forms.DataGridView();
            this.gridViewEffectType = new System.Windows.Forms.DataGridView();
            this.lbl_ingredientRanks = new System.Windows.Forms.Label();
            this.lbl_potionRanks = new System.Windows.Forms.Label();
            this.lbl_effectTypes = new System.Windows.Forms.Label();
            this.gridViewEffects = new System.Windows.Forms.DataGridView();
            this.lbl_effects = new System.Windows.Forms.Label();
            this.btn_loadEffects = new System.Windows.Forms.Button();
            this.btn_saveEffects = new System.Windows.Forms.Button();
            this.saveEffectDialog = new System.Windows.Forms.SaveFileDialog();
            this.openEffectDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIngredientRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPotionRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEffectType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEffects)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewIngredientRank
            // 
            this.gridViewIngredientRank.AllowUserToAddRows = false;
            this.gridViewIngredientRank.AllowUserToDeleteRows = false;
            this.gridViewIngredientRank.AllowUserToResizeColumns = false;
            this.gridViewIngredientRank.AllowUserToResizeRows = false;
            this.gridViewIngredientRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewIngredientRank.Location = new System.Drawing.Point(12, 48);
            this.gridViewIngredientRank.MultiSelect = false;
            this.gridViewIngredientRank.Name = "gridViewIngredientRank";
            this.gridViewIngredientRank.Size = new System.Drawing.Size(204, 160);
            this.gridViewIngredientRank.TabIndex = 3;
            this.gridViewIngredientRank.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewIngredientRank_CellContentClick);
            this.gridViewIngredientRank.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridViewIngredientRank_UserAddedRow);
            this.gridViewIngredientRank.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridViewIngredientRank_UserDeletedRow);
            // 
            // gridViewPotionRank
            // 
            this.gridViewPotionRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPotionRank.Location = new System.Drawing.Point(232, 48);
            this.gridViewPotionRank.Name = "gridViewPotionRank";
            this.gridViewPotionRank.Size = new System.Drawing.Size(204, 160);
            this.gridViewPotionRank.TabIndex = 5;
            // 
            // gridViewEffectType
            // 
            this.gridViewEffectType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewEffectType.Location = new System.Drawing.Point(452, 48);
            this.gridViewEffectType.Name = "gridViewEffectType";
            this.gridViewEffectType.Size = new System.Drawing.Size(204, 160);
            this.gridViewEffectType.TabIndex = 7;
            // 
            // lbl_ingredientRanks
            // 
            this.lbl_ingredientRanks.AutoSize = true;
            this.lbl_ingredientRanks.Location = new System.Drawing.Point(12, 32);
            this.lbl_ingredientRanks.Name = "lbl_ingredientRanks";
            this.lbl_ingredientRanks.Size = new System.Drawing.Size(91, 13);
            this.lbl_ingredientRanks.TabIndex = 2;
            this.lbl_ingredientRanks.Text = "Ingredient Ranks:";
            // 
            // lbl_potionRanks
            // 
            this.lbl_potionRanks.AutoSize = true;
            this.lbl_potionRanks.Location = new System.Drawing.Point(232, 32);
            this.lbl_potionRanks.Name = "lbl_potionRanks";
            this.lbl_potionRanks.Size = new System.Drawing.Size(74, 13);
            this.lbl_potionRanks.TabIndex = 4;
            this.lbl_potionRanks.Text = "Potion Ranks:";
            // 
            // lbl_effectTypes
            // 
            this.lbl_effectTypes.AutoSize = true;
            this.lbl_effectTypes.Location = new System.Drawing.Point(452, 32);
            this.lbl_effectTypes.Name = "lbl_effectTypes";
            this.lbl_effectTypes.Size = new System.Drawing.Size(70, 13);
            this.lbl_effectTypes.TabIndex = 6;
            this.lbl_effectTypes.Text = "Effect Types:";
            // 
            // gridViewEffects
            // 
            this.gridViewEffects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewEffects.Location = new System.Drawing.Point(12, 232);
            this.gridViewEffects.Name = "gridViewEffects";
            this.gridViewEffects.Size = new System.Drawing.Size(384, 160);
            this.gridViewEffects.TabIndex = 9;
            // 
            // lbl_effects
            // 
            this.lbl_effects.AutoSize = true;
            this.lbl_effects.Location = new System.Drawing.Point(12, 216);
            this.lbl_effects.Name = "lbl_effects";
            this.lbl_effects.Size = new System.Drawing.Size(43, 13);
            this.lbl_effects.TabIndex = 8;
            this.lbl_effects.Text = "Effects:";
            // 
            // btn_loadEffects
            // 
            this.btn_loadEffects.Location = new System.Drawing.Point(12, 4);
            this.btn_loadEffects.Name = "btn_loadEffects";
            this.btn_loadEffects.Size = new System.Drawing.Size(96, 23);
            this.btn_loadEffects.TabIndex = 0;
            this.btn_loadEffects.Text = "Load Effects";
            this.btn_loadEffects.UseVisualStyleBackColor = true;
            this.btn_loadEffects.Click += new System.EventHandler(this.btn_loadEffects_Click);
            // 
            // btn_saveEffects
            // 
            this.btn_saveEffects.Location = new System.Drawing.Point(128, 4);
            this.btn_saveEffects.Name = "btn_saveEffects";
            this.btn_saveEffects.Size = new System.Drawing.Size(96, 23);
            this.btn_saveEffects.TabIndex = 1;
            this.btn_saveEffects.Text = "Save Effects";
            this.btn_saveEffects.UseVisualStyleBackColor = true;
            this.btn_saveEffects.Click += new System.EventHandler(this.btn_saveEffects_Click);
            // 
            // saveEffectDialog
            // 
            this.saveEffectDialog.DefaultExt = "json";
            this.saveEffectDialog.FileName = "PotionEffects";
            this.saveEffectDialog.Filter = "\"JSON|*.json|All files|*.*\"";
            // 
            // openEffectDialog
            // 
            this.openEffectDialog.DefaultExt = "json";
            this.openEffectDialog.FileName = "PotionEffects";
            this.openEffectDialog.Filter = "\"JSON|*.json|All files|*.*\"";
            // 
            // EffectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 409);
            this.Controls.Add(this.btn_saveEffects);
            this.Controls.Add(this.btn_loadEffects);
            this.Controls.Add(this.lbl_effects);
            this.Controls.Add(this.gridViewEffects);
            this.Controls.Add(this.lbl_effectTypes);
            this.Controls.Add(this.lbl_potionRanks);
            this.Controls.Add(this.lbl_ingredientRanks);
            this.Controls.Add(this.gridViewEffectType);
            this.Controls.Add(this.gridViewPotionRank);
            this.Controls.Add(this.gridViewIngredientRank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(696, 452);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(696, 452);
            this.Name = "EffectsForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Edit Effects Lists";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIngredientRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPotionRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEffectType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEffects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewIngredientRank;
        private System.Windows.Forms.DataGridView gridViewPotionRank;
        private System.Windows.Forms.DataGridView gridViewEffectType;
        private System.Windows.Forms.DataGridView gridViewEffects;
        private System.Windows.Forms.Label lbl_ingredientRanks;
        private System.Windows.Forms.Label lbl_potionRanks;
        private System.Windows.Forms.Label lbl_effectTypes;
        private System.Windows.Forms.Label lbl_effects;
        private System.Windows.Forms.Button btn_loadEffects;
        private System.Windows.Forms.Button btn_saveEffects;
        private System.Windows.Forms.OpenFileDialog openEffectDialog;
        private System.Windows.Forms.SaveFileDialog saveEffectDialog;
    }
}