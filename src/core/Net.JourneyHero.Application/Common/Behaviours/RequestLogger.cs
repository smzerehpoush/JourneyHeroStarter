using MediatR.Pipeline;
using Microsoft.Extensions.Logging;
using Net.JourneyHero.Application.Common.Interfaces;

namespace Net.JourneyHero.Application.Common.Behaviours
{
    public class RequestLogger<TRequest> : IRequestPreProcessor<TRequest> where TRequest : notnull
    {
        private readonly ILogger _logger;
        private readonly ICurrentUserService _currentUserService;

        public RequestLogger(ILogger logger, ICurrentUserService currentUserService)
        {
            _logger = logger;
            _currentUserService = currentUserService;
        }

        public Task Process(TRequest request, CancellationToken cancellationToken)
        {
            var name = typeof(TRequest).Name;

            _logger.LogInformation("Incoming Request: {Name} {@UserId} {@Request}",
                name, _currentUserService.UserId, request);

            return Task.CompletedTask;
        }
    }
}