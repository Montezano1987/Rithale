namespace Rhitale.Entities.Clientes
{
    public class ClientePJ : Cliente
    {
        public string CNPJ { get; set; }

        public ClientePJ(string nome, string email, string telefone, string cnpj)
            : base(nome, email, telefone)
        {
            CNPJ = cnpj;
        }

        public override string ToString()
        {
            return base.ToString() + $", CNPJ: {CNPJ}";
        }
    }
}
