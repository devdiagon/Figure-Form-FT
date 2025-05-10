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
    public partial class FrmCuadrado : Form
    {
        private Square ObjSquare = new Square();
        private static FrmCuadrado instance;

        public static FrmCuadrado GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmCuadrado();
            }
            return instance;
        }
        public FrmCuadrado()
        {
            InitializeComponent();
            adjustImage();
        }

        private void adjustImage()
        {
            if (picImage.Image != null)
            {
                int contenedorAlto = picImage.Height;
                float relacion = (float)picImage.Image.Width / picImage.Image.Height;
                int nuevoAncho = (int)(contenedorAlto * relacion);

                picImage.Width = nuevoAncho;
                picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void FrmCuadrado_Load(object sender, EventArgs e)
        {
            ObjSquare.initializeData(txtInputA, txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjSquare.initializeData(txtInputA, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjSquare.CloseForm(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjSquare.ReadData(txtInputA);
            ObjSquare.calculatePerimeter();
            ObjSquare.calculateArea();
            ObjSquare.PrintData(txtPerimeter, txtArea);
        }
    }
}
