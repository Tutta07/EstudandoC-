using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace ContaBancaria.Herança
{
    public interface IContaCorrenteRepository: IBaseRepository<ContaCorrente>
    {
        void ResgatarTitulo();
    }
}