namespace Capa_Vista.Vista_Capacitacion
{
    partial class frmCursos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer tmrDGVCurso;
            this.tbcCursos = new System.Windows.Forms.TabControl();
            this.tbpIngresar = new System.Windows.Forms.TabPage();
            this.btnBuscarCapacit = new System.Windows.Forms.Button();
            this.txtCodigoCurso = new System.Windows.Forms.TextBox();
            this.lblCodCur = new System.Windows.Forms.Label();
            this.btnIngresarC = new System.Windows.Forms.Button();
            this.lblDetalleC = new System.Windows.Forms.Label();
            this.rtxtDetalleC = new System.Windows.Forms.RichTextBox();
            this.gbpDatos = new System.Windows.Forms.GroupBox();
            this.txtPuestoCurC = new System.Windows.Forms.TextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.txtNombC = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCodigoCapacit = new System.Windows.Forms.TextBox();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.lblNombCurso = new System.Windows.Forms.Label();
            this.lblCodCapacitador = new System.Windows.Forms.Label();
            this.tbpEditar = new System.Windows.Forms.TabPage();
            this.btnActualizarCE = new System.Windows.Forms.Button();
            this.txtCodigoCapCE = new System.Windows.Forms.TextBox();
            this.txtNombreCE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCodiCapa = new System.Windows.Forms.Label();
            this.gbpDatosEdit = new System.Windows.Forms.GroupBox();
            this.txtPuestoDCE = new System.Windows.Forms.TextBox();
            this.lblPuestoo = new System.Windows.Forms.Label();
            this.txtEmailDCE = new System.Windows.Forms.TextBox();
            this.lblNommm = new System.Windows.Forms.Label();
            this.txtNombreDCE = new System.Windows.Forms.TextBox();
            this.lblCorr = new System.Windows.Forms.Label();
            this.txtCodigoCap = new System.Windows.Forms.TextBox();
            this.lblCodCap = new System.Windows.Forms.Label();
            this.btnBuscarCap = new System.Windows.Forms.Button();
            this.btnEditarCap = new System.Windows.Forms.Button();
            this.lblDetalleEdit = new System.Windows.Forms.Label();
            this.rtxtDetalleEdit = new System.Windows.Forms.RichTextBox();
            this.tbpEliminar = new System.Windows.Forms.TabPage();
            this.txtCodigoCapEli = new System.Windows.Forms.TextBox();
            this.txtNombreEli = new System.Windows.Forms.TextBox();
            this.lblNnomm = new System.Windows.Forms.Label();
            this.lblCoddo = new System.Windows.Forms.Label();
            this.gbpDatosEli = new System.Windows.Forms.GroupBox();
            this.txtPuestoEli = new System.Windows.Forms.TextBox();
            this.lblPuiest = new System.Windows.Forms.Label();
            this.txtEmailCaEli = new System.Windows.Forms.TextBox();
            this.lblNnommb = new System.Windows.Forms.Label();
            this.txtNombCaEli = new System.Windows.Forms.TextBox();
            this.lblEemail = new System.Windows.Forms.Label();
            this.txtCodigoCE = new System.Windows.Forms.TextBox();
            this.lblCodECE = new System.Windows.Forms.Label();
            this.btnBuscarCE = new System.Windows.Forms.Button();
            this.btnEliminarC = new System.Windows.Forms.Button();
            this.lblDetalleCE = new System.Windows.Forms.Label();
            this.rtxtDetalleCE = new System.Windows.Forms.RichTextBox();
            this.dvgEmpleadosMostrar = new System.Windows.Forms.DataGridView();
            this.lblAser = new System.Windows.Forms.Label();
            this.cmbEncabezado = new System.Windows.Forms.ComboBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscarEmp = new System.Windows.Forms.Button();
            this.lblEsft = new System.Windows.Forms.Label();
            this.lsvInfoCap = new System.Windows.Forms.ListView();
            this.clmhCodigoCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhCursoCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhCapacitador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            tmrDGVCurso = new System.Windows.Forms.Timer(this.components);
            this.tbcCursos.SuspendLayout();
            this.tbpIngresar.SuspendLayout();
            this.gbpDatos.SuspendLayout();
            this.tbpEditar.SuspendLayout();
            this.gbpDatosEdit.SuspendLayout();
            this.tbpEliminar.SuspendLayout();
            this.gbpDatosEli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmpleadosMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrDGVCurso
            // 
            tmrDGVCurso.Enabled = true;
            tmrDGVCurso.Interval = 5000;
            tmrDGVCurso.Tick += new System.EventHandler(this.tmrDGVCurso_Tick);
            // 
            // tbcCursos
            // 
            this.tbcCursos.Controls.Add(this.tbpIngresar);
            this.tbcCursos.Controls.Add(this.tbpEditar);
            this.tbcCursos.Controls.Add(this.tbpEliminar);
            this.tbcCursos.Location = new System.Drawing.Point(14, 13);
            this.tbcCursos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbcCursos.Name = "tbcCursos";
            this.tbcCursos.SelectedIndex = 0;
            this.tbcCursos.Size = new System.Drawing.Size(489, 512);
            this.tbcCursos.TabIndex = 0;
            // 
            // tbpIngresar
            // 
            this.tbpIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpIngresar.Controls.Add(this.btnBuscarCapacit);
            this.tbpIngresar.Controls.Add(this.txtCodigoCurso);
            this.tbpIngresar.Controls.Add(this.lblCodCur);
            this.tbpIngresar.Controls.Add(this.btnIngresarC);
            this.tbpIngresar.Controls.Add(this.lblDetalleC);
            this.tbpIngresar.Controls.Add(this.rtxtDetalleC);
            this.tbpIngresar.Controls.Add(this.gbpDatos);
            this.tbpIngresar.Controls.Add(this.txtCodigoCapacit);
            this.tbpIngresar.Controls.Add(this.txtNombreCurso);
            this.tbpIngresar.Controls.Add(this.lblNombCurso);
            this.tbpIngresar.Controls.Add(this.lblCodCapacitador);
            this.tbpIngresar.Location = new System.Drawing.Point(4, 25);
            this.tbpIngresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpIngresar.Name = "tbpIngresar";
            this.tbpIngresar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpIngresar.Size = new System.Drawing.Size(481, 483);
            this.tbpIngresar.TabIndex = 0;
            this.tbpIngresar.Text = "Ingresar Curso";
            // 
            // btnBuscarCapacit
            // 
            this.btnBuscarCapacit.Location = new System.Drawing.Point(400, 108);
            this.btnBuscarCapacit.Name = "btnBuscarCapacit";
            this.btnBuscarCapacit.Size = new System.Drawing.Size(60, 23);
            this.btnBuscarCapacit.TabIndex = 10;
            this.btnBuscarCapacit.Text = "Buscar";
            this.btnBuscarCapacit.UseVisualStyleBackColor = true;
            this.btnBuscarCapacit.Click += new System.EventHandler(this.btnBuscarCapacit_Click);
            // 
            // txtCodigoCurso
            // 
            this.txtCodigoCurso.Location = new System.Drawing.Point(166, 42);
            this.txtCodigoCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoCurso.Name = "txtCodigoCurso";
            this.txtCodigoCurso.Size = new System.Drawing.Size(294, 23);
            this.txtCodigoCurso.TabIndex = 9;
            this.txtCodigoCurso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
            // 
            // lblCodCur
            // 
            this.lblCodCur.AutoSize = true;
            this.lblCodCur.Location = new System.Drawing.Point(14, 46);
            this.lblCodCur.Name = "lblCodCur";
            this.lblCodCur.Size = new System.Drawing.Size(110, 16);
            this.lblCodCur.TabIndex = 8;
            this.lblCodCur.Text = "Codigo del Curso";
            // 
            // btnIngresarC
            // 
            this.btnIngresarC.Location = new System.Drawing.Point(388, 445);
            this.btnIngresarC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIngresarC.Name = "btnIngresarC";
            this.btnIngresarC.Size = new System.Drawing.Size(87, 28);
            this.btnIngresarC.TabIndex = 7;
            this.btnIngresarC.Text = "Ingresar";
            this.btnIngresarC.UseVisualStyleBackColor = true;
            this.btnIngresarC.Click += new System.EventHandler(this.btnIngresarC_Click);
            // 
            // lblDetalleC
            // 
            this.lblDetalleC.AutoSize = true;
            this.lblDetalleC.Location = new System.Drawing.Point(14, 261);
            this.lblDetalleC.Name = "lblDetalleC";
            this.lblDetalleC.Size = new System.Drawing.Size(152, 16);
            this.lblDetalleC.TabIndex = 6;
            this.lblDetalleC.Text = "Detalles de Capacitación";
            // 
            // rtxtDetalleC
            // 
            this.rtxtDetalleC.Location = new System.Drawing.Point(7, 281);
            this.rtxtDetalleC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtDetalleC.Name = "rtxtDetalleC";
            this.rtxtDetalleC.Size = new System.Drawing.Size(468, 156);
            this.rtxtDetalleC.TabIndex = 5;
            this.rtxtDetalleC.Text = "";
            // 
            // gbpDatos
            // 
            this.gbpDatos.Controls.Add(this.txtPuestoCurC);
            this.gbpDatos.Controls.Add(this.lblPuesto);
            this.gbpDatos.Controls.Add(this.txtEmail);
            this.gbpDatos.Controls.Add(this.lblNombreC);
            this.gbpDatos.Controls.Add(this.txtNombC);
            this.gbpDatos.Controls.Add(this.lblEmail);
            this.gbpDatos.Enabled = false;
            this.gbpDatos.Location = new System.Drawing.Point(7, 139);
            this.gbpDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbpDatos.Name = "gbpDatos";
            this.gbpDatos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbpDatos.Size = new System.Drawing.Size(463, 118);
            this.gbpDatos.TabIndex = 4;
            this.gbpDatos.TabStop = false;
            this.gbpDatos.Text = "Datos Capacitador";
            // 
            // txtPuestoCurC
            // 
            this.txtPuestoCurC.Location = new System.Drawing.Point(159, 86);
            this.txtPuestoCurC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPuestoCurC.Name = "txtPuestoCurC";
            this.txtPuestoCurC.Size = new System.Drawing.Size(294, 23);
            this.txtPuestoCurC.TabIndex = 10;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(7, 89);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(46, 16);
            this.lblPuesto.TabIndex = 9;
            this.lblPuesto.Text = "Puesto";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(159, 55);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(294, 23);
            this.txtEmail.TabIndex = 8;
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.Location = new System.Drawing.Point(7, 27);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(55, 16);
            this.lblNombreC.TabIndex = 6;
            this.lblNombreC.Text = "Nombre";
            // 
            // txtNombC
            // 
            this.txtNombC.Location = new System.Drawing.Point(159, 24);
            this.txtNombC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombC.Name = "txtNombC";
            this.txtNombC.Size = new System.Drawing.Size(294, 23);
            this.txtNombC.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 58);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-Mail";
            // 
            // txtCodigoCapacit
            // 
            this.txtCodigoCapacit.Location = new System.Drawing.Point(166, 108);
            this.txtCodigoCapacit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoCapacit.Name = "txtCodigoCapacit";
            this.txtCodigoCapacit.Size = new System.Drawing.Size(232, 23);
            this.txtCodigoCapacit.TabIndex = 3;
            this.txtCodigoCapacit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(166, 73);
            this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(294, 23);
            this.txtNombreCurso.TabIndex = 2;
            // 
            // lblNombCurso
            // 
            this.lblNombCurso.AutoSize = true;
            this.lblNombCurso.Location = new System.Drawing.Point(14, 77);
            this.lblNombCurso.Name = "lblNombCurso";
            this.lblNombCurso.Size = new System.Drawing.Size(114, 16);
            this.lblNombCurso.TabIndex = 1;
            this.lblNombCurso.Text = "Nombre del Curso";
            // 
            // lblCodCapacitador
            // 
            this.lblCodCapacitador.AutoSize = true;
            this.lblCodCapacitador.Location = new System.Drawing.Point(14, 111);
            this.lblCodCapacitador.Name = "lblCodCapacitador";
            this.lblCodCapacitador.Size = new System.Drawing.Size(145, 16);
            this.lblCodCapacitador.TabIndex = 0;
            this.lblCodCapacitador.Text = "Codigo de Capacitador";
            // 
            // tbpEditar
            // 
            this.tbpEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpEditar.Controls.Add(this.btnActualizarCE);
            this.tbpEditar.Controls.Add(this.txtCodigoCapCE);
            this.tbpEditar.Controls.Add(this.txtNombreCE);
            this.tbpEditar.Controls.Add(this.label5);
            this.tbpEditar.Controls.Add(this.lblCodiCapa);
            this.tbpEditar.Controls.Add(this.gbpDatosEdit);
            this.tbpEditar.Controls.Add(this.txtCodigoCap);
            this.tbpEditar.Controls.Add(this.lblCodCap);
            this.tbpEditar.Controls.Add(this.btnBuscarCap);
            this.tbpEditar.Controls.Add(this.btnEditarCap);
            this.tbpEditar.Controls.Add(this.lblDetalleEdit);
            this.tbpEditar.Controls.Add(this.rtxtDetalleEdit);
            this.tbpEditar.Location = new System.Drawing.Point(4, 25);
            this.tbpEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpEditar.Name = "tbpEditar";
            this.tbpEditar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpEditar.Size = new System.Drawing.Size(481, 483);
            this.tbpEditar.TabIndex = 1;
            this.tbpEditar.Text = "Editar Curso";
            // 
            // btnActualizarCE
            // 
            this.btnActualizarCE.Location = new System.Drawing.Point(373, 110);
            this.btnActualizarCE.Name = "btnActualizarCE";
            this.btnActualizarCE.Size = new System.Drawing.Size(83, 23);
            this.btnActualizarCE.TabIndex = 24;
            this.btnActualizarCE.Text = "Actualizar";
            this.btnActualizarCE.UseVisualStyleBackColor = true;
            this.btnActualizarCE.Click += new System.EventHandler(this.btnActualizarCE_Click);
            // 
            // txtCodigoCapCE
            // 
            this.txtCodigoCapCE.Location = new System.Drawing.Point(165, 110);
            this.txtCodigoCapCE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoCapCE.Name = "txtCodigoCapCE";
            this.txtCodigoCapCE.Size = new System.Drawing.Size(202, 23);
            this.txtCodigoCapCE.TabIndex = 23;
            this.txtCodigoCapCE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
            // 
            // txtNombreCE
            // 
            this.txtNombreCE.Location = new System.Drawing.Point(165, 79);
            this.txtNombreCE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreCE.Name = "txtNombreCE";
            this.txtNombreCE.Size = new System.Drawing.Size(294, 23);
            this.txtNombreCE.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nombre del Curso";
            // 
            // lblCodiCapa
            // 
            this.lblCodiCapa.AutoSize = true;
            this.lblCodiCapa.Location = new System.Drawing.Point(13, 113);
            this.lblCodiCapa.Name = "lblCodiCapa";
            this.lblCodiCapa.Size = new System.Drawing.Size(145, 16);
            this.lblCodiCapa.TabIndex = 20;
            this.lblCodiCapa.Text = "Codigo de Capacitador";
            // 
            // gbpDatosEdit
            // 
            this.gbpDatosEdit.Controls.Add(this.txtPuestoDCE);
            this.gbpDatosEdit.Controls.Add(this.lblPuestoo);
            this.gbpDatosEdit.Controls.Add(this.txtEmailDCE);
            this.gbpDatosEdit.Controls.Add(this.lblNommm);
            this.gbpDatosEdit.Controls.Add(this.txtNombreDCE);
            this.gbpDatosEdit.Controls.Add(this.lblCorr);
            this.gbpDatosEdit.Enabled = false;
            this.gbpDatosEdit.Location = new System.Drawing.Point(6, 165);
            this.gbpDatosEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbpDatosEdit.Name = "gbpDatosEdit";
            this.gbpDatosEdit.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbpDatosEdit.Size = new System.Drawing.Size(463, 118);
            this.gbpDatosEdit.TabIndex = 19;
            this.gbpDatosEdit.TabStop = false;
            this.gbpDatosEdit.Text = "Datos Capacitador";
            // 
            // txtPuestoDCE
            // 
            this.txtPuestoDCE.Location = new System.Drawing.Point(159, 86);
            this.txtPuestoDCE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPuestoDCE.Name = "txtPuestoDCE";
            this.txtPuestoDCE.Size = new System.Drawing.Size(294, 23);
            this.txtPuestoDCE.TabIndex = 10;
            // 
            // lblPuestoo
            // 
            this.lblPuestoo.AutoSize = true;
            this.lblPuestoo.Location = new System.Drawing.Point(7, 89);
            this.lblPuestoo.Name = "lblPuestoo";
            this.lblPuestoo.Size = new System.Drawing.Size(46, 16);
            this.lblPuestoo.TabIndex = 9;
            this.lblPuestoo.Text = "Puesto";
            // 
            // txtEmailDCE
            // 
            this.txtEmailDCE.Location = new System.Drawing.Point(159, 55);
            this.txtEmailDCE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailDCE.Name = "txtEmailDCE";
            this.txtEmailDCE.Size = new System.Drawing.Size(294, 23);
            this.txtEmailDCE.TabIndex = 8;
            // 
            // lblNommm
            // 
            this.lblNommm.AutoSize = true;
            this.lblNommm.Location = new System.Drawing.Point(7, 27);
            this.lblNommm.Name = "lblNommm";
            this.lblNommm.Size = new System.Drawing.Size(55, 16);
            this.lblNommm.TabIndex = 6;
            this.lblNommm.Text = "Nombre";
            // 
            // txtNombreDCE
            // 
            this.txtNombreDCE.Location = new System.Drawing.Point(159, 24);
            this.txtNombreDCE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreDCE.Name = "txtNombreDCE";
            this.txtNombreDCE.Size = new System.Drawing.Size(294, 23);
            this.txtNombreDCE.TabIndex = 7;
            // 
            // lblCorr
            // 
            this.lblCorr.AutoSize = true;
            this.lblCorr.Location = new System.Drawing.Point(7, 58);
            this.lblCorr.Name = "lblCorr";
            this.lblCorr.Size = new System.Drawing.Size(45, 16);
            this.lblCorr.TabIndex = 5;
            this.lblCorr.Text = "E-Mail";
            // 
            // txtCodigoCap
            // 
            this.txtCodigoCap.Location = new System.Drawing.Point(165, 10);
            this.txtCodigoCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoCap.Name = "txtCodigoCap";
            this.txtCodigoCap.Size = new System.Drawing.Size(202, 23);
            this.txtCodigoCap.TabIndex = 18;
            this.txtCodigoCap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
            // 
            // lblCodCap
            // 
            this.lblCodCap.AutoSize = true;
            this.lblCodCap.Location = new System.Drawing.Point(13, 13);
            this.lblCodCap.Name = "lblCodCap";
            this.lblCodCap.Size = new System.Drawing.Size(110, 16);
            this.lblCodCap.TabIndex = 17;
            this.lblCodCap.Text = "Codigo del Curso";
            // 
            // btnBuscarCap
            // 
            this.btnBuscarCap.Location = new System.Drawing.Point(373, 10);
            this.btnBuscarCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarCap.Name = "btnBuscarCap";
            this.btnBuscarCap.Size = new System.Drawing.Size(83, 23);
            this.btnBuscarCap.TabIndex = 16;
            this.btnBuscarCap.Text = "Buscar";
            this.btnBuscarCap.UseVisualStyleBackColor = true;
            this.btnBuscarCap.Click += new System.EventHandler(this.btnBuscarCap_Click);
            // 
            // btnEditarCap
            // 
            this.btnEditarCap.Enabled = false;
            this.btnEditarCap.Location = new System.Drawing.Point(388, 445);
            this.btnEditarCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditarCap.Name = "btnEditarCap";
            this.btnEditarCap.Size = new System.Drawing.Size(87, 28);
            this.btnEditarCap.TabIndex = 15;
            this.btnEditarCap.Text = "Editar";
            this.btnEditarCap.UseVisualStyleBackColor = true;
            this.btnEditarCap.Click += new System.EventHandler(this.btnEditarCap_Click);
            // 
            // lblDetalleEdit
            // 
            this.lblDetalleEdit.AutoSize = true;
            this.lblDetalleEdit.Location = new System.Drawing.Point(13, 287);
            this.lblDetalleEdit.Name = "lblDetalleEdit";
            this.lblDetalleEdit.Size = new System.Drawing.Size(152, 16);
            this.lblDetalleEdit.TabIndex = 14;
            this.lblDetalleEdit.Text = "Detalles de Capacitación";
            // 
            // rtxtDetalleEdit
            // 
            this.rtxtDetalleEdit.Location = new System.Drawing.Point(6, 307);
            this.rtxtDetalleEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtDetalleEdit.Name = "rtxtDetalleEdit";
            this.rtxtDetalleEdit.Size = new System.Drawing.Size(469, 130);
            this.rtxtDetalleEdit.TabIndex = 13;
            this.rtxtDetalleEdit.Text = "";
            // 
            // tbpEliminar
            // 
            this.tbpEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpEliminar.Controls.Add(this.txtCodigoCapEli);
            this.tbpEliminar.Controls.Add(this.txtNombreEli);
            this.tbpEliminar.Controls.Add(this.lblNnomm);
            this.tbpEliminar.Controls.Add(this.lblCoddo);
            this.tbpEliminar.Controls.Add(this.gbpDatosEli);
            this.tbpEliminar.Controls.Add(this.txtCodigoCE);
            this.tbpEliminar.Controls.Add(this.lblCodECE);
            this.tbpEliminar.Controls.Add(this.btnBuscarCE);
            this.tbpEliminar.Controls.Add(this.btnEliminarC);
            this.tbpEliminar.Controls.Add(this.lblDetalleCE);
            this.tbpEliminar.Controls.Add(this.rtxtDetalleCE);
            this.tbpEliminar.Location = new System.Drawing.Point(4, 25);
            this.tbpEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpEliminar.Name = "tbpEliminar";
            this.tbpEliminar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpEliminar.Size = new System.Drawing.Size(481, 483);
            this.tbpEliminar.TabIndex = 2;
            this.tbpEliminar.Text = "Elminar Curso";
            // 
            // txtCodigoCapEli
            // 
            this.txtCodigoCapEli.Enabled = false;
            this.txtCodigoCapEli.Location = new System.Drawing.Point(165, 106);
            this.txtCodigoCapEli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoCapEli.Name = "txtCodigoCapEli";
            this.txtCodigoCapEli.Size = new System.Drawing.Size(294, 23);
            this.txtCodigoCapEli.TabIndex = 34;
            // 
            // txtNombreEli
            // 
            this.txtNombreEli.Enabled = false;
            this.txtNombreEli.Location = new System.Drawing.Point(165, 75);
            this.txtNombreEli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreEli.Name = "txtNombreEli";
            this.txtNombreEli.Size = new System.Drawing.Size(294, 23);
            this.txtNombreEli.TabIndex = 33;
            // 
            // lblNnomm
            // 
            this.lblNnomm.AutoSize = true;
            this.lblNnomm.Location = new System.Drawing.Point(13, 78);
            this.lblNnomm.Name = "lblNnomm";
            this.lblNnomm.Size = new System.Drawing.Size(114, 16);
            this.lblNnomm.TabIndex = 32;
            this.lblNnomm.Text = "Nombre del Curso";
            // 
            // lblCoddo
            // 
            this.lblCoddo.AutoSize = true;
            this.lblCoddo.Location = new System.Drawing.Point(13, 109);
            this.lblCoddo.Name = "lblCoddo";
            this.lblCoddo.Size = new System.Drawing.Size(145, 16);
            this.lblCoddo.TabIndex = 31;
            this.lblCoddo.Text = "Codigo de Capacitador";
            // 
            // gbpDatosEli
            // 
            this.gbpDatosEli.Controls.Add(this.txtPuestoEli);
            this.gbpDatosEli.Controls.Add(this.lblPuiest);
            this.gbpDatosEli.Controls.Add(this.txtEmailCaEli);
            this.gbpDatosEli.Controls.Add(this.lblNnommb);
            this.gbpDatosEli.Controls.Add(this.txtNombCaEli);
            this.gbpDatosEli.Controls.Add(this.lblEemail);
            this.gbpDatosEli.Enabled = false;
            this.gbpDatosEli.Location = new System.Drawing.Point(6, 161);
            this.gbpDatosEli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbpDatosEli.Name = "gbpDatosEli";
            this.gbpDatosEli.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbpDatosEli.Size = new System.Drawing.Size(463, 118);
            this.gbpDatosEli.TabIndex = 30;
            this.gbpDatosEli.TabStop = false;
            this.gbpDatosEli.Text = "Datos Capacitador";
            // 
            // txtPuestoEli
            // 
            this.txtPuestoEli.Location = new System.Drawing.Point(159, 86);
            this.txtPuestoEli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPuestoEli.Name = "txtPuestoEli";
            this.txtPuestoEli.Size = new System.Drawing.Size(294, 23);
            this.txtPuestoEli.TabIndex = 10;
            // 
            // lblPuiest
            // 
            this.lblPuiest.AutoSize = true;
            this.lblPuiest.Location = new System.Drawing.Point(7, 89);
            this.lblPuiest.Name = "lblPuiest";
            this.lblPuiest.Size = new System.Drawing.Size(46, 16);
            this.lblPuiest.TabIndex = 9;
            this.lblPuiest.Text = "Puesto";
            // 
            // txtEmailCaEli
            // 
            this.txtEmailCaEli.Location = new System.Drawing.Point(159, 55);
            this.txtEmailCaEli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailCaEli.Name = "txtEmailCaEli";
            this.txtEmailCaEli.Size = new System.Drawing.Size(294, 23);
            this.txtEmailCaEli.TabIndex = 8;
            // 
            // lblNnommb
            // 
            this.lblNnommb.AutoSize = true;
            this.lblNnommb.Location = new System.Drawing.Point(7, 27);
            this.lblNnommb.Name = "lblNnommb";
            this.lblNnommb.Size = new System.Drawing.Size(55, 16);
            this.lblNnommb.TabIndex = 6;
            this.lblNnommb.Text = "Nombre";
            // 
            // txtNombCaEli
            // 
            this.txtNombCaEli.Location = new System.Drawing.Point(159, 24);
            this.txtNombCaEli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombCaEli.Name = "txtNombCaEli";
            this.txtNombCaEli.Size = new System.Drawing.Size(294, 23);
            this.txtNombCaEli.TabIndex = 7;
            // 
            // lblEemail
            // 
            this.lblEemail.AutoSize = true;
            this.lblEemail.Location = new System.Drawing.Point(7, 58);
            this.lblEemail.Name = "lblEemail";
            this.lblEemail.Size = new System.Drawing.Size(45, 16);
            this.lblEemail.TabIndex = 5;
            this.lblEemail.Text = "E-Mail";
            // 
            // txtCodigoCE
            // 
            this.txtCodigoCE.Location = new System.Drawing.Point(165, 11);
            this.txtCodigoCE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoCE.Name = "txtCodigoCE";
            this.txtCodigoCE.Size = new System.Drawing.Size(214, 23);
            this.txtCodigoCE.TabIndex = 29;
            this.txtCodigoCE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
            // 
            // lblCodECE
            // 
            this.lblCodECE.AutoSize = true;
            this.lblCodECE.Location = new System.Drawing.Point(13, 14);
            this.lblCodECE.Name = "lblCodECE";
            this.lblCodECE.Size = new System.Drawing.Size(110, 16);
            this.lblCodECE.TabIndex = 28;
            this.lblCodECE.Text = "Codigo del Curso";
            // 
            // btnBuscarCE
            // 
            this.btnBuscarCE.Location = new System.Drawing.Point(385, 10);
            this.btnBuscarCE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarCE.Name = "btnBuscarCE";
            this.btnBuscarCE.Size = new System.Drawing.Size(74, 25);
            this.btnBuscarCE.TabIndex = 27;
            this.btnBuscarCE.Text = "Buscar";
            this.btnBuscarCE.UseVisualStyleBackColor = true;
            this.btnBuscarCE.Click += new System.EventHandler(this.btnBuscarCE_Click);
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.Enabled = false;
            this.btnEliminarC.Location = new System.Drawing.Point(388, 445);
            this.btnEliminarC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(87, 28);
            this.btnEliminarC.TabIndex = 26;
            this.btnEliminarC.Text = "Eliminar";
            this.btnEliminarC.UseVisualStyleBackColor = true;
            this.btnEliminarC.Click += new System.EventHandler(this.btnEliminarC_Click);
            // 
            // lblDetalleCE
            // 
            this.lblDetalleCE.AutoSize = true;
            this.lblDetalleCE.Location = new System.Drawing.Point(13, 287);
            this.lblDetalleCE.Name = "lblDetalleCE";
            this.lblDetalleCE.Size = new System.Drawing.Size(152, 16);
            this.lblDetalleCE.TabIndex = 25;
            this.lblDetalleCE.Text = "Detalles de Capacitación";
            // 
            // rtxtDetalleCE
            // 
            this.rtxtDetalleCE.Enabled = false;
            this.rtxtDetalleCE.Location = new System.Drawing.Point(6, 307);
            this.rtxtDetalleCE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtDetalleCE.Name = "rtxtDetalleCE";
            this.rtxtDetalleCE.Size = new System.Drawing.Size(469, 130);
            this.rtxtDetalleCE.TabIndex = 24;
            this.rtxtDetalleCE.Text = "";
            // 
            // dvgEmpleadosMostrar
            // 
            this.dvgEmpleadosMostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvgEmpleadosMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEmpleadosMostrar.Location = new System.Drawing.Point(509, 38);
            this.dvgEmpleadosMostrar.Name = "dvgEmpleadosMostrar";
            this.dvgEmpleadosMostrar.Size = new System.Drawing.Size(661, 277);
            this.dvgEmpleadosMostrar.TabIndex = 1;
            // 
            // lblAser
            // 
            this.lblAser.AutoSize = true;
            this.lblAser.Location = new System.Drawing.Point(509, 13);
            this.lblAser.Name = "lblAser";
            this.lblAser.Size = new System.Drawing.Size(51, 16);
            this.lblAser.TabIndex = 2;
            this.lblAser.Text = "Campo";
            // 
            // cmbEncabezado
            // 
            this.cmbEncabezado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncabezado.FormattingEnabled = true;
            this.cmbEncabezado.Location = new System.Drawing.Point(565, 10);
            this.cmbEncabezado.Name = "cmbEncabezado";
            this.cmbEncabezado.Size = new System.Drawing.Size(202, 24);
            this.cmbEncabezado.TabIndex = 3;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(828, 10);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(262, 23);
            this.txtBuscador.TabIndex = 4;
            // 
            // btnBuscarEmp
            // 
            this.btnBuscarEmp.Location = new System.Drawing.Point(1096, 10);
            this.btnBuscarEmp.Name = "btnBuscarEmp";
            this.btnBuscarEmp.Size = new System.Drawing.Size(74, 23);
            this.btnBuscarEmp.TabIndex = 5;
            this.btnBuscarEmp.Text = "Buscar";
            this.btnBuscarEmp.UseVisualStyleBackColor = true;
            this.btnBuscarEmp.Click += new System.EventHandler(this.btnBuscarEmp_Click);
            // 
            // lblEsft
            // 
            this.lblEsft.AutoSize = true;
            this.lblEsft.Location = new System.Drawing.Point(773, 13);
            this.lblEsft.Name = "lblEsft";
            this.lblEsft.Size = new System.Drawing.Size(49, 16);
            this.lblEsft.TabIndex = 6;
            this.lblEsft.Text = "Igual A";
            // 
            // lsvInfoCap
            // 
            this.lsvInfoCap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmhCodigoCap,
            this.clmhCursoCap,
            this.clmhCapacitador});
            this.lsvInfoCap.HideSelection = false;
            this.lsvInfoCap.Location = new System.Drawing.Point(509, 319);
            this.lsvInfoCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvInfoCap.Name = "lsvInfoCap";
            this.lsvInfoCap.Size = new System.Drawing.Size(661, 207);
            this.lsvInfoCap.TabIndex = 7;
            this.lsvInfoCap.UseCompatibleStateImageBehavior = false;
            this.lsvInfoCap.View = System.Windows.Forms.View.Details;
            // 
            // clmhCodigoCap
            // 
            this.clmhCodigoCap.Text = "Codigo";
            this.clmhCodigoCap.Width = 67;
            // 
            // clmhCursoCap
            // 
            this.clmhCursoCap.Text = "Curso";
            this.clmhCursoCap.Width = 165;
            // 
            // clmhCapacitador
            // 
            this.clmhCapacitador.Text = "Capacitador";
            this.clmhCapacitador.Width = 263;
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1182, 539);
            this.Controls.Add(this.lsvInfoCap);
            this.Controls.Add(this.lblEsft);
            this.Controls.Add(this.btnBuscarEmp);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.cmbEncabezado);
            this.Controls.Add(this.lblAser);
            this.Controls.Add(this.dvgEmpleadosMostrar);
            this.Controls.Add(this.tbcCursos);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCursos";
            this.Text = "302 - Cursos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCursos_KeyDown);
            this.tbcCursos.ResumeLayout(false);
            this.tbpIngresar.ResumeLayout(false);
            this.tbpIngresar.PerformLayout();
            this.gbpDatos.ResumeLayout(false);
            this.gbpDatos.PerformLayout();
            this.tbpEditar.ResumeLayout(false);
            this.tbpEditar.PerformLayout();
            this.gbpDatosEdit.ResumeLayout(false);
            this.gbpDatosEdit.PerformLayout();
            this.tbpEliminar.ResumeLayout(false);
            this.tbpEliminar.PerformLayout();
            this.gbpDatosEli.ResumeLayout(false);
            this.gbpDatosEli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmpleadosMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCursos;
        private System.Windows.Forms.TabPage tbpIngresar;
        private System.Windows.Forms.Label lblDetalleC;
        private System.Windows.Forms.RichTextBox rtxtDetalleC;
        private System.Windows.Forms.GroupBox gbpDatos;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.TextBox txtNombC;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCodigoCapacit;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label lblNombCurso;
        private System.Windows.Forms.Label lblCodCapacitador;
        private System.Windows.Forms.TabPage tbpEditar;
        private System.Windows.Forms.Button btnIngresarC;
        private System.Windows.Forms.TextBox txtCodigoCap;
        private System.Windows.Forms.Label lblCodCap;
        private System.Windows.Forms.Button btnBuscarCap;
        private System.Windows.Forms.Button btnEditarCap;
        private System.Windows.Forms.Label lblDetalleEdit;
        private System.Windows.Forms.RichTextBox rtxtDetalleEdit;
        private System.Windows.Forms.TabPage tbpEliminar;
        private System.Windows.Forms.TextBox txtCodigoCE;
        private System.Windows.Forms.Label lblCodECE;
        private System.Windows.Forms.Button btnBuscarCE;
        private System.Windows.Forms.Button btnEliminarC;
        private System.Windows.Forms.Label lblDetalleCE;
        private System.Windows.Forms.RichTextBox rtxtDetalleCE;
        private System.Windows.Forms.TextBox txtCodigoCurso;
        private System.Windows.Forms.Label lblCodCur;
        private System.Windows.Forms.TextBox txtPuestoCurC;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Button btnBuscarCapacit;
        private System.Windows.Forms.TextBox txtCodigoCapCE;
        private System.Windows.Forms.TextBox txtNombreCE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCodiCapa;
        private System.Windows.Forms.GroupBox gbpDatosEdit;
        private System.Windows.Forms.TextBox txtPuestoDCE;
        private System.Windows.Forms.Label lblPuestoo;
        private System.Windows.Forms.TextBox txtEmailDCE;
        private System.Windows.Forms.Label lblNommm;
        private System.Windows.Forms.TextBox txtNombreDCE;
        private System.Windows.Forms.Label lblCorr;
        private System.Windows.Forms.Button btnActualizarCE;
        private System.Windows.Forms.TextBox txtCodigoCapEli;
        private System.Windows.Forms.TextBox txtNombreEli;
        private System.Windows.Forms.Label lblNnomm;
        private System.Windows.Forms.Label lblCoddo;
        private System.Windows.Forms.GroupBox gbpDatosEli;
        private System.Windows.Forms.TextBox txtPuestoEli;
        private System.Windows.Forms.Label lblPuiest;
        private System.Windows.Forms.TextBox txtEmailCaEli;
        private System.Windows.Forms.Label lblNnommb;
        private System.Windows.Forms.TextBox txtNombCaEli;
        private System.Windows.Forms.Label lblEemail;
        private System.Windows.Forms.DataGridView dvgEmpleadosMostrar;
        private System.Windows.Forms.Label lblAser;
        private System.Windows.Forms.ComboBox cmbEncabezado;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Button btnBuscarEmp;
        private System.Windows.Forms.Label lblEsft;
        private System.Windows.Forms.ListView lsvInfoCap;
        private System.Windows.Forms.ColumnHeader clmhCodigoCap;
        private System.Windows.Forms.ColumnHeader clmhCursoCap;
        private System.Windows.Forms.ColumnHeader clmhCapacitador;
    }
}