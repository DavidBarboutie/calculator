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
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_egual = new System.Windows.Forms.Button();
            this.b_plus = new System.Windows.Forms.Button();
            this.b_minus = new System.Windows.Forms.Button();
            this.b_mutliply = new System.Windows.Forms.Button();
            this.b_divide = new System.Windows.Forms.Button();
            this.P_historique = new System.Windows.Forms.Panel();
            this.P_results = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.b_3 = new System.Windows.Forms.Button();
            this.b_6 = new System.Windows.Forms.Button();
            this.b_9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.b_0 = new System.Windows.Forms.Button();
            this.b_2 = new System.Windows.Forms.Button();
            this.b_5 = new System.Windows.Forms.Button();
            this.b_8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.b_1 = new System.Windows.Forms.Button();
            this.b_4 = new System.Windows.Forms.Button();
            this.b_7 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.P_background_numbers_symbols.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.b_7);
            this.panel1.Controls.Add(this.b_4);
            this.panel1.Controls.Add(this.b_1);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.b_8);
            this.panel1.Controls.Add(this.b_5);
            this.panel1.Controls.Add(this.b_2);
            this.panel1.Controls.Add(this.b_0);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.b_9);
            this.panel1.Controls.Add(this.b_6);
            this.panel1.Controls.Add(this.b_3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.B_egual);
            this.panel1.Controls.Add(this.b_plus);
            this.panel1.Controls.Add(this.b_minus);
            this.panel1.Controls.Add(this.b_mutliply);
            this.panel1.Controls.Add(this.b_divide);
            this.panel1.Location = new System.Drawing.Point(321, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 256);
            this.panel1.TabIndex = 0;
            // 
            // B_egual
            // 
            this.B_egual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.B_egual.FlatAppearance.BorderSize = 0;
            this.B_egual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_egual.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_egual.Location = new System.Drawing.Point(250, 205);
            this.B_egual.Name = "B_egual";
            this.B_egual.Size = new System.Drawing.Size(82, 50);
            this.B_egual.TabIndex = 4;
            this.B_egual.Text = "=";
            this.B_egual.UseVisualStyleBackColor = false;
            // 
            // b_plus
            // 
            this.b_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_plus.FlatAppearance.BorderSize = 0;
            this.b_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_plus.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_plus.Location = new System.Drawing.Point(250, 154);
            this.b_plus.Name = "b_plus";
            this.b_plus.Size = new System.Drawing.Size(82, 50);
            this.b_plus.TabIndex = 3;
            this.b_plus.Text = "+";
            this.b_plus.UseVisualStyleBackColor = false;
            // 
            // b_minus
            // 
            this.b_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_minus.FlatAppearance.BorderSize = 0;
            this.b_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_minus.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_minus.Location = new System.Drawing.Point(250, 103);
            this.b_minus.Name = "b_minus";
            this.b_minus.Size = new System.Drawing.Size(82, 50);
            this.b_minus.TabIndex = 2;
            this.b_minus.Text = "−";
            this.b_minus.UseVisualStyleBackColor = false;
            // 
            // b_mutliply
            // 
            this.b_mutliply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_mutliply.FlatAppearance.BorderSize = 0;
            this.b_mutliply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_mutliply.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_mutliply.Location = new System.Drawing.Point(250, 52);
            this.b_mutliply.Name = "b_mutliply";
            this.b_mutliply.Size = new System.Drawing.Size(82, 50);
            this.b_mutliply.TabIndex = 1;
            this.b_mutliply.Text = "×";
            this.b_mutliply.UseVisualStyleBackColor = false;
            // 
            // b_divide
            // 
            this.b_divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_divide.FlatAppearance.BorderSize = 0;
            this.b_divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_divide.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_divide.Location = new System.Drawing.Point(250, 1);
            this.b_divide.Name = "b_divide";
            this.b_divide.Size = new System.Drawing.Size(82, 50);
            this.b_divide.TabIndex = 0;
            this.b_divide.Text = "÷";
            this.b_divide.UseVisualStyleBackColor = false;
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
            this.P_results.Location = new System.Drawing.Point(0, -2);
            this.P_results.Name = "P_results";
            this.P_results.Size = new System.Drawing.Size(656, 121);
            this.P_results.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(167, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // b_3
            // 
            this.b_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.b_3.FlatAppearance.BorderSize = 0;
            this.b_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_3.Location = new System.Drawing.Point(167, 154);
            this.b_3.Name = "b_3";
            this.b_3.Size = new System.Drawing.Size(82, 50);
            this.b_3.TabIndex = 6;
            this.b_3.Text = "3";
            this.b_3.UseVisualStyleBackColor = false;
            // 
            // b_6
            // 
            this.b_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.b_6.FlatAppearance.BorderSize = 0;
            this.b_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_6.Location = new System.Drawing.Point(167, 103);
            this.b_6.Name = "b_6";
            this.b_6.Size = new System.Drawing.Size(82, 50);
            this.b_6.TabIndex = 7;
            this.b_6.Text = "6";
            this.b_6.UseVisualStyleBackColor = false;
            // 
            // b_9
            // 
            this.b_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.b_9.FlatAppearance.BorderSize = 0;
            this.b_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_9.Location = new System.Drawing.Point(167, 52);
            this.b_9.Name = "b_9";
            this.b_9.Size = new System.Drawing.Size(82, 50);
            this.b_9.TabIndex = 8;
            this.b_9.Text = "9";
            this.b_9.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(167, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 50);
            this.button5.TabIndex = 9;
            this.button5.Text = "=";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // b_0
            // 
            this.b_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.b_0.FlatAppearance.BorderSize = 0;
            this.b_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_0.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_0.Location = new System.Drawing.Point(84, 205);
            this.b_0.Name = "b_0";
            this.b_0.Size = new System.Drawing.Size(82, 50);
            this.b_0.TabIndex = 10;
            this.b_0.Text = "0";
            this.b_0.UseVisualStyleBackColor = false;
            // 
            // b_2
            // 
            this.b_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.b_2.FlatAppearance.BorderSize = 0;
            this.b_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_2.Location = new System.Drawing.Point(84, 154);
            this.b_2.Name = "b_2";
            this.b_2.Size = new System.Drawing.Size(82, 50);
            this.b_2.TabIndex = 11;
            this.b_2.Text = "2";
            this.b_2.UseVisualStyleBackColor = false;
            // 
            // b_5
            // 
            this.b_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.b_5.FlatAppearance.BorderSize = 0;
            this.b_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_5.Location = new System.Drawing.Point(84, 103);
            this.b_5.Name = "b_5";
            this.b_5.Size = new System.Drawing.Size(82, 50);
            this.b_5.TabIndex = 12;
            this.b_5.Text = "5";
            this.b_5.UseVisualStyleBackColor = false;
            // 
            // b_8
            // 
            this.b_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.b_8.FlatAppearance.BorderSize = 0;
            this.b_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_8.Location = new System.Drawing.Point(84, 52);
            this.b_8.Name = "b_8";
            this.b_8.Size = new System.Drawing.Size(82, 50);
            this.b_8.TabIndex = 13;
            this.b_8.Text = "8";
            this.b_8.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(84, 1);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(82, 50);
            this.button10.TabIndex = 14;
            this.button10.Text = "=";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1, 205);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(82, 50);
            this.button11.TabIndex = 15;
            this.button11.Text = "=";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // b_1
            // 
            this.b_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.b_1.FlatAppearance.BorderSize = 0;
            this.b_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_1.Location = new System.Drawing.Point(1, 154);
            this.b_1.Name = "b_1";
            this.b_1.Size = new System.Drawing.Size(82, 50);
            this.b_1.TabIndex = 16;
            this.b_1.Text = "1";
            this.b_1.UseVisualStyleBackColor = false;
            // 
            // b_4
            // 
            this.b_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.b_4.FlatAppearance.BorderSize = 0;
            this.b_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_4.Location = new System.Drawing.Point(1, 103);
            this.b_4.Name = "b_4";
            this.b_4.Size = new System.Drawing.Size(82, 50);
            this.b_4.TabIndex = 17;
            this.b_4.Text = "4";
            this.b_4.UseVisualStyleBackColor = false;
            // 
            // b_7
            // 
            this.b_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.b_7.FlatAppearance.BorderSize = 0;
            this.b_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_7.Location = new System.Drawing.Point(1, 52);
            this.b_7.Name = "b_7";
            this.b_7.Size = new System.Drawing.Size(82, 50);
            this.b_7.TabIndex = 18;
            this.b_7.Text = "7";
            this.b_7.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(1, 1);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(82, 50);
            this.button15.TabIndex = 19;
            this.button15.Text = "=";
            this.button15.UseVisualStyleBackColor = false;
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
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel P_background_numbers_symbols;
        private Panel P_historique;
        private Panel P_results;
        private Panel panel1;
        private Button B_egual;
        private Button b_plus;
        private Button b_minus;
        private Button b_mutliply;
        private Button b_divide;
        private Button button1;
        private Button button11;
        private Button button10;
        private Button b_8;
        private Button b_5;
        private Button b_2;
        private Button b_0;
        private Button button5;
        private Button b_9;
        private Button b_6;
        private Button b_3;
        private Button button15;
        private Button b_7;
        private Button b_4;
        private Button b_1;
    }
}

