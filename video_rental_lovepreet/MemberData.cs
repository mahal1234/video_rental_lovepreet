using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace video_rental_lovepreet
{
    public class MemberData
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
        public int CountRecord(int MemberID) {
            DataTable tbl = new DataTable();
            String operation = "select * from Rent where CustomerID='"+MemberID.ToString()+"' and ReturnDate='Booked'";
            tbl = SearchOperation(operation);
            return tbl.Rows.Count - 1;
            
        }

        public String returnName()
        {

            DataTable tblData = new DataTable();
            tblData = SearchOperation("select * from Member");
            int x = 0, y = 0, cunt = 0;
            String Name= "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = SearchOperation("select * from Rent where CustomerID=" + Convert.ToInt32(tblData.Rows[x]["ID"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Name = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }

            return Name;
        }

    }
}
