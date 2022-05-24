namespace TechnicalTassk.Services
{
    public class WrappersResponse<T>
    {
        public WrappersResponse()
        {

        }
        public WrappersResponse(T data)
        {
            Succeeded = true;
            Message = string.Empty;
            Errors = null;
            Data = data;
        }
        public T Data { get; set; }
        public bool Succeeded { get; set; }
        public string[] Errors { get; set; }
        public string Message { get; set; }
    }
}
