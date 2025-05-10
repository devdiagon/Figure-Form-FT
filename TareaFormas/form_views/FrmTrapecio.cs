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
    public partial class FrmTrapecio : Form
    {
        private Trapeze ObjTrapeze = new Trapeze();
        private FrmRomboide frmPrev;
        private FrmElipse frmNext;
        public FrmTrapecio(FrmRomboide frmPrevious)
        {
            InitializeComponent();
            adjustImage();
            frmPrev = frmPrevious;
            frmNext = new FrmElipse(this);
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

        private void FrmTrapecio_Load(object sender, EventArgs e)
        {
            ObjTrapeze.initializeData(txtInputA, txtInputB, txtInputHeight, txtInputSide1, txtInputSide2, txtPerimeter, txtArea);
        }

        private void FrmTrapecio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjTrapeze.initializeData(txtInputA, txtInputB, txtInputHeight, txtInputSide1, txtInputSide2, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjTrapeze.CloseForm(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjTrapeze.ReadData(txtInputA, txtInputB, txtInputHeight, txtInputSide1, txtInputSide2);
            ObjTrapeze.calculatePerimeter();
            ObjTrapeze.calculateArea();
            ObjTrapeze.PrintData(txtPerimeter, txtArea);
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
