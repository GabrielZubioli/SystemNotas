using System.Drawing.Text;

namespace SistemaNotas
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
            try
            {
                const string server = "localHost";
                const string database = "dbSystemNotas";
                const string user = "zubioli";
                const string password = "99458163";

                string conexaoBanco = $"server={server}; user id={user}; database = {database}; password = {password}";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message);
            }
        }
    }
}
