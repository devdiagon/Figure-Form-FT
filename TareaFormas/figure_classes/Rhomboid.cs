using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaFormas.figure_classes
{
    internal class Rhomboid : Control
    {
        private float rHeight;
        private float rSideA
        {
            get => inputA;
            set => inputA = value;
        }

        private float rSideB
        {
            get => inputB;
            set => inputB = value;
        }
        public Rhomboid() 
        {
            rHeight = 0.0f;
        }

        public virtual void ReadData(TextBox txtInputSideA, TextBox txtInputSideB, TextBox txtInputHeight)
        {
            try
            {
                rSideA = float.Parse(txtInputSideA.Text);
                rSideB = float.Parse(txtInputSideB.Text);
                rHeight = float.Parse(txtInputHeight.Text);

                if (rSideA < 0 || rSideB < 0 || rHeight < 0)
                {
                    MessageBox.Show("No pueden haber ingresos negativos", "mensaje de error");
                    rSideA = 0.0f; rSideB = 0.0f;
                    rHeight = 0.0f;
                    return;
                }

                if (rSideA == rSideB)
                {
                    MessageBox.Show("Un romboide tiene sus lados (a) y (b) diferentes", "mensaje de error");
                    rSideA = 0.0f; rSideB = 0.0f;
                    rHeight = 0.0f;
                    return;
                }

                if (rSideB <= rHeight)
                {
                    MessageBox.Show("El lado oblicuo (b) debe ser mayor que la altura", "mensaje de error");
                    rSideA = 0.0f; rSideB = 0.0f;
                    rHeight = 0.0f;
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void initializeData(TextBox txtInputSideA, TextBox txtInputSideB, TextBox txtInputHeight, TextBox txtPerimeter, TextBox txtArea)
        {
            rSideA = 0.0f; rSideB = 0.0f;
            rHeight = 0.0f;
            perimeter = 0.0f; area = 0.0f;

            txtInputSideA.Text = ""; txtInputSideB.Text = "";
            txtInputHeight.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            txtInputSideA.Focus();
        }

        public void calculatePerimeter()
        {
            perimeter = 2 * rSideA + 2 * rSideB;
        }
        public void calculateArea()
        {
            area = rSideA * rHeight;
        }
    }
}
