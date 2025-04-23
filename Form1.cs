using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatrice
{
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
        }

        // user input
        string currentInput = "";
        // init value
        double firstOperand = 0;         
        string currentOperator = "";
        // for resets
        bool isNewInput = true;


        private void UpdateLabelText(string nouveauTexte)
        {
            //postion fixe de la droite du label
            int positionFixeDroite = 622;
            L_view.AutoSize = true;
            L_view.Text = nouveauTexte;

            // Repositionner le label pour qu’il s’étende vers la gauche
            int nouvelleLargeur = L_view.PreferredWidth;
            L_view.Left = positionFixeDroite - nouvelleLargeur;
        }

        //init to 0
        private void Calculatrice_Load(object sender, EventArgs e)
        {
            L_view.Text = firstOperand.ToString();
        }

        //numbers inputs
        private void b_1_Click(object sender, EventArgs e)
        {
            currentInput += b_1.Text;
            UpdateLabelText(currentInput);
        }

        private void b_2_Click(object sender, EventArgs e)
        {
            currentInput += b_2.Text;
            UpdateLabelText(currentInput);
        }

        private void b_3_Click(object sender, EventArgs e)
        {
            currentInput += b_3.Text;
            UpdateLabelText(currentInput);
        }

        private void b_4_Click(object sender, EventArgs e)
        {
            currentInput += b_4.Text;
            UpdateLabelText(currentInput);
        }

        private void b_5_Click(object sender, EventArgs e)
        {
            currentInput += b_5.Text;
            UpdateLabelText(currentInput);
        }

        private void b_6_Click(object sender, EventArgs e)
        {
            currentInput += b_6.Text;
            UpdateLabelText(currentInput);
        }

        private void b_7_Click(object sender, EventArgs e)
        {
            currentInput += b_7.Text;
            UpdateLabelText(currentInput);
        }

        private void b_8_Click(object sender, EventArgs e)
        {
            currentInput += b_8.Text;
            UpdateLabelText(currentInput);
        }

        private void b_9_Click(object sender, EventArgs e)
        {
            currentInput += b_9.Text;
            UpdateLabelText(currentInput);
        }

        private void b_0_Click(object sender, EventArgs e)
        {
            currentInput += b_0.Text;
            UpdateLabelText(currentInput);
        }

        private void b_dot_Click(object sender, EventArgs e)
        {
            // Séparer l'expression sur les opérateurs
            string[] parts = currentInput.Split('+', '-', '×', '÷');
            string lastNumber = parts.Last();

            // Vérifie qu'il n'y a pas déjà un point
            // Et que le dernier caractère est un chiffre (évite les "+." ou ".3")
            if (!lastNumber.Contains(".") && lastNumber.Length > 0 && char.IsDigit(lastNumber.Last()))
            {
                currentInput += ".";
                UpdateLabelText(currentInput);
            }
            // Cas spécial : début d'un nouveau nombre (ex: "3+" puis on clique sur ".")
            else if (lastNumber == "")
            {
                currentInput += "0.";
                UpdateLabelText(currentInput);
            }
        }

        //operators
        private void b_plus_Click(object sender, EventArgs e)
        {
            currentInput += "+";
            UpdateLabelText(currentInput);
        }

        private void b_minus_Click(object sender, EventArgs e)
        {
            currentInput += "-";
            UpdateLabelText(currentInput);
        }

        private void b_mutliply_Click(object sender, EventArgs e)
        {
            currentInput += "*";
            UpdateLabelText(currentInput);
        }
        private void b_divide_Click(object sender, EventArgs e)
        {
            currentInput += "/";
            UpdateLabelText(currentInput);

        }

        //quand le bouton egual est cliquer
        private void B_egual_Click(object sender, EventArgs e)
        {
            try
            {
                //Remplace les symboles spéciaux par les bons opérateurs
                string expression = currentInput.Replace("×", "*").Replace("÷", "/");

                //calcul de l'expression
                DataTable table = new DataTable();
                object resultObj = table.Compute(expression, "");

                double result = Convert.ToDouble(resultObj);

                // Affichage
                UpdateLabelText(result.ToString());

                // Mise à jour des variables pour les futurs calculs
                currentInput = result.ToString();
                firstOperand = result;
                isNewInput = true;
            }
            catch
            {
                UpdateLabelText("Erreur");
            }
        }

        private void b_clear_Click(object sender, EventArgs e)
        {
            currentInput = "";
            UpdateLabelText("");
        }
    }
}
