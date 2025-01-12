using CourseFronted.Servicios;

namespace CourseFronted.Servicios
{
    public class ServiciosEstudiantesCursos : IServiciosEstudiantesCursos
    {
        public Task<HttpResponseWrapper<object>> DeleteEstudiantesCursos(string url)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<TActionResponse>> DeleteEstudiantesCursos<TActionResponse>(string url)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<T>> GetEstudiantesCursos<T>(string url)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<object>> PostEstudiantesCursos<T>(string url, T model)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<TActionResponse>> PostEstudiantesCursos<T, TActionResponse>(string url, T model)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<object>> PutEstudiantesCursos<T>(string url, T model)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<TActionResponse>> PutEstudiantesCursos<T, TActionResponse>(string url, T model)
        {
            throw new NotImplementedException();
        }
    }
}
