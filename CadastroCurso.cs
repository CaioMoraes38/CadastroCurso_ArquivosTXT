using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace ProjetoCadastro
{
    public partial class CadastroCurso1 : MaterialForm
    {
        string cadastroFileName = "Cadastro.txt";
        bool isAlteracao = false;
        int indexSelecionado = 0;

        public CadastroCurso1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                Salvar();
                tabCadastroCurso.SelectedIndex = 1;
            }
        }

        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("Código é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNomeCurso.Text))
            {
                MessageBox.Show("Nome é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeCurso.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cboSemestre.Text))
            {
                MessageBox.Show("O campo Carga Horária é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSemestre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cboPeriodo.Text))
            {
                MessageBox.Show("O campo Semestre é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPeriodo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cboNivel.Text))
            {
                MessageBox.Show("O campo Período é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNivel.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cboArea.Text))
            {
                MessageBox.Show("O campo Valor é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboArea.Focus();
                return false;
            }

            return true;
        }

        private void Salvar()
        {
            var line = $"{txtMatricula.Text};{txtNomeCurso.Text};{cboSemestre.Text};{cboPeriodo.Text};{cboNivel.Text};{cboArea.Text}";

            if (!isAlteracao)
            {
                var file = new StreamWriter(cadastroFileName, true);
                file.WriteLine(line);
                file.Close();
            }
            else
            {
                string[] cursos = File.ReadAllLines(cadastroFileName);
                cursos[indexSelecionado] = line;
                File.WriteAllLines(cadastroFileName, cursos);
            }
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPageCadastroCurso.Controls)
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

        private void carregarListView()
        {
            Cursor.Current = Cursors.WaitCursor;
            mlvConsultaCurso.Columns.Clear();
            mlvConsultaCurso.Items.Clear();
            mlvConsultaCurso.Columns.Add("Código");
            mlvConsultaCurso.Columns.Add("Nome");
            mlvConsultaCurso.Columns.Add("Carga Horária");
            mlvConsultaCurso.Columns.Add("Semestre");
            mlvConsultaCurso.Columns.Add("Período");
            mlvConsultaCurso.Columns.Add("Área");

            string[] cursos = File.ReadAllLines(cadastroFileName);

            foreach (string curso in cursos)
            {
                var dados = curso.Split(';');
                mlvConsultaCurso.Items.Add(new ListViewItem(dados));
            }


            foreach (ColumnHeader column in mlvConsultaCurso.Columns)
            {
                column.Width = -2;
            }

            Cursor.Current = Cursors.Default;
        }

        private void tabPageCadastroCurso_Enter(object sender, EventArgs e)
        {
            carregarListView();
        }

        private void Editar()
        {
            if (mlvConsultaCurso.SelectedIndices.Count > 0)
            {
                indexSelecionado = mlvConsultaCurso.SelectedIndices[0];
                isAlteracao = true;
                var item = mlvConsultaCurso.Items[indexSelecionado];
                txtMatricula.Text = item.SubItems[0].Text;
                txtNomeCurso.Text = item.SubItems[1].Text;
                cboSemestre.Text = item.SubItems[2].Text;
                cboPeriodo.Text = item.SubItems[3].Text;
                cboNivel.Text = item.SubItems[4].Text;
                cboArea.Text = item.SubItems[5].Text;
                tabCadastroCurso.SelectedIndex = 0;
                txtMatricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecione um curso para editar", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Excluir()
        {
            List<string> cursos = File.ReadAllLines(cadastroFileName).ToList();
            cursos.RemoveAt(indexSelecionado);
            File.WriteAllLines(cadastroFileName, cursos);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (mlvConsultaCurso.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show(this, "Deseja realmente excluir o curso selecionado?", "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    indexSelecionado = mlvConsultaCurso.SelectedIndices[0];
                    Excluir();
                    carregarListView();
                }
            }
            else
            {
                MessageBox.Show("Selecione um curso para excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Atenção: informações não salvas serão perdidas", "Confirmação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                tabCadastroCurso.SelectedIndex = 1;
            }
        }

       

        private void mlvConsultaCurso_DoubleClick(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            LimpaCampos();
            tabCadastroCurso.SelectedIndex = 0;
            txtMatricula.Focus();
        }
    }
}