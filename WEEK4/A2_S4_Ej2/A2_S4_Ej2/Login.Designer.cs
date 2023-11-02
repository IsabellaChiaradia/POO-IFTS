using Dashboard_ClubDeportivo;

namespace A2_S4_Ej2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnClose = new Button();
            bntIngresar = new CustomBotonDos();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(37, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 168);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ScrollBar;
            pictureBox2.Location = new Point(260, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(354, 423);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ScrollBar;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(343, 185);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(204, 40);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ScrollBar;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(343, 257);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(204, 40);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ScrollBar;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(385, 116);
            label1.Name = "label1";
            label1.Size = new Size(104, 45);
            label1.TabIndex = 4;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.ScrollBar;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(354, 194);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(182, 22);
            txtUsuario.TabIndex = 5;
            txtUsuario.Text = "Usuario";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtClave
            // 
            txtClave.BackColor = SystemColors.ScrollBar;
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.ForeColor = SystemColors.InfoText;
            txtClave.Location = new Point(354, 266);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(182, 22);
            txtClave.TabIndex = 6;
            txtClave.Text = "Clave";
            txtClave.Enter += txtClave_Enter;
            txtClave.Leave += txtClave_Leave;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ScrollBar;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(557, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(41, 41);
            btnClose.TabIndex = 9;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Enter += btnClose_Click;
            // 
            // bntIngresar
            // 
            bntIngresar.BackColor = Color.Peru;
            bntIngresar.Cursor = Cursors.Hand;
            bntIngresar.FlatAppearance.BorderSize = 0;
            bntIngresar.FlatStyle = FlatStyle.Flat;
            bntIngresar.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            bntIngresar.ForeColor = Color.White;
            bntIngresar.Location = new Point(365, 324);
            bntIngresar.Name = "bntIngresar";
            bntIngresar.Size = new Size(150, 35);
            bntIngresar.TabIndex = 10;
            bntIngresar.Text = "INGRESAR";
            bntIngresar.UseVisualStyleBackColor = false;
            bntIngresar.Click += bntIngresar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(610, 421);
            Controls.Add(bntIngresar);
            Controls.Add(btnClose);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private PictureBox pictureBox5;
        private Button btnClose;
        private CustomBotonDos bntIngresar;
    }
}