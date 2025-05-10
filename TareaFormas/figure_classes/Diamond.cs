using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaFormas.figure_classes
{
    internal class Diamond : Control
    {
        private float dSide;
        private float dDiagD
        {
            get => inputA;
            set => inputA = value;
        }

        private float dDiagd
        {
            get => inputB;
            set => inputB = value;
        }
        public Diamond()
        {
            dSide = 0.0f;
        }

        public virtual void ReadData(TextBox txtInputA, TextBox txtInputB, TextBox txtInputSide)
        {
            try
            {
                inputA = float.Parse(txtInputA.Text);
                inputB = float.Parse(txtInputB.Text);
                dSide = float.Parse(txtInputSide.Text);

                if (inputA < 0 || inputB < 0 || dSide < 0)
                {
                    MessageBox.Show("No pueden haber ingresos negativos", "mensaje de error");
                    inputA = 0.0f; inputB = 0.0f;
                    dSide = 0.0f;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void initializeData(TextBox txtInputA, TextBox txtInputB, TextBox txtInputSide, TextBox txtPerimeter, TextBox txtArea)
        {
            inputA = 0.0f; inputB = 0.0f;
            dSide = 0.0f;
            perimeter = 0.0f; area = 0.0f;

            txtInputA.Text = ""; txtInputB.Text = "";
            txtInputSide.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            txtInputA.Focus();
        }

        public void calculatePerimeter()
        {
            perimeter = 4 * dSide;
        }
        public void calculateArea()
        {
            area = dDiagD * dDiagd / 2;
        }
    }
}
