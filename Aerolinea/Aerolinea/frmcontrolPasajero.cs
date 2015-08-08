using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
//PROGRAMADOR Y ANALISTA: Pamela Jacqueline Selman David
//Fecha Inicio: 31/Julio/2015      Fecha Fin: 03/Agosto/2015
namespace Aerolinea
{
    public partial class frmcontrolPasajero : Form
    {
        public frmcontrolPasajero()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void ingresoPasajero_Load(object sender, EventArgs e)
        {
            funconsultarPasajeros();
           
            funllenarComboModificarPasajero();


        }

        private void funllenarComboModificarPasajero()
        {
            cmbmodificarPasajero.Items.Add("Seleccione Código");
            using (clasconexion.funobtenerConexion())
            {
                string squery = "SELECT ncodpasajero  FROM aerolinea.MaPASAJERO";
                MySqlCommand cmdc = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos);
                //grdPasajeros.DataSource = dtDatos;
                cmbmodificarPasajero.ValueMember = "ncodpasajero";
                cmbmodificarPasajero.DisplayMember = "ncodpasajero";
                cmbmodificarPasajero.DataSource = dtDatos;
                clasconexion.funobtenerConexion().Close();


               





            }
        }

        private void funconsultarPasajeros()
        {
          using (clasconexion.funobtenerConexion())
            {
                string squery = "SELECT ncodpasajero as CodigoPasajero,vnompasajero as NombrePasajero,vapepasajero as ApellidoPasajero,vdireccion as DireccionPasajero,nedadpasajero as EdadPasajero,vdpi as DPI, DATE_FORMAT(dfechanacimiento, '%d-%m-%Y') as FechaNacimiento, vnopasaporte as PasaportePasajero,vestado as EstadoPasajero FROM aerolinea.MaPASAJERO  where vestado='ACTIVO'";
                MySqlCommand cmdc = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                DataTable dtDatos = new DataTable();
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(squery, clasconexion.funobtenerConexion());
                mdaDatos.Fill(dtDatos);
                grdPasajeros.DataSource = dtDatos;
                clasconexion.funobtenerConexion().Close();
            }
        }

        private void btnGuardarPasajero_Click(object sender, EventArgs e)
        {
            try
            {
                
                int ifilas;
                int icodigoPasajero;
                using (clasconexion.funobtenerConexion())
                {
                    string squery = "SELECT COUNT(*) As Cant FROM aerolinea.MaPASAJERO ";
                    MySqlCommand cmd = new MySqlCommand(squery, clasconexion.funobtenerConexion());
                    ifilas = Convert.ToInt32(cmd.ExecuteScalar());
                    icodigoPasajero = ifilas + 1;
                    clasconexion.funobtenerConexion().Close();
                   

                }
                using (clasconexion.funobtenerConexion())
                {

                    string sfechaNacimiento = dtpasajero.Value.ToShortDateString();
                    //MessageBox.Show(sfechaNacimiento);
                    string sinsertarPasajero = "INSERT INTO aerolinea.MaPASAJERO  (ncodpasajero,vnompasajero,vapepasajero,vdireccion,nedadpasajero,vdpi,dfechanacimiento,vnopasaporte,vestado)values(" + icodigoPasajero + ",'" + txtNomPasajero.Text + "','" + txtApellidoPasajero.Text + "','" + txtDireccionPasajero.Text + "'," + txtEdadPasajero.Text + ",'" + txtdpiPasajero.Text + "','" + dtpasajero.Text + "','" + txtnoPasaporte.Text + "','" + "ACTIVO" + "')";
                    MySqlCommand cmd2 = new MySqlCommand(sinsertarPasajero, clasconexion.funobtenerConexion());
                    MySqlDataReader MyReader;
                    MyReader = cmd2.ExecuteReader();  
                    MessageBox.Show("PASAJERO ALMACENADO");
                    clasconexion.funobtenerConexion().Close();
                    funlimpiar();
                    funconsultarPasajeros(); 
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void funlimpiar()
        {
            txtNomPasajero.Text = "";
            txtApellidoPasajero.Text = "";
            txtCorreoPasajero1.Text = "";
            txtCorreoPasajero2.Text = "";
            txtDireccionPasajero.Text = "";
            txtEdadPasajero.Text = "";
            txtnoPasaporte.Text = "";
            txtTelefonoPasajero1.Text = "";
            txtTelefonoPasajero2.Text = "";
            txtdpiPasajero.Text = "";
            


        }

        private void btnBuscarPasajero_Click(object sender, EventArgs e)
        {
            funbuscarPasajero();
        }

        private void funbuscarPasajero()
        {


            using (clasconexion.funobtenerConexion())
            {

                string squeryBuscarPasajero = "SELECT ncodpasajero as CodigoPasajero,vnompasajero as NombrePasajero,vapepasajero as ApellidoPasajero,vdireccion as DireccionPasajero,nedadpasajero as Edad,vdpi as DPI,dfechanacimiento  as FechaNacimiento,vnopasaporte as PasaportePasajero,vestado as EstadoPasajero FROM aerolinea.MaPASAJERO  where vnopasaporte=" + txtBusquedaPasajero.Text + " or ncodpasajero=" + txtBusquedaPasajero.Text;
                MySqlCommand cmdc = new MySqlCommand(squeryBuscarPasajero, clasconexion.funobtenerConexion());
                DataTable dtDat = new DataTable();
                MySqlDataAdapter mdaDat = new MySqlDataAdapter(squeryBuscarPasajero, clasconexion.funobtenerConexion());
                mdaDat.Fill(dtDat);
                grdPasajeros.DataSource = dtDat;
                clasconexion.funobtenerConexion().Close();


            }
        }

        private void btnEliminarPasajero_Click(object sender, EventArgs e)
        {
            funeliminarPasajero();
        }

        private void funeliminarPasajero()
        {
            
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbmodificarPasajero_SelectedIndexChanged(object sender, EventArgs e)
        {
            funbuscarPasajeroAModificar();

        }

        private void funbuscarPasajeroAModificar()
        {
            using (clasconexion.funobtenerConexion())
            {

                string squeryBuscarPasajero = "SELECT ncodpasajero ,vnompasajero ,vapepasajero ,vdireccion ,nedadpasajero,vdpi,dfechanacimiento,vnopasaporte,vestado  FROM aerolinea.MaPASAJERO  where ncodpasajero=" + cmbmodificarPasajero.Text + ";";
                MySqlCommand cmdc = new MySqlCommand(squeryBuscarPasajero, clasconexion.funobtenerConexion());
               
                MySqlDataReader drdr = cmdc.ExecuteReader();
                if (drdr.Read()) {
                    txtNomPasajero.Text=  Convert.ToString(drdr["vnompasajero"]);
                    txtApellidoPasajero.Text = Convert.ToString(drdr["vapepasajero"]);
                    txtDireccionPasajero.Text = Convert.ToString(drdr["vdireccion"]);
                    txtEdadPasajero.Text = Convert.ToString(drdr["nedadpasajero"]);
                    txtdpiPasajero.Text =  Convert.ToString(drdr["vdpi"]);
                    //dtpasajero.Text =  Convert.ToString(drdr["dfechanacimiento"]);
                    txtnoPasaporte.Text=  Convert.ToString(drdr["vnopasaporte"]);
                }
                
                clasconexion.funobtenerConexion().Close();


            }
        }
    }
}
