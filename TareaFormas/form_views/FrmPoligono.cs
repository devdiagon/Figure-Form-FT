using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareaFormas.figure_classes;

namespace TareaFormas.form_views
{
    public partial class FrmPoligono : Form
    {
        private Polygon ObjPolygon = new Polygon();
        private static FrmPoligono instance;

        public static FrmPoligono GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmPoligono();
            }
            return instance;
        }
        private FrmPoligono()
        {
            InitializeComponent();
            adjustImage();
        }

        private void adjustImage()
        {
            if (picImage.Image != null)
            {
                int contenedorAncho = picImage.Width;
                float relacion = (float)picImage.Image.Width / picImage.Image.Height;
                int nuevoAlto = (int)(contenedorAncho * relacion);

                picImage.Height = nuevoAlto;
                picImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void FrmPoligono_Load(object sender, EventArgs e)
        {
            ObjPolygon.initializeData(txtInputA, txtInputB, lstInputSides, txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjPolygon.initializeData(txtInputA, txtInputB, lstInputSides, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjPolygon.CloseForm(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjPolygon.ReadData(txtInputA, txtInputB, lstInputSides);
            ObjPolygon.calculatePerimeter();
            ObjPolygon.calculateArea();
            ObjPolygon.PrintData(txtPerimeter, txtArea);
        }
    }
}
