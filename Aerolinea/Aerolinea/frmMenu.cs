using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//PROGRAMADOR Y ANALISTA: Pamela Jacqueline Selman David
//Fecha Inicio: 31/Julio/2015      Fecha Fin: 09/Agosto/2015
namespace Aerolinea
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void rESERVACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmingresoReservacion ires = new frmingresoReservacion();
            ires.Show();
            this.Hide();
        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void pASAJEROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcontrolPasajero ipasaj = new frmcontrolPasajero();
            ipasaj.Show();
            this.Hide();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cancelaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pAGOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrealizacionPago rP = new frmrealizacionPago();
            rP.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void vUELOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rEGISTROAVIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcontrolAvion frmavionvuelo = new frmcontrolAvion();
            frmavionvuelo.Show();
            this.Hide();
        }

        private void aSIGNACIÓNVUELOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcontrolVuelo frmavionvuelo = new frmcontrolVuelo();
            frmavionvuelo.Show();
            this.Hide();
        }
    }
}
