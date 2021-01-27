using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace ContaBancaria.Herança
{
    public interface IContaInvestimentoRepository : IBaseRepository<ContaInvenstimento>
    {
        void ResgatarTitulo(ContaInvenstimento contaInvenstimento);
        List <ContaInvenstimento> ListarInvestimento();
        List<ContaInvenstimento> ListarInvestimentosPorData(DateTime dataInicio,DateTime dataFim);
        void Investir(ContaInvenstimento contaInvenstimento);
    }
}