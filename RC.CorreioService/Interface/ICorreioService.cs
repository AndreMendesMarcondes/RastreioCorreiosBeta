using RC.Domain;

namespace RC.CorreioService.Interface
{
    public interface ICorreioService
    {
        RastreioCorreioDTO Processar(string codigosRastreio);
    }
}
