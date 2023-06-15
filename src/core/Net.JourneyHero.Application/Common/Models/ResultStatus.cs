namespace Net.JourneyHero.Application.Common.Models;

public class ResultStatus
{
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