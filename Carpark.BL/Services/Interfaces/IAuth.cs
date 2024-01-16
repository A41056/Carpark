using Carpark.Data.Models;

namespace Carpark.BL.Services.Interfaces
{
    public interface IAuth
    {
        Task<string> Authenticate(LoginRequest request);
    }
}
