
namespace GuildManage
{
    partial class GuildeView
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
            this.dataHeroGrid = new System.Windows.Forms.DataGridView();
            this.ModifierHero = new System.Windows.Forms.Button();
            this.NomBox = new System.Windows.Forms.TextBox();
            this.PrénomBox = new System.Windows.Forms.TextBox();
            this.SpéBox = new System.Windows.Forms.TextBox();
            this.ClasseBox = new System.Windows.Forms.TextBox();
            this.RéputBox = new System.Windows.Forms.TextBox();
            this.NiveauBox = new System.Windows.Forms.NumericUpDown();
            this.PuissanceBox = new System.Windows.Forms.NumericUpDown();
            this.RéussiteBox = new System.Windows.Forms.NumericUpDown();
            this.SupprimerHero = new System.Windows.Forms.Button();
            this.AjouterHero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataHeroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NiveauBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuissanceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RéussiteBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataHeroGrid
            // 
            this.dataHeroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHeroGrid.Location = new System.Drawing.Point(428, 22);
            this.dataHeroGrid.Name = "dataHeroGrid";
            this.dataHeroGrid.Size = new System.Drawing.Size(812, 358);
            this.dataHeroGrid.TabIndex = 0;
            this.dataHeroGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHeroGrid_CellContentClick);
            this.dataHeroGrid.SelectionChanged += new System.EventHandler(this.dataHeroGrid_SelectionChanged);
            // 
            // ModifierHero
            // 
            this.ModifierHero.Location = new System.Drawing.Point(22, 446);
            this.ModifierHero.Name = "ModifierHero";
            this.ModifierHero.Size = new System.Drawing.Size(110, 29);
            this.ModifierHero.TabIndex = 1;
            this.ModifierHero.Text = "Modifier";
            this.ModifierHero.UseVisualStyleBackColor = true;
            this.ModifierHero.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // NomBox
            // 
            this.NomBox.Location = new System.Drawing.Point(174, 22);
            this.NomBox.Name = "NomBox";
            this.NomBox.Size = new System.Drawing.Size(231, 20);
            this.NomBox.TabIndex = 2;
            // 
            // PrénomBox
            // 
            this.PrénomBox.Location = new System.Drawing.Point(174, 48);
            this.PrénomBox.Name = "PrénomBox";
            this.PrénomBox.Size = new System.Drawing.Size(231, 20);
            this.PrénomBox.TabIndex = 3;
            // 
            // SpéBox
            // 
            this.SpéBox.Location = new System.Drawing.Point(174, 74);
            this.SpéBox.Name = "SpéBox";
            this.SpéBox.Size = new System.Drawing.Size(231, 20);
            this.SpéBox.TabIndex = 4;
            // 
            // ClasseBox
            // 
            this.ClasseBox.Location = new System.Drawing.Point(174, 100);
            this.ClasseBox.Name = "ClasseBox";
            this.ClasseBox.Size = new System.Drawing.Size(231, 20);
            this.ClasseBox.TabIndex = 5;
            // 
            // RéputBox
            // 
            this.RéputBox.Location = new System.Drawing.Point(174, 204);
            this.RéputBox.Name = "RéputBox";
            this.RéputBox.Size = new System.Drawing.Size(231, 20);
            this.RéputBox.TabIndex = 9;
            // 
            // NiveauBox
            // 
            this.NiveauBox.Location = new System.Drawing.Point(174, 126);
            this.NiveauBox.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.NiveauBox.Name = "NiveauBox";
            this.NiveauBox.Size = new System.Drawing.Size(231, 20);
            this.NiveauBox.TabIndex = 10;
            // 
            // PuissanceBox
            // 
            this.PuissanceBox.Location = new System.Drawing.Point(174, 152);
            this.PuissanceBox.Maximum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.PuissanceBox.Name = "PuissanceBox";
            this.PuissanceBox.Size = new System.Drawing.Size(231, 20);
            this.PuissanceBox.TabIndex = 11;
            // 
            // RéussiteBox
            // 
            this.RéussiteBox.Location = new System.Drawing.Point(174, 178);
            this.RéussiteBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.RéussiteBox.Name = "RéussiteBox";
            this.RéussiteBox.Size = new System.Drawing.Size(231, 20);
            this.RéussiteBox.TabIndex = 12;
            // 
            // SupprimerHero
            // 
            this.SupprimerHero.Location = new System.Drawing.Point(150, 446);
            this.SupprimerHero.Name = "SupprimerHero";
            this.SupprimerHero.Size = new System.Drawing.Size(110, 29);
            this.SupprimerHero.TabIndex = 13;
            this.SupprimerHero.Text = "Supprimer";
            this.SupprimerHero.UseVisualStyleBackColor = true;
            this.SupprimerHero.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // AjouterHero
            // 
            this.AjouterHero.Location = new System.Drawing.Point(266, 446);
            this.AjouterHero.Name = "AjouterHero";
            this.AjouterHero.Size = new System.Drawing.Size(110, 29);
            this.AjouterHero.TabIndex = 14;
            this.AjouterHero.Text = "Ajouter";
            this.AjouterHero.UseVisualStyleBackColor = true;
            this.AjouterHero.Click += new System.EventHandler(this.AjouterHero_Click);
            // 
            // GuildeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 595);
            this.Controls.Add(this.AjouterHero);
            this.Controls.Add(this.SupprimerHero);
            this.Controls.Add(this.RéussiteBox);
            this.Controls.Add(this.PuissanceBox);
            this.Controls.Add(this.NiveauBox);
            this.Controls.Add(this.RéputBox);
            this.Controls.Add(this.ClasseBox);
            this.Controls.Add(this.SpéBox);
            this.Controls.Add(this.PrénomBox);
            this.Controls.Add(this.NomBox);
            this.Controls.Add(this.ModifierHero);
            this.Controls.Add(this.dataHeroGrid);
            this.Name = "GuildeView";
            this.Text = "GuildeView";
            this.Load += new System.EventHandler(this.GuildeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHeroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NiveauBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuissanceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RéussiteBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataHeroGrid;
        private System.Windows.Forms.Button ModifierHero;
        private System.Windows.Forms.TextBox NomBox;
        private System.Windows.Forms.TextBox PrénomBox;
        private System.Windows.Forms.TextBox SpéBox;
        private System.Windows.Forms.TextBox ClasseBox;
        private System.Windows.Forms.TextBox RéputBox;
        private System.Windows.Forms.NumericUpDown NiveauBox;
        private System.Windows.Forms.NumericUpDown PuissanceBox;
        private System.Windows.Forms.NumericUpDown RéussiteBox;
        private System.Windows.Forms.Button SupprimerHero;
        private System.Windows.Forms.Button AjouterHero;
    }
}