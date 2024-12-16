using System.Data;
using System.Data.SqlClient;

namespace Day9CSharpDataAccessADOPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*
             * Using ADO.Net 
                    1 -SSMS Tool Connect SQL Server  Done 
                    2 -Select Instance Authentication  Windows 
                    3 -Connect (USE Database )  
                    4 -(Select * from Employees )To Show the Employees table 
                    5 -Execute Query 
             */
            //Data Source = SAYEDHAWAS\EDPI2024R2; Integrated Security = True; Connect Timeout = 30; Encrypt = True; Trust Server Certificate = True; Application Intent = ReadWrite; Multi Subnet Failover = False
            //Data Source =.\EDPI2024R2; Initial Catalog = Northwind; Integrated Security = True

            // Server Name ; Database ; Security Model

            DataTable dataTable = new DataTable();

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = @"Data Source =.\EDPI2024R2;Initial Catalog = Northwind; Integrated Security = True";
            //con.Open();  //open Connection Model 
            ////Open New Query 
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = "Select FirstName , LastName from Employees";
            //SqlDataReader dataReader = cmd.ExecuteReader();
            //if (dataReader.Read())
            //{
            //    dataTable.Load(dataReader);
            //}

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    Console.WriteLine($"FirstName : {row[0]} LastName {row[1]}");
            //}
            //con.Close(); //Close Database Connection 


            //Using Block 
            using (SqlConnection conn = new SqlConnection(@"Data Source =.\EDPI2024R2;Initial Catalog = Northwind; Integrated Security = True"))
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("Select FirstName , LastName , HireDate from Employees", conn);
                SqlDataReader dr = cmd2.ExecuteReader();
                if (dr.Read())
                {
                    dataTable.Load(dr);
                }
                foreach (DataRow row in dataTable.Rows)
                {
                    Console.WriteLine($"FirstName : {row[0]} LastName {row[1]} HireData {row[2]}");
                }
            }
            //conn
            Console.ReadLine();


        }
    }
}
