using _3C1CLARA7.Code.DAL;
using _3C1CLARA7.Code.DTO;
using System.Data;

namespace _3C1CLARA7.Code.BLL
{
    class ProdutosBLL
    {
        //Objeto para acesso ao banco de dados
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_Produtos";


        //O método de inserir recebe os dados via DTO 
        //e envia para o banco de dados através da classe AcessoBancoDados
        public void Inserir(ProdutosDTO medDto)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values(null,'{medDto.Produto}','{medDto.Categoria}','{medDto.Quantidade}','{medDto.Preco}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(ProdutosDTO medDto)
        {
            string editar = $"update {tabela} set Produto = '{medDto.Produto}', categoria = '{medDto.Categoria}', quantidade = '{medDto.Quantidade}', preco = '{medDto.Preco}' where id = '{medDto.Id}';";
            conexao.ExecutarComando(editar);
        }
        public void Excluir(ProdutosDTO medDto)
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
