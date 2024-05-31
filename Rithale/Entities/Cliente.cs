namespace Rhitale.Entities;
public class Cliente
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }

    public Cliente(string nome, string cpf, string email, string telefone)
    {
        Nome = nome;
        Cpf = cpf;
        Email = email;
        Telefone = telefone;
    }

    public override string ToString()
    {
        return $"Cliente: {Nome}, CPF: {Cpf}, Email: {Email}, Telefone: {Telefone}";
    }
}
