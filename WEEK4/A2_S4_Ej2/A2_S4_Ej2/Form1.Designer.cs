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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            btnIngresar = new Button();
            btnLimpiar = new Button();
            cboTipo = new ComboBox();
            dbgrdPostulante = new DataGridView();
            btnClose = new Button();
            picName = new PictureBox();
            picApellido = new PictureBox();
            picDocumento = new PictureBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            pictureBox1 = new PictureBox();
            lblTipo = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dbgrdPostulante).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picApellido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDocumento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(534, 88);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(131, 35);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(534, 157);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(131, 33);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cboTipo
            // 
            cboTipo.BackColor = SystemColors.ScrollBar;
            cboTipo.FlatStyle = FlatStyle.Flat;
            cboTipo.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(344, 136);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(136, 29);
            cboTipo.TabIndex = 8;
            // 
            // dbgrdPostulante
            // 
            dbgrdPostulante.AllowUserToAddRows = false;
            dbgrdPostulante.AllowUserToDeleteRows = false;
            dbgrdPostulante.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dbgrdPostulante.BackgroundColor = SystemColors.ButtonFace;
            dbgrdPostulante.BorderStyle = BorderStyle.Fixed3D;
            dbgrdPostulante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbgrdPostulante.Location = new Point(260, 246);
            dbgrdPostulante.Name = "dbgrdPostulante";
            dbgrdPostulante.RowTemplate.Height = 25;
            dbgrdPostulante.Size = new Size(463, 165);
            dbgrdPostulante.TabIndex = 10;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ScrollBar;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(682, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(41, 41);
            btnClose.TabIndex = 11;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // picName
            // 
            picName.BackColor = SystemColors.ScrollBar;
            picName.BackgroundImage = (Image)resources.GetObject("picName.BackgroundImage");
            picName.BackgroundImageLayout = ImageLayout.Stretch;
            picName.Location = new Point(287, 22);
            picName.Name = "picName";
            picName.Size = new Size(204, 40);
            picName.TabIndex = 12;
            picName.TabStop = false;
            // 
            // picApellido
            // 
            picApellido.BackColor = SystemColors.ScrollBar;
            picApellido.BackgroundImage = (Image)resources.GetObject("picApellido.BackgroundImage");
            picApellido.BackgroundImageLayout = ImageLayout.Stretch;
            picApellido.Location = new Point(287, 78);
            picApellido.Name = "picApellido";
            picApellido.Size = new Size(204, 40);
            picApellido.TabIndex = 13;
            picApellido.TabStop = false;
            // 
            // picDocumento
            // 
            picDocumento.BackColor = SystemColors.ScrollBar;
            picDocumento.BackgroundImage = (Image)resources.GetObject("picDocumento.BackgroundImage");
            picDocumento.BackgroundImageLayout = ImageLayout.Stretch;
            picDocumento.Location = new Point(287, 179);
            picDocumento.Name = "picDocumento";
            picDocumento.Size = new Size(204, 40);
            picDocumento.TabIndex = 14;
            picDocumento.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ScrollBar;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(298, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(182, 22);
            txtNombre.TabIndex = 15;
            txtNombre.Text = "Nombre";
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = SystemColors.ScrollBar;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(298, 88);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(182, 22);
            txtApellido.TabIndex = 16;
            txtApellido.Text = "Apellido";
            txtApellido.Enter += txtApellido_Enter;
            txtApellido.Leave += txtApellido_Leave;
            // 
            // txtDocumento
            // 
            txtDocumento.BackColor = SystemColors.ScrollBar;
            txtDocumento.BorderStyle = BorderStyle.None;
            txtDocumento.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumento.Location = new Point(298, 188);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(182, 22);
            txtDocumento.TabIndex = 17;
            txtDocumento.Text = "Documento";
            txtDocumento.Enter += txtDocumento_Enter;
            txtDocumento.Leave += txtDocumento_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ScrollBar;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(287, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 40);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(298, 141);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(40, 21);
            lblTipo.TabIndex = 20;
            lblTipo.Text = "Tipo";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(30, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(173, 168);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(236, 429);
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(735, 421);
            Controls.Add(pictureBox2);
            Controls.Add(cboTipo);
            Controls.Add(lblTipo);
            Controls.Add(pictureBox1);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(picDocumento);
            Controls.Add(picApellido);
            Controls.Add(picName);
            Controls.Add(btnClose);
            Controls.Add(dbgrdPostulante);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PRIMER PROYECTO";
            ((System.ComponentModel.ISupportInitialize)dbgrdPostulante).EndInit();
            ((System.ComponentModel.ISupportInitialize)picName).EndInit();
            ((System.ComponentModel.ISupportInitialize)picApellido).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDocumento).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIngresar;
        private Button btnLimpiar;
        private ComboBox cboTipo;
        private DataGridView dbgrdPostulante;
        private Button btnClose;
        private PictureBox picName;
        private PictureBox picApellido;
        private PictureBox picDocumento;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private PictureBox pictureBox1;
        private Label lblTipo;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}