
namespace CourseFronted.Servicios
{
    public class ServiciosRespuestas : IServiciosRespuestas
    {
        public Task<HttpResponseWrapper<object>> DeleteRespuestas(string url)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<TActionResponse>> DeleteRespuestas<TActionResponse>(string url)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<T>> GetRespuestas<T>(string url)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<object>> PostRespuestas<T>(string url, T model)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<TActionResponse>> PostRespuestas<T, TActionResponse>(string url, T model)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<object>> PutRespuestas<T>(string url, T model)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<TActionResponse>> PutRespuestas<T, TActionResponse>(string url, T model)
        {
            throw new NotImplementedException();
        }
    }
}
