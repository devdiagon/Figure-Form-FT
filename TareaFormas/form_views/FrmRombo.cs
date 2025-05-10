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
    public partial class FrmRombo : Form
    {
        private Diamond ObjDiamond = new Diamond();
        private FrmDeltoide frmNext;
        private FrmRectangulo frmPrev;
        public FrmRombo(FrmRectangulo frmPrevious)
        {
            InitializeComponent();
            adjustImage();
            frmPrev = frmPrevious;
            frmNext = new FrmDeltoide(this);
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
        private void FrmRombo_Load(object sender, EventArgs e)
        {
            ObjDiamond.initializeData(txtInputA, txtInputB, txtInputSide, txtPerimeter, txtArea);
        }

        private void FrmRombo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjDiamond.initializeData(txtInputA, txtInputB, txtInputSide, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjDiamond.CloseForm(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjDiamond.ReadData(txtInputA, txtInputB, txtInputSide);
            ObjDiamond.calculatePerimeter();
            ObjDiamond.calculateArea();
            ObjDiamond.PrintData(txtPerimeter, txtArea);
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            frmNext.Show();
            this.Hide();
        }

        private void btnPrevForm_Click(object sender, EventArgs e)
        {
            frmPrev.Show();
            this.Hide();
        }
    }
}
