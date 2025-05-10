using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaFormas.figure_classes
{
    internal class Polygon : Control
    {
        private int pSideQuantity;
        private float pSide
        {
            get => inputA;
            set => inputA = value;
        }

        private float pApothem
        {
            get => inputB;
            set => inputB = value;
        }

        public Polygon()
        {
            pSideQuantity = 0;
        }

        public virtual void ReadData(TextBox txtInputA, TextBox txtInputB, ListBox lstInputSides)
        {
            try
            {
                inputA = float.Parse(txtInputA.Text);
                inputB = float.Parse(txtInputB.Text);
                pSideQuantity = int.Parse(lstInputSides.SelectedItem.ToString());

                if (inputA < 0 || inputB < 0 || pSideQuantity < 0)
                {
                    MessageBox.Show("No pueden haber ingresos negativos", "mensaje de error");
                    inputA = 0.0f; inputB = 0.0f;
                }

                if(pSideQuantity < 5)
                {
                    MessageBox.Show("Inserte un mínimo de 5 lados para el polígono", "mensaje de error");
                    pSideQuantity = 0;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void initializeData(TextBox txtInputA, TextBox txtInputB, ListBox lstInputSides, TextBox txtPerimeter, TextBox txtArea)
        {
            inputA = 0.0f; inputB = 0.0f;
            pSideQuantity = 0;
            perimeter = 0.0f; area = 0.0f;

            txtInputA.Text = ""; txtInputB.Text = "";
            lstInputSides.SelectedIndex = 0;
            txtPerimeter.Text = ""; txtArea.Text = "";

            txtInputA.Focus();
        }

        public void calculatePerimeter()
        {
            perimeter = pSideQuantity * pSide;
        }
        public void calculateArea()
        {
            area = perimeter * pApothem / 2;
        }
    }
}
