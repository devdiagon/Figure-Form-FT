using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaFormas.figure_classes
{
    internal class Trapezoid : Control
    {
        private float tSideC;
        private float tSideD;
        private float tTheta;
        private float tPhi;
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

        public Trapezoid()
        {
            tSideC = 0.0f; tSideD = 0.0f;
            tTheta = 0.0f; tPhi = 0.0f;
        }
        private bool validateSides()
        {
            return (tSideA + tSideB + tSideC > tSideD) &&
                   (tSideB + tSideC + tSideD > tSideA) &&
                   (tSideC + tSideD + tSideA > tSideB) &&
                   (tSideD + tSideA + tSideB > tSideC);
        }
        private bool validateAngles()
        {
            return tTheta > 0 && tTheta < 180 && tPhi > 0 && tPhi < 180;
        }

        public virtual void ReadData(TextBox txtInputA, TextBox txtInputB, TextBox txtInputC, TextBox txtInputD, TextBox txtInputAngleTheta, TextBox txtInputAnglePhi)
        {
            try
            {
                tSideA = float.Parse(txtInputA.Text);
                tSideB = float.Parse(txtInputB.Text);
                tSideC = float.Parse(txtInputC.Text);
                tSideD = float.Parse(txtInputD.Text);
                tTheta = float.Parse(txtInputAngleTheta.Text);
                tPhi = float.Parse(txtInputAnglePhi.Text);

                if (tSideA < 0 || tSideB < 0 || tSideC < 0 || tSideD < 0)
                {
                    MessageBox.Show("No pueden haber ingresos negativos", "mensaje de error");
                    tSideA = 0.0f; tSideB = 0.0f; tSideC = 0.0f; tSideD = 0.0f;
                    tTheta = 0.0f; tPhi = 0.0f;
                    return;
                }

                if (!validateSides())
                {
                    MessageBox.Show("Lados no válidos", "mensaje de error");
                    tSideA = 0.0f; tSideB = 0.0f; tSideC = 0.0f; tSideD = 0.0f;
                    tTheta = 0.0f; tPhi = 0.0f;
                    return;
                }

                if (!validateAngles())
                {
                    MessageBox.Show("Los ángulos deben estar entre 0° y 180°", "mensaje de error");
                    tSideA = 0.0f; tSideB = 0.0f; tSideC = 0.0f; tSideD = 0.0f;
                    tTheta = 0.0f; tPhi = 0.0f;
                    return;
                }

                //Convertir en ángulo en radianes
                tTheta = (float)(Math.PI / 180) * tTheta;
                tPhi = (float)(Math.PI / 180) * tPhi;
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void initializeData(TextBox txtInputA, TextBox txtInputB, TextBox txtInputC, TextBox txtInputD, TextBox txtInputAngleTheta, TextBox txtInputAnglePhi, TextBox txtPerimeter, TextBox txtArea)
        {
            tSideA = 0.0f; tSideB = 0.0f; tSideC = 0.0f; tSideD = 0.0f;
            tTheta = 0.0f; tPhi = 0.0f;
            perimeter = 0.0f; area = 0.0f;

            txtInputA.Text = ""; txtInputB.Text = ""; txtInputC.Text = ""; txtInputD.Text = "";
            txtInputAngleTheta.Text = ""; txtInputAnglePhi.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            txtInputA.Focus();
        }

        public void calculatePerimeter()
        {
            perimeter = tSideA + tSideB + tSideC + tSideD;
        }
        public void calculateArea()
        {
            float semiperimeter = (tSideA + tSideB + tSideC + tSideD) / 2;

            float product1 = (semiperimeter - tSideA) * (semiperimeter - tSideB) * (semiperimeter - tSideC) * (semiperimeter - tSideD);
            float product2 = tSideA * tSideB * tSideC * tSideD;
            float angleOp = (float)(Math.Pow(Math.Cos((tTheta + tPhi) / 2), 2));

            area = (float)Math.Sqrt(product1 - (product2 * angleOp));
        }
    }
}
