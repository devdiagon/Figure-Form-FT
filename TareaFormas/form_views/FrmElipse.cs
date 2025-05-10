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
    public partial class FrmElipse : Form
    {
        private Elipse ObjElipse = new Elipse();
        private static FrmElipse instance;

        public static FrmElipse GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmElipse();
            }
            return instance;
        }
        private FrmElipse()
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

        private void FrmElipse_Load(object sender, EventArgs e)
        {
            ObjElipse.initializeData(txtInputA, txtInputB, txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjElipse.initializeData(txtInputA, txtInputB, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjElipse.CloseForm(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjElipse.ReadData(txtInputA, txtInputB);
            ObjElipse.calculatePerimeter();
            ObjElipse.calculateArea();
            ObjElipse.PrintData(txtPerimeter, txtArea);
        }
    }
}
