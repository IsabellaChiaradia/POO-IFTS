using PrimerForm;

namespace A2_S4_Ej2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "Clave")
            {
                txtClave.Text = "";
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "Clave";
                txtClave.UseSystemPasswordChar = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Administrador" && txtClave.Text == "Admin1234")
            {
                MessageBox.Show("INGRESO EXITOSO", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                frmPrincipal formularioPrincipal = new frmPrincipal();
                formularioPrincipal.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("USUARIO Y/O CONTRASEÑA INCORRECTO", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

        }
    }
}