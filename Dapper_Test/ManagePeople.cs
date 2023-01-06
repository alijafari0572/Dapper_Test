using Dapper_Test.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dapper_Test
{
    public class ManagePeople
    {
        private static string ConnectionString = "Data Source = .;Initial Catalog=Dapper_DB;Integrated Security=True;";
   public static List<Person_Viewmodel> GetAll()
        {

             List<Person_Viewmodel> list;
            using(IDbConnection db=new  SqlConnection(ConnectionString))
            {

            }
            return list;
        }
    }
}
