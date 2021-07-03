
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
            ((System.ComponentModel.ISupportInitialize)(this.dataHeroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataHeroGrid
            // 
            this.dataHeroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHeroGrid.Location = new System.Drawing.Point(22, 22);
            this.dataHeroGrid.Name = "dataHeroGrid";
            this.dataHeroGrid.Size = new System.Drawing.Size(1218, 259);
            this.dataHeroGrid.TabIndex = 0;
            // 
            // GuildeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 595);
            this.Controls.Add(this.dataHeroGrid);
            this.Name = "GuildeView";
            this.Text = "GuildeView";
            this.Load += new System.EventHandler(this.GuildeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHeroGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataHeroGrid;
    }
}