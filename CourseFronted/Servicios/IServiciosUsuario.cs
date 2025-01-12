namespace CourseFronted.Servicios
{
    public interface IServiciosUsuario
    {
        Task<HttpResponseWrapper<T>> GetUsuario<T>(string url);
        Task<HttpResponseWrapper<object>> PostUsuario<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PostUsuario<T, TActionResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> PutUsuario<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PutUsuario<T, TActionResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> DeleteUsuario(string url);
        Task<HttpResponseWrapper<TActionResponse>> DeleteUsuario<TActionResponse>(string url);
        
    }

    public interface IServiciosCursos
    {
        Task<HttpResponseWrapper<T>> GetCursos<T>(string url);
        Task<HttpResponseWrapper<object>> PostCursos<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PostCursos<T, TActionResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> PutCursos<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PutCursos<T, TActionResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> DeleteCursos(string url);
        Task<HttpResponseWrapper<TActionResponse>> DeleteCursos<TActionResponse>(string url);
    }
    public interface IServiciosEstudiantesCursos
    {
        Task<HttpResponseWrapper<T>> GetEstudiantesCursos<T>(string url);
        Task<HttpResponseWrapper<object>> PostEstudiantesCursos<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PostEstudiantesCursos<T, TActionResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> PutEstudiantesCursos<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PutEstudiantesCursos<T, TActionResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> DeleteEstudiantesCursos(string url);
        Task<HttpResponseWrapper<TActionResponse>> DeleteEstudiantesCursos<TActionResponse>(string url);

    }

    public interface IServiciosEvaluaciones
    {
        Task<HttpResponseWrapper<T>> GetEvaluaciones<T>(string url);
        Task<HttpResponseWrapper<object>> PostEvaluaciones<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PostEvaluaciones<T, TActionResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> PutEvaluaciones<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PutEvaluaciones<T, TActionResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> DeleteEvaluaciones(string url);
        Task<HttpResponseWrapper<TActionResponse>> DeleteEvaluaciones<TActionResponse>(string url);

    }

    public interface IServiciosPreguntasEvaluacion
    {
        Task<HttpResponseWrapper<T>> GetPreguntasEvaluacion<T>(string url);
        Task<HttpResponseWrapper<object>> PostPreguntasEvaluacion<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PostPreguntasEvaluacion<T, TActionResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> PutPreguntasEvaluacion<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PutPreguntasEvaluacion<T, TActionResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> DeletePreguntasEvaluacion(string url);
        Task<HttpResponseWrapper<TActionResponse>> DeletePreguntasEvaluacion<TActionResponse>(string url);

    }

    public interface IServiciosRespuestas
    {
        Task<HttpResponseWrapper<T>> GetRespuestas<T>(string url);
        Task<HttpResponseWrapper<object>> PostRespuestas<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PostRespuestas<T, TActionResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> PutRespuestas<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PutRespuestas<T, TActionResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> DeleteRespuestas(string url);
        Task<HttpResponseWrapper<TActionResponse>> DeleteRespuestas<TActionResponse>(string url);
    }
}
