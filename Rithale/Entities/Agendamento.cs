using Rhitale.Entities.Enums;

namespace Rhitale.Entities;
public class Agendamento
{
    public Cliente Cliente { get; set; }
    public Profissional Profissional { get; set; }
    public Servico Servico { get; set; }
    public DateTime Data { get; set; }
    public StatusAgendamento Status { get; set; }
    public TimeSpan Hora { get; set; }

    public Agendamento(Cliente cliente, Profissional profissional, Servico servico, DateTime data, TimeSpan hora, StatusAgendamento status)
    {
        Cliente = cliente;
        Profissional = profissional;
        Servico = servico;
        Data = data;
        Status = status;
        Hora = hora;
    }

    public override string ToString()
    {
        return $"Agendamento: {Cliente}, {Profissional}, {Servico}, Data: {Data:dd/MM/yyyy}, Hora: {Hora:HH/mm}, Status: {Status}";
    }
}