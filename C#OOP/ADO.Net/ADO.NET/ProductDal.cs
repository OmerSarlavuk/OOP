using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NET
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog = ETrade; integrated security = true");

        public List<Product> GetAll()
        {
            ConnectionControl();

            SqlCommand sqlCommand = new SqlCommand("select * from Products", _connection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    Name = Convert.ToString(reader["Name"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }

            reader.Close();
            _connection.Close();

            return products;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        //bu datatable kullanarak liste ile değil ve kullanımı daha ada az eskiye göre
        public DataTable GetAll2()
        {
            

            if(_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

            SqlCommand sqlCommand = new SqlCommand("select * from Products", _connection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            DataTable dataTable = new DataTable();

            dataTable.Load(reader);
            reader.Close();
            _connection.Close();

            return dataTable;
        }

        public void Add(Product product)
        {
            ConnectionControl();

            SqlCommand sqlCommand = new SqlCommand("insert into Products " +
                "values(@name, @unitPrice, @stockAmount)", _connection);

            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);

            sqlCommand.ExecuteNonQuery();

            _connection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();

            SqlCommand sqlCommand = new SqlCommand("update Products set " +
                "Name = @name, UnitPrice = @unitPrice, StockAmount = @stockAmount where Id = @id", _connection);

            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            sqlCommand.Parameters.AddWithValue("@id", product.Id);

            sqlCommand.ExecuteNonQuery();

            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();

            SqlCommand sqlCommand = new SqlCommand("delete from Products where Id = @id", _connection);

            
            sqlCommand.Parameters.AddWithValue("@id", id);

            sqlCommand.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
