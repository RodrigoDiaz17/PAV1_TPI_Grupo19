namespace ProyectoBase
{
    partial class AltaPersona
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
            this.gdrPersonas = new System.Windows.Forms.DataGridView();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNroDocumento = new System.Windows.Forms.MaskedTextBox();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelTopBtnArea = new System.Windows.Forms.Panel();
            this.panelBottomBtnArea = new System.Windows.Forms.Panel();
            this.btnDireccion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnGuardarPersona = new System.Windows.Forms.Button();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnSeleccionarPersona = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPersonas)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel23.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdrPersonas
            // 
            this.gdrPersonas.AllowUserToAddRows = false;
            this.gdrPersonas.AllowUserToDeleteRows = false;
            this.gdrPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDocumento,
            this.Documento,
            this.Nombre,
            this.Apellido});
            this.gdrPersonas.Location = new System.Drawing.Point(452, 71);
            this.gdrPersonas.Name = "gdrPersonas";
            this.gdrPersonas.ReadOnly = true;
            this.gdrPersonas.RowHeadersWidth = 51;
            this.gdrPersonas.RowTemplate.Height = 24;
            this.gdrPersonas.Size = new System.Drawing.Size(683, 566);
            this.gdrPersonas.TabIndex = 999999999;
            this.gdrPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrPersonas_CellContentClick);
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "IdTipoDocumento";
            this.TipoDocumento.HeaderText = "Tipo doc";
            this.TipoDocumento.MinimumWidth = 6;
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Width = 40;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "NroDocumento";
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 250;
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(218, 268);
            this.txtNroDocumento.Mask = "99999999";
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(71, 23);
            this.txtNroDocumento.TabIndex = 6;
            this.txtNroDocumento.ValidatingType = typeof(int);
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDocumento.Location = new System.Drawing.Point(51, 268);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(159, 20);
            this.lblNroDocumento.TabIndex = 999999999;
            this.lblNroDocumento.Text = "N° de documento:";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(218, 230);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(155, 24);
            this.cmbTipoDocumento.TabIndex = 5;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.Location = new System.Drawing.Point(39, 230);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(174, 20);
            this.lblTipoDocumento.TabIndex = 999999999;
            this.lblTipoDocumento.Text = "Tipo de documento:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(140, 187);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(56, 20);
            this.lblSexo.TabIndex = 999999999;
            this.lblSexo.Text = "Sexo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 999999999;
            this.label1.Text = "Fecha de nacimiento:";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(217, 149);
            this.txtFechaNacimiento.Mask = "00/00/0000";
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(72, 23);
            this.txtFechaNacimiento.TabIndex = 3;
            this.txtFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(217, 121);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(206, 23);
            this.txtApellido.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(119, 121);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(82, 20);
            this.lblApellido.TabIndex = 999999999;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(217, 93);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(119, 93);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 20);
            this.lblNombre.TabIndex = 999999999;
            this.lblNombre.Text = "Nombre:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(217, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(72, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // panelTopBtnArea
            // 
            this.panelTopBtnArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panelTopBtnArea.Location = new System.Drawing.Point(35, 367);
            this.panelTopBtnArea.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelTopBtnArea.Name = "panelTopBtnArea";
            this.panelTopBtnArea.Size = new System.Drawing.Size(164, 1);
            this.panelTopBtnArea.TabIndex = 999999999;
            // 
            // panelBottomBtnArea
            // 
            this.panelBottomBtnArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panelBottomBtnArea.Location = new System.Drawing.Point(35, 401);
            this.panelBottomBtnArea.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelBottomBtnArea.Name = "panelBottomBtnArea";
            this.panelBottomBtnArea.Size = new System.Drawing.Size(164, 1);
            this.panelBottomBtnArea.TabIndex = 999999999;
            // 
            // btnDireccion
            // 
            this.btnDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnDireccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDireccion.FlatAppearance.BorderSize = 0;
            this.btnDireccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.btnDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDireccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDireccion.Location = new System.Drawing.Point(35, 367);
            this.btnDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.btnDireccion.Name = "btnDireccion";
            this.btnDireccion.Size = new System.Drawing.Size(164, 35);
            this.btnDireccion.TabIndex = 7;
            this.btnDireccion.Text = "Agregar Direccion";
            this.btnDireccion.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel1.Location = new System.Drawing.Point(50, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 1);
            this.panel1.TabIndex = 999999999;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel2.Location = new System.Drawing.Point(35, 367);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 34);
            this.panel2.TabIndex = 999999999;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel3.Location = new System.Drawing.Point(198, 368);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 34);
            this.panel3.TabIndex = 999999999;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(48, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(362, 38);
            this.lblTitulo.TabIndex = 999999999;
            this.lblTitulo.Text = "Cargar nueva persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(685, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "Cargar nueva persona";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel8.Location = new System.Drawing.Point(685, 51);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(270, 1);
            this.panel8.TabIndex = 42;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel10.Location = new System.Drawing.Point(452, 637);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(684, 1);
            this.panel10.TabIndex = 999999999;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel11.Location = new System.Drawing.Point(451, 71);
            this.panel11.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1, 569);
            this.panel11.TabIndex = 999999999;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel12.Controls.Add(this.panel9);
            this.panel12.Location = new System.Drawing.Point(1135, 71);
            this.panel12.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1, 569);
            this.panel12.TabIndex = 999999999;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel9.Location = new System.Drawing.Point(-544, 207);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(541, 1);
            this.panel9.TabIndex = 35;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel13.Location = new System.Drawing.Point(685, 51);
            this.panel13.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(270, 1);
            this.panel13.TabIndex = 42;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel14.Location = new System.Drawing.Point(452, 71);
            this.panel14.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(684, 1);
            this.panel14.TabIndex = 999999999;
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel15.Location = new System.Drawing.Point(198, 436);
            this.panel15.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1, 34);
            this.panel15.TabIndex = 1000000001;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel16.Location = new System.Drawing.Point(35, 435);
            this.panel16.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1, 34);
            this.panel16.TabIndex = 1000000002;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel17.Location = new System.Drawing.Point(35, 435);
            this.panel17.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(164, 1);
            this.panel17.TabIndex = 1000000003;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel18.Location = new System.Drawing.Point(35, 469);
            this.panel18.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(164, 1);
            this.panel18.TabIndex = 1000000004;
            // 
            // btnGuardarPersona
            // 
            this.btnGuardarPersona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnGuardarPersona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarPersona.FlatAppearance.BorderSize = 0;
            this.btnGuardarPersona.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.btnGuardarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPersona.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGuardarPersona.Location = new System.Drawing.Point(35, 435);
            this.btnGuardarPersona.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarPersona.Name = "btnGuardarPersona";
            this.btnGuardarPersona.Size = new System.Drawing.Size(164, 35);
            this.btnGuardarPersona.TabIndex = 8;
            this.btnGuardarPersona.Text = "Guardar Persona";
            this.btnGuardarPersona.UseVisualStyleBackColor = false;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel19.Location = new System.Drawing.Point(198, 505);
            this.panel19.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(1, 34);
            this.panel19.TabIndex = 1000000011;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel20.Location = new System.Drawing.Point(35, 504);
            this.panel20.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(1, 34);
            this.panel20.TabIndex = 1000000012;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel21.Location = new System.Drawing.Point(35, 504);
            this.panel21.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(164, 1);
            this.panel21.TabIndex = 1000000013;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel22.Location = new System.Drawing.Point(35, 538);
            this.panel22.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(164, 1);
            this.panel22.TabIndex = 1000000014;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(35, 504);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(164, 35);
            this.btnLimpiarCampos.TabIndex = 9;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // btnSeleccionarPersona
            // 
            this.btnSeleccionarPersona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSeleccionarPersona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarPersona.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarPersona.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.btnSeleccionarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarPersona.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSeleccionarPersona.Location = new System.Drawing.Point(34, 4);
            this.btnSeleccionarPersona.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionarPersona.Name = "btnSeleccionarPersona";
            this.btnSeleccionarPersona.Size = new System.Drawing.Size(164, 35);
            this.btnSeleccionarPersona.TabIndex = 1000000010;
            this.btnSeleccionarPersona.Text = "Seleccionar Persona";
            this.btnSeleccionarPersona.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel7.Location = new System.Drawing.Point(34, 38);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(164, 1);
            this.panel7.TabIndex = 1000000014;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel6.Location = new System.Drawing.Point(34, 4);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(164, 1);
            this.panel6.TabIndex = 1000000013;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel5.Location = new System.Drawing.Point(34, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 34);
            this.panel5.TabIndex = 1000000012;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(102)))), ((int)(((byte)(35)))));
            this.panel4.Location = new System.Drawing.Point(197, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 34);
            this.panel4.TabIndex = 1000000011;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.panel4);
            this.panel23.Controls.Add(this.panel5);
            this.panel23.Controls.Add(this.panel6);
            this.panel23.Controls.Add(this.panel7);
            this.panel23.Controls.Add(this.btnSeleccionarPersona);
            this.panel23.Location = new System.Drawing.Point(6, 563);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(207, 46);
            this.panel23.TabIndex = 1000000015;
            // 
            // AltaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 666);
            this.Controls.Add(this.panel23);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.panel22);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.btnGuardarPersona);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTopBtnArea);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBottomBtnArea);
            this.Controls.Add(this.btnDireccion);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gdrPersonas);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.lblNroDocumento);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de nueva persona";
            this.Load += new System.EventHandler(this.AltaPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrPersonas)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.MaskedTextBox txtFechaNacimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.MaskedTextBox txtNroDocumento;
        private System.Windows.Forms.DataGridView gdrPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelTopBtnArea;
        private System.Windows.Forms.Panel panelBottomBtnArea;
        private System.Windows.Forms.Button btnDireccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button btnGuardarPersona;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnSeleccionarPersona;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel23;
    }
}