﻿using System.Collections.Generic;
using TOTVS.PDV.Services.Models;

namespace TOTVS.PDV.Services.Contracts
{
    public interface IDinheiroService
    {
        List<Dinheiro> ObterTodos();
    }
}
