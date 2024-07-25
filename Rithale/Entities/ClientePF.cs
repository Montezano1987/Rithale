namespace Rhitale.Entities.Clientes
{
    public class ClientePF : Cliente
    {
        public string CPF { get; set; }

        public ClientePF(string nome, string email, string telefone, string cpf)
            : base(nome, email, telefone)
        {
            CPF = cpf;
        }

        public override string ToString()
        {
            return base.ToString() + $", CPF: {CPF}";
        }
    }
}
