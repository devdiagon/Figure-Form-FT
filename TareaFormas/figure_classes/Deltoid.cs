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
        private float dAngle;
        private float dSideA
        {
            get => inputA;
            set => inputA = value;
        }

        private float dSideB
        {
            get => inputB;
            set => inputB = value;
        }
        public Deltoid() 
        {
            dAngle = 0.0f;
        }

        public virtual void ReadData(TextBox txtInputA, TextBox txtInputB, TextBox txtInputAngle)
        {
            try
            {
                dSideA = float.Parse(txtInputA.Text);
                dSideB = float.Parse(txtInputB.Text);
                dAngle = float.Parse(txtInputAngle.Text);

                if (dSideA < 0 || dSideB < 0 || dAngle < 0)
                {
                    MessageBox.Show("No pueden haber ingresos negativos", "mensaje de error");
                    dSideA = 0.0f; dSideB = 0.0f; dAngle = 0.0f;
                    return;
                }

                if (dSideA == dSideB)
                {
                    MessageBox.Show("Un deltoide tiene lados (a) y (b) diferentes", "mensaje de error");
                    dSideA = 0.0f; dSideB = 0.0f; dAngle = 0.0f;
                    return;
                }

                if(dAngle <= 0 || dAngle >= 180)
                {
                    MessageBox.Show("El ángulo entre los lados tiene que estar entre 0 y 180", "mensaje de error");
                    dSideA = 0.0f; dSideB = 0.0f; dAngle = 0.0f;
                    return;
                }

                //Convertir en ángulo en radianes
                dAngle = (float)(Math.PI / 180) * dAngle;
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void initializeData(TextBox txtInputA, TextBox txtInputB, TextBox txtInputAngle, TextBox txtPerimeter, TextBox txtArea)
        {
            dSideA = 0.0f; dSideB = 0.0f; dAngle = 0.0f;
            perimeter = 0.0f; area = 0.0f;

            txtInputA.Text = ""; txtInputB.Text = ""; txtInputAngle.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            txtInputA.Focus();
        }

        public void calculatePerimeter()
        {
            perimeter = 2 * dSideA + 2 * dSideB;
        }
        public void calculateArea()
        {
            area = dSideA * dSideB * (float)Math.Sin(dAngle);
        }
    }
}
