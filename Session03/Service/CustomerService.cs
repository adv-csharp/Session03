using Session03.Model;
using Session03.Utils;
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
        const string connStr = "Server=.;Database=140102;Trusted_Connection=True;";

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

        //Databse First
        public void CreateSP(Customer model)
        {
            //https://downloadly.ir/software/programming/ssms-tools-pack/
            
            using var conn = new SqlConnection(connStr);
            using var command = new SqlCommand();
            command.Connection = conn;
           
            command.CommandText = @"sp_Customer_Insert";
            command.CommandType = System.Data.CommandType.StoredProcedure;

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


        public  List<Customer> ReadDataSqlReader()
        {
            var result = new List<Customer>();

            using var conn = new SqlConnection(connStr);
            using var command =  new SqlCommand();
            command.Connection = conn;
            command.CommandText = "select * from [dbo].[Customer]";
            conn.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Customer
                {
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Email = reader["Email"].ToString(),
                    Address = reader["Address"].ToString(),
                    NationalCode = reader["NationalCode"].ToString(),
                    DOB = Convert.ToDateTime(reader["DOB"]),                    
                    Id = Convert.ToInt32(reader["Id"]),
                    IsActive = Convert.ToBoolean(reader["IsActive"]),
                });

                //Reflection
                //Framework Object Relational Mapper
            }
            conn.Close();
            return result;
        }

        public void Update(int id, Customer model)
        {

        }

        public void Delete(int id)
        {
            using var conn = new SqlConnection(connStr);
            using var command = new SqlCommand();
            command.Connection = conn;

            command.CommandText = @"sp_Customer_Delete";
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("id", id);

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
