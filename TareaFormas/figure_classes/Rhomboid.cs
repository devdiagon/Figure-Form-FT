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

        public virtual void ReadData(TextBox txtInputA, TextBox txtInputB, TextBox txtInputHeight)
        {
            try
            {
                inputA = float.Parse(txtInputA.Text);
                inputB = float.Parse(txtInputB.Text);
                rHeight = float.Parse(txtInputHeight.Text);

                if (inputA < 0 || inputB < 0 || rHeight < 0)
                {
                    MessageBox.Show("No pueden haber ingresos negativos", "mensaje de error");
                    inputA = 0.0f; inputB = 0.0f;
                    rHeight = 0.0f;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void initializeData(TextBox txtInputA, TextBox txtInputB, TextBox txtInputHeight, TextBox txtPerimeter, TextBox txtArea)
        {
            inputA = 0.0f; inputB = 0.0f;
            rHeight = 0.0f;
            perimeter = 0.0f; area = 0.0f;

            txtInputA.Text = ""; txtInputB.Text = "";
            txtInputHeight.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            txtInputA.Focus();
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
