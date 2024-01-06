

namespace BeyondCloud.Models.HttpModels
{
    public class HttpResponse<T>: HttpResponse
    {
        public new T Data { get; set; }
    }
}
