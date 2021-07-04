
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
            this.NomLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridSaccoche = new System.Windows.Forms.DataGridView();
            this.HeroID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataHeroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NiveauBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuissanceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RéussiteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSaccoche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroID)).BeginInit();
            this.SuspendLayout();
            // 
            // dataHeroGrid
            // 
            this.dataHeroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHeroGrid.Location = new System.Drawing.Point(375, 22);
            this.dataHeroGrid.Name = "dataHeroGrid";
            this.dataHeroGrid.Size = new System.Drawing.Size(865, 277);
            this.dataHeroGrid.TabIndex = 0;
            this.dataHeroGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHeroGrid_CellContentClick);
            this.dataHeroGrid.SelectionChanged += new System.EventHandler(this.dataHeroGrid_SelectionChanged);
            // 
            // ModifierHero
            // 
            this.ModifierHero.Location = new System.Drawing.Point(138, 270);
            this.ModifierHero.Name = "ModifierHero";
            this.ModifierHero.Size = new System.Drawing.Size(110, 29);
            this.ModifierHero.TabIndex = 1;
            this.ModifierHero.Text = "Modifier";
            this.ModifierHero.UseVisualStyleBackColor = true;
            this.ModifierHero.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // NomBox
            // 
            this.NomBox.Location = new System.Drawing.Point(138, 22);
            this.NomBox.Name = "NomBox";
            this.NomBox.Size = new System.Drawing.Size(231, 20);
            this.NomBox.TabIndex = 2;
            // 
            // PrénomBox
            // 
            this.PrénomBox.Location = new System.Drawing.Point(138, 48);
            this.PrénomBox.Name = "PrénomBox";
            this.PrénomBox.Size = new System.Drawing.Size(231, 20);
            this.PrénomBox.TabIndex = 3;
            // 
            // SpéBox
            // 
            this.SpéBox.Location = new System.Drawing.Point(138, 74);
            this.SpéBox.Name = "SpéBox";
            this.SpéBox.Size = new System.Drawing.Size(231, 20);
            this.SpéBox.TabIndex = 4;
            // 
            // ClasseBox
            // 
            this.ClasseBox.Location = new System.Drawing.Point(138, 100);
            this.ClasseBox.Name = "ClasseBox";
            this.ClasseBox.Size = new System.Drawing.Size(231, 20);
            this.ClasseBox.TabIndex = 5;
            // 
            // RéputBox
            // 
            this.RéputBox.Location = new System.Drawing.Point(138, 204);
            this.RéputBox.Name = "RéputBox";
            this.RéputBox.Size = new System.Drawing.Size(231, 20);
            this.RéputBox.TabIndex = 9;
            // 
            // NiveauBox
            // 
            this.NiveauBox.Location = new System.Drawing.Point(138, 126);
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
            this.PuissanceBox.Location = new System.Drawing.Point(138, 152);
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
            this.RéussiteBox.Location = new System.Drawing.Point(138, 178);
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
            this.SupprimerHero.Location = new System.Drawing.Point(259, 270);
            this.SupprimerHero.Name = "SupprimerHero";
            this.SupprimerHero.Size = new System.Drawing.Size(110, 29);
            this.SupprimerHero.TabIndex = 13;
            this.SupprimerHero.Text = "Supprimer";
            this.SupprimerHero.UseVisualStyleBackColor = true;
            this.SupprimerHero.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // AjouterHero
            // 
            this.AjouterHero.Location = new System.Drawing.Point(12, 270);
            this.AjouterHero.Name = "AjouterHero";
            this.AjouterHero.Size = new System.Drawing.Size(110, 29);
            this.AjouterHero.TabIndex = 14;
            this.AjouterHero.Text = "Ajouter";
            this.AjouterHero.UseVisualStyleBackColor = true;
            this.AjouterHero.Click += new System.EventHandler(this.AjouterHero_Click);
            // 
            // NomLabel
            // 
            this.NomLabel.AutoSize = true;
            this.NomLabel.Location = new System.Drawing.Point(77, 22);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(55, 13);
            this.NomLabel.TabIndex = 15;
            this.NomLabel.Text = "Nom Héro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Prénom Héro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Spécialité Héro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Classe Héro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Niveau Héro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Puissance Héro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Réussite Héro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Réputation Héro";
            // 
            // dataGridSaccoche
            // 
            this.dataGridSaccoche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSaccoche.Location = new System.Drawing.Point(375, 352);
            this.dataGridSaccoche.Name = "dataGridSaccoche";
            this.dataGridSaccoche.Size = new System.Drawing.Size(865, 222);
            this.dataGridSaccoche.TabIndex = 25;
            // 
            // HeroID
            // 
            this.HeroID.Location = new System.Drawing.Point(177, 241);
            this.HeroID.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.HeroID.Name = "HeroID";
            this.HeroID.Size = new System.Drawing.Size(120, 20);
            this.HeroID.TabIndex = 26;
            this.HeroID.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.HeroID.Visible = false;
            this.HeroID.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // GuildeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 595);
            this.Controls.Add(this.HeroID);
            this.Controls.Add(this.dataGridSaccoche);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSaccoche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroID)).EndInit();
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
        private System.Windows.Forms.Label NomLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridSaccoche;
        private System.Windows.Forms.NumericUpDown HeroID;
    }
}