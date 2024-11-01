using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class FormCadastroAluno : MaterialForm
    {
        string alunoFileName = "aluno.txt";
        bool isAteracao = false;
        int indexSelecionado = 0;

        public FormCadastroAluno()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                Salvar();
                TabControlCadastro.SelectedIndex = 1;
            }
        }

        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("Matricula é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("O campo Endereço é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("O campo Bairro é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("O campo Cidade é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("O campo Senha é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return false;
            }

            if (!DateTime.TryParse(txtDataNascimento.Text, out DateTime result))
            {
                MessageBox.Show("O campo Data de Nascimento é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataNascimento.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cboEstado.Text))
            {
                MessageBox.Show("O campo Estado é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboEstado.Focus();
                return false;
            }
            return true;
        }

        private void Salvar()
        {
            var line = $"{txtMatricula.Text};" + $"{txtDataNascimento.Text};" + $"{txtNome.Text};" + $"{txtEndereco.Text};" +
                       $"{txtBairro.Text};" + $"{txtCidade.Text};" + $"{cboEstado.Text};" + $"{txtSenha.Text};";

            if (!isAteracao)
            {
                var file = new StreamWriter(alunoFileName, true);
                file.WriteLine(line);
                file.Close();
            }
            else
            {
                string[] alunos = File.ReadAllLines(alunoFileName);
                alunos[indexSelecionado] = line;
                File.WriteAllLines(alunoFileName, alunos);
            }
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            isAteracao = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        private void carregaListView()
        {
            Cursor.Current = Cursors.WaitCursor;
            mlvAlunos.Columns.Clear();
            mlvAlunos.Items.Clear();
            mlvAlunos.Columns.Add("Matricula");
            mlvAlunos.Columns.Add("Data Nascimento");
            mlvAlunos.Columns.Add("Nome");
            mlvAlunos.Columns.Add("Endereço");
            mlvAlunos.Columns.Add("Bairro");
            mlvAlunos.Columns.Add("Cidade");
            mlvAlunos.Columns.Add("Estado");
           

            string[] alunos = File.ReadAllLines(alunoFileName);

            foreach (String aluno in alunos)
            {
                var campos = aluno.Split(';');
                mlvAlunos.Items.Add(new ListViewItem(campos));
            }

            // Ajusta o tamanho das colunas com base no cabeçalho
            foreach (ColumnHeader column in mlvAlunos.Columns)
            {
                column.Width = -2; 
            }

            Cursor.Current = Cursors.Default;
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            carregaListView();
        }

        private void Editar()
        {
            if (mlvAlunos.SelectedIndices.Count > 0)
            {
                indexSelecionado = mlvAlunos.SelectedIndices[0];
                isAteracao = true;
                var item = mlvAlunos.Items[indexSelecionado];
                txtMatricula.Text = item.SubItems[0].Text;
                txtDataNascimento.Text = item.SubItems[1].Text;
                txtNome.Text = item.SubItems[2].Text;
                txtEndereco.Text = item.SubItems[3].Text;
                txtBairro.Text = item.SubItems[4].Text;
                txtCidade.Text = item.SubItems[5].Text;
                cboEstado.Text = item.SubItems[6].Text;
                txtSenha.Text = item.SubItems[7].Text;
                TabControlCadastro.SelectedIndex = 0;
                txtBairro.Focus();
            }
            else
            {
                MessageBox.Show("Selecione um aluno para editar", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Excluir()
        {
            List<string> alunos = File.ReadAllLines(alunoFileName).ToList();
            alunos.RemoveAt(indexSelecionado);
            File.WriteAllLines(alunoFileName, alunos);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void mlvAlunos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (mlvAlunos.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show(this, "Deseja realmente excluir o aluno selecionado?", "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    indexSelecionado = mlvAlunos.SelectedIndices[0];
                    Excluir();
                    carregaListView();
                }
            }
            else
            {
                MessageBox.Show("Selecione um aluno para excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Ateção: informações não salvas serão perdididas", "Confirmação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                TabControlCadastro.SelectedIndex = 1;
            }
        }

        private void btn__novo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            TabControlCadastro.SelectedIndex = 0;
            txtBairro.Focus();
        }
    }
}