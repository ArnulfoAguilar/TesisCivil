namespace JHICalAcero
{
    partial class Resultado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textProyecto = new System.Windows.Forms.TextBox();
            this.textResponsable = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textPropietario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textUbicacion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textElemento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtT = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.Label();
            this.txtLambda = new System.Windows.Forms.Label();
            this.txtKtr = new System.Windows.Forms.Label();
            this.txtCb = new System.Windows.Forms.Label();
            this.txtFc = new System.Windows.Forms.Label();
            this.txtFy = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btngenerarPdf = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(832, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(738, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculo de Cantidad de Acero para Elementos Estructurales de Concreto Reforzado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Proyecto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ing. Responsable";
            // 
            // textProyecto
            // 
            this.textProyecto.Location = new System.Drawing.Point(133, 30);
            this.textProyecto.Name = "textProyecto";
            this.textProyecto.ReadOnly = true;
            this.textProyecto.Size = new System.Drawing.Size(306, 20);
            this.textProyecto.TabIndex = 5;
            // 
            // textResponsable
            // 
            this.textResponsable.Location = new System.Drawing.Point(129, 107);
            this.textResponsable.Name = "textResponsable";
            this.textResponsable.ReadOnly = true;
            this.textResponsable.Size = new System.Drawing.Size(310, 20);
            this.textResponsable.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textPropietario);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textUbicacion);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textElemento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textResponsable);
            this.groupBox1.Controls.Add(this.textProyecto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 143);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generalidades del proyecto";
            // 
            // textPropietario
            // 
            this.textPropietario.Location = new System.Drawing.Point(543, 68);
            this.textPropietario.Name = "textPropietario";
            this.textPropietario.ReadOnly = true;
            this.textPropietario.Size = new System.Drawing.Size(306, 20);
            this.textPropietario.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(455, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Propietario";
            // 
            // textUbicacion
            // 
            this.textUbicacion.Location = new System.Drawing.Point(133, 67);
            this.textUbicacion.Name = "textUbicacion";
            this.textUbicacion.ReadOnly = true;
            this.textUbicacion.Size = new System.Drawing.Size(306, 20);
            this.textUbicacion.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(48, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "Ubicacion";
            // 
            // textElemento
            // 
            this.textElemento.Location = new System.Drawing.Point(543, 31);
            this.textElemento.Name = "textElemento";
            this.textElemento.ReadOnly = true;
            this.textElemento.Size = new System.Drawing.Size(306, 20);
            this.textElemento.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Elemento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtT);
            this.groupBox2.Controls.Add(this.txtS);
            this.groupBox2.Controls.Add(this.txtE);
            this.groupBox2.Controls.Add(this.txtLambda);
            this.groupBox2.Controls.Add(this.txtKtr);
            this.groupBox2.Controls.Add(this.txtCb);
            this.groupBox2.Controls.Add(this.txtFc);
            this.groupBox2.Controls.Add(this.txtFy);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(14, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(892, 121);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // txtT
            // 
            this.txtT.AutoSize = true;
            this.txtT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT.Location = new System.Drawing.Point(751, 80);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(16, 17);
            this.txtT.TabIndex = 18;
            this.txtT.Text = "0";
            // 
            // txtS
            // 
            this.txtS.AutoSize = true;
            this.txtS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtS.Location = new System.Drawing.Point(751, 34);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(16, 17);
            this.txtS.TabIndex = 17;
            this.txtS.Text = "0";
            // 
            // txtE
            // 
            this.txtE.AutoSize = true;
            this.txtE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE.Location = new System.Drawing.Point(506, 80);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(16, 17);
            this.txtE.TabIndex = 16;
            this.txtE.Text = "0";
            // 
            // txtLambda
            // 
            this.txtLambda.AutoSize = true;
            this.txtLambda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLambda.Location = new System.Drawing.Point(506, 34);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(16, 17);
            this.txtLambda.TabIndex = 15;
            this.txtLambda.Text = "0";
            // 
            // txtKtr
            // 
            this.txtKtr.AutoSize = true;
            this.txtKtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKtr.Location = new System.Drawing.Point(299, 80);
            this.txtKtr.Name = "txtKtr";
            this.txtKtr.Size = new System.Drawing.Size(16, 17);
            this.txtKtr.TabIndex = 14;
            this.txtKtr.Text = "0";
            // 
            // txtCb
            // 
            this.txtCb.AutoSize = true;
            this.txtCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCb.Location = new System.Drawing.Point(299, 34);
            this.txtCb.Name = "txtCb";
            this.txtCb.Size = new System.Drawing.Size(16, 17);
            this.txtCb.TabIndex = 13;
            this.txtCb.Text = "0";
            // 
            // txtFc
            // 
            this.txtFc.AutoSize = true;
            this.txtFc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFc.Location = new System.Drawing.Point(96, 80);
            this.txtFc.Name = "txtFc";
            this.txtFc.Size = new System.Drawing.Size(16, 17);
            this.txtFc.TabIndex = 12;
            this.txtFc.Text = "0";
            // 
            // txtFy
            // 
            this.txtFy.AutoSize = true;
            this.txtFy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFy.Location = new System.Drawing.Point(96, 34);
            this.txtFy.Name = "txtFy";
            this.txtFy.Size = new System.Drawing.Size(16, 17);
            this.txtFy.TabIndex = 11;
            this.txtFy.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(724, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "ψt";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(721, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "ψs";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(485, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "ψe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(485, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "λ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(270, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ktr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(270, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "cb";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fy";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 379);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(884, 172);
            this.dataGridView1.TabIndex = 10;
            // 
            // btngenerarPdf
            // 
            this.btngenerarPdf.BackColor = System.Drawing.Color.ForestGreen;
            this.btngenerarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerarPdf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btngenerarPdf.Location = new System.Drawing.Point(684, 597);
            this.btngenerarPdf.Name = "btngenerarPdf";
            this.btngenerarPdf.Size = new System.Drawing.Size(97, 30);
            this.btngenerarPdf.TabIndex = 11;
            this.btngenerarPdf.Text = "Generar PDF";
            this.btngenerarPdf.UseVisualStyleBackColor = false;
            this.btngenerarPdf.Click += new System.EventHandler(this.BtngenerarPdf_Click);
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 649);
            this.Controls.Add(this.btngenerarPdf);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.Resultado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textProyecto;
        private System.Windows.Forms.TextBox textResponsable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtT;
        private System.Windows.Forms.Label txtS;
        private System.Windows.Forms.Label txtE;
        private System.Windows.Forms.Label txtLambda;
        private System.Windows.Forms.Label txtKtr;
        private System.Windows.Forms.Label txtCb;
        private System.Windows.Forms.Label txtFc;
        private System.Windows.Forms.Label txtFy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textPropietario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textUbicacion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textElemento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btngenerarPdf;
    }
}