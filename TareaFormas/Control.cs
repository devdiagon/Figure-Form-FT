using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TareaFormas
{
    internal class Control
    {
        protected float inputA;
        protected float inputB;

        protected float perimeter;
        protected float area;

        public Control()
        {
            inputA = 0.0f; inputB = 0.0f;
            perimeter = 0.0f; area = 0.0f;
        }
        public virtual void ReadData(TextBox txtInputA, TextBox txtInputB)
        {
            try
            {
                inputA = float.Parse(txtInputA.Text);
                inputB = float.Parse(txtInputB.Text);

                if(inputA < 0 || inputB < 0)
                {
                    MessageBox.Show("No pueden haber ingresos negativos", "mensaje de error");
                    inputA = 0.0f; inputB = 0.0f;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = perimeter.ToString();
            txtArea.Text = area.ToString();
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }

        public void initializeData(TextBox txtInputA, TextBox txtInputB, TextBox txtPerimeter, TextBox txtArea)
        {
            inputA = 0.0f; inputB = 0.0f;
            perimeter = 0.0f; area = 0.0f;

            txtInputA.Text = ""; txtInputB.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            txtInputA.Focus();
        }
    }
}
