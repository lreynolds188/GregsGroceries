using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace GregsGrocery
{
    public static class Utilities
    {
        public static string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/Grocery_Master.accdb;Persist Security Info=True";

        #region Operator Methods

        // Checks the operators name against the operators pin through all the users in the database, and returns true/false depending on if the user was found and the password matched
        public static bool CheckCredentials(string _OperatorName, string _OperatorPin)
        {
            DataSet dsCredentials = new DataSet();
            dsCredentials = LoadCredentials();
            for (int i = 0; i < dsCredentials.Tables[0].Rows.Count; i++)
            {
                DataRow row = dsCredentials.Tables[0].Rows[i];
                if (_OperatorName.ToLower() == row.ItemArray.GetValue(1).ToString().ToLower() && _OperatorPin.ToLower() == row.ItemArray.GetValue(2).ToString().ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        // Loads all user credentials from the database, and returns the data as a DataSet
        public static DataSet LoadCredentials()
        {
            DataSet dsCredentials = new DataSet();
            var connection = new OleDbConnection();
            connection.ConnectionString = conString;

            connection.Open();
            OleDbDataAdapter myOleDbAdapter = new OleDbDataAdapter();
            myOleDbAdapter.SelectCommand = new OleDbCommand("SELECT * FROM tblOperators", connection);
            myOleDbAdapter.Fill(dsCredentials);
            connection.Close();
            return dsCredentials;
        }

        // Loads all user credentials from the database without their corresponding ID's, and returns the data as a DataSet
        public static DataSet LoadCredentialsWithoutID()
        {
            DataSet dsCredentials = new DataSet();
            var connection = new OleDbConnection();
            connection.ConnectionString = conString;

            connection.Open();
            OleDbDataAdapter myOleDbAdapter = new OleDbDataAdapter();
            myOleDbAdapter.SelectCommand = new OleDbCommand("SELECT OperatorName, OperatorPin, OperatorSales, OperatorAdmin FROM tblOperators", connection);
            myOleDbAdapter.Fill(dsCredentials);
            connection.Close();
            return dsCredentials;
        }

        // Loads a specific users' data from the database, and returns the data as a DataRow
        public static DataRow LoadUserCredentials(string _User)
        {
            DataSet dsCedentials = new DataSet();
            var connection = new OleDbConnection();
            connection.ConnectionString = conString;

            connection.Open();
            OleDbDataAdapter myAdapter = new OleDbDataAdapter();
            myAdapter.SelectCommand = new OleDbCommand("SELECT * FROM tblOperators WHERE OperatorName = '" + _User + "'", connection);
            myAdapter.Fill(dsCedentials);
            connection.Close();

            return dsCedentials.Tables[0].Rows[0];
        }

        // Loads a specific users' data from the database, and returns the data minus the users' ID as a DataRow
        public static DataRow LoadUserCredentialsWithoutID(string _User)
        {
            DataSet dsCredentials = new DataSet();
            var connection = new OleDbConnection();
            connection.ConnectionString = conString;

            connection.Open();
            OleDbDataAdapter myAdapter = new OleDbDataAdapter();
            myAdapter.SelectCommand = new OleDbCommand("SELECT OperatorName, OperatorPin, OperatorSales, OperatorAdmin FROM tblOperators WHERE OperatorName = '"+_User+"'", connection);
            myAdapter.Fill(dsCredentials);
            connection.Close();

            return dsCredentials.Tables[0].Rows[0];
        }

        // Updates the credentials of a user that matches _CurrentUserName in the database table tblOperators with the new values sent to the method
        public static void UpdateCredentials(string _CurrentUserName, string _NewUserName, string _UserPin, bool _SalesPriv, bool _AdminPriv)
        {
            var con = new OleDbConnection();
            con.ConnectionString = conString;

            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd = new OleDbCommand("UPDATE tblOperators SET OperatorName = '" + _NewUserName + "', OperatorPin = '" + _UserPin + "', OperatorSales = " + _SalesPriv + ", OperatorAdmin = " + _AdminPriv + " WHERE OperatorName = '" + _CurrentUserName + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // Adds a new user to the database table tblOperators
        public static void AddNewUser(string _UserName, string _UserPin, bool _UserSales, bool _UserAdmin)
        {
            var con = new OleDbConnection();
            con.ConnectionString = conString;
            con.Open();

            OleDbCommand cmd = new OleDbCommand("INSERT INTO tblOperators (OperatorName, OperatorPin, OperatorSales, OperatorAdmin) Values ('"+_UserName+"', '"+_UserPin+"', "+_UserSales+", "+_UserAdmin+")", con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public static void DeleteUser(string _UserName)
        {
            var con = new OleDbConnection();
            con.ConnectionString = conString;
            con.Open();

            OleDbCommand cmd = new OleDbCommand("DELETE FROM tblOperators WHERE OperatorName = '"+_UserName+"'", con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        #endregion

        #region Product Methods

        // Loads the products table from the database, and returns it as a DataSet
        public static DataSet LoadProducts()
        {
            DataSet dsProducts = new DataSet();
            var connection = new OleDbConnection();
            connection.ConnectionString = conString;

            connection.Open();
            OleDbDataAdapter myAdapter = new OleDbDataAdapter();
            myAdapter.SelectCommand = new OleDbCommand("SELECT * FROM tblProducts", connection);
            myAdapter.Fill(dsProducts);
            connection.Close();
            return dsProducts;
        }

        // Loads the products table from the database minus the products' ID column, and returns it as a DataSet
        public static DataSet LoadProductsWithoutID()
        {
            DataSet dsProducts = new DataSet();
            var connection = new OleDbConnection();
            connection.ConnectionString = conString;

            connection.Open();
            OleDbDataAdapter myAdapter = new OleDbDataAdapter();
            myAdapter.SelectCommand = new OleDbCommand("SELECT ProductDescription, ProductPrice FROM tblProducts", connection);
            myAdapter.Fill(dsProducts);
            connection.Close();
            return dsProducts;
        }

        // Loads a specific product row from the database by matching the product ID sent to the method (_productID), and returns it as a DataRow
        public static DataRow LoadSpecificProduct(int _productID)
        {
            DataSet dsProduct = new DataSet();
            DataRow row;
            var connection = new OleDbConnection();
            connection.ConnectionString = conString;

            connection.Open();
            OleDbDataAdapter myAdapter = new OleDbDataAdapter();
            myAdapter.SelectCommand = new OleDbCommand("SELECT * FROM tblProducts WHERE ProductID = " + _productID + "", connection);
            myAdapter.Fill(dsProduct);
            row = dsProduct.Tables[0].Rows[0];
            connection.Close();
            return row;
        }

        // Loads a specific product row from the database the matching the product ID sent to the method (_productID), and returns it as a DataRow
        public static DataRow LoadSpecificProduct(string _productName)
        {
            DataSet dsProduct = new DataSet();
            DataRow row;
            var connection = new OleDbConnection();
            connection.ConnectionString = conString;

            connection.Open();
            OleDbDataAdapter myAdapter = new OleDbDataAdapter();
            myAdapter.SelectCommand = new OleDbCommand("SELECT * FROM tblProducts WHERE ProductDescription ='" + _productName + "'", connection);
            myAdapter.Fill(dsProduct);
            row = dsProduct.Tables[0].Rows[0];
            connection.Close();
            return row;
        }

        public static void AddNewProduct(string _ProductDescription, double _ProductPrice)
        {
            var con = new OleDbConnection();
            con.ConnectionString = conString;
            con.Open();

            OleDbCommand cmd = new OleDbCommand("INSERT INTO tblProducts (ProductDescription, ProductPrice) VALUES ('"+_ProductDescription+"', "+_ProductPrice+")", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void UpdateProduct(int _ProductID, string _ProductDescription, double _ProductPrice)
        {
            var con = new OleDbConnection();
            con.ConnectionString = conString;
            con.Open();

            OleDbCommand cmd = new OleDbCommand("UPDATE tblProducts SET ProductDescription = '"+_ProductDescription+"', ProductPrice = "+_ProductPrice+" WHERE ProductID = "+_ProductID+"", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void DeleteProduct(int _ProductID)
        {
            var con = new OleDbConnection();
            con.ConnectionString = conString;
            con.Open();

            OleDbCommand cmd = new OleDbCommand("DELETE FROM tblProducts WHERE ProductID = " + _ProductID + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        #endregion

        #region Sales Methods
        // Loads all sales from the database, and returns them as a DataSet
        public static DataSet LoadSales()
        {
            DataSet dsSales = new DataSet();
            var connection = new OleDbConnection();
            connection.ConnectionString = conString;

            connection.Open();
            OleDbDataAdapter myAdapter = new OleDbDataAdapter();
            myAdapter.SelectCommand = new OleDbCommand("SELECT * FROM tblSales", connection);
            myAdapter.Fill(dsSales);
            connection.Close();
            return dsSales;
        }

        // Loads sales between a specific date range
        public static DataSet LoadSalesByDateAndCompletion(string dateFrom, string dateTo, int i)
        {
            DataSet dsSales = new DataSet();
            var connection = new OleDbConnection();
            connection.ConnectionString = conString;

            string cmd = string.Empty;

            // i == 1 (Load all sales within the dates
            // i == 2 (Load all sales within the dates that are completed
            // i == 3 (Load all sales within the dates that are incomplete
            if (i == 1){
                cmd = "SELECT * FROM tblSales WHERE [SaleTime] BETWEEN #"+dateFrom+"# AND #"+dateTo+"#";
            }
            else if (i == 2)
            {
                cmd = "SELECT * FROM tblSales WHERE [SaleTime] BETWEEN #" + dateFrom + "# AND #" + dateTo + "# AND [Complete] = true";
            }
            else if (i == 3)
            {
                cmd = "SELECT * FROM tblSales WHERE [SaleTime] BETWEEN #" + dateFrom + "# AND #" + dateTo + "# AND [Complete] = false";
            }

            connection.Open();
            OleDbDataAdapter myAdapter = new OleDbDataAdapter();
            myAdapter.SelectCommand = new OleDbCommand(cmd, connection);
            myAdapter.Fill(dsSales);
            connection.Close();
            return dsSales;
        }

        // Load a specific sale from the database that matches int SaleID sent to the method, and return a DataTable
        public static DataTable LoadSale(int SaleID)
        {
            DataTable dtSale = new DataTable();
            var connection = new OleDbConnection();
            connection.ConnectionString = conString;

            connection.Open();
            OleDbDataAdapter myAdapter = new OleDbDataAdapter();
            myAdapter.SelectCommand = new OleDbCommand("SELECT ProductID, LinePrice, LineQuantity FROM tblSaleLines WHERE SaleID = " + SaleID + "", connection);
            myAdapter.Fill(dtSale);
            connection.Close();
            return dtSale;
        }

        public static bool LoadSaleCompleted(int SaleID)
        {
            DataSet dsSales = new DataSet();

            var con = new OleDbConnection();
            con.ConnectionString = conString;

            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = new OleDbCommand("SELECT Complete FROM tblSales WHERE SaleID = "+SaleID+"", con);
            adapter.Fill(dsSales);
            con.Close();
            return bool.Parse(dsSales.Tables[0].Rows[0].ItemArray.GetValue(0).ToString());
        }

        // Load all sale ID's from the database, and return them as a DataSet
        public static DataSet LoadSaleIDs()
        {
            DataSet dsSales = new DataSet();
            var connection = new OleDbConnection();
            connection.ConnectionString = conString;

            connection.Open();
            OleDbDataAdapter myAdapter = new OleDbDataAdapter();
            myAdapter.SelectCommand = new OleDbCommand("SELECT SaleID FROM tblSales", connection);
            myAdapter.Fill(dsSales);
            connection.Close();
            return dsSales;
        }

        // Loads the last sales' ID in the database, and returns it as an int
        public static int LoadLastSaleID()
        {
            DataSet dsSales = new DataSet();
            DataRow row;
            var connection = new OleDbConnection();
            connection.ConnectionString = conString;

            connection.Open();
            OleDbDataAdapter myAdapter = new OleDbDataAdapter();
            myAdapter.SelectCommand = new OleDbCommand("SELECT LAST (SaleID) FROM tblSales", connection);
            myAdapter.Fill(dsSales);
            connection.Close();
            row = dsSales.Tables[0].Rows[0];
            return int.Parse(row.ItemArray.GetValue(0).ToString());
        }

        // Inserts a sale into the database table tblSales
        public static void InsertSale(string userId, bool completed)
        {
            string query = "";
                
            if(completed == true){
                query = "INSERT INTO tblSales (SaleTime, OperatorID, Complete) VALUES ('" + DateTime.Now + "', '" + int.Parse(LoadUserCredentials(userId).ItemArray.GetValue(0).ToString()) + "', true)";
            } else{
                query = "INSERT INTO tblSales (SaleTime, OperatorID, Complete) VALUES ('" + DateTime.Now + "', '" + int.Parse(LoadUserCredentials(userId).ItemArray.GetValue(0).ToString()) + "', false)";
            }
            
            var connection = new OleDbConnection();
            connection.ConnectionString = conString;

            connection.Open();
            OleDbCommand cmd = new OleDbCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        // Inserts all the lines of a sale into the database table tblSaleLines
        public static void InsertSaleLines(DataTable myData, int saleID)
        {
            foreach (DataRow row in myData.Rows)
            {
                int productID = int.Parse(Utilities.LoadSpecificProduct(row.ItemArray.GetValue(0).ToString()).ItemArray.GetValue(0).ToString());
                double linePrice = double.Parse(row.ItemArray.GetValue(1).ToString().Remove(0, 1));
                int lineQty = int.Parse(row.ItemArray.GetValue(2).ToString());

                var connection = new OleDbConnection();
                connection.ConnectionString = conString;

                connection.Open();
                OleDbCommand cmd = new OleDbCommand("INSERT INTO tblSaleLines (ProductID, SaleID, LinePrice, LineQuantity) VALUES ('" + productID + "', '" + saleID + "', '" + linePrice + "', '" + lineQty + "')", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        // Delete all sale lines that correspond to the saleID
        public static void DeleteSaleLines(int saleID)
        {
            var con = new OleDbConnection();
            con.ConnectionString = conString;

            con.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM tblSaleLines WHERE SaleID = "+saleID+"", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void DeleteSale(int saleID)
        {
            var con = new OleDbConnection();
            con.ConnectionString = conString;

            con.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM tblSales WHERE SaleID = " + saleID + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        #endregion

    }
}