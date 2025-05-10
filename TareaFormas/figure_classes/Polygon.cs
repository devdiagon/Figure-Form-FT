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
        private float pApothem;
        private float pSide
        {
            get => inputA;
            set => inputA = value;
        }
        public Polygon()
        {
            pSideQuantity = 0;
            pApothem = 0.0f;
        }

        private void computeApothem()
        {
            pApothem = pSide / (2 * (float)Math.Tan(Math.PI/ pSideQuantity));
        }

        public virtual void ReadData(TextBox txtInputSide, ListBox lstInputSides)
        {
            try
            {
                pSide = float.Parse(txtInputSide.Text);
                pSideQuantity = int.Parse(lstInputSides.SelectedItem.ToString());

                if (pSide < 0 || pSideQuantity < 0)
                {
                    MessageBox.Show("No pueden haber ingresos negativos", "mensaje de error");
                    pSide = 0.0f;
                }

                if(pSideQuantity < 5)
                {
                    MessageBox.Show("Inserte un mínimo de 5 lados para el polígono", "mensaje de error");
                    pSideQuantity = 0;
                }

                computeApothem();
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void initializeData(TextBox txtInputSide, ListBox lstInputSides, TextBox txtPerimeter, TextBox txtArea)
        {
            pSide = 0.0f; pApothem = 0.0f;
            pSideQuantity = 0;
            perimeter = 0.0f; area = 0.0f;

            txtInputSide.Text = "";
            lstInputSides.SelectedIndex = 0;
            txtPerimeter.Text = ""; txtArea.Text = "";

            txtInputSide.Focus();
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
