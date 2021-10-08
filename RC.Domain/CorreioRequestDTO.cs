using Newtonsoft.Json;

namespace RC.Domain
{
    public class CorreioRequestDTO
    {
        public CorreioRequestDTO(string code)
        {
            this.code = code;
        }

        public string type { get; private set; } = "LS";
        public string code { get; private set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
