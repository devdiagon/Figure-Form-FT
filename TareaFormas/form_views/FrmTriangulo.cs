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
    public partial class FrmTriangulo : Form
    {
        private Triangle ObjTriangle = new Triangle();
        private static FrmTriangulo instance;

        public static FrmTriangulo GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmTriangulo();
            }
            return instance;
        }
        public FrmTriangulo()
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

        private void FrmTriangulo_Load(object sender, EventArgs e)
        {
            ObjTriangle.initializeData(txtInputA, txtInputB, txtInputC, txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjTriangle.initializeData(txtInputA, txtInputB, txtInputC, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjTriangle.CloseForm(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjTriangle.ReadData(txtInputA, txtInputB, txtInputC);
            ObjTriangle.calculatePerimeter();
            ObjTriangle.calculateArea();
            ObjTriangle.PrintData(txtPerimeter, txtArea);
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
