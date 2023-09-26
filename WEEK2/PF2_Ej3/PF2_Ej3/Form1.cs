namespace PF2_Ej3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dato 1: " + dato1.Text + " dato 2: " + dato2.Text, "DATOS DESDE TextBox", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string datoUno;
            string datoDos;

            datoUno = Convert.ToString(Microsoft.VisualBasic.Interaction.InputBox("Ingresar el valor del DATO 1",
            "PRIMER DATO", "Ingrese aquí"));

            datoDos = Convert.ToString(Microsoft.VisualBasic.Interaction.InputBox("Ingresar el valor del DATO 2",
            "SEGUNDO DATO", "Ingrese aquí"));

            MessageBox.Show("El DATO 1 ES: →   " + datoUno + "  y el DATO 2 es:  →  " + datoDos,
                "DATOS DESDE EL CUADRO DE DÍALOGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            double numUno;
            double numDos;

            numUno = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa el NÚMERO 1",
                "NÚMERO UNO", "Ingrese aquí"));

            numDos = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingresa el NÚMERO 2",
                "NÚMERO DOS", "Ingrese aquí"));

            if (numUno > numDos)
            {
                MessageBox.Show("El NÚMERO 1 es mayor que el NÚMERO 2",
                    "EL NÚMERO MAYOR ES: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El NÚMERO 2 es mayor que el NÚMERO 1",
                    "EL NÚMERO MAYOR ES: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}