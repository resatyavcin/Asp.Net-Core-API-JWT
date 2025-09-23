using System.Text.Json.Serialization;

namespace SharedLibrary.Dtos
{
    public class Response<T> where T:class 
    {
        #region properties
        public T Data { get; private set; }
        public int StatusCode { get; private set; }

        [JsonIgnore]
        public bool isSuccessFull { get; set; }
        public ErrorDto Error { get; private set; }
        #endregion

        #region methods
        public static Response<T> Success(T data, int statusCode)
        {
            return new Response<T> { Data = data, StatusCode = statusCode, isSuccessFull = true };
        }

        public static Response<T> Success(int statusCode)
        {
            return new Response<T> { Data = default, StatusCode = statusCode, isSuccessFull = true };
        }
        public static Response<T> Fail(ErrorDto error, int statusCode, bool isShow)
        {
            return new Response<T> { Error = error, StatusCode = statusCode, isSuccessFull = false };
        }
        public static Response<T> Fail(string errorMessage, int statusCode, bool isShow)
        {
            var errorDto = new ErrorDto(errorMessage, isShow);
            return new Response<T> { Error = errorDto, StatusCode = statusCode, isSuccessFull = false };
        }
        #endregion
    }
}
