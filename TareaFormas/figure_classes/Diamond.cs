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

        private void computeSide()
        {
            dSide = (float)Math.Sqrt(Math.Pow(dDiagD, 2) + Math.Pow(dDiagd, 2)) / 2;
        }

        public virtual void ReadData(TextBox txtInputA, TextBox txtInputB)
        {
            try
            {
                dDiagD = float.Parse(txtInputA.Text);
                dDiagd = float.Parse(txtInputB.Text);

                if (dDiagD < 0 || dDiagd < 0)
                {
                    MessageBox.Show("No pueden haber ingresos negativos", "mensaje de error");
                    dDiagD = 0.0f; dDiagd = 0.0f;
                    dSide = 0.0f;
                    return;
                }

                if (dDiagD == dDiagd)
                {
                    MessageBox.Show("Un rombo debe tener diagonales diferentes", "mensaje de error");
                    dDiagD = 0.0f; dDiagd = 0.0f;
                    dSide = 0.0f;
                    return;
                }

                computeSide();
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
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
