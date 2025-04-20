using System.Drawing;
using System.Windows.Forms;

namespace calculatrice
{
    partial class Calculatrice
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.P_background_numbers_symbols = new System.Windows.Forms.Panel();
            this.P_historique = new System.Windows.Forms.Panel();
            this.P_results = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.P_background_numbers_symbols.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_background_numbers_symbols
            // 
            this.P_background_numbers_symbols.BackColor = System.Drawing.Color.Honeydew;
            this.P_background_numbers_symbols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_background_numbers_symbols.Controls.Add(this.panel1);
            this.P_background_numbers_symbols.Location = new System.Drawing.Point(0, 115);
            this.P_background_numbers_symbols.Name = "P_background_numbers_symbols";
            this.P_background_numbers_symbols.Size = new System.Drawing.Size(656, 260);
            this.P_background_numbers_symbols.TabIndex = 0;
            // 
            // P_historique
            // 
            this.P_historique.BackColor = System.Drawing.Color.IndianRed;
            this.P_historique.Location = new System.Drawing.Point(655, 0);
            this.P_historique.Name = "P_historique";
            this.P_historique.Size = new System.Drawing.Size(231, 377);
            this.P_historique.TabIndex = 1;
            // 
            // P_results
            // 
            this.P_results.BackColor = System.Drawing.Color.Turquoise;
            this.P_results.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.P_results.ForeColor = System.Drawing.Color.White;
            this.P_results.Location = new System.Drawing.Point(0, 0);
            this.P_results.Name = "P_results";
            this.P_results.Size = new System.Drawing.Size(656, 121);
            this.P_results.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(386, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // Calculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(883, 375);
            this.Controls.Add(this.P_results);
            this.Controls.Add(this.P_historique);
            this.Controls.Add(this.P_background_numbers_symbols);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculatrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.P_background_numbers_symbols.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel P_background_numbers_symbols;
        private Panel P_historique;
        private Panel P_results;
        private Panel panel1;
    }
}

