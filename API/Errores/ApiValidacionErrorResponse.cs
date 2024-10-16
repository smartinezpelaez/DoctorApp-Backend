using Microsoft.Identity.Client;

namespace API.Errores
{
    public class ApiValidacionErrorResponse : ApiErrorResponse
    {
        public ApiValidacionErrorResponse() : base(400)
        {            
        }

        public IEnumerable<string> Errores { get; set; }



    }
}
