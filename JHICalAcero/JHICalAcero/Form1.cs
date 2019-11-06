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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string lecho = "Superior";
        public string S = "0";
        public string Solicitacion = "Compresion";
        public string lambda = "0.75";
        public string T = "1";
        public string imagen = "";
        public string R = "0.75";

        private void Form1_Load(object sender, EventArgs e)
        {
            try { 
            CargarCBElemento();
            cargarCBFy();
            cargarCBFc();
            cargarCBVarilla();
            cargarCBClave();
            cargarCBE();
            DesactivarW();
            llenarGrid();
            }
            catch (Exception error)
            {
                MessageBox.Show("Hubo un error con la base de datos: "+error.ToString());
            }
        }
        public void CargarCBElemento()
        {
            List<item> lista = new List<item>();
            lista.Add(new item("Zapata", 1));
            lista.Add(new item("Tensor", 2));
            lista.Add(new item("Viga de Fundacion", 3));
            lista.Add(new item("Columna", 4));
            lista.Add(new item("Pared Estructural", 5));
            lista.Add(new item("Viga", 6));
            lista.Add(new item("Losa Densa", 7));
            lista.Add(new item("Losa Aligerada", 8));
            cbElemento.DisplayMember = "Name";
            cbElemento.ValueMember = "Value";
            cbElemento.DataSource = lista;
        }
        public void cargarCBFy()
        {
            List<item> lista = new List<item>();
            lista.Add(new item("2800", 1));
            lista.Add(new item("3500", 2));
            lista.Add(new item("4200", 3));
            cbFy.DisplayMember="Name";
            cbFy.ValueMember = "Value";
            cbFy.DataSource = lista;

        }

        public void cargarCBFc()
        {
            List<item> lista = new List<item>();
            lista.Add(new item("210", 1));
            lista.Add(new item("280", 2));
            lista.Add(new item("350", 3));
            cbFc.DisplayMember = "Name";
            cbFc.ValueMember = "Value";
            cbFc.DataSource = lista;
        }
        public void cargarCBVarilla()
        {
            List<item> lista = new List<item>();
            lista.Add(new item("#2", 1));
            lista.Add(new item("#3", 2));
            lista.Add(new item("#4", 3));
            lista.Add(new item("#5", 4));
            lista.Add(new item("#6", 5));
            lista.Add(new item("#7", 6));
            lista.Add(new item("#8", 7));
            lista.Add(new item("#9", 8));
            lista.Add(new item("#10", 9));
            lista.Add(new item("#11", 10));
            cbVarilla.DisplayMember = "Name";
            cbVarilla.ValueMember = "Value";
            cbVarilla.DataSource = lista;

        }
      

        public void cargarCBE()
        {
            List<item> lista = new List<item>();
            lista.Add(new item("1", 1));
            lista.Add(new item("1.2", 2));
            lista.Add(new item("1.5", 3));
         
            cbe.DisplayMember = "Name";
            cbe.ValueMember = "Value";
            cbe.DataSource = lista;

        }
        public void cargarCBClave()
        {
            List<item> lista = new List<item>();
            lista.Add(new item("AL90", 1));
            lista.Add(new item("AL135", 2));
            lista.Add(new item("AL180", 3));
            lista.Add(new item("ALC90", 4));
            lista.Add(new item("ALC135", 5));
            lista.Add(new item("ALC180", 6));
            lista.Add(new item("ALR", 7));
            lista.Add(new item("ALRC", 8));
            lista.Add(new item("AT90", 9));
            lista.Add(new item("AT135", 10));
            lista.Add(new item("AT180", 11));
            lista.Add(new item("ATC135", 12));
            lista.Add(new item("DBE135", 13));
            lista.Add(new item("GRAPA", 14));
            lista.Add(new item("VGD90", 15));
            cbClave.DisplayMember = "Name";
            cbClave.ValueMember = "Value";
            cbClave.DataSource = lista;
        }

        private void CbClave_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbClave.SelectedValue)
            {
                case 1:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Ganchos/AL90.png");
                    imagen = "Ganchos/AL90.png";
                    break;
                case 2:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Ganchos/AL135.png");
                    imagen = "Ganchos/AL135.png";
                    break;
                case 3:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Ganchos/AL180.png");
                    imagen = "Ganchos/AL180.png";
                    break;
                case 4:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Ganchos/ALC90.png");
                    imagen = "Ganchos/ALC90.png";
                    break;
                case 5:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Ganchos/ALC135.png");
                    imagen = "Ganchos/ALC135.png";
                    break;
                case 6:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Ganchos/ALC180.png");
                    imagen = "Ganchos/ALC180.png";
                    break;
                case 7:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Ganchos/ALR.png");
                    imagen = "Ganchos/ALR.png";
                    break;
                case 8:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Ganchos/ALRC.png");
                    imagen = "Ganchos/ALRC.png";
                    break;
                case 9:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Ganchos/AT90.png");
                    imagen = "Ganchos/AT90.png";
                    break;
                case 10:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Ganchos/AT135.png");
                    imagen = "Ganchos/AT135.png";
                    break;
                case 11:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Ganchos/AT180.png");
                    imagen = "Ganchos/AT180.png";
                    break;
                case 12:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Ganchos/ATC135.png");
                    imagen = "Ganchos/ATC135.png";
                    break;
                case 13:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Ganchos/DBE135.png");
                    imagen = "Ganchos/DBE135.png";
                    break;
                case 14:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Ganchos/GRAPA.png");
                    imagen = "Ganchos/GRAPA.png";
                    break;
                case 15:
                    pictureBox1.Image = System.Drawing.Image.FromFile("Ganchos/VGD90.png");
                    imagen = "Ganchos/VGD90.png";
                    break;
                default:
                    MessageBox.Show("No existe esta clave");
                    break;
            }

        }
        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbVarilla.SelectedValue)
            {
                case 1:
                   txtDiametro.Text="0.64";
                    break;
                case 2:
                    txtDiametro.Text = "0.95";
                    break;
                case 3:
                    txtDiametro.Text = "1.27";
                    break;
                case 4:
                    txtDiametro.Text = "1.59";
                    break;
                case 5:
                    txtDiametro.Text = "1.91";
                    break;
                case 6:
                    txtDiametro.Text = "2.22";
                    break;
                case 7:
                    txtDiametro.Text = "2.54";
                    break;
                case 8:
                    txtDiametro.Text = "2.87";
                    break;
                case 9:
                    txtDiametro.Text = "3.23";
                    break;
                case 10:
                    txtDiametro.Text = "3.58";
                    break;
                
                default:
                    MessageBox.Show("No existe este tipo de varilla");
                    break;
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\JHICalAcero.db;Version=3"))
                {
                    
                    connection.Close();
                    connection.Open();
                    SQLiteParameter param = new SQLiteParameter();
                    string queryString;
                    if (Solicitacion=="Tension")
                    {
                        queryString = queryTension();
                    }
                    else
                    {
                        queryString = queryCompresion();
                    }
                    

                    SQLiteCommand command = new SQLiteCommand(queryString, connection);
                    SQLiteDataReader lector;
                    
                    lector = command.ExecuteReader();
                    lector.Close();
                    MessageBox.Show("Se ha insertado en la base de datos");
                    connection.Close();
                    llenarGrid();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Ocurrio un error al Guardar" + error.ToString());
            }

           
        }
        private string queryTension()
        {
            string queryString = "INSERT INTO elemento(ProyectoID,elemento, fy,fc,varilla,diametro,clave" +
                                        ",solicitacion,lecho,cantidad,cb,ktr,lambda,e,s,t,lrect,imagen) " +
                                         "VALUES(" +
                                         Int32.Parse(VariablesGlobales.IDPROYECTO) +
                                         ",'" + cbElemento.SelectedItem.ToString() + "'" +  //elemento
                                         ",'" + cbFy.SelectedItem.ToString() + "'" + //fy
                                         ",'" + cbFc.SelectedItem.ToString() + "'" +  //fc
                                         ",'" + cbVarilla.SelectedItem.ToString() + "'" + //varilla
                                         ",'" + txtDiametro.Text.ToString() + "'" +  //diametro
                                         ",'" + cbClave.SelectedItem.ToString() + "'" + //clave
                                         ",'" + Solicitacion.ToString() + "'" +  //solicitacion
                                         ",'" + lecho.ToString() + "'" +  //lecho
                                         ",'" + numCantidad.Value.ToString() + "'" +  //Cantidad
                                         ",'" + numCb.Value.ToString() + "'" +  //CB
                                         ",'" + numKTR.Value.ToString() + "'" +  //KTR
                                         ",'" + lambda + "'" +  //lambda
                                         ",'" + cbe.SelectedItem.ToString() + "'" +  //E
                                         ",'" + S + "'" + //S
                                         ",'" + T + "'" + //T
                                         ",'" + numLRECT.Value.ToString() + "'" +  //LRECT
                                         ",'" + imagen.ToString() + "'" +  //Imagen
                                         "); ";
            return queryString;
        }
        private string queryCompresion()
        {
            string queryString = "INSERT INTO elemento(ProyectoID,elemento, fy,fc,varilla,diametro,clave" +
                                        ",solicitacion,lecho,cantidad,lambda,lrect,imagen,r) " +
                                         "VALUES(" +
                                         Int32.Parse(VariablesGlobales.IDPROYECTO) +
                                         ",'" + cbElemento.SelectedItem.ToString() + "'" +  //elemento
                                         ",'" + cbFy.SelectedItem.ToString() + "'" + //fy
                                         ",'" + cbFc.SelectedItem.ToString() + "'" +  //fc
                                         ",'" + cbVarilla.SelectedItem.ToString() + "'" + //varilla
                                         ",'" + txtDiametro.Text.ToString() + "'" +  //diametro
                                         ",'" + cbClave.SelectedItem.ToString() + "'" + //clave
                                         ",'" + Solicitacion.ToString() + "'" +  //solicitacion
                                         ",'" + lecho.ToString() + "'" +  //lecho
                                         ",'" + numCantidad.Value.ToString() + "'" +  //Cantidad
                                         ",'" + lambda + "'" +  //lambda
                                         ",'" + numLRECT.Value.ToString() + "'" +  //LRECT
                                         ",'" + imagen.ToString() + "'" +  //Imagen
                                         ",'" + R + "'" +  //WR
                                         "); ";
            return queryString;
        }
        private  void llenarGrid()
        {
            try
            {
                string queryString = "SELECT * FROM ELEMENTO WHERE PROYECTOID=" + VariablesGlobales.IDPROYECTO;
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
            }catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            R = "0.75";
        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            R = "1";
        }
        private void RbS08_CheckedChanged(object sender, EventArgs e)
        {
            S = "0.8";
        }

        private void RbS1_CheckedChanged(object sender, EventArgs e)
        {
            S = "1";
        }

        private void RbT1_CheckedChanged(object sender, EventArgs e)
        {
            T = "1";
        }

        private void RbT13_CheckedChanged(object sender, EventArgs e)
        {
            T = "1.3";
        }

        private void RbSuperior_CheckedChanged(object sender, EventArgs e)
        {
            lecho = "Superior";
        }

        private void RbInferior_CheckedChanged(object sender, EventArgs e)
        {
            lecho = "Inferior";
        }

        private void RbCompresion_CheckedChanged(object sender, EventArgs e)
        {
            Solicitacion = "Comprension";
            DesactivarW();
        }

        private void RbTension_CheckedChanged(object sender, EventArgs e)
        {
            Solicitacion = "Tension";
            DesactivarR();
        }

        private void Lambda075_CheckedChanged(object sender, EventArgs e)
        {
            lambda = "0.75";
        }

        private void Lambda1_CheckedChanged(object sender, EventArgs e)
        {
            lambda = "1";
        }


        private void ProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.Show();
        }

       
        private void DesactivarR()
        {
            groupR.Hide();
            GroupT.Show();
            groupS.Show();
            cbe.Show();
            txtWe.Show();
            numCb.Show();
            txtCb.Show();
            numKTR.Show();
            numKTR.Show();
        }
        private void DesactivarW()
        {
            groupR.Show();
            GroupT.Hide();
            groupS.Hide();
            cbe.Hide();
            txtWe.Hide();
            numCb.Hide();
            txtCb.Hide();
            numKTR.Hide();
            txtKtr.Hide();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VariablesGlobales.IDELEMENTO = dataGridView1.Rows[e.RowIndex].Cells["ElementoID"].Value.ToString();
            Resultado resultado = new Resultado();
            this.Hide();
            resultado.Show();
        }
    }

}
