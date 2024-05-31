using System;
using System.Globalization;
using Rhitale.Entities.Enums;

namespace Rhitale.Entities;
public class Agendamento
{
    public Cliente Cliente { get; set; }
    public Profissional Profissional { get; set; }
    public Servico Servico { get; set; }
    public DateTime Data { get; set; }
    public StatusAgendamento Status { get; set; }

    public Agendamento(Cliente cliente, Profissional profissional, Servico servico, DateTime data, StatusAgendamento status)
    {
        Cliente = cliente;
        Profissional = profissional;
        Servico = servico;
        Data = data;
        Status = status;
    }

    public override string ToString()
    {
        return $"Agendamento: {Cliente}, {Profissional}, {Servico}, Data: {Data:dd/MM/yyyy HH/mm}, Status: {Status}";
    }
}