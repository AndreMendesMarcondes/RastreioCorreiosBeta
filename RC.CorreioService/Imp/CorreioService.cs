using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RC.CorreioService.Interface;
using RC.Domain;
using RestSharp;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RC.CorreioService.Imp
{
    public class CorreioService : ICorreioService
    {
        private readonly RestClient _client;

        public CorreioService(IConfiguration configuration)
        {
            _client = new RestClient(configuration["CorreioApiURL"]);
        }


        public RastreioCorreioDTO Processar(string codigosRastreio)
        {
            string todosOsCodigosDeRastreio = "";

            foreach (var codigo in codigosRastreio.Split(","))
                todosOsCodigosDeRastreio += codigo;

            RastreioCorreioDTO retorno = Get(todosOsCodigosDeRastreio);
            return retorno;
        }

        private RastreioCorreioDTO Get(string codigoRastreio)
        {
            RastreioCorreioDTO rastreio = new();
            _client.Timeout = -1;
            var request = new RestRequest("/api/rastreio", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            var body = new CorreioRequestDTO(codigoRastreio).ToString();
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = _client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                rastreio = JsonConvert.DeserializeObject<RastreioCorreioDTO>(response.Content);
            }

            return rastreio;
        }
    }
}
