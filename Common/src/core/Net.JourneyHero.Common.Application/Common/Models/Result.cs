namespace Net.JourneyHero.Application.Common.Models
{
    public class Result<TData>
    {
        private Result(ResultStatus status, TData? data = default)
        {
            ResultCode = status.ResultCode;
            ResultMessage = status.ResultMessage;
            Data = data;
        }

        public TData? Data { get; }
        public int ResultCode { get; }
        public string ResultMessage { get; }

        public static Result<TData> Succeed(TData data)
        {
            return new Result<TData>(ResultStatus.Ok, data);
        }

        public static Result<object> Succeed()
        {
            return new Result<object>(ResultStatus.Ok);
        }
    }
}