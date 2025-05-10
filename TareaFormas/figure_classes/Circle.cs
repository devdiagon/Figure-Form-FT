using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace TareaFormas.figure_classes
{
    internal class Circle : Control
    {
        private float cRadius
        {
            get => inputA;
            set => inputA = value;
        }

        public Circle() { }

        public virtual void ReadData(TextBox txtInputA)
        {
            try
            {
                inputA = float.Parse(txtInputA.Text);

                if (inputA < 0)
                {
                    MessageBox.Show("No pueden haber ingresos negativos", "mensaje de error");
                    inputA = 0.0f;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }
        public void initializeData(TextBox txtInputA, TextBox txtPerimeter, TextBox txtArea)
        {
            inputA = 0.0f;
            perimeter = 0.0f; area = 0.0f;

            txtInputA.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            txtInputA.Focus();
        }

        public void calculatePerimeter()
        {
            perimeter = 2 * (float)Math.PI * cRadius;
        }
        public void calculateArea()
        {
            area = cRadius * (float)Math.PI * cRadius;
        }
    }
}
