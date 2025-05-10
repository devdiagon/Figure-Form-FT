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
        private static FrmDeltoide instance;

        public static FrmDeltoide GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmDeltoide();
            }
            return instance;
        }
        private FrmDeltoide()
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

        private void FrmDeltoide_Load(object sender, EventArgs e)
        {
            ObjDeltoid.initializeData(txtInputSideA, txtInputSideB, txtInputAngle, txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjDeltoid.initializeData(txtInputSideA, txtInputSideB, txtInputAngle, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjDeltoid.CloseForm(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjDeltoid.ReadData(txtInputSideA, txtInputSideB, txtInputAngle);
            ObjDeltoid.calculatePerimeter();
            ObjDeltoid.calculateArea();
            ObjDeltoid.PrintData(txtPerimeter, txtArea);
        }
    }
}
