namespace JHICalAcero
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbElemento = new System.Windows.Forms.ComboBox();
            this.cbFy = new System.Windows.Forms.ComboBox();
            this.cbVarilla = new System.Windows.Forms.ComboBox();
            this.cbFc = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbe = new System.Windows.Forms.ComboBox();
            this.cbClave = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKtr = new System.Windows.Forms.Label();
            this.txtCb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtWe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTension = new System.Windows.Forms.RadioButton();
            this.rbCompresion = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbInferior = new System.Windows.Forms.RadioButton();
            this.rbSuperior = new System.Windows.Forms.RadioButton();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.numCb = new System.Windows.Forms.NumericUpDown();
            this.numKTR = new System.Windows.Forms.NumericUpDown();
            this.numLRECT = new System.Windows.Forms.NumericUpDown();
            this.txtDiametro = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lambda1 = new System.Windows.Forms.RadioButton();
            this.lambda075 = new System.Windows.Forms.RadioButton();
            this.groupS = new System.Windows.Forms.GroupBox();
            this.rbS1 = new System.Windows.Forms.RadioButton();
            this.rbS08 = new System.Windows.Forms.RadioButton();
            this.GroupT = new System.Windows.Forms.GroupBox();
            this.rbT13 = new System.Windows.Forms.RadioButton();
            this.rbT1 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupR = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.labelB = new System.Windows.Forms.Label();
            this.numH = new System.Windows.Forms.NumericUpDown();
            this.labelH = new System.Windows.Forms.Label();
            this.numRec = new System.Windows.Forms.NumericUpDown();
            this.labelRec = new System.Windows.Forms.Label();
            this.numDiametro = new System.Windows.Forms.NumericUpDown();
            this.labelDiametro = new System.Windows.Forms.Label();
            this.txtposicion = new System.Windows.Forms.Label();
            this.cbGrapa = new System.Windows.Forms.ComboBox();
            this.numLM = new System.Windows.Forms.NumericUpDown();
            this.txtLM = new System.Windows.Forms.Label();
            this.numC = new System.Windows.Forms.NumericUpDown();
            this.txtC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLRECT)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupS.SuspendLayout();
            this.GroupT.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiametro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).BeginInit();
            this.SuspendLayout();
            // 
            // cbElemento
            // 
            this.cbElemento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbElemento.FormattingEnabled = true;
            this.cbElemento.Items.AddRange(new object[] {
            "Zapata",
            "Tensor",
            "Viga de Fundacion",
            "Columna",
            "Pared Estructural",
            "Viga",
            "Losa Densa",
            "Losa Aligerada"});
            this.cbElemento.Location = new System.Drawing.Point(460, 55);
            this.cbElemento.Margin = new System.Windows.Forms.Padding(2);
            this.cbElemento.Name = "cbElemento";
            this.cbElemento.Size = new System.Drawing.Size(123, 21);
            this.cbElemento.TabIndex = 0;
            // 
            // cbFy
            // 
            this.cbFy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFy.FormattingEnabled = true;
            this.cbFy.Items.AddRange(new object[] {
            "2800",
            "3500",
            "4200"});
            this.cbFy.Location = new System.Drawing.Point(639, 55);
            this.cbFy.Margin = new System.Windows.Forms.Padding(2);
            this.cbFy.Name = "cbFy";
            this.cbFy.Size = new System.Drawing.Size(123, 21);
            this.cbFy.TabIndex = 1;
            // 
            // cbVarilla
            // 
            this.cbVarilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVarilla.FormattingEnabled = true;
            this.cbVarilla.Items.AddRange(new object[] {
            "#2",
            "#3",
            "#4",
            "#5",
            "#6",
            "#7",
            "#8",
            "#9",
            "#10",
            "#11"});
            this.cbVarilla.Location = new System.Drawing.Point(1019, 55);
            this.cbVarilla.Margin = new System.Windows.Forms.Padding(2);
            this.cbVarilla.Name = "cbVarilla";
            this.cbVarilla.Size = new System.Drawing.Size(123, 21);
            this.cbVarilla.TabIndex = 3;
            this.cbVarilla.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // cbFc
            // 
            this.cbFc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFc.FormattingEnabled = true;
            this.cbFc.Items.AddRange(new object[] {
            "210",
            "280",
            "350",
            "420"});
            this.cbFc.Location = new System.Drawing.Point(821, 55);
            this.cbFc.Margin = new System.Windows.Forms.Padding(2);
            this.cbFc.Name = "cbFc";
            this.cbFc.Size = new System.Drawing.Size(123, 21);
            this.cbFc.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cbe
            // 
            this.cbe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbe.FormattingEnabled = true;
            this.cbe.Items.AddRange(new object[] {
            "1",
            "1.2",
            "1.5"});
            this.cbe.Location = new System.Drawing.Point(1019, 123);
            this.cbe.Margin = new System.Windows.Forms.Padding(2);
            this.cbe.Name = "cbe";
            this.cbe.Size = new System.Drawing.Size(123, 21);
            this.cbe.TabIndex = 14;
            // 
            // cbClave
            // 
            this.cbClave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClave.FormattingEnabled = true;
            this.cbClave.Items.AddRange(new object[] {
            "A90L",
            "A180L",
            "A90T",
            "A135T",
            "A180T"});
            this.cbClave.Location = new System.Drawing.Point(639, 121);
            this.cbClave.Margin = new System.Windows.Forms.Padding(2);
            this.cbClave.Name = "cbClave";
            this.cbClave.Size = new System.Drawing.Size(123, 21);
            this.cbClave.TabIndex = 5;
            this.cbClave.SelectedIndexChanged += new System.EventHandler(this.CbClave_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chartreuse;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1007, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1146, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Elemento";
            // 
            // txtKtr
            // 
            this.txtKtr.AutoSize = true;
            this.txtKtr.Location = new System.Drawing.Point(1016, 348);
            this.txtKtr.Name = "txtKtr";
            this.txtKtr.Size = new System.Drawing.Size(20, 13);
            this.txtKtr.TabIndex = 20;
            this.txtKtr.Text = "Ktr";
            // 
            // txtCb
            // 
            this.txtCb.AutoSize = true;
            this.txtCb.Location = new System.Drawing.Point(834, 348);
            this.txtCb.Name = "txtCb";
            this.txtCb.Size = new System.Drawing.Size(20, 13);
            this.txtCb.TabIndex = 21;
            this.txtCb.Text = "Cb";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(636, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Clave";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(457, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Diametro ( cm )";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1016, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "# de varilla";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(818, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Fc ( kg/cm2 )";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(636, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Fy ( kg/cm2 )";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(639, 348);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Lrect";
            // 
            // txtWe
            // 
            this.txtWe.AutoSize = true;
            this.txtWe.Location = new System.Drawing.Point(1016, 108);
            this.txtWe.Name = "txtWe";
            this.txtWe.Size = new System.Drawing.Size(21, 13);
            this.txtWe.TabIndex = 35;
            this.txtWe.Text = "ψe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTension);
            this.groupBox1.Controls.Add(this.rbCompresion);
            this.groupBox1.Location = new System.Drawing.Point(734, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 61);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitación";
            // 
            // rbTension
            // 
            this.rbTension.AutoSize = true;
            this.rbTension.Location = new System.Drawing.Point(132, 29);
            this.rbTension.Name = "rbTension";
            this.rbTension.Size = new System.Drawing.Size(63, 17);
            this.rbTension.TabIndex = 1;
            this.rbTension.Text = "Tensión";
            this.rbTension.UseVisualStyleBackColor = true;
            this.rbTension.CheckedChanged += new System.EventHandler(this.RbTension_CheckedChanged);
            // 
            // rbCompresion
            // 
            this.rbCompresion.AutoSize = true;
            this.rbCompresion.Checked = true;
            this.rbCompresion.Location = new System.Drawing.Point(20, 29);
            this.rbCompresion.Name = "rbCompresion";
            this.rbCompresion.Size = new System.Drawing.Size(80, 17);
            this.rbCompresion.TabIndex = 0;
            this.rbCompresion.TabStop = true;
            this.rbCompresion.Text = "Compresión";
            this.rbCompresion.UseVisualStyleBackColor = true;
            this.rbCompresion.CheckedChanged += new System.EventHandler(this.RbCompresion_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbInferior);
            this.groupBox2.Controls.Add(this.rbSuperior);
            this.groupBox2.Location = new System.Drawing.Point(460, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 61);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lecho";
            // 
            // rbInferior
            // 
            this.rbInferior.AutoSize = true;
            this.rbInferior.Location = new System.Drawing.Point(145, 29);
            this.rbInferior.Name = "rbInferior";
            this.rbInferior.Size = new System.Drawing.Size(57, 17);
            this.rbInferior.TabIndex = 3;
            this.rbInferior.Text = "Inferior";
            this.rbInferior.UseVisualStyleBackColor = true;
            this.rbInferior.CheckedChanged += new System.EventHandler(this.RbInferior_CheckedChanged);
            // 
            // rbSuperior
            // 
            this.rbSuperior.AutoSize = true;
            this.rbSuperior.Checked = true;
            this.rbSuperior.Location = new System.Drawing.Point(20, 29);
            this.rbSuperior.Name = "rbSuperior";
            this.rbSuperior.Size = new System.Drawing.Size(64, 17);
            this.rbSuperior.TabIndex = 2;
            this.rbSuperior.TabStop = true;
            this.rbSuperior.Text = "Superior";
            this.rbSuperior.UseVisualStyleBackColor = true;
            this.rbSuperior.CheckedChanged += new System.EventHandler(this.RbSuperior_CheckedChanged);
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(460, 364);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 20);
            this.numCantidad.TabIndex = 6;
            // 
            // numCb
            // 
            this.numCb.Location = new System.Drawing.Point(837, 364);
            this.numCb.Name = "numCb";
            this.numCb.Size = new System.Drawing.Size(120, 20);
            this.numCb.TabIndex = 7;
            // 
            // numKTR
            // 
            this.numKTR.Location = new System.Drawing.Point(1014, 364);
            this.numKTR.Name = "numKTR";
            this.numKTR.Size = new System.Drawing.Size(120, 20);
            this.numKTR.TabIndex = 12;
            // 
            // numLRECT
            // 
            this.numLRECT.Location = new System.Drawing.Point(642, 364);
            this.numLRECT.Name = "numLRECT";
            this.numLRECT.Size = new System.Drawing.Size(120, 20);
            this.numLRECT.TabIndex = 17;
            // 
            // txtDiametro
            // 
            this.txtDiametro.Location = new System.Drawing.Point(460, 123);
            this.txtDiametro.Name = "txtDiametro";
            this.txtDiametro.ReadOnly = true;
            this.txtDiametro.Size = new System.Drawing.Size(120, 20);
            this.txtDiametro.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lambda1);
            this.groupBox3.Controls.Add(this.lambda075);
            this.groupBox3.Location = new System.Drawing.Point(1007, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 61);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "λ";
            // 
            // lambda1
            // 
            this.lambda1.AutoSize = true;
            this.lambda1.Location = new System.Drawing.Point(145, 29);
            this.lambda1.Name = "lambda1";
            this.lambda1.Size = new System.Drawing.Size(31, 17);
            this.lambda1.TabIndex = 3;
            this.lambda1.Text = "1";
            this.lambda1.UseVisualStyleBackColor = true;
            this.lambda1.CheckedChanged += new System.EventHandler(this.Lambda1_CheckedChanged);
            // 
            // lambda075
            // 
            this.lambda075.AutoSize = true;
            this.lambda075.Checked = true;
            this.lambda075.Location = new System.Drawing.Point(20, 29);
            this.lambda075.Name = "lambda075";
            this.lambda075.Size = new System.Drawing.Size(46, 17);
            this.lambda075.TabIndex = 2;
            this.lambda075.TabStop = true;
            this.lambda075.Text = "0.75";
            this.lambda075.UseVisualStyleBackColor = true;
            this.lambda075.CheckedChanged += new System.EventHandler(this.Lambda075_CheckedChanged);
            // 
            // groupS
            // 
            this.groupS.Controls.Add(this.rbS1);
            this.groupS.Controls.Add(this.rbS08);
            this.groupS.Location = new System.Drawing.Point(1007, 261);
            this.groupS.Name = "groupS";
            this.groupS.Size = new System.Drawing.Size(253, 61);
            this.groupS.TabIndex = 12;
            this.groupS.TabStop = false;
            this.groupS.Text = "ψs";
            // 
            // rbS1
            // 
            this.rbS1.AutoSize = true;
            this.rbS1.Location = new System.Drawing.Point(145, 29);
            this.rbS1.Name = "rbS1";
            this.rbS1.Size = new System.Drawing.Size(31, 17);
            this.rbS1.TabIndex = 3;
            this.rbS1.Text = "1";
            this.rbS1.UseVisualStyleBackColor = true;
            this.rbS1.CheckedChanged += new System.EventHandler(this.RbS1_CheckedChanged);
            // 
            // rbS08
            // 
            this.rbS08.AutoSize = true;
            this.rbS08.Checked = true;
            this.rbS08.Location = new System.Drawing.Point(20, 29);
            this.rbS08.Name = "rbS08";
            this.rbS08.Size = new System.Drawing.Size(40, 17);
            this.rbS08.TabIndex = 2;
            this.rbS08.TabStop = true;
            this.rbS08.Text = "0.8";
            this.rbS08.UseVisualStyleBackColor = true;
            this.rbS08.CheckedChanged += new System.EventHandler(this.RbS08_CheckedChanged);
            // 
            // GroupT
            // 
            this.GroupT.Controls.Add(this.rbT13);
            this.GroupT.Controls.Add(this.rbT1);
            this.GroupT.Location = new System.Drawing.Point(734, 261);
            this.GroupT.Name = "GroupT";
            this.GroupT.Size = new System.Drawing.Size(253, 61);
            this.GroupT.TabIndex = 13;
            this.GroupT.TabStop = false;
            this.GroupT.Text = "ψt";
            // 
            // rbT13
            // 
            this.rbT13.AutoSize = true;
            this.rbT13.Location = new System.Drawing.Point(145, 29);
            this.rbT13.Name = "rbT13";
            this.rbT13.Size = new System.Drawing.Size(40, 17);
            this.rbT13.TabIndex = 3;
            this.rbT13.Text = "1.3";
            this.rbT13.UseVisualStyleBackColor = true;
            this.rbT13.CheckedChanged += new System.EventHandler(this.RbT13_CheckedChanged);
            // 
            // rbT1
            // 
            this.rbT1.AutoSize = true;
            this.rbT1.Checked = true;
            this.rbT1.Location = new System.Drawing.Point(20, 29);
            this.rbT1.Name = "rbT1";
            this.rbT1.Size = new System.Drawing.Size(31, 17);
            this.rbT1.TabIndex = 2;
            this.rbT1.TabStop = true;
            this.rbT1.Text = "1";
            this.rbT1.UseVisualStyleBackColor = true;
            this.rbT1.CheckedChanged += new System.EventHandler(this.RbT1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proyectosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // proyectosToolStripMenuItem
            // 
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.proyectosToolStripMenuItem.Text = "Proyectos";
            this.proyectosToolStripMenuItem.Click += new System.EventHandler(this.ProyectosToolStripMenuItem_Click);
            // 
            // groupR
            // 
            this.groupR.Controls.Add(this.radioButton1);
            this.groupR.Controls.Add(this.radioButton2);
            this.groupR.Location = new System.Drawing.Point(460, 261);
            this.groupR.Name = "groupR";
            this.groupR.Size = new System.Drawing.Size(253, 61);
            this.groupR.TabIndex = 14;
            this.groupR.TabStop = false;
            this.groupR.Text = "ψr";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(145, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "0.75";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 513);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1207, 164);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // numB
            // 
            this.numB.Location = new System.Drawing.Point(460, 429);
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(120, 20);
            this.numB.TabIndex = 46;
            this.numB.Visible = false;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(457, 413);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(14, 13);
            this.labelB.TabIndex = 47;
            this.labelB.Text = "B";
            this.labelB.Visible = false;
            // 
            // numH
            // 
            this.numH.Location = new System.Drawing.Point(642, 429);
            this.numH.Name = "numH";
            this.numH.Size = new System.Drawing.Size(120, 20);
            this.numH.TabIndex = 48;
            this.numH.Visible = false;
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(639, 413);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(15, 13);
            this.labelH.TabIndex = 49;
            this.labelH.Text = "H";
            this.labelH.Visible = false;
            // 
            // numRec
            // 
            this.numRec.Location = new System.Drawing.Point(837, 429);
            this.numRec.Name = "numRec";
            this.numRec.Size = new System.Drawing.Size(120, 20);
            this.numRec.TabIndex = 50;
            this.numRec.Visible = false;
            // 
            // labelRec
            // 
            this.labelRec.AutoSize = true;
            this.labelRec.Location = new System.Drawing.Point(834, 413);
            this.labelRec.Name = "labelRec";
            this.labelRec.Size = new System.Drawing.Size(22, 13);
            this.labelRec.TabIndex = 51;
            this.labelRec.Text = "rec";
            this.labelRec.Visible = false;
            // 
            // numDiametro
            // 
            this.numDiametro.Location = new System.Drawing.Point(1014, 429);
            this.numDiametro.Name = "numDiametro";
            this.numDiametro.Size = new System.Drawing.Size(120, 20);
            this.numDiametro.TabIndex = 52;
            this.numDiametro.Visible = false;
            // 
            // labelDiametro
            // 
            this.labelDiametro.AutoSize = true;
            this.labelDiametro.Location = new System.Drawing.Point(1011, 413);
            this.labelDiametro.Name = "labelDiametro";
            this.labelDiametro.Size = new System.Drawing.Size(49, 13);
            this.labelDiametro.TabIndex = 53;
            this.labelDiametro.Text = "Diametro";
            this.labelDiametro.Visible = false;
            // 
            // txtposicion
            // 
            this.txtposicion.AutoSize = true;
            this.txtposicion.Location = new System.Drawing.Point(818, 106);
            this.txtposicion.Name = "txtposicion";
            this.txtposicion.Size = new System.Drawing.Size(94, 13);
            this.txtposicion.TabIndex = 55;
            this.txtposicion.Text = "Posicion de Grapa";
            this.txtposicion.Visible = false;
            // 
            // cbGrapa
            // 
            this.cbGrapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrapa.FormattingEnabled = true;
            this.cbGrapa.Items.AddRange(new object[] {
            "1",
            "1.2",
            "1.5"});
            this.cbGrapa.Location = new System.Drawing.Point(821, 121);
            this.cbGrapa.Margin = new System.Windows.Forms.Padding(2);
            this.cbGrapa.Name = "cbGrapa";
            this.cbGrapa.Size = new System.Drawing.Size(123, 21);
            this.cbGrapa.TabIndex = 54;
            this.cbGrapa.Visible = false;
            // 
            // numLM
            // 
            this.numLM.Location = new System.Drawing.Point(821, 121);
            this.numLM.Name = "numLM";
            this.numLM.Size = new System.Drawing.Size(120, 20);
            this.numLM.TabIndex = 56;
            this.numLM.Visible = false;
            // 
            // txtLM
            // 
            this.txtLM.AutoSize = true;
            this.txtLM.Location = new System.Drawing.Point(818, 105);
            this.txtLM.Name = "txtLM";
            this.txtLM.Size = new System.Drawing.Size(22, 13);
            this.txtLM.TabIndex = 57;
            this.txtLM.Text = "LM";
            this.txtLM.Visible = false;
            // 
            // numC
            // 
            this.numC.Location = new System.Drawing.Point(821, 121);
            this.numC.Name = "numC";
            this.numC.Size = new System.Drawing.Size(120, 20);
            this.numC.TabIndex = 58;
            this.numC.Visible = false;
            // 
            // txtC
            // 
            this.txtC.AutoSize = true;
            this.txtC.Location = new System.Drawing.Point(818, 105);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(14, 13);
            this.txtC.TabIndex = 59;
            this.txtC.Text = "C";
            this.txtC.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.numC);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.numLM);
            this.Controls.Add(this.txtLM);
            this.Controls.Add(this.txtposicion);
            this.Controls.Add(this.cbGrapa);
            this.Controls.Add(this.numDiametro);
            this.Controls.Add(this.labelDiametro);
            this.Controls.Add(this.numRec);
            this.Controls.Add(this.labelRec);
            this.Controls.Add(this.numH);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupR);
            this.Controls.Add(this.GroupT);
            this.Controls.Add(this.groupS);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtDiametro);
            this.Controls.Add(this.numLRECT);
            this.Controls.Add(this.numKTR);
            this.Controls.Add(this.numCb);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtWe);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCb);
            this.Controls.Add(this.txtKtr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbClave);
            this.Controls.Add(this.cbe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbFc);
            this.Controls.Add(this.cbVarilla);
            this.Controls.Add(this.cbFy);
            this.Controls.Add(this.cbElemento);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Varillas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLRECT)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupS.ResumeLayout(false);
            this.groupS.PerformLayout();
            this.GroupT.ResumeLayout(false);
            this.GroupT.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupR.ResumeLayout(false);
            this.groupR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiametro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbElemento;
        private System.Windows.Forms.ComboBox cbFy;
        private System.Windows.Forms.ComboBox cbVarilla;
        private System.Windows.Forms.ComboBox cbFc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbe;
        private System.Windows.Forms.ComboBox cbClave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtKtr;
        private System.Windows.Forms.Label txtCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label txtWe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTension;
        private System.Windows.Forms.RadioButton rbCompresion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbInferior;
        private System.Windows.Forms.RadioButton rbSuperior;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.NumericUpDown numCb;
        private System.Windows.Forms.NumericUpDown numKTR;
        private System.Windows.Forms.NumericUpDown numLRECT;
        private System.Windows.Forms.TextBox txtDiametro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton lambda1;
        private System.Windows.Forms.RadioButton lambda075;
        private System.Windows.Forms.GroupBox groupS;
        private System.Windows.Forms.RadioButton rbS1;
        private System.Windows.Forms.RadioButton rbS08;
        private System.Windows.Forms.GroupBox GroupT;
        private System.Windows.Forms.RadioButton rbT13;
        private System.Windows.Forms.RadioButton rbT1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupR;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.NumericUpDown numH;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.NumericUpDown numRec;
        private System.Windows.Forms.Label labelRec;
        private System.Windows.Forms.NumericUpDown numDiametro;
        private System.Windows.Forms.Label labelDiametro;
        private System.Windows.Forms.Label txtposicion;
        private System.Windows.Forms.ComboBox cbGrapa;
        private System.Windows.Forms.NumericUpDown numLM;
        private System.Windows.Forms.Label txtLM;
        private System.Windows.Forms.NumericUpDown numC;
        private System.Windows.Forms.Label txtC;
    }
}

