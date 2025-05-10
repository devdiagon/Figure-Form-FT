using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaFormas.figure_classes
{
    internal class Deltoid : Control
    {
        private float dSideA;
        private float dSideB;
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
        public Deltoid() 
        {
            dSideA = 0.0f; dSideB = 0.0f;
        }

        public virtual void ReadData(TextBox txtInputA, TextBox txtInputB, TextBox txtInputSideA, TextBox txtInputSideB)
        {
            try
            {
                inputA = float.Parse(txtInputA.Text);
                inputB = float.Parse(txtInputB.Text);
                dSideA = float.Parse(txtInputSideA.Text);
                dSideB = float.Parse(txtInputSideB.Text);

                if (inputA < 0 || inputB < 0 || dSideA < 0 || dSideB < 0)
                {
                    MessageBox.Show("No pueden haber ingresos negativos", "mensaje de error");
                    inputA = 0.0f; inputB = 0.0f;
                    dSideA = 0.0f; dSideB = 0.0f;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void initializeData(TextBox txtInputA, TextBox txtInputB, TextBox txtInputSideA, TextBox txtInputSideB, TextBox txtPerimeter, TextBox txtArea)
        {
            inputA = 0.0f; inputB = 0.0f;
            dSideA = 0.0f; dSideB = 0.0f;
            perimeter = 0.0f; area = 0.0f;

            txtInputA.Text = ""; txtInputB.Text = "";
            txtInputSideA.Text = ""; txtInputSideB.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            txtInputA.Focus();
        }

        public void calculatePerimeter()
        {
            perimeter = 2 * dSideA + 2 * dSideB;
        }
        public void calculateArea()
        {
            area = dDiagD * dDiagd / 2;
        }
    }
}
