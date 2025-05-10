using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaFormas.figure_classes
{
    internal class Triangle : Control
    {

        private float tSideA
        {
            get => inputA;
            set => inputA = value;
        }

        private float tSideB
        {
            get => inputB;
            set => inputB = value;
        }

        private float tSideC;

        public Triangle() 
        {
            tSideC = 0.0f;
        }

        public void ReadData(TextBox txtInputSideA, TextBox txtInputSideB, TextBox txtInputSideC)
        {
            try
            {
                tSideA = float.Parse(txtInputSideA.Text);
                tSideB = float.Parse(txtInputSideB.Text);
                tSideC = float.Parse(txtInputSideC.Text);

                if (tSideA < 0 || tSideB < 0 || tSideC < 0)
                {
                    MessageBox.Show("No pueden haber ingresos negativos", "mensaje de error");
                    tSideA = 0.0f; tSideB = 0.0f; tSideC = 0.0f;
                }

                if (!(tSideA + tSideB > tSideC && tSideA + tSideC > tSideB && tSideB + tSideC > tSideA))
                {
                    MessageBox.Show("Lados no válidos", "mensaje de error");
                    tSideA = 0.0f;tSideB = 0.0f; tSideC = 0.0f;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }
        public void initializeData(TextBox txtInputSideA, TextBox txtInputSideB, TextBox txtInputSideC, TextBox txtPerimeter, TextBox txtArea)
        {
            tSideA = 0.0f; tSideB = 0.0f; tSideC = 0.0f;
            perimeter = 0.0f; area = 0.0f;

            txtInputSideA.Text = ""; txtInputSideB.Text = ""; txtInputSideC.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            txtInputSideA.Focus();
        }

        public void calculatePerimeter()
        {
            perimeter = tSideA + tSideB + tSideC;
        }
        public void calculateArea()
        {
            //Formula de Herón
            float part1 = (float)(4 * Math.Pow(tSideA, 2) * Math.Pow(tSideB, 2));
            float part2 = (float)(Math.Pow(tSideA, 2) + Math.Pow(tSideB, 2) - Math.Pow(tSideC, 2));

            area = (float)Math.Sqrt(part1 - Math.Pow(part2, 2)) / 4;
        }
    }
}
