using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace ContaBancaria.Herança
{
    public interface IBaseRepository <Tentity>
    {
        void Save(Tentity entity);
        void Update(int id);
        void Delete(int id);
        
    }
}