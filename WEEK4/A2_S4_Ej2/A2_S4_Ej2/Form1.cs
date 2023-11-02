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


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string name = txtNombre.Text;
            string lastName = txtApellido.Text;
            string type = cboTipo.Text;


            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Documento inválido. Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            int id;

            if (!int.TryParse(txtDocumento.Text, out id))
            {
                MessageBox.Show("Documento inválido. Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Postulante candidate = new Postulante(name, lastName, type, id);

            dbgrdPostulante.Rows.Add(candidate.Nombre, candidate.Apellido, candidate.Tipo, candidate.Documento);

            MessageBox.Show("NOMBRE: " + candidate.Nombre + "   APELLIDO:   " +
                candidate.Apellido + "   TIPO DE ID:   " + candidate.Tipo + "     DOCUMENTO:   "
                 + candidate.Documento, "INGRESO DEL CANDIDATO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNombre.Text = "Nombre";
            txtApellido.Text = "Apellido";
            cboTipo.Text = "";
            txtDocumento.Text = "Documento";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "Nombre";
            txtApellido.Text = "Apellido";
            cboTipo.Text = "";
            txtDocumento.Text = "Documento";


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
            }
        }

        private void txtDocumento_Enter(object sender, EventArgs e)
        {
            if (txtDocumento.Text == "Documento")
            {
                txtDocumento.Text = "";
            }
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            if (txtDocumento.Text == "")
            {
                txtDocumento.Text = "Documento";
            }
        }
    }
}