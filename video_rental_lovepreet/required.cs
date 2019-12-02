using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace video_rental_lovepreet
{
    public class required
    {
        //connection is called the object of the sql connection class that is used to genreate a link between them 
        public SqlConnection connection;

        
        // constr is known as connection string thaat is used to provide the link between the vs to sql server 
        public String conStr = "Data Source=DESKTOP-K5FQKLS\\SQLEXPRESS;Initial Catalog=loveRental;Integrated Security=True";

        //Cmd Instance Object to Create the Relation between  the Commad to execute the sql Command 
        public SqlCommand Command;

        // DReader is instance to read the data from the database and pass to the Class
        public SqlDataReader DataReader;

        

    }
}
