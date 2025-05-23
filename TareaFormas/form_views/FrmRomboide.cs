﻿using System;
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
    public partial class FrmRomboide : Form
    {
        private Rhomboid ObjRhomboid = new Rhomboid();
        private static FrmRomboide instance;
        public static FrmRomboide GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmRomboide();
            }
            return instance;
        }

        private FrmRomboide()
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

        private void FrmRomboide_Load(object sender, EventArgs e)
        {
            ObjRhomboid.initializeData(txtInputA, txtInputB, txtInputHeight, txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjRhomboid.initializeData(txtInputA, txtInputB, txtInputHeight, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjRhomboid.CloseForm(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjRhomboid.ReadData(txtInputA, txtInputB, txtInputHeight);
            ObjRhomboid.calculatePerimeter();
            ObjRhomboid.calculateArea();
            ObjRhomboid.PrintData(txtPerimeter, txtArea);
        }
    }
}
