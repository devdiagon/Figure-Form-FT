using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaFormas.figure_classes
{
    internal class Rectangle : Control
    {
        private float rBase
        {
            get => inputA;
            set => inputA = value;
        }

        private float rHeight
        {
            get => inputB;
            set => inputB = value;
        }

        public Rectangle() { }

        public virtual void ReadData(TextBox txtInputA, TextBox txtInputB)
        {
            try
            {
                inputA = float.Parse(txtInputA.Text);
                inputB = float.Parse(txtInputB.Text);

                if (inputA < 0 || inputB < 0)
                {
                    MessageBox.Show("No pueden haber ingresos negativos", "mensaje de error");
                    inputA = 0.0f; inputB = 0.0f;
                    return;
                }

                if (inputA == inputB)
                {
                    MessageBox.Show("Un rectángulo tiene base y altura diferentes", "mensaje de error");
                    inputA = 0.0f; inputB = 0.0f;
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void calculatePerimeter()
        {
            perimeter = 2 * rBase +  2 * rHeight;
        }
        public void calculateArea()
        {
            area = rBase * rHeight;
        }
    }
}
