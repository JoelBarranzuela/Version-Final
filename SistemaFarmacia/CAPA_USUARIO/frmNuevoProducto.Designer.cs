namespace CAPA_USUARIO
{
    partial class frmNuevoProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoProducto = new System.Windows.Forms.ComboBox();
            this.pn2 = new System.Windows.Forms.Panel();
            this.cboTpresentacion2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nudStock2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescripcion2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecioUnitario2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pn1 = new System.Windows.Forms.Panel();
            this.txtNrolote1 = new System.Windows.Forms.TextBox();
            this.dtpFechavencimiento1 = new System.Windows.Forms.DateTimePicker();
            this.cboTipoMedicamento = new System.Windows.Forms.ComboBox();
            this.cboCondicionVenta = new System.Windows.Forms.ComboBox();
            this.cboLaboratorio = new System.Windows.Forms.ComboBox();
            this.cboPrincipioActivo = new System.Windows.Forms.ComboBox();
            this.cboTpresentacion1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudStock1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcion1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioUnitario1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock2)).BeginInit();
            this.pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo Producto ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registrar un nuevo Producto por Categoria";
            // 
            // cboTipoProducto
            // 
            this.cboTipoProducto.DisplayMember = "Seleccione >";
            this.cboTipoProducto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoProducto.FormattingEnabled = true;
            this.cboTipoProducto.Location = new System.Drawing.Point(130, 47);
            this.cboTipoProducto.Name = "cboTipoProducto";
            this.cboTipoProducto.Size = new System.Drawing.Size(162, 28);
            this.cboTipoProducto.TabIndex = 4;
            this.cboTipoProducto.Text = "Seleccione";
            this.cboTipoProducto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pn2
            // 
            this.pn2.Controls.Add(this.cboTpresentacion2);
            this.pn2.Controls.Add(this.label15);
            this.pn2.Controls.Add(this.nudStock2);
            this.pn2.Controls.Add(this.label9);
            this.pn2.Controls.Add(this.txtDescripcion2);
            this.pn2.Controls.Add(this.label10);
            this.pn2.Controls.Add(this.txtPrecioUnitario2);
            this.pn2.Controls.Add(this.label11);
            this.pn2.Controls.Add(this.txtNombre2);
            this.pn2.Controls.Add(this.label12);
            this.pn2.Location = new System.Drawing.Point(32, 98);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(724, 367);
            this.pn2.TabIndex = 7;
            // 
            // cboTpresentacion2
            // 
            this.cboTpresentacion2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTpresentacion2.FormattingEnabled = true;
            this.cboTpresentacion2.Location = new System.Drawing.Point(150, 160);
            this.cboTpresentacion2.Name = "cboTpresentacion2";
            this.cboTpresentacion2.Size = new System.Drawing.Size(184, 28);
            this.cboTpresentacion2.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "Tipo Presentacion";
            // 
            // nudStock2
            // 
            this.nudStock2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStock2.Location = new System.Drawing.Point(150, 120);
            this.nudStock2.Name = "nudStock2";
            this.nudStock2.Size = new System.Drawing.Size(68, 26);
            this.nudStock2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-4, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Descripcion Producto";
            // 
            // txtDescripcion2
            // 
            this.txtDescripcion2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion2.Location = new System.Drawing.Point(150, 201);
            this.txtDescripcion2.Multiline = true;
            this.txtDescripcion2.Name = "txtDescripcion2";
            this.txtDescripcion2.Size = new System.Drawing.Size(184, 108);
            this.txtDescripcion2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(91, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Stock";
            // 
            // txtPrecioUnitario2
            // 
            this.txtPrecioUnitario2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario2.Location = new System.Drawing.Point(150, 74);
            this.txtPrecioUnitario2.Name = "txtPrecioUnitario2";
            this.txtPrecioUnitario2.Size = new System.Drawing.Size(146, 26);
            this.txtPrecioUnitario2.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Precio Unitario";
            // 
            // txtNombre2
            // 
            this.txtNombre2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre2.Location = new System.Drawing.Point(150, 28);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(146, 26);
            this.txtNombre2.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(77, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Nombre";
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.txtNrolote1);
            this.pn1.Controls.Add(this.dtpFechavencimiento1);
            this.pn1.Controls.Add(this.cboTipoMedicamento);
            this.pn1.Controls.Add(this.cboCondicionVenta);
            this.pn1.Controls.Add(this.cboLaboratorio);
            this.pn1.Controls.Add(this.cboPrincipioActivo);
            this.pn1.Controls.Add(this.cboTpresentacion1);
            this.pn1.Controls.Add(this.label5);
            this.pn1.Controls.Add(this.nudStock1);
            this.pn1.Controls.Add(this.label6);
            this.pn1.Controls.Add(this.txtDescripcion1);
            this.pn1.Controls.Add(this.label7);
            this.pn1.Controls.Add(this.txtPrecioUnitario1);
            this.pn1.Controls.Add(this.label8);
            this.pn1.Controls.Add(this.txtNombre1);
            this.pn1.Controls.Add(this.label20);
            this.pn1.Controls.Add(this.label19);
            this.pn1.Controls.Add(this.label18);
            this.pn1.Controls.Add(this.label17);
            this.pn1.Controls.Add(this.label16);
            this.pn1.Controls.Add(this.label14);
            this.pn1.Controls.Add(this.label13);
            this.pn1.Location = new System.Drawing.Point(32, 98);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(724, 367);
            this.pn1.TabIndex = 5;
            // 
            // txtNrolote1
            // 
            this.txtNrolote1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrolote1.Location = new System.Drawing.Point(525, 120);
            this.txtNrolote1.Name = "txtNrolote1";
            this.txtNrolote1.Size = new System.Drawing.Size(146, 26);
            this.txtNrolote1.TabIndex = 46;
            // 
            // dtpFechavencimiento1
            // 
            this.dtpFechavencimiento1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechavencimiento1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechavencimiento1.Location = new System.Drawing.Point(525, 160);
            this.dtpFechavencimiento1.Name = "dtpFechavencimiento1";
            this.dtpFechavencimiento1.Size = new System.Drawing.Size(181, 26);
            this.dtpFechavencimiento1.TabIndex = 45;
            // 
            // cboTipoMedicamento
            // 
            this.cboTipoMedicamento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoMedicamento.FormattingEnabled = true;
            this.cboTipoMedicamento.Items.AddRange(new object[] {
            "Generica",
            "Marca"});
            this.cboTipoMedicamento.Location = new System.Drawing.Point(525, 249);
            this.cboTipoMedicamento.Name = "cboTipoMedicamento";
            this.cboTipoMedicamento.Size = new System.Drawing.Size(180, 28);
            this.cboTipoMedicamento.TabIndex = 44;
            // 
            // cboCondicionVenta
            // 
            this.cboCondicionVenta.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCondicionVenta.FormattingEnabled = true;
            this.cboCondicionVenta.Items.AddRange(new object[] {
            "Sin Receta Medica",
            "Con Receta Medica",
            "Con Receta Medica Retenida"});
            this.cboCondicionVenta.Location = new System.Drawing.Point(525, 201);
            this.cboCondicionVenta.Name = "cboCondicionVenta";
            this.cboCondicionVenta.Size = new System.Drawing.Size(180, 28);
            this.cboCondicionVenta.TabIndex = 43;
            // 
            // cboLaboratorio
            // 
            this.cboLaboratorio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLaboratorio.FormattingEnabled = true;
            this.cboLaboratorio.Location = new System.Drawing.Point(525, 74);
            this.cboLaboratorio.Name = "cboLaboratorio";
            this.cboLaboratorio.Size = new System.Drawing.Size(180, 28);
            this.cboLaboratorio.TabIndex = 42;
            // 
            // cboPrincipioActivo
            // 
            this.cboPrincipioActivo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPrincipioActivo.FormattingEnabled = true;
            this.cboPrincipioActivo.Location = new System.Drawing.Point(525, 27);
            this.cboPrincipioActivo.Name = "cboPrincipioActivo";
            this.cboPrincipioActivo.Size = new System.Drawing.Size(180, 28);
            this.cboPrincipioActivo.TabIndex = 41;
            // 
            // cboTpresentacion1
            // 
            this.cboTpresentacion1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTpresentacion1.FormattingEnabled = true;
            this.cboTpresentacion1.Location = new System.Drawing.Point(150, 160);
            this.cboTpresentacion1.Name = "cboTpresentacion1";
            this.cboTpresentacion1.Size = new System.Drawing.Size(184, 28);
            this.cboTpresentacion1.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Tipo Presentacion";
            // 
            // nudStock1
            // 
            this.nudStock1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStock1.Location = new System.Drawing.Point(150, 120);
            this.nudStock1.Name = "nudStock1";
            this.nudStock1.Size = new System.Drawing.Size(68, 26);
            this.nudStock1.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-4, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Descripcion Producto";
            // 
            // txtDescripcion1
            // 
            this.txtDescripcion1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion1.Location = new System.Drawing.Point(150, 201);
            this.txtDescripcion1.Multiline = true;
            this.txtDescripcion1.Name = "txtDescripcion1";
            this.txtDescripcion1.Size = new System.Drawing.Size(184, 108);
            this.txtDescripcion1.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Stock";
            // 
            // txtPrecioUnitario1
            // 
            this.txtPrecioUnitario1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario1.Location = new System.Drawing.Point(150, 74);
            this.txtPrecioUnitario1.Name = "txtPrecioUnitario1";
            this.txtPrecioUnitario1.Size = new System.Drawing.Size(146, 26);
            this.txtPrecioUnitario1.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Precio Unitario";
            // 
            // txtNombre1
            // 
            this.txtNombre1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre1.Location = new System.Drawing.Point(150, 28);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(146, 26);
            this.txtNombre1.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(77, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 20);
            this.label20.TabIndex = 31;
            this.label20.Text = "Nombre";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(368, 252);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(140, 20);
            this.label19.TabIndex = 30;
            this.label19.Text = "Tipo de Medicamento";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(381, 204);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 20);
            this.label18.TabIndex = 29;
            this.label18.Text = "Condicion de Venta";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(384, 166);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "Fecha Vencimiento";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(450, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 20);
            this.label16.TabIndex = 27;
            this.label16.Text = "N° Lote ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(432, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Laboratorio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(406, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Principio Activo";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(249, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Registrar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(382, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 523);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboTipoProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.pn2);
            this.Name = "frmNuevoProducto";
            this.Text = "Registrar Nuevo producto";
            this.Load += new System.EventHandler(this.frmNuevoProducto_Load);
            this.pn2.ResumeLayout(false);
            this.pn2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock2)).EndInit();
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipoProducto;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.NumericUpDown nudStock2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescripcion2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecioUnitario2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboTpresentacion2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNrolote1;
        private System.Windows.Forms.DateTimePicker dtpFechavencimiento1;
        private System.Windows.Forms.ComboBox cboTipoMedicamento;
        private System.Windows.Forms.ComboBox cboCondicionVenta;
        private System.Windows.Forms.ComboBox cboLaboratorio;
        private System.Windows.Forms.ComboBox cboPrincipioActivo;
        private System.Windows.Forms.ComboBox cboTpresentacion1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudStock1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcion1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecioUnitario1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}