namespace PF2_Ej3
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            dato1 = new TextBox();
            dato2 = new TextBox();
            button1 = new Button();
            btnCalculo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 69);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "DATO 1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 141);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "DATO 2";
            // 
            // dato1
            // 
            dato1.Location = new Point(109, 66);
            dato1.Name = "dato1";
            dato1.Size = new Size(148, 23);
            dato1.TabIndex = 2;
            dato1.TextChanged += textBox1_TextChanged;
            // 
            // dato2
            // 
            dato2.Location = new Point(109, 138);
            dato2.Name = "dato2";
            dato2.Size = new Size(148, 23);
            dato2.TabIndex = 3;
            dato2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(119, 180);
            button1.Name = "button1";
            button1.Size = new Size(125, 39);
            button1.TabIndex = 4;
            button1.Text = "ACEPTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCalculo
            // 
            btnCalculo.Location = new Point(119, 255);
            btnCalculo.Name = "btnCalculo";
            btnCalculo.Size = new Size(125, 39);
            btnCalculo.TabIndex = 5;
            btnCalculo.Text = "CALCULO";
            btnCalculo.UseVisualStyleBackColor = true;
            btnCalculo.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 321);
            Controls.Add(btnCalculo);
            Controls.Add(button1);
            Controls.Add(dato2);
            Controls.Add(dato1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "INGRESO Y MUESTRA DE DATOS";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox dato1;
        private TextBox dato2;
        private Button button1;
        private Button btnCalculo;
    }
}