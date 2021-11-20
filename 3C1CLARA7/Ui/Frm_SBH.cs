using _3C1CLARA7.Code.BLL;
using _3C1CLARA7.Code.DTO;
using System;
using System.Windows.Forms;

namespace _3C1CLARA7.Ui
{
    public partial class Frm_SBH : Form
    {
        //Criação dos objetos que acessam a camada de negócio
        ProdutosBLL medbll = new ProdutosBLL();
        ProdutosDTO meddto = new ProdutosDTO();
        public Frm_SBH()
        {
            InitializeComponent();
            dgvEstoque.DataSource = medbll.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto 
            meddto.Produto = txtProduto.Text;
            meddto.Categoria = txtCategoria.Text;
            meddto.Quantidade = int.Parse(txtQuantidade.Text);
            meddto.Preco = double.Parse(txtPreco.Text);

            //Envio do dto preenchido para o método inserir
            medbll.Inserir(meddto);

            //mensagem de cadastrado 
            MessageBox.Show("Cadastrado com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvEstoque.DataSource = medbll.Listar();
            //limpar campos
            txtId.Clear();
            txtProduto.Clear();
            txtCategoria.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto 
            meddto.Id = int.Parse(txtId.Text);
            meddto.Produto = txtProduto.Text;
            meddto.Categoria = txtCategoria.Text;
            meddto.Quantidade = int.Parse(txtQuantidade.Text);
            meddto.Preco = double.Parse(txtPreco.Text);

            //Envio do dto preenchido para o método inserir
            medbll.Editar(meddto);

            //mensagem de cadastrado 
            MessageBox.Show("Editado com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvEstoque.DataSource = medbll.Listar();
            //limpar campos
            txtId.Clear();
            txtProduto.Clear();
            txtCategoria.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto 
            meddto.Id = int.Parse(txtId.Text);
            meddto.Produto = txtProduto.Text;
            meddto.Categoria = txtCategoria.Text;
            meddto.Quantidade = int.Parse(txtQuantidade.Text);
            meddto.Preco = double.Parse(txtPreco.Text);

            //Envio do dto preenchido para o método inserir
            medbll.Excluir(meddto);

            //mensagem de cadastrado 
            MessageBox.Show("Excluido com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvEstoque.DataSource = medbll.Listar();
            //limpar campos
            txtId.Clear();
            txtProduto.Clear();
            txtCategoria.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
        }

        private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
                txtId.Text = dgvEstoque.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtProduto.Text = dgvEstoque.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCategoria.Text = dgvEstoque.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtQuantidade.Text = dgvEstoque.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPreco.Text = dgvEstoque.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch {
                MessageBox.Show("Impossivel selecionar esse campo!!");
            }
        }
    }
}
