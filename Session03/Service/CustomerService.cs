using Session03.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.Service
{
    public class CustomerService
    {
        //CRUD

        public void Create(Customer model)
        {
            // Validate Model -> Fluent Validation API
            // Validate Business

            /*
             * 1. new SQLConnection
             * 2. new SQLCommand
             * 3. SQLCommand.text
             * 4. SQLCommand.connection
             * 5. SQLConnection.open
             * 6. SQLCommand.execute
             * 7. SQLConnection close?
             */

            //ADO.Net

            //using
            //Connection String
            string connStr = "Server=.;Database=140102;Trusted_Connection=True;";
            //using (var conn = new SqlConnection(connStr))
            //{

            //}

            using var conn = new SqlConnection(connStr);
            using var command = new SqlCommand();
            command.Connection = conn;
            //command.CommandText = @$"INSERT INTO [dbo].[Customer]
            //       ([FirstName]
            //       ,[LastName]
            //       ,[NationalCode]
            //       ,[DOB]
            //       ,[Address]
            //       ,[Email]
            //       ,[IsActive])
            //    VALUES
            //       ('{model.FirstName}'
            //       ,'{model.LastName}'
            //       ,'{model.NationalCode}'
            //       ,{model.DOB}
            //       ,'{model.Address}'
            //       ,'{model.Email}'
            //       ,{model.IsActive})
            //        GO";
            ////SQL Injection ❌☠☠☠☠☠


            command.CommandText = @"INSERT INTO [dbo].[Customer]
                   ([FirstName]
                   ,[LastName]
                   ,[NationalCode]
                   ,[DOB]
                   ,[Address]
                   ,[Email]
                   ,[IsActive])
                VALUES
                   (@FirstName
                   ,@LastName
                   ,@NationalCode
                   ,@DOB
                   ,@Address
                   ,@Email
                   ,@IsActive)";

            command.Parameters.AddWithValue("FirstName", model.FirstName);
            command.Parameters.AddWithValue("LastName", model.LastName);
            command.Parameters.AddWithValue("NationalCode", model.NationalCode);
            command.Parameters.AddWithValue("DOB", model.DOB);
            command.Parameters.AddWithValue("Address", model.Address);
            command.Parameters.AddWithValue("Email", model.Email);
            command.Parameters.AddWithValue("IsActive", model.IsActive);

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

        }

        public void Update(int id, Customer model)
        {

        }

        public void Delete(int id)
        {

        }
    }
}
