using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;

namespace wreplicaesp
{
    internal class DB
    {
        SqlConnectionStringBuilder? dbData;
        public SqlConnection? connection;
        public bool connectionOpen;
        public string errorMessage;
        public string errorDetail;
        public bool error;
        public int errorNumber;

        public DB(string datasource, string userid, string password, string catalog)
        {
            error = false;
            connectionOpen = false;
            errorMessage = string.Empty;
            errorDetail = string.Empty;
            errorNumber = 0;
            try
            {
                dbData = new SqlConnectionStringBuilder
                {
                    DataSource = datasource,
                    UserID = userid,
                    Password = password,
                    InitialCatalog = catalog
                };
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = "Error creating dbData string";
                errorDetail = ex.Message;
            }
        }

        public bool OpenConnection()
        {
            string connetionString = string.Empty;
            //connectionOpen = false;
            error = false;
            try
            {
                if (dbData != null)
                {
                    connetionString = dbData.ConnectionString;
                }
                if (!connectionOpen)
                {
                    using SqlConnection connection = new(connetionString);
                    connection.Open();
                    connectionOpen = true;
                }
            }
            catch (SqlException ex)
            {
                connectionOpen = false;
                error = true;
                errorMessage = ex.Number switch
                {
                    -1 => "Error connecting to remote database (" + ex.Number.ToString() + ")",
                    156 => "SQL syntax error. (" + ex.Number.ToString() + ")",
                    208 => "Invalid object name. (" + ex.Number.ToString() + ")",
                    233 => "Error connecting to remote database. Wrong credentials. (" + ex.Number.ToString() + ")",
                    2714 => "Error creating remote object. Object exists. (" + ex.Number.ToString() + ")",
                    2601 => "Error connecting to remote database (" + ex.Number.ToString() + ")",
                    _ => "General SQL exception (" + ex.Number.ToString() + ")",
                };
                errorNumber = ex.Number;
                errorDetail = ex.Message;
            }
            return error;
        }

        public bool CloseConnection()
        {
            try
            {
                if (connection != null) {
                    connection.Close();
                    connectionOpen = false;
                }
            }
            catch (SqlException ex)
            {
                error = true;
                errorMessage = ex.Number switch
                {
                    -1 => "Error connecting to remote database (" + ex.Number.ToString() + ")",
                    156 => "SQL syntax error. (" + ex.Number.ToString() + ")",
                    208 => "Invalid object name. (" + ex.Number.ToString() + ")",
                    233 => "Error connecting to remote database. Wrong credentials. (" + ex.Number.ToString() + ")",
                    2714 => "Error creating remote object. Object exists. (" + ex.Number.ToString() + ")",
                    2601 => "Error connecting to remote database (" + ex.Number.ToString() + ")",
                    _ => "General SQL exception (" + ex.Number.ToString() + ")",
                };
                errorNumber = ex.Number;
                errorDetail = ex.Message;
            }
            return error;
        }

        public bool RunQuery(string query)
        {
            string connetionString = string.Empty;
            try
            {
                if (dbData != null) {
                    connetionString = dbData.ConnectionString;
                }
                
                using SqlConnection connection = new(connetionString);
                SqlCommand command = new(query, connection);
                command.Connection.Open();
                //
                Random r = new Random();
                int rInt = r.Next(1, 10);
                Thread.Sleep(rInt * 1000);
                //
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                error = true;
                errorMessage = ex.Number switch
                {
                    -1 => "Error connecting to remote database (" + ex.Number.ToString() + ")",
                    156 => "SQL syntax error. (" + ex.Number.ToString() + ")",
                    208 => "Invalid object name. (" + ex.Number.ToString() + ")",
                    233 => "Error connecting to remote database. Wrong credentials. (" + ex.Number.ToString() + ")",
                    2714 => "Error creating remote object. Object exists. (" + ex.Number.ToString() + ")",
                    2601 => "Error connecting to remote database (" + ex.Number.ToString() + ")",
                    _ => "General SQL exception (" + ex.Number.ToString() + ")",
                };
                errorNumber = ex.Number;
                errorDetail = ex.Message;
            }
            return error;
        }

        public bool RenameStoredProcedure(string oldName, string newName)
        {
            try
            {
                string renameCommand = "EXEC sp_rename '" + oldName + "', '" + newName + "';";

                using SqlConnection connection = new SqlConnection(dbData.ConnectionString);
                SqlCommand command = new SqlCommand(renameCommand, connection);
                command.Connection.Open();
                //
                Thread.Sleep(2000);
                //
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                error = true;
                errorMessage = ex.Number switch
                {
                    -1 => "Error connecting to remote database (" + ex.Number.ToString() + ")",
                    156 => "SQL syntax error. (" + ex.Number.ToString() + ")",
                    208 => "Invalid object name. (" + ex.Number.ToString() + ")",
                    233 => "Error connecting to remote database. Wrong credentials. (" + ex.Number.ToString() + ")",
                    2714 => "Error creating remote object. Object exists. (" + ex.Number.ToString() + ")",
                    2601 => "Error connecting to remote database (" + ex.Number.ToString() + ")",
                    _ => "General SQL exception (" + ex.Number.ToString() + ")",
                };
                errorNumber = ex.Number;
                errorDetail = ex.Message;
            }
            return error;
        }

        public string getErrorMessage()
        {
            return errorMessage;
        }

        public string getErrorDetail()
        {
            return errorDetail;
        }

        public int getErrorNumber()
        {
            return errorNumber;
        }

        public bool Error()
        {
            return error;
        }

        public void ResetError()
        {
            error = false;
            errorMessage = string.Empty;
            errorDetail = string.Empty;
            errorNumber = 0;
        }
    }
}
