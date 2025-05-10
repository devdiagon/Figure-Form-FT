using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareaFormas.figure_classes;

namespace TareaFormas.form_views
{
    public partial class FrmRectangulo : Form
    {
        private Rectangle ObjRectangle = new Rectangle();
        private static FrmRectangulo instance;
        public static FrmRectangulo GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmRectangulo();
            }
            return instance;
        }
        public FrmRectangulo()
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

        private void FrmRectangulo_Load(object sender, EventArgs e)
        {
            ObjRectangle.initializeData(txtInputA, txtInputB, txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjRectangle.initializeData(txtInputA, txtInputB, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjRectangle.CloseForm(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjRectangle.ReadData(txtInputA, txtInputB);
            ObjRectangle.calculatePerimeter();
            ObjRectangle.calculateArea();
            ObjRectangle.PrintData(txtPerimeter, txtArea);
        }
    }
}
