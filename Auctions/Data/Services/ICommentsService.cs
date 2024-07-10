using Auctions.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Auctions.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
