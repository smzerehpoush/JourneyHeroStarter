using System.Security.Claims;
using Net.JourneyHero.Application.Common.Interfaces;

namespace Net.JourneyHero.WebApi.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            UserId = Guid.NewGuid().ToString();
        }

        public string UserId { get; }
    }
}