namespace PrimerForm
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            cboTipo.Items.Add("DNI");
            cboTipo.Items.Add("Pasaporte");
            cboTipo.Items.Add("Extranjero");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string name;
            string lastName;
            string type;
            int id;

            name = txtNombre.Text;
            lastName = txtApellido.Text;
            type = cboTipo.Text;
            id = Convert.ToInt32(txtDocumento.Text);

            Postulante candidate = new Postulante(name,lastName,type,id);

            MessageBox.Show("NOMBRE: " + candidate.Nombre + "   APELLIDO:   " +
                candidate.Apellido + "   TIPO DE ID:   " + candidate.Tipo + "     DOCUMENTO:   "
                 + candidate.Documento, "INGRESO DEL CANDIDATO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}