using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace ContaBancaria.Herança
{
    public interface IBaseService <Tentity>
    {
        void Salvar(Tentity entity);
        void Update(int id);
        void Delete (int id);
        List<Tentity> ObterTodos();
        
    }
}