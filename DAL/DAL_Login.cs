using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Login
    {
        //Get Authentication 
        public Users GetUsers(Users users)
        {
            Users _objUser = new Users();
            try
            {
                if (users != null && users.UserName != string.Empty && users.Password != string.Empty)
                {
                    using (LocalEntity _context = new LocalEntity())
                    {
                        var result = (from x in _context.tbl_User
                                      where x.Name.Equals(users.UserName) && x.Password.Equals(users.Password)
                                      select x).FirstOrDefault();

                        if (result != null)
                        {
                            _objUser.UserName = result.Name;
                            _objUser.Role = result.Role;
                        }
                        else
                        {
                            _objUser.MessageText = "Please enter valid username and password";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _objUser;
        }
    }
}
