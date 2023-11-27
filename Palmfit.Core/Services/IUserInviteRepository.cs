using Core.Helpers;
using Palmfit.Data.Entities;

namespace Core.Services
{
    public interface IUserInviteRepository
    {
        Task<PaginParameter<Invite>> GetAllUserInvitesAsync(int page, int pageSize);
    }
}
