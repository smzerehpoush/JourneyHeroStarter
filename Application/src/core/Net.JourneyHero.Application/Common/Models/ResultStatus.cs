namespace Net.JourneyHero.Application.Common.Models;

public class ResultStatus
{
    public static readonly ResultStatus Ok = new ResultStatus(0, "ok");

    public ResultStatus(int resultCode, string messageKey)
    {
        ResultCode = resultCode;
        MessageKey = messageKey;
    }

    //todo: implement behaviour
    public string ResultMessage => MessageKey;
    public int ResultCode { get; }
    public string MessageKey { get; }
}