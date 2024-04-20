using Microsoft.SqlServer.Server;
using ProjectDLL.BL;
using ProjectDLL.DLInterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDLL.DL.DB
{
    public class PersonDB:IPerson
    {
        public void Create(Person person)
        {
            DataBase.openConnection();
            string query = $"insert into Person values('{person.getName()}','{person.getPassword()}','{person.getRole()}')";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            cmd.ExecuteNonQuery();
            DataBase.closeConnection();
        }
        public bool IsExist(string name)
        {
            DataBase.openConnection();
            string query = $"select * from Person where Name = '{name}'";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bool exist = false;
            while (reader.Read())
            {
                exist = true;
            }
            DataBase.closeConnection();
            return exist;
        }
        public Person Read(string find)
        {
            DataBase.openConnection();
            string query = $"select * from Person where Name = '{find}'";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Person person = null;
            while (reader.Read()) 
            {
                string name = reader["Name"].ToString();
                string password = reader["Password"].ToString();
                string role = reader["Role"].ToString();
                person = new Person(name, password, role);
            }
            DataBase.closeConnection();
            return person;

        }
        public Person signin(Person person)
        {
           
            DataBase.openConnection();
            string query = $"select * from Person where Name = '{person.getName()}' AND Password = '{person.getPassword()}'";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Person per = null;
            while (reader.Read())
            {
                string name = reader["Name"].ToString();
                string password = reader["Password"].ToString();
                string role = reader["Role"].ToString();
                per = new Person(name, password, role);
            }
            DataBase.closeConnection();
            return per;
        }


    }
}
