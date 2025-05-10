using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
