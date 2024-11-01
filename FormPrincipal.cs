using ReaLTaiizor.Forms;

namespace ProjetoCadastro
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroAluno formAluno = new FormCadastroAluno();
            formAluno.MdiParent = this;
            formAluno.Show();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }

        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCurso1 formCurso = new CadastroCurso1();
            formCurso.MdiParent = this;
            formCurso.Show();
        }
    }
}
