using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Interfaces.API.Modelos
{
    public interface IModelosController
    {
        Task<IActionResult> Obtener(Guid IdModelo);
    }
}
