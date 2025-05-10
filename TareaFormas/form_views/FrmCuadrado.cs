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
        private FrmTriangulo frmPrev;
        private FrmRectangulo frmNext;
        private Square ObjSquare = new Square();
        public FrmCuadrado(FrmTriangulo frmPrevious)
        {
            InitializeComponent();
            adjustImage();
            frmPrev = frmPrevious;
            frmNext = new FrmRectangulo(this);
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

        private void FrmCuadrado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            frmNext.Show();
            this.Hide();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            frmPrev.Show();
            this.Hide();
        }
    }
}
