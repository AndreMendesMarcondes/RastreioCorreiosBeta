using RC.Domain;
using System.Collections.Generic;

namespace RC.CorreioService.Interface
{
    public interface ICorreioService
    {
        List<RastreioCorreioDTO> Processar(string codigosRastreio);
    }
}
