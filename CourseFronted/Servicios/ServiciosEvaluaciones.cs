
namespace CourseFronted.Servicios
{
    public class ServiciosEvaluaciones : IServiciosEvaluaciones
    {
        public Task<HttpResponseWrapper<object>> DeleteEvaluaciones(string url)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<TActionResponse>> DeleteEvaluaciones<TActionResponse>(string url)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<T>> GetEvaluaciones<T>(string url)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<object>> PostEvaluaciones<T>(string url, T model)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<TActionResponse>> PostEvaluaciones<T, TActionResponse>(string url, T model)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<object>> PutEvaluaciones<T>(string url, T model)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<TActionResponse>> PutEvaluaciones<T, TActionResponse>(string url, T model)
        {
            throw new NotImplementedException();
        }
    }
}
