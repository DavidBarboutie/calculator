﻿using System.Drawing;
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
            this.b_clear = new System.Windows.Forms.Button();
            this.b_7 = new System.Windows.Forms.Button();
            this.b_4 = new System.Windows.Forms.Button();
            this.b_1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.b_8 = new System.Windows.Forms.Button();
            this.b_5 = new System.Windows.Forms.Button();
            this.b_2 = new System.Windows.Forms.Button();
            this.b_0 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.b_9 = new System.Windows.Forms.Button();
            this.b_6 = new System.Windows.Forms.Button();
            this.b_3 = new System.Windows.Forms.Button();
            this.b_dot = new System.Windows.Forms.Button();
            this.B_egual = new System.Windows.Forms.Button();
            this.b_plus = new System.Windows.Forms.Button();
            this.b_minus = new System.Windows.Forms.Button();
            this.b_mutliply = new System.Windows.Forms.Button();
            this.b_divide = new System.Windows.Forms.Button();
            this.P_historique = new System.Windows.Forms.Panel();
            this.P_results = new System.Windows.Forms.Panel();
            this.L_view = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.P_background_numbers_symbols.SuspendLayout();
            this.panel1.SuspendLayout();
            this.P_results.SuspendLayout();
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
            this.panel1.Controls.Add(this.b_clear);
            this.panel1.Controls.Add(this.b_7);
            this.panel1.Controls.Add(this.b_4);
            this.panel1.Controls.Add(this.b_1);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.b_8);
            this.panel1.Controls.Add(this.b_5);
            this.panel1.Controls.Add(this.b_2);
            this.panel1.Controls.Add(this.b_0);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.b_9);
            this.panel1.Controls.Add(this.b_6);
            this.panel1.Controls.Add(this.b_3);
            this.panel1.Controls.Add(this.b_dot);
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
            // b_clear
            // 
            this.b_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.b_clear.FlatAppearance.BorderSize = 0;
            this.b_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_clear.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_clear.Location = new System.Drawing.Point(1, 1);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new System.Drawing.Size(82, 50);
            this.b_clear.TabIndex = 19;
            this.b_clear.Text = "C";
            this.b_clear.UseVisualStyleBackColor = false;
            this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
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
            this.b_7.Click += new System.EventHandler(this.b_7_Click);
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
            this.b_4.Click += new System.EventHandler(this.b_4_Click);
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
            this.b_1.Click += new System.EventHandler(this.b_1_Click);
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
            this.b_8.Click += new System.EventHandler(this.b_8_Click);
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
            this.b_5.Click += new System.EventHandler(this.b_5_Click);
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
            this.b_2.Click += new System.EventHandler(this.b_2_Click);
            // 
            // b_0
            // 
            this.b_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.b_0.FlatAppearance.BorderSize = 0;
            this.b_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_0.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_0.Location = new System.Drawing.Point(1, 205);
            this.b_0.Name = "b_0";
            this.b_0.Size = new System.Drawing.Size(165, 50);
            this.b_0.TabIndex = 10;
            this.b_0.Text = "0";
            this.b_0.UseVisualStyleBackColor = false;
            this.b_0.Click += new System.EventHandler(this.b_0_Click);
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
            this.b_9.Click += new System.EventHandler(this.b_9_Click);
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
            this.b_6.Click += new System.EventHandler(this.b_6_Click);
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
            this.b_3.Click += new System.EventHandler(this.b_3_Click);
            // 
            // b_dot
            // 
            this.b_dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.b_dot.FlatAppearance.BorderSize = 0;
            this.b_dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_dot.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_dot.Location = new System.Drawing.Point(167, 205);
            this.b_dot.Name = "b_dot";
            this.b_dot.Size = new System.Drawing.Size(82, 50);
            this.b_dot.TabIndex = 5;
            this.b_dot.Text = ".";
            this.b_dot.UseVisualStyleBackColor = false;
            this.b_dot.Click += new System.EventHandler(this.b_dot_Click);
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
            this.B_egual.Click += new System.EventHandler(this.B_egual_Click);
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
            this.b_plus.Click += new System.EventHandler(this.b_plus_Click);
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
            this.b_minus.Click += new System.EventHandler(this.b_minus_Click);
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
            this.b_mutliply.Click += new System.EventHandler(this.b_mutliply_Click);
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
            this.b_divide.Click += new System.EventHandler(this.b_divide_Click);
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
            this.P_results.BackColor = System.Drawing.Color.Black;
            this.P_results.Controls.Add(this.L_view);
            this.P_results.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.P_results.ForeColor = System.Drawing.Color.White;
            this.P_results.Location = new System.Drawing.Point(0, -2);
            this.P_results.Name = "P_results";
            this.P_results.Size = new System.Drawing.Size(656, 121);
            this.P_results.TabIndex = 2;
            // 
            // L_view
            // 
            this.L_view.AutoSize = true;
            this.L_view.BackColor = System.Drawing.Color.Black;
            this.L_view.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_view.Location = new System.Drawing.Point(592, 54);
            this.L_view.Name = "L_view";
            this.L_view.Size = new System.Drawing.Size(86, 32);
            this.L_view.TabIndex = 0;
            this.L_view.Text = "label1";
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
            this.Name = "Calculatrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculatrice_Load);
            this.P_background_numbers_symbols.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.P_results.ResumeLayout(false);
            this.P_results.PerformLayout();
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
        private Button b_dot;
        private Button button10;
        private Button b_8;
        private Button b_5;
        private Button b_2;
        private Button b_0;
        private Button button5;
        private Button b_9;
        private Button b_6;
        private Button b_3;
        private Button b_clear;
        private Button b_7;
        private Button b_4;
        private Button b_1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label L_view;
    }
}

