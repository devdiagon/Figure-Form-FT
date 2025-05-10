using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaFormas.figure_classes
{
    internal class Square : Control
    {
        private float sBase
        {
            get => inputA;
            set => inputA = value;
        }

        public Square() { }

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
            perimeter = sBase * 4;
        }
        public void calculateArea()
        {
            area = sBase * sBase;
        }
    }
}
