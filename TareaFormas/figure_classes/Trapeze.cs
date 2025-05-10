using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaFormas.figure_classes
{
    internal class Trapeze : Control
    {
        private float tHeight;
        private float tSide1;
        private float tSide2;
        private float tBaseB
        {
            get => inputA;
            set => inputA = value;
        }

        private float tBaseb
        {
            get => inputB;
            set => inputB = value;
        }

        public Trapeze()
        {
            tHeight = 0.0f; tSide1 = 0.0f; tSide2 = 0.0f;
        }

        private void computeHeight()
        {
            float baseDif = tBaseB - tBaseb;
            float numerator = (float)(Math.Pow(tSide1, 2) - Math.Pow(tSide2, 2) +  Math.Pow(baseDif, 2));
            float frac = numerator / (2 * baseDif);
            tHeight = (float)Math.Sqrt( Math.Pow(tSide1,2) - Math.Pow(frac,2) );
        }

        public virtual void ReadData(TextBox txtInputA, TextBox txtInputB, TextBox txtInputSide1, TextBox txtInputSide2)
        {
            try
            {
                tBaseB = float.Parse(txtInputA.Text);
                tBaseb = float.Parse(txtInputB.Text);
                tSide1 = float.Parse(txtInputSide1.Text);
                tSide2 = float.Parse(txtInputSide2.Text);

                if (tBaseB < 0 || tBaseb < 0 || tSide1 < 0 || tSide2 < 0)
                {
                    MessageBox.Show("No pueden haber ingresos negativos", "mensaje de error");
                    tBaseB = 0.0f; tBaseb = 0.0f;
                    tSide1 = 0.0f; tSide2 = 0.0f;
                    tHeight = 0.0f;
                }

                if(tBaseB <= tBaseb)
                {
                    MessageBox.Show("La base (B) debe ser mayor a la base (b)", "mensaje de error");
                    tBaseB = 0.0f; tBaseb = 0.0f;
                    tSide1 = 0.0f; tSide2 = 0.0f;
                    tHeight = 0.0f;
                }

                computeHeight();

                if(float.IsNaN(tHeight) || float.IsInfinity(tHeight))
                {
                    MessageBox.Show("Ingreso de lados no válidos", "mensaje de error");
                    tBaseB = 0.0f; tBaseb = 0.0f;
                    tSide1 = 0.0f; tSide2 = 0.0f;
                    tHeight = 0.0f;
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void initializeData(TextBox txtInputA, TextBox txtInputB, TextBox txtInputSide1, TextBox txtInputSide2, TextBox txtPerimeter, TextBox txtArea)
        {
            inputA = 0.0f; inputB = 0.0f;
            tSide1 = 0.0f; tSide2 = 0.0f;
            tHeight = 0.0f;
            perimeter = 0.0f; area = 0.0f;

            txtInputA.Text = ""; txtInputB.Text = "";
            txtInputSide1.Text = ""; txtInputSide2.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            txtInputA.Focus();
        }

        public void calculatePerimeter()
        {
            perimeter = tBaseB + tBaseb + tSide1 + tSide2;
        }
        public void calculateArea()
        {
            area = (tBaseB + tBaseb) * tHeight / 2;
        }
    }
}
