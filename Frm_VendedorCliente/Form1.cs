namespace Frm_VendedorCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonVendedor_Click(object sender, EventArgs e)
        {
            Frm_LoginVendedor formLogin = new Frm_LoginVendedor();
            formLogin.Show();
        }

        private void botonCliente_Click(object sender, EventArgs e)
        {
            Frm_LoginVendedor formLogin = new Frm_LoginVendedor();
            formLogin.Show();
        }
    }
}