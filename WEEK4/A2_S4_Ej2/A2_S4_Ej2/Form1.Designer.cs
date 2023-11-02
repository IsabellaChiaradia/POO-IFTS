namespace PrimerForm
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            lblDocumento = new Label();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            cboTipo = new ComboBox();
            label1 = new Label();
            dbgrdPostulante = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dbgrdPostulante).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(92, 42);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(168, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(92, 93);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(337, 161);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 3;
            lblDocumento.Text = "Documento";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(168, 85);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(233, 23);
            txtApellido.TabIndex = 4;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(413, 153);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(233, 23);
            txtDocumento.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(515, 22);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(131, 35);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(515, 85);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(131, 33);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(168, 153);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 161);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 9;
            label1.Text = "Tipo";
            // 
            // dbgrdPostulante
            // 
            dbgrdPostulante.AllowUserToAddRows = false;
            dbgrdPostulante.AllowUserToDeleteRows = false;
            dbgrdPostulante.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dbgrdPostulante.BackgroundColor = SystemColors.ButtonFace;
            dbgrdPostulante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbgrdPostulante.Location = new Point(92, 223);
            dbgrdPostulante.Name = "dbgrdPostulante";
            dbgrdPostulante.RowTemplate.Height = 25;
            dbgrdPostulante.Size = new Size(554, 186);
            dbgrdPostulante.TabIndex = 10;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(735, 421);
            Controls.Add(dbgrdPostulante);
            Controls.Add(label1);
            Controls.Add(cboTipo);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(lblDocumento);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PRIMER PROYECTO";
            ((System.ComponentModel.ISupportInitialize)dbgrdPostulante).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private Label lblDocumento;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private Button btnIngresar;
        private Button btnLimpiar;
        private ComboBox cboTipo;
        private Label label1;
        private DataGridView dbgrdPostulante;
    }
}