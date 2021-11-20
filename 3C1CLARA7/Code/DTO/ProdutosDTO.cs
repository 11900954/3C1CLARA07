namespace _3C1CLARA7.Code.DTO
{
    class ProdutosDTO
    {
        private int _id, _quantidade;
        private string _produto, _categoria;
        private double _preco;

        public int Id { get => _id; set => _id = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public string Produto { get => _produto; set => _produto = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public double Preco { get => _preco; set => _preco = value; }
    }
}
