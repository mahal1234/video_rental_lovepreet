using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace video_rental_lovepreet
{
   public class RentalData
    {
        required CompVariable = new required();

        // method to operate the differeent operation like insert delete update 
        public void DataOperation(String includeQuery)
        {
            CompVariable.connection = new SqlConnection(CompVariable.conStr);
            CompVariable.connection.Open();
            CompVariable.Command = new SqlCommand(includeQuery, CompVariable.connection);
            CompVariable.Command.ExecuteNonQuery();
            CompVariable.connection.Close();
        }


        // method to perform the search operation on the database for specific where clause with or without 
        public DataTable SearchOperation(String qry)
        {
            DataTable tbl = new DataTable();


            CompVariable.connection = new SqlConnection(CompVariable.conStr);

            CompVariable.connection.Open();
            CompVariable.Command = new SqlCommand(qry, CompVariable.connection);

            CompVariable.DataReader = CompVariable.Command.ExecuteReader();

            tbl.Load(CompVariable.DataReader);

            CompVariable.connection.Close();

            return tbl;
        }




        //count the record from the table 
        public int CountRecord(int RentID)
        {
            DataTable tbl = new DataTable();
            String operation = "select * from Rent where ID=" + RentID + " and ReturnDate='Booked'";
            tbl = SearchOperation(operation);
            return tbl.Rows.Count;

        }

    }
}
