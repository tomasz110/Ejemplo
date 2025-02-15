﻿using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Interfaces.DA.Vehiculos
{
    public interface IVehiculosDA
    {
        Task<IEnumerable<VehiculoResponse>> Obtener();
        Task<VehiculoResponse> Obtener(Guid Id);
        Task<Guid> Agregar(VehiculoRequest vehiculo);
        Task<Guid> Editar(Guid Id, VehiculoRequest vehiculo);

        Task<Guid> Eliminar(Guid Id);

    }
}
