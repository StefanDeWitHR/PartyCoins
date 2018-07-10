using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Data.Managers
{
    public class CompanyManger :  InterfaceCRUD<Company> {

        IDbConnection _con;
        public CompanyManger(IDbConnection con)
        {
            _con = con;
        }

        public bool Add(Company CompanyRec) {
        try
        {
            DynamicParameters parameters = new DynamicParameters();
           // parameters.Add("@UserName", user.UserName);
            //parameters.Add("@UserMobile", user.UserMobile);
            
            SqlMapper.Execute(_con,  "SELECT * from company");
            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> Get()
        {
            throw new NotImplementedException();
        }

        public Company Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Company entity)
        {
            throw new NotImplementedException();
        }

        void InterfaceCRUD<Company>.Add(Company entity)
        {
            throw new NotImplementedException();
        }
        //public bool Delete(int userId)
        //{
        //    DynamicParameters parameters = newDynamicParameters();
        //    parameters.Add("@UserId", userId);
        //    SqlMapper.Execute(con, "DeleteUser", param parameters, commandType StoredProcedure);
        //    return true;
        //}
        //public IList<User> GetAllUser()
        //{
        //    IList<User> customerList = SqlMapper.Query<User>(con, "GetAllUsers", commandType StoredProcedure).ToList();
        //    return customerList;
        //}
        //public Company GetUserById(int userId)
        //{
        //    try
        //    {
        //        DynamicParameters parameters = new DynamicParameters();
        //        parameters.Add("@CustomerID", userId);
        //        return SqlMapper.Query<User>((SqlConnection)con, "GetUserById", parameters, commandType StoredProcedure).FirstOrDefault();
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //public bool Update(Company user)
        //{
        //    try
        //    {
        //        DynamicParameters parameters = new DynamicParameters();
        //        parameters.Add("@UserId", user.UserId);
        //        parameters.Add("@UserName", user.UserName);
        //        parameters.Add("@UserMobile", user.UserMobile);
        //        parameters.Add("@UserEmail", user.UserEmail);
        //        parameters.Add("@FaceBookUrl", user.FaceBookUrl);
        //        parameters.Add("@LinkedInUrl", user.LinkedInUrl);
        //        parameters.Add("@TwitterUrl", user.TwitterUrl);
        //        parameters.Add("@PersonalWebUrl", user.PersonalWebUrl);
        //        SqlMapper.Execute(con, "UpdateUser", param parameters, commandType StoredProcedure);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }  
}
