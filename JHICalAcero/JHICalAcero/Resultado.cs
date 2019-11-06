using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JHICalAcero
{
    public partial class Resultado : Form
    {
        #region "variables"
        string proyecto = "";
        string elemento = "";
        string ubicacion = "";
        string propietario = "";
        string responsable = "";
        string tramo = "";
        string varilla = "";
        string clave = "";
        string esquema = "";
        string lecho = "";
        string solicitacion = "";
        string longitudTotal = "";
        string cantidadQuintales = "";
        string imagen = "";
        int fy = 0;
        int fc = 0;
        int cantidad = 0;
        float cb = 0.0f;
        float Ktr = 0.0f;
        float lambda = 0.0f;
        float ew = 0.0f;
        float s = 0.0f;
        float t = 0.0f;
        float lrect = 0.0f;
        float ld = 0.0f;
        float ldx2 = 0.0f;
        float ld1 = 0.0f;
        float ld2 = 0.0f;
        float lext = 0.0f;
        float ldh = 0.0f;
        float diametro = 0.0f;
        float WR = 0.0f;
        #endregion
        public Resultado()
        {
            InitializeComponent();
            calcular();
            cargarGrid();
        }
        private void cargarGrid()
        {
            //Encabezados
            dataGridView1.Columns.Add("varilla", "#varilla");
            dataGridView1.Columns.Add("diametro", "Diametro");
            dataGridView1.Columns.Add("codigo", "Codigo");
            dataGridView1.Columns.Add("lecho", "Lecho");
            dataGridView1.Columns.Add("solicitacion", "Solicitacion");
            dataGridView1.Columns.Add("cantidad", "Cantidad");
            dataGridView1.Columns.Add("ld", "Ld");
            dataGridView1.Columns.Add("lext", "Lext");
            dataGridView1.Columns.Add("ldh", "Ldh");
            dataGridView1.Columns.Add("longitudUnidad", "Longitud total por Unidad");
            dataGridView1.Columns.Add("longitudTotal", "Longitud total");
            dataGridView1.Columns.Add("quintales", "Cantidad en Quintales");
            //Datos
            dataGridView1.Rows.Add(varilla.ToString(), diametro.ToString(), clave.ToString(), lecho.ToString(), solicitacion.ToString(), cantidad.ToString(), ld.ToString(), lext.ToString(), ldh.ToString(), "Longitud/unidad", "Longitud Total", "Quintales");
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        public void calcular()
        {
            asignarVariables();
            comprobarEstadoVarillas();

        }
        public void asignarVariables()
        {
            asignarProyecto();
            asignarElemento();
        }
        public void asignarProyecto()
        {
            string queryString = "SELECT * FROM PROYECTO WHERE PROYECTOID=" + VariablesGlobales.IDPROYECTO;
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\JHICalAcero.db;Version=3"))
            {
                connection.Close();
                SQLiteCommand command = new SQLiteCommand(queryString, connection);
                SQLiteDataReader lector;
                connection.Open();
                lector = command.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        proyecto = lector.GetString(1);
                        ubicacion = lector.GetString(2);
                        propietario = lector.GetString(3);
                        responsable = lector.GetString(4);
                    }
                    lector.Close();
                }
                connection.Close();
                textProyecto.Text = proyecto.ToString();
                textUbicacion.Text = ubicacion.ToString();
                textPropietario.Text = propietario.ToString();
                textResponsable.Text = responsable.ToString();
            }
        }
        public void asignarElemento()
        {
            string queryString = "SELECT * FROM ELEMENTO WHERE ELEMENTOID=" + VariablesGlobales.IDELEMENTO;
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=.\JHICalAcero.db;Version=3"))
            {
                
                connection.Close();
                SQLiteCommand command = new SQLiteCommand(queryString, connection);
                SQLiteDataReader lector;
                connection.Open();
                lector = command.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {

                        elemento = lector.GetString(2);
                        fy = Int32.Parse(lector.GetString(3));
                        fc = Int32.Parse(lector.GetString(4));
                        varilla = lector.GetString(5);
                        diametro = float.Parse(lector.GetString(6));
                        clave = lector.GetString(7);
                        solicitacion = lector.GetString(8);
                        lecho = lector.GetString(9);
                        cantidad = Int32.Parse(lector.GetString(10));
                        lambda = float.Parse(lector.GetString(13));
                        lrect = float.Parse(lector.GetString(17));
                        imagen = lector.GetString(18);
                        if (solicitacion != "Compresion")
                        {
                            cb = float.Parse(lector.GetString(11));
                            Ktr = float.Parse(lector.GetString(12));
                            ew = float.Parse(lector.GetString(14));
                            s = float.Parse(lector.GetString(15));
                            t = float.Parse(lector.GetString(16));
                        }
                        if (solicitacion != "Tension")
                        {
                            WR = float.Parse(lector.GetString(19));
                        }
                        
                    }
                    lector.Close();
                    connection.Close();
                    
                }
                textElemento.Text = elemento.ToString();
                txtFy.Text = fy.ToString() + "Kg/cm^2";
                txtFc.Text = fc.ToString() + "Kg/cm^2";
                txtCb.Text = cb.ToString();
                txtKtr.Text = Ktr.ToString();
                txtLambda.Text = lambda.ToString();
                txtE.Text = ew.ToString();
                txtS.Text = s.ToString();
                txtT.Text = t.ToString();

            }
        }
        private void comprobarEstadoVarillas()
        {
            if (clave == "ALR")
            {
                if (solicitacion == "Compresion")
                {
                    calculoVarillasRectasCompresion();
                }
                else
                {
                    calculoVarillasRectasTension();
                }
            }
            else
            {
                calculoGanchoAcero();
            }

        }
        private void calculoVarillasRectasCompresion()
        {
            ld1 = ((0.075f * fy * t) / (lambda * float.Parse(Math.Sqrt(fc).ToString()))) * diametro;
            ld2 = 0.0044f * fy * diametro;
            ld = (ld1 > ld2) ? ld1 : ld2;
            ld = (ld > 20) ? ld : 20;
            ldx2 = ld * 2;
        }
        private void calculoVarillasRectasTension()
        {
            float primero = (fy / (3.5f * lambda * float.Parse(Math.Sqrt(fc).ToString())));
            float ecuacion49 = ((cb + Ktr) / diametro);
            ecuacion49 = (ecuacion49 >= 2.5f) ? 2.5f : ecuacion49;
            float segundo = (t * ew * s) / ecuacion49;
            ld = primero * segundo * diametro;
            ld = (ld <= 30f) ? 30.0f : ld;
            ldx2 = ld * 2;
        }
        private void calculoGanchoAcero()
        {
            calcularldhGanchoAcero();
            if (clave == "A90L" || clave == "A180L")
            {
                calcularLextGanchoLongitudinal();
            }
            else
            {
                calcularLextGanchoTransversal();
            }

            calcularLongitudRectaGancho();

        }
        private void calcularldhGanchoAcero()
        {
            ldh = (fy * diametro) / (17f * lambda * float.Parse(Math.Sqrt(fc).ToString()));
            //Concreto peso normal lambda=1, liviano lambda =0.75
            if (lambda == 1)
            {
                float mayor = ((diametro * 8f) > 15) ? (diametro * 8f) : 15f;
                ldh = (ldh > mayor) ? ldh : mayor;
            }
            else
            {
                float mayor = ((diametro * 10f) > 19) ? (diametro * 10f) : 19f;
                ldh = (ldh > mayor) ? ldh : mayor;
            }
        }
        private void calcularLongitudRectaGancho()
        {
            float factor = 0.0f;
            if (lecho == "Superior")
            {
                factor = 3.25f;
            }
            else
            {
                factor = 2.5f;
            }
            ld = (factor * fy * diametro) / (17f * lambda * float.Parse(Math.Sqrt(fc).ToString()));
        }
        private void calcularLextGanchoLongitudinal()
        {
            // se verifica si es gancho de 90 o de 180
            //si es 90, se multiplica el diametro x12
            //si es 180 se multiplica el diametro x4 y se verifica que sea mayor a 4
            if (clave == "A90L")
            {
                lext = 12f * diametro;
            }
            else if (clave == "A180L")
            {
                float cuadruple = (diametro * 4f);
                lext = (cuadruple > 6.5f) ? cuadruple : 6.5f;
            }
            else
            {
                MessageBox.Show("No se pudo identificar el codigo");
            }

        }
        private void calcularLextGanchoTransversal()
        {
            if (clave == "A90T")
            {
                if (varilla == "#3" || varilla == "#4" || varilla == "#5")
                {
                    float sextuple = diametro * 6f;
                    lext = (sextuple > 7.5) ? sextuple : 7.5f;
                }
                else if (varilla == "#6" || varilla == "#7" || varilla == "#8")
                {
                    lext = 12f * diametro;
                }
                else
                {
                    MessageBox.Show("No se tiene un valor Lext para este tipo de varilla");
                }
            }
            else if (clave == "A135T")
            {
                float sextuple = diametro * 6.0f;
                lext = (sextuple > 7.5f) ? sextuple : 7.5f;
            }
            else
            {
                float cuadruple = diametro * 4;
                lext = (cuadruple > 6.5f) ? cuadruple : 6.5f;
            }

        }

        private void Resultado_Load(object sender, EventArgs e)
        {

        }

        private void BtngenerarPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = @"../" + proyecto + "_" + elemento + ".pdf";
                PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileStream(nombre.ToString(), FileMode.Create, FileAccess.Write)));
                Document document = new Document(pdfDocument);
                Paragraph SaltoCarro = new Paragraph(" ");
                Paragraph Titulo = new Paragraph("HOJA DE CALCULO DE LA CANTIDAD DE ACERO PARA ELEMENTOS ESTRUCTURALES DE CONCRETO REFORZADO");
                document.Add(Titulo);//TITULO
                document.Add(SaltoCarro);
                //ESTO ES PARA PASARSE A OTRA PAGINA document.Add(new AreaBreak());

                //+++++++++++++++++++++++++++++TABLA GEENERALIDADES
                Paragraph TituloGeneralidades = new Paragraph("Generalidades del proyecto");
                document.Add(TituloGeneralidades);//TITULO
                Table tablaGeneralidades = new Table(UnitValue.CreatePercentArray(2)).UseAllAvailableWidth();
                tablaGeneralidades.AddCell("Proyecto");
                tablaGeneralidades.AddCell(proyecto.ToString());
                tablaGeneralidades.AddCell("Elemento");
                tablaGeneralidades.AddCell(elemento.ToString());
                document.Add(tablaGeneralidades);
                //+++++++++++++++++++++++++++++TABLA GEENERALIDADES
                document.Add(SaltoCarro);

                //+++++++++++++++++++++++++++++TABLA DATOS
                Paragraph TituloDatos = new Paragraph("Datos");
                document.Add(TituloDatos);//TITULO
                Table tablaDatos = new Table(UnitValue.CreatePercentArray(8)).UseAllAvailableWidth();
                //Encabezados
                tablaDatos.AddCell("Fy");
                tablaDatos.AddCell("Fc");
                tablaDatos.AddCell("Cb");
                tablaDatos.AddCell("Ktr");
                tablaDatos.AddCell("Lambda");
                tablaDatos.AddCell("ψe");
                tablaDatos.AddCell("ψs");
                tablaDatos.AddCell("ψe");
                //Datos
                tablaDatos.AddCell(fy.ToString() + " Kg/cm^2");
                tablaDatos.AddCell(fc.ToString() + " Kg/cm^2");
                tablaDatos.AddCell(cb.ToString());
                tablaDatos.AddCell(Ktr.ToString());
                tablaDatos.AddCell(lambda.ToString());
                tablaDatos.AddCell(ew.ToString());
                tablaDatos.AddCell(s.ToString());
                tablaDatos.AddCell(t.ToString());
                document.Add(tablaDatos);
                //+++++++++++++++++++++++++++++TABLA DATOS
                //+++++++++++++++++++++++++++++IMAGEN
                iText.Layout.Element.Image image = new iText.Layout.Element.Image(ImageDataFactory.Create(imagen.ToString()));
                image.SetHeight(60);
                image.SetWidth(60);
                //document.Add(image);
                //+++++++++++++++++++++++++++++IMAGEN
                //+++++++++++++++++++++++++++++TABLA RESULTADO
                Paragraph TituloResultado = new Paragraph("Resultados");
                document.Add(TituloResultado);//TITULO
                Table tablaResultado = new Table(UnitValue.CreatePercentArray(10)).UseAllAvailableWidth();
                //Encabezados
                tablaResultado.AddCell("#Varilla");
                tablaResultado.AddCell("Diámetro");
                tablaResultado.AddCell("Código");
                tablaResultado.AddCell("Esquema");
                tablaResultado.AddCell("Lecho");
                tablaResultado.AddCell("Solicitación");
                tablaResultado.AddCell("Cantidad");
                tablaResultado.AddCell("Ld");
                tablaResultado.AddCell("Lext");
                tablaResultado.AddCell("Ldh");
                //Datos
                tablaResultado.AddCell(varilla.ToString());
                tablaResultado.AddCell(diametro.ToString());
                tablaResultado.AddCell(clave.ToString());
                tablaResultado.AddCell(image);
                tablaResultado.AddCell(lecho.ToString());
                tablaResultado.AddCell(solicitacion.ToString());
                tablaResultado.AddCell(cantidad.ToString());
                tablaResultado.AddCell(ld.ToString());
                tablaResultado.AddCell(lext.ToString());
                tablaResultado.AddCell(ldh.ToString());

                document.Add(tablaResultado);
                //+++++++++++++++++++++++++++++TABLA RESULTADO

                document.Close();
                MessageBox.Show("Se ha creado el PDF exitosamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error!! Cierre el PDF si lo tiene abierto");
            }

        }


    }
}
