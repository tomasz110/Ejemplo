﻿using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Interfaces.Flujo.Marcas
{
    public interface IMarcasFlujo
    {
        public Task<IEnumerable<MarcasBase>> Obtener();
    }
}
