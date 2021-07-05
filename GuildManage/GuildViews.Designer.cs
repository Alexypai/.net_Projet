
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.QuantiteObjetBox = new System.Windows.Forms.NumericUpDown();
            this.PrixObjetBox = new System.Windows.Forms.NumericUpDown();
            this.LvlObjetBox = new System.Windows.Forms.NumericUpDown();
            this.DesObjetBox = new System.Windows.Forms.TextBox();
            this.NomObjetBox = new System.Windows.Forms.TextBox();
            this.AjoutObjet = new System.Windows.Forms.Button();
            this.SupprimerObjet = new System.Windows.Forms.Button();
            this.ModifierObjet = new System.Windows.Forms.Button();
            this.ObjetID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataHeroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NiveauBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuissanceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RéussiteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSaccoche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantiteObjetBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrixObjetBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LvlObjetBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjetID)).BeginInit();
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
            this.dataGridSaccoche.SelectionChanged += new System.EventHandler(this.dataGridSaccoche_SelectionChanged);
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
            this.HeroID.Visible = false;
            this.HeroID.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Quantité Objet";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Prix Objet";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Niveau Objet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Description Objet";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(75, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Nom Objet";
            // 
            // QuantiteObjetBox
            // 
            this.QuantiteObjetBox.Location = new System.Drawing.Point(138, 475);
            this.QuantiteObjetBox.Name = "QuantiteObjetBox";
            this.QuantiteObjetBox.Size = new System.Drawing.Size(231, 20);
            this.QuantiteObjetBox.TabIndex = 34;
            // 
            // PrixObjetBox
            // 
            this.PrixObjetBox.Location = new System.Drawing.Point(138, 449);
            this.PrixObjetBox.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.PrixObjetBox.Name = "PrixObjetBox";
            this.PrixObjetBox.Size = new System.Drawing.Size(231, 20);
            this.PrixObjetBox.TabIndex = 33;
            // 
            // LvlObjetBox
            // 
            this.LvlObjetBox.Location = new System.Drawing.Point(138, 423);
            this.LvlObjetBox.Maximum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.LvlObjetBox.Name = "LvlObjetBox";
            this.LvlObjetBox.Size = new System.Drawing.Size(231, 20);
            this.LvlObjetBox.TabIndex = 32;
            // 
            // DesObjetBox
            // 
            this.DesObjetBox.Location = new System.Drawing.Point(138, 397);
            this.DesObjetBox.Name = "DesObjetBox";
            this.DesObjetBox.Size = new System.Drawing.Size(231, 20);
            this.DesObjetBox.TabIndex = 31;
            // 
            // NomObjetBox
            // 
            this.NomObjetBox.Location = new System.Drawing.Point(138, 371);
            this.NomObjetBox.Name = "NomObjetBox";
            this.NomObjetBox.Size = new System.Drawing.Size(231, 20);
            this.NomObjetBox.TabIndex = 30;
            // 
            // AjoutObjet
            // 
            this.AjoutObjet.Location = new System.Drawing.Point(12, 545);
            this.AjoutObjet.Name = "AjoutObjet";
            this.AjoutObjet.Size = new System.Drawing.Size(110, 29);
            this.AjoutObjet.TabIndex = 42;
            this.AjoutObjet.Text = "Ajouter";
            this.AjoutObjet.UseVisualStyleBackColor = true;
            this.AjoutObjet.Click += new System.EventHandler(this.AjoutObjet_Click);
            // 
            // SupprimerObjet
            // 
            this.SupprimerObjet.Location = new System.Drawing.Point(259, 545);
            this.SupprimerObjet.Name = "SupprimerObjet";
            this.SupprimerObjet.Size = new System.Drawing.Size(110, 29);
            this.SupprimerObjet.TabIndex = 41;
            this.SupprimerObjet.Text = "Supprimer";
            this.SupprimerObjet.UseVisualStyleBackColor = true;
            this.SupprimerObjet.Click += new System.EventHandler(this.SupprimerObjet_Click);
            // 
            // ModifierObjet
            // 
            this.ModifierObjet.Location = new System.Drawing.Point(138, 545);
            this.ModifierObjet.Name = "ModifierObjet";
            this.ModifierObjet.Size = new System.Drawing.Size(110, 29);
            this.ModifierObjet.TabIndex = 40;
            this.ModifierObjet.Text = "Modifier";
            this.ModifierObjet.UseVisualStyleBackColor = true;
            this.ModifierObjet.Click += new System.EventHandler(this.ModifierObjet_Click);
            // 
            // ObjetID
            // 
            this.ObjetID.Location = new System.Drawing.Point(177, 519);
            this.ObjetID.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.ObjetID.Name = "ObjetID";
            this.ObjetID.Size = new System.Drawing.Size(120, 20);
            this.ObjetID.TabIndex = 43;
            this.ObjetID.CursorChanged += new System.EventHandler(this.ObjetID_CursorChanged);
            // 
            // GuildeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 595);
            this.Controls.Add(this.ObjetID);
            this.Controls.Add(this.AjoutObjet);
            this.Controls.Add(this.SupprimerObjet);
            this.Controls.Add(this.ModifierObjet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.QuantiteObjetBox);
            this.Controls.Add(this.PrixObjetBox);
            this.Controls.Add(this.LvlObjetBox);
            this.Controls.Add(this.DesObjetBox);
            this.Controls.Add(this.NomObjetBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.QuantiteObjetBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrixObjetBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LvlObjetBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjetID)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown QuantiteObjetBox;
        private System.Windows.Forms.NumericUpDown PrixObjetBox;
        private System.Windows.Forms.NumericUpDown LvlObjetBox;
        private System.Windows.Forms.TextBox DesObjetBox;
        private System.Windows.Forms.TextBox NomObjetBox;
        private System.Windows.Forms.Button AjoutObjet;
        private System.Windows.Forms.Button SupprimerObjet;
        private System.Windows.Forms.Button ModifierObjet;
        private System.Windows.Forms.NumericUpDown ObjetID;
    }
}