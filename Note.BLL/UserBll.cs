using Note.DAL;
using Note.IDAL;
using Note.Model;
using System;
using System.Collections.Generic;

namespace Note.BLL
{
    public class UserBll
    {
        /*
         각 Tier 별로 접근 순서
        클라이언트 버튼 -> ASP.NET MC 리스트 출력 호출 -> BLL
        -> IDAL -> DAL 
         */

        // 강한 결합
        //private UserDal _userDal = new UserDal(); 

        // 약한 결합 - 인터페이스를 통한 접근 방식
        private readonly IUserDal _userDal;

        public UserBll(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetUser(int userNo)
        {
            return _userDal.GetUser(userNo);
        }

        public List<User> GetUserList()
        {
            throw new NotImplementedException();
        }
    }
}
