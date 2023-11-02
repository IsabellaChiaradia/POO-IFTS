using A2_S4_Ej2;

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

            DataGridViewTextBoxColumn nombreColumn = new DataGridViewTextBoxColumn();
            nombreColumn.HeaderText = "Nombre";
            dbgrdPostulante.Columns.Add(nombreColumn);

            DataGridViewTextBoxColumn apellidoColumn = new DataGridViewTextBoxColumn();
            apellidoColumn.HeaderText = "Apellido";
            dbgrdPostulante.Columns.Add(apellidoColumn);

            DataGridViewTextBoxColumn tipoColumn = new DataGridViewTextBoxColumn();
            tipoColumn.HeaderText = "Tipo";
            dbgrdPostulante.Columns.Add(tipoColumn);

            DataGridViewTextBoxColumn documentoColumn = new DataGridViewTextBoxColumn();
            documentoColumn.HeaderText = "Documento";
            dbgrdPostulante.Columns.Add(documentoColumn);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string name = txtNombre.Text;
            string lastName = txtApellido.Text;
            string type = cboTipo.Text;


            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Documento inválido. Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del evento sin procesar más
            }

            int id;

            if (!int.TryParse(txtDocumento.Text, out id))
            {
                MessageBox.Show("Documento inválido. Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del evento sin procesar más
            }

            Postulante candidate = new Postulante(name, lastName, type, id);

            dbgrdPostulante.Rows.Add(candidate.Nombre, candidate.Apellido, candidate.Tipo, candidate.Documento);

            MessageBox.Show("NOMBRE: " + candidate.Nombre + "   APELLIDO:   " +
                candidate.Apellido + "   TIPO DE ID:   " + candidate.Tipo + "     DOCUMENTO:   "
                 + candidate.Documento, "INGRESO DEL CANDIDATO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNombre.Text = "";
            txtApellido.Text = "";
            cboTipo.Text = "";
            txtDocumento.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cboTipo.Text = "";
            txtDocumento.Text = "";


        }
    }
}