namespace QuickBuy.Dominio.Entidades
{
   public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Preco { get; set; }
        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
