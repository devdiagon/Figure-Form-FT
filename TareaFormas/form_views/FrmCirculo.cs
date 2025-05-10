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
    public partial class FrmCirculo : Form
    {
        private Circle ObjCircle = new Circle();
        private static FrmCirculo instance;

        public static FrmCirculo GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmCirculo();
            }
            return instance;
        }
        private FrmCirculo()
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

        private void FrmCirculo_Load(object sender, EventArgs e)
        {
            ObjCircle.initializeData(txtInputA, txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCircle.initializeData(txtInputA, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjCircle.CloseForm(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCircle.ReadData(txtInputA);
            ObjCircle.calculatePerimeter();
            ObjCircle.calculateArea();
            ObjCircle.PrintData(txtPerimeter, txtArea);
        }
    }
}
