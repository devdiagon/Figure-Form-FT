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

        public virtual void ReadData(TextBox txtInputA, TextBox txtInputB, TextBox txtInputHeight, TextBox txtInputSide1, TextBox txtInputSide2)
        {
            try
            {
                inputA = float.Parse(txtInputA.Text);
                inputB = float.Parse(txtInputB.Text);
                tSide1 = float.Parse(txtInputSide1.Text);
                tSide2 = float.Parse(txtInputSide2.Text);
                tHeight = float.Parse(txtInputHeight.Text);

                if (inputA < 0 || inputB < 0 || tSide1 < 0 || tSide2 < 0 || tHeight < 0)
                {
                    MessageBox.Show("No pueden haber ingresos negativos", "mensaje de error");
                    inputA = 0.0f; inputB = 0.0f;
                    tSide1 = 0.0f; tSide2 = 0.0f;
                    tHeight = 0.0f;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void initializeData(TextBox txtInputA, TextBox txtInputB, TextBox txtInputHeight, TextBox txtInputSide1, TextBox txtInputSide2, TextBox txtPerimeter, TextBox txtArea)
        {
            inputA = 0.0f; inputB = 0.0f;
            tSide1 = 0.0f; tSide2 = 0.0f;
            tHeight = 0.0f;
            perimeter = 0.0f; area = 0.0f;

            txtInputA.Text = ""; txtInputB.Text = "";
            txtInputSide1.Text = ""; txtInputSide2.Text = "";
            txtInputHeight.Text = "";
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
