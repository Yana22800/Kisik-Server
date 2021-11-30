using Kisik.BusinessLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisik.BusinessLogic.Core.Interfaces
{
    public interface IUserService
    {
        Task<UserInformationBlo> Register(UserInformationBlo userInformationBlo);
        Task<UserInformationBlo> Auth(UserInformationBlo userInformationBlo);
        Task<UserInformationBlo> Update(UserInformationBlo userInformationBlo, UserUpdateBlo userUpdateBlo);
        Task<UserInformationBlo> Get(int userId);
        Task<bool> DoesExist(int numberPrefix, int number);
    }
}
