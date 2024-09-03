using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            dgvAlunos.Rows.Add(txtNome.Text, txtCurso.Text);
            txtNome.Clear();
            txtCurso.Clear();
            MessageBox.Show("Aluno incluido com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblTotal.Text = dgvAlunos.RowCount.ToString();
            txtNome.Focus();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.RowCount > 0)
            {
                dgvAlunos.Rows.RemoveAt(dgvAlunos.CurrentRow.Index);
                MessageBox.Show("Aluno excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTotal.Text = dgvAlunos.RowCount.ToString();
            }
            else
            {
                MessageBox.Show("Não há nenhum aluno para ser excluído", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAlteracao.Text = dgvAlunos.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.RowCount > 0)
            {
                dgvAlunos.CurrentRow.Cells[0].Value = txtAlteracao.Text;
                MessageBox.Show("Aluno alterado com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não há nenhum aluno para ser alterado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            dgvAlunos.RowCount = 0;
            lblTotal.Text = dgvAlunos.RowCount.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
