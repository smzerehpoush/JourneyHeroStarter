namespace Net.JourneyHero.Application.Common.Models
{
    public class Result<TData>
    {
        public Result(ResultStatus status, TData? data = default)
        {
            ResultCode = status.ResultCode;
            ResultMessage = status.ResultMessage;
            Data = data;
        }

        public TData? Data { get; }
        public int ResultCode { get; }
        public string ResultMessage { get; }
    }
}