using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaFormas.figure_classes
{
    internal class Rectangle : Control
    {
        private float rBase
        {
            get => inputA;
            set => inputA = value;
        }

        private float rHeight
        {
            get => inputB;
            set => inputB = value;
        }

        public Rectangle() { }

        public void calculatePerimeter()
        {
            perimeter = 2 * rBase +  2 * rHeight; //Asumiendo que es un triángulo equilátero
        }
        public void calculateArea()
        {
            area = rBase * rHeight;
        }
    }
}
