using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareaFormas.form_views;

namespace TareaFormas
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            FrmTriangulo frmTriangulo = FrmTriangulo.GetInstance();
            placeForm(frmTriangulo);
        }

        private void placeForm(Form formulario)
        {
            pnlWrapper.Controls.Clear();                       // Quita los formulario del panel
            formulario.TopLevel = false;                       // Evita que el fomrulario se abra como ventana independiente
            formulario.FormBorderStyle = FormBorderStyle.None; // Quita botones de minimizar, maximizar, cerrar y ajuste
            formulario.Dock = DockStyle.Fill;                  // El formulario se expande en el panel
            pnlWrapper.Controls.Add(formulario);               // Muestra el formulario en el panel
            formulario.Show();
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriangulo frmTriangulo = FrmTriangulo.GetInstance();
            placeForm(frmTriangulo);
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuadrado frmCuadrado = FrmCuadrado.GetInstance();
            placeForm(frmCuadrado);
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRectangulo frmRectangulo = FrmRectangulo.GetInstance();
            placeForm (frmRectangulo);
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCirculo frmCirculo = FrmCirculo.GetInstance();
            placeForm(frmCirculo);
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmElipse frmElipse = FrmElipse.GetInstance();
            placeForm(frmElipse);
        }

        private void poligonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPoligono frmPoligono = FrmPoligono.GetInstance();
            placeForm(frmPoligono);
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRombo frmRombo = FrmRombo.GetInstance();
            placeForm(frmRombo);
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRomboide frmRomboide = FrmRomboide.GetInstance();
            placeForm(frmRomboide);
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapecio frmTrapecio = FrmTrapecio.GetInstance();
            placeForm(frmTrapecio);
        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deltoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeltoide frmDeltoide = FrmDeltoide.GetInstance();
            placeForm(frmDeltoide);
        }

        private void trapecioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTrapecio frmTrapecio = FrmTrapecio.GetInstance();
            placeForm(frmTrapecio);
        }

        private void trapezoideToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTrapezoide frmTrapezoide = FrmTrapezoide.GetInstance();
            placeForm(frmTrapezoide);
        }
    }
}
