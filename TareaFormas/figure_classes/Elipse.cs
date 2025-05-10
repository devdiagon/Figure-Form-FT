using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaFormas.figure_classes
{
    internal class Elipse : Control
    {
        private float eAxisa
        {
            get => inputA;
            set => inputA = value;
        }

        private float eAxisb
        {
            get => inputB;
            set => inputB = value;
        }

        public Elipse() { }

        public virtual void ReadData(TextBox txtInputA, TextBox txtInputB)
        {
            try
            {
                eAxisa = float.Parse(txtInputA.Text);
                eAxisb = float.Parse(txtInputB.Text);

                if (eAxisa <= 0 || eAxisb <= 0)
                {
                    MessageBox.Show("Los semiejes no pueden ser negativos o cero", "mensaje de error");
                    eAxisa = 0.0f; eAxisb = 0.0f;
                    return;
                }

                if(eAxisa < eAxisb)
                {
                    MessageBox.Show("El semieje 'a' tiene que ser mayor que el semieje 'b'", "mensaje de error");
                    eAxisa = 0.0f; eAxisb = 0.0f;
                    return;
                }

                if (eAxisa == eAxisb)
                {
                    MessageBox.Show("Una elipse tiene semiejes de valores diferentes", "mensaje de error");
                    eAxisa = 0.0f; eAxisb = 0.0f;
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
            perimeter = (float)Math.PI * ( 3 * (eAxisa + eAxisb) - (float)Math.Sqrt((3 * eAxisa + eAxisb) * (eAxisa + 3 * eAxisb)) );
        }
        public void calculateArea()
        {
            area = (float)Math.PI * eAxisa * eAxisb;
        }
    }
}
