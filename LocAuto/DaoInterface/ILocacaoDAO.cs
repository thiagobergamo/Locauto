﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DaoInterface
{
    public interface ILocacaoDAO
    {
        void Inserir(Locacao locacao);
    }
}
