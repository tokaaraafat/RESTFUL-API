using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTFUL_API
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController1 : ControllerBase
    {
        
        [HttpGet("{id}")]
        public List<string> GetEmpById(string NationalIDNumber)
        {
            List<string> employees = new List<string>();
            string connectionString = "Data Source = DESKTOP-J9HV5PE\\SQLEXPRESS; Initial Catalog = AdventureWorks2017; User ID = sa; Password = eslam; Integrated Security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(" SELECT BusinessEntityID, NationalIDNumber, LoginID, OrganizationLevel, JobTitle, BirthDate, MaritalStatus, Gender, HireDate " +
                    "FROM HumanResources.Employee where (NationalIDNumber = N'" + NationalIDNumber + "')", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string BusinessEntityID = reader["BusinessEntityID"].ToString();
                    string NationalIDNo = reader["NationalIDNumber"].ToString();
                    string LoginID = reader["LoginID"].ToString();
                    string OrganizationLevel = reader["OrganizationLevel"].ToString();
                    string JobTitle = reader["JobTitle"].ToString();
                    string BirthDate = reader["BirthDate"].ToString();
                    string MaritalStatus = reader["MaritalStatus"].ToString();
                    string Gender = reader["Gender"].ToString();
                    string HireDate = reader["HireDate"].ToString();

                    employees.Add(BusinessEntityID);
                    employees.Add(NationalIDNo);
                    employees.Add(LoginID);
                    employees.Add(OrganizationLevel);
                    employees.Add(JobTitle);
                    employees.Add(BirthDate);
                    employees.Add(MaritalStatus);
                    employees.Add(Gender);
                    employees.Add(HireDate);


                }


            }

            return employees;

        }
        // DELETE api/<EmpController1>/5
        [HttpDelete("{id}")]
        public List<string> DeleteEmpById(int id)
        {
            {
                List<string> employees = new List<string>();
                string connectionString = "Data Source = DESKTOP-J9HV5PE\\SQLEXPRESS; Initial Catalog = AdventureWorks2017; User ID = sa; Password = eslam; Integrated Security=true";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(" SELECT BusinessEntityID, NationalIDNumber, LoginID, OrganizationLevel, JobTitle, BirthDate, MaritalStatus, Gender, HireDate " +
                        "FROM HumanResources.Employee where (NationalIDNumber = N'" + id + "')", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string BusinessEntityID = reader["BusinessEntityID"].ToString();
                        string NationalIDNo = reader["NationalIDNumber"].ToString();
                        string LoginID = reader["LoginID"].ToString();
                        string OrganizationLevel = reader["OrganizationLevel"].ToString();
                        string JobTitle = reader["JobTitle"].ToString();
                        string BirthDate = reader["BirthDate"].ToString();
                        string MaritalStatus = reader["MaritalStatus"].ToString();
                        string Gender = reader["Gender"].ToString();
                        string HireDate = reader["HireDate"].ToString();

                        employees.Add(BusinessEntityID);
                        employees.Add(NationalIDNo);
                        employees.Add(LoginID);
                        employees.Add(OrganizationLevel);
                        employees.Add(JobTitle);
                        employees.Add(BirthDate);
                        employees.Add(MaritalStatus);
                        employees.Add(Gender);
                        employees.Add(HireDate);


                    }


                }

                return employees;
            }
        }
            // POST api/<EmpController1>
            [HttpPost]
            public List<string> Post([FromBody] string id)
            {
                List<string> employees = new List<string>();
                string connectionString = "Data Source = DESKTOP-J9HV5PE\\SQLEXPRESS; Initial Catalog = AdventureWorks2017; User ID = sa; Password = eslam; Integrated Security=true";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(" SELECT BusinessEntityID, NationalIDNumber, LoginID, OrganizationLevel, JobTitle, BirthDate, MaritalStatus, Gender, HireDate " +
                        "FROM HumanResources.Employee where (NationalIDNumber = N'" + id + "')", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string BusinessEntityID = reader["BusinessEntityID"].ToString();
                        string NationalIDNo = reader["NationalIDNumber"].ToString();
                        string LoginID = reader["LoginID"].ToString();
                        string OrganizationLevel = reader["OrganizationLevel"].ToString();
                        string JobTitle = reader["JobTitle"].ToString();
                        string BirthDate = reader["BirthDate"].ToString();
                        string MaritalStatus = reader["MaritalStatus"].ToString();
                        string Gender = reader["Gender"].ToString();
                        string HireDate = reader["HireDate"].ToString();

                        employees.Add(BusinessEntityID);
                        employees.Add(NationalIDNo);
                        employees.Add(LoginID);
                        employees.Add(OrganizationLevel);
                        employees.Add(JobTitle);
                        employees.Add(BirthDate);
                        employees.Add(MaritalStatus);
                        employees.Add(Gender);
                        employees.Add(HireDate);


                    }


                }

                return employees;
            }
        }
        }
    