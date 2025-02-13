using ProjetoLogin.Apresentacao;

namespace ProjetoLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastreSe_Click(object sender, EventArgs e)
        {
            CadastreSe cadastrese = new CadastreSe();
            cadastrese.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
