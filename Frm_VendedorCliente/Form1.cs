using BibliotecaDeClases;
using System.Media;

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
            SoundPlayer sonidoLogueo = new SoundPlayer();
            sonidoLogueo.SoundLocation = "C:/Users/GAMER ASUS/Downloads/compraa.wav";
            sonidoLogueo.Play();
            Frm_LoginVendedor formLogin = new Frm_LoginVendedor();
            formLogin.Show();
            this.Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            SoundPlayer sonidoLogueo = new SoundPlayer();
            sonidoLogueo.SoundLocation = "C:/Users/GAMER ASUS/Downloads/compraa.wav";
            sonidoLogueo.Play();
            Frm_LoginCliente formLogin = new Frm_LoginCliente();
            formLogin.Show();
            this.Hide();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SoundPlayer sonidoCerrar = new SoundPlayer();
            sonidoCerrar.SoundLocation = "C:/Users/GAMER ASUS/Downloads/cerrar_1.wav";
            sonidoCerrar.Play();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}