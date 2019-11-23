using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class RegisterProcessor
    {
        public static int CreateRegistration(int UserId, string firstName, string lastName, string email,
             string subject, string phoneNum)
        {
            Registration data = new Registration
            {
                UserID = UserId,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Subject = subject,
                PhoneNum = phoneNum,
               
            };
            string sql = @"insert into dbo.Registration (UserID, FirstName, LastName, Email,  Subject, PhoneNum)
                           values (@UserID,@FirstName, @LastName, @Email,  @Subject, @PhoneNum);";
            return SqlDataAccess.SaveData(sql, data);
    }
        public static List<Registration> LoadRegisters()
        {
            string sql = @"select id, UserID, FirstName, LastName, Email,Subject, PhoneNum,
                        from dbo.Registration;";
            return SqlDataAccess.LoadData<Registration>(sql);
        }
    }
}