using System.Security.Principal;

namespace API.Errores
{
    public class ApiException : ApiErrorResponse
    {
        public ApiException(int statusCode, string mensaje = null, string detalle = null): base(statusCode,mensaje)
        {
            
            Detalle = detalle;
        }

        public int StausCode { get; set; }
        public string Mensaje { get; set; }
        public string Detalle { get; set; }
    }
}
