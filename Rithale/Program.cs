using Rhitale.Entities;
using Rhitale.Entities.Enums;

namespace Rhitale;

class Program
{


    static List<Profissional> profissionais = new List<Profissional>
    {
        new Profissional("Thamiris Montezano", "Biomedica!"),
        new Profissional("Aline Ribeiro", "Esteticista!"),
        new Profissional("Andreia", "Massoterapeuta!"),
        new Profissional("Cassiane", "Manicure!"),
    };

    static List<Servico> servicos = new List<Servico>
    {
        new Servico("Depilação a Laser", 200.00),
        new Servico("Limpeza de Pele", 80.00),
        new Servico("Massagem", 100.00),
        new Servico("Mão e Pé", 50.00),
    };

    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindos a Clínica Rhitale");
        Console.WriteLine();


        Cliente cliente = CriarCliente();
        Profissional profissional = EscolherProfissional();
        Servico servico = EscolherServico();
        DateTime data = EscolherData();
        TimeSpan hora = EscolherHora();

        Agendamento agendamento = new Agendamento(cliente, profissional, servico, data, hora, StatusAgendamento.Pendente);

        Console.WriteLine("Detalhes do Agendamento:");
        Console.WriteLine(agendamento);
    }

    static Cliente CriarCliente()
    {
        Console.WriteLine("Informe os dados do cliente:");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("CPF: ");
        string cpf = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();

        return new Cliente
            (nome, cpf, email, telefone);
    }

    static Profissional EscolherProfissional()
    {
        Console.WriteLine("Escolha um profissional:");
        int i = 1;
        foreach (var profissional in profissionais)
        {
            Console.WriteLine($"{i}. {profissional}");
            i++;
        }

        int escolha;
        while (true)
        {
            Console.Write("Opção: ");
            if (int.TryParse(Console.ReadLine(), out escolha) && escolha >= 1 && escolha <= profissionais.Count)
            {
                return profissionais[escolha - 1];
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }

    static Servico EscolherServico()
    {
        Console.WriteLine("Escolha um serviço:");
        int i = 1;
        foreach (var servico in servicos)
        {
            Console.WriteLine($"{i}. {servico}");
            i++;
        }

        int escolha;
        while (true)
        {
            Console.Write("Opção: ");
            if (int.TryParse(Console.ReadLine(), out escolha) && escolha >= 1 && escolha <= servicos.Count)
            {
                return servicos[escolha - 1];
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }

    static DateTime EscolherData()
    {
        Console.WriteLine("Escolha uma data para o agendamento:");
        DateTime data;
        while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data))
        {
            Console.WriteLine("Formato de data inválido. Tente novamente.");
            Console.Write("Data e Hora (dd/MM/yyyy): ");
        }

        return data;
    }

    static TimeSpan EscolherHora()
    {
        Console.WriteLine("Escolha a hora para o agendamento (HH:mm):");
        TimeSpan hora;

        while (!TimeSpan.TryParseExact(Console.ReadLine(), "HH:mm", null, System.Globalization.TimeSpanStyles.None, out hora))
        {
            Console.WriteLine("Formato de hora inválido. Tente novamente.");
            Console.Write("Hora (HH:mm): ");
        }

        return hora;
    }
}