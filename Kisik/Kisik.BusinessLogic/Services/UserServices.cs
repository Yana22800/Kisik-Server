using AutoMapper;
using Kisik.BusinessLogic.Core.Interfaces;
using Kisik.BusinessLogic.Core.Models;
using Kisik.DataAccess.Core.Interfaces;
using Kisik.DataAccess.Core.Models;
using Microsoft.EntityFrameworkCore;
using Shareds.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Kisik.BusinessLogic.Services
{
    public class UserServices : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IContext _contex;

        public UserServices(IMapper mapper, IContext contex)
        {
            _mapper = mapper;
            _contex = contex;
        }

        public Task<UserInformationBlo> Auth(UserInformationBlo userInformationBlo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesExist(int numberPrefix, int number)
        {
            throw new NotImplementedException();
        }

        public async Task<UserInformationBlo> Get(int userId)
        {
            UserRto user = await _contex.Users.FirstOrDefaultAsync(h => h.Id == userId);
            if (user == null) throw new NotFoundException($"Пользоватль с id {userId} не найден");

            UserInformationBlo userInformationBlo = await ConvertToUserInformation(user);
            return userInformationBlo;
        }
        public Task<UserInformationBlo> Register(UserInformationBlo userInformationBlo)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Update(UserInformationBlo userInformationBlo, UserUpdateBlo userUpdateBlo)
        {
            throw new NotImplementedException();
        }

        private async Task<UserInformationBlo> ConvertToUserInformation(UserRto userRto)
        {
            if (userRto == null) throw new ArgumentNullException(nameof(userRto));

            UserInformationBlo userInformationBlo = _mapper.Map<UserInformationBlo>(userRto);

            return userInformationBlo;
        }
    }
}
