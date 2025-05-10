using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaFormas.figure_classes
{
    internal class Triangle : Control
    {

        private float tBase
        {
            get => inputA;
            set => inputA = value;
        }

        private float tHeight
        {
            get => inputB;
            set => inputB = value;
        }

        public Triangle() { }
        public void calculatePerimeter()
        {
            perimeter = tBase * 3; //Asumiendo que es un triángulo equilátero
        }
        public void calculateArea()
        {
            area = tBase * tHeight / 2;
        }
    }
}
