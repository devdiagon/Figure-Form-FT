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
    public partial class FrmDeltoide : Form
    {
        private Deltoid ObjDeltoid = new Deltoid();
        private FrmRombo frmPrev;
        private FrmRomboide frmNext;
        public FrmDeltoide(FrmRombo frmPrevious)
        {
            InitializeComponent();
            adjustImage();
            frmPrev = frmPrevious;
            frmNext = new FrmRomboide(this);
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

        private void FrmDeltoide_Load(object sender, EventArgs e)
        {
            ObjDeltoid.initializeData(txtInputA, txtInputB, txtInputSideA, txtInputSideB, txtPerimeter, txtArea);
        }

        private void FrmDeltoide_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjDeltoid.initializeData(txtInputA, txtInputB, txtInputSideA, txtInputSideB, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjDeltoid.CloseForm(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjDeltoid.ReadData(txtInputA, txtInputB, txtInputSideA, txtInputSideB);
            ObjDeltoid.calculatePerimeter();
            ObjDeltoid.calculateArea();
            ObjDeltoid.PrintData(txtPerimeter, txtArea);
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
