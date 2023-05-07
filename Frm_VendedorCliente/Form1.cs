namespace Frm_VendedorCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            Frm_LoginVendedor formLogin = new Frm_LoginVendedor();
            formLogin.Show();
            this.Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Frm_LoginCliente formLogin = new Frm_LoginCliente();
            formLogin.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}