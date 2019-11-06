using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace JHICalAcero
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtProyecto.Text) || String.IsNullOrEmpty(txtUbicacion.Text) || String.IsNullOrEmpty(txtPropietario.Text) || String.IsNullOrEmpty(txtIng.Text))
                {
                    MessageBox.Show("Llene los campos obligatorios");
                }
                else
                {

                    using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\JHICalAcero.db;Version=3"))
                    {

                        connection.Close();
                        connection.Open();
                        SQLiteParameter param = new SQLiteParameter();
                        string queryString = "insert into Proyecto(Proyecto,Ubicacion,Propietario,IngResponsable) values('" +

                                             txtProyecto.Text + "'" +  //Proyecto
                                             ",'" + txtUbicacion.Text + "'" + //Ubicacion
                                             ",'" + txtPropietario.Text + "'" +  //fc
                                             ",'" + txtIng.Text + "'" + //Ing Responsable
                                             "); ";
                        SQLiteCommand command = new SQLiteCommand(queryString, connection);
                        SQLiteDataReader lector;

                        lector = command.ExecuteReader();
                        lector.Close();
                        MessageBox.Show("Se ha insertado en la base de datos");
                        connection.Close();
                        llenarGrid();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrio un error al Guardar" + error.ToString());
            }
        }
        private void llenarGrid()
        {
            try { 
            string queryString = "SELECT * FROM Proyecto order by 1 DESC";
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\JHICalAcero.db;Version=3"))
            {
                connection.Close();
                SQLiteCommand command = new SQLiteCommand(queryString, connection);
                SQLiteDataReader lector;
                connection.Open();
                lector = command.ExecuteReader();

                if (lector.HasRows)
                {
                    lector.Close();
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "DGView");
                    this.dataGridView1.DataSource = dataSet.Tables["DGView"];
                }
                connection.Close();

            }
            }catch(Exception error){
                MessageBox.Show(error.ToString());
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VariablesGlobales.IDPROYECTO = dataGridView1.Rows[e.RowIndex].Cells["ProyectoID"].Value.ToString();
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtProyecto.Text = "";
            txtPropietario.Text = "";
            txtUbicacion.Text = "";
            txtIng.Text = "";
        }
    }
}
