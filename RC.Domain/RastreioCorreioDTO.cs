using System;
using System.Collections.Generic;

namespace RC.Domain
{
    public class RastreioCorreioDTO
    {
        public List<Objeto> objeto { get; set; }
        public string pesquisa { get; set; }
        public string quantidade { get; set; }
        public string resultado { get; set; }
        public string versao { get; set; }
    }
    public class Endereco
    {
        public string bairro { get; set; }
        public string cep { get; set; }
        public string codigo { get; set; }
        public string latitude { get; set; }
        public string localidade { get; set; }
        public string logradouro { get; set; }
        public string longitude { get; set; }
        public string numero { get; set; }
        public string uf { get; set; }
    }

    public class Destino
    {
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string codigo { get; set; }
        public Endereco endereco { get; set; }
        public string local { get; set; }
        public string uf { get; set; }
    }

    public class Unidade
    {
        public string cidade { get; set; }
        public string codigo { get; set; }
        public Endereco endereco { get; set; }
        public string local { get; set; }
        public string sto { get; set; }
        public string tipounidade { get; set; }
        public string uf { get; set; }
    }

    public class Postagem
    {
        public string ar { get; set; }
        public string cepdestino { get; set; }
        public string datapostagem { get; set; }
        public string dataprogramada { get; set; }
        public string dh { get; set; }
        public string mp { get; set; }
        public string peso { get; set; }
        public string prazotratamento { get; set; }
        public string volume { get; set; }
    }

    public class Evento
    {
        public string cepDestino { get; set; }
        public string criacao { get; set; }
        public string data { get; set; }
        public string dataPostagem { get; set; }
        public string descricao { get; set; }
        public List<Destino> destino { get; set; }
        public string diasUteis { get; set; }
        public string hora { get; set; }
        public string prazoGuarda { get; set; }
        public string status { get; set; }
        public string tipo { get; set; }
        public Unidade unidade { get; set; }
        public Postagem postagem { get; set; }
    }

    public class Objeto
    {
        public string categoria { get; set; }
        public List<Evento> evento { get; set; }
        public string nome { get; set; }
        public string numero { get; set; }
        public string sigla { get; set; }
    }

}
