using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video_rental_lovepreet
{
    public partial class Form1 : Form
    {

        MemberData obj_Member = new MemberData();
        videoData obj_Video = new videoData();
        RentalData obj_Rental = new RentalData();

        int rent = 0, video = 0, customer = 0;

        public Form1()
        {
            InitializeComponent();

            DataTable obj = new DataTable();
            obj = obj_Rental.SearchOperation("select * from Rent");
            if (obj.Rows.Count <= 0)
            {
                TxtRentId.Text = "1";
            }
            else {
                TxtRentId.Text =""+(obj.Rows.Count+1);
            }

        }
        public void reset() {
            txtCustomerAddress.Text = "";
            TxtCustomerId.Text = "";
            txtCustomerMObile.Text = "";
            txtCustomerName.Text = "";
            txtVideoCopies.Text = "";
            txtVideoCost.Text = "";
            txtVideoGenre.Text = "";
            TxtVideoId.Text = "";
            txtVideoPlot.Text = "";
            txtVideoRatting.Text = "";
            txtVideoTitle.Text = "";
            txtVideoYear.Text = "";

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            DataTable obj = new DataTable();
            obj = obj_Member.SearchOperation("Select * from Video");
            dataGridView1.DataSource = obj;

            customer = 0;
            rent = 0;
            video = 1;


        }

        private void btnCustomerSAve_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.ToString().Equals("") || txtCustomerMObile.Text.ToString().Equals("") || txtCustomerAddress.Text.ToString().Equals(""))
            {
                MessageBox.Show("Fill all the Member Details ");
            }
            else {
                //query string to pass the record in the table for better performance of the rental system 
                String operation = "insert into Member(Name,Contact,Address) values ('"+ txtCustomerName.Text.ToString()+"','"+txtCustomerMObile.Text.ToString()+"','"+txtCustomerAddress.Text.ToString()+"')";
                obj_Member.DataOperation(operation);
                MessageBox.Show("Customer Record is saved in the Database ");
                // after saving or executing the query reset the column 
                txtCustomerName.Text = "";
                txtCustomerMObile.Text = "";
                txtCustomerAddress.Text = "";
                reset();
            }
        }

        private void btnCustomerDElete_Click(object sender, EventArgs e)
        {
            if (!TxtCustomerId.Text.ToString().Equals(""))
            {
                String operation = "";
                if (obj_Member.CountRecord(Convert.ToInt32(TxtCustomerId.Text.ToString())) <= 0)
                {
                    operation = "delete from Member where ID=" + Convert.ToInt32(TxtCustomerId.Text.ToString()) + "";
                    obj_Member.DataOperation(operation);
                    MessageBox.Show("Selected customer is deleted from the data base record ");
                    reset();

                }
                else {
                    MessageBox.Show("You already have an Vidoe Please return first ");
                }
                // after delete operation  the query reset the column 
                txtCustomerName.Text = "";
                txtCustomerMObile.Text = "";
                txtCustomerAddress.Text = "";

            }
            else {
                MessageBox.Show("Select the customer to delete him ");
            }
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (!TxtCustomerId.Text.ToString().Equals(""))
            {
                if (!txtCustomerName.Text.ToString().Equals("") || !txtCustomerMObile.Text.ToString().Equals("") || !txtCustomerAddress.Text.ToString().Equals("")) {
                    String operation = "update Member set Name='" + txtCustomerName.Text.ToString() + "',Contact='" + txtCustomerMObile.Text.ToString() + "',Address='" + txtCustomerAddress.Text.ToString() + "' where ID=" + Convert.ToInt32(TxtCustomerId.Text.ToString()) + "";
                    obj_Member.DataOperation(operation);
                    MessageBox.Show("record of the customer is  Updated ");
                    // after delete operation  the query reset the column 
                    txtCustomerName.Text = "";
                    txtCustomerMObile.Text = "";
                    txtCustomerAddress.Text = "";
                    reset();
                }
                else {
                    MessageBox.Show("FIll all the values to update his record ");
                }
            }
            else {
                MessageBox.Show("Select the details of the cusotmer to reset his account ");
            }

        }

        private void btnVideoSAve_Click(object sender, EventArgs e)
        {
            if (!txtVideoTitle.Text.ToString().Equals("") && !txtVideoRatting.Text.ToString().Equals("") && !txtVideoYear.Text.ToString().Equals("")  && !txtVideoCopies.Text.ToString().Equals("") && !txtVideoPlot.Text.ToString().Equals("") && !txtVideoGenre.Text.ToString().Equals("")) {


                // get the current date to genrate the charges of the video to rent if the video is old then the charges will be 2 dollar other wise 5 dollar it willbe chrge 
                //DateTime currentDate = DateTime.Now;

                int Currentyear = DateTime.Now.Year;

                int Year = Currentyear - Convert.ToInt32(txtVideoYear.Text.ToString());
                // MessageBox.Show(diff.ToString());
                if (Year >= 5)
                {
                    txtVideoCost.Text = "2";
                }
                else if (Year >= 0 && Year < 5)
                {
                    txtVideoCost.Text = "5";
                }
                MessageBox.Show("Video Renting charges  is ==" + txtVideoCost.Text.ToString());



                String operation = "insert into Video (Title,Ratting,Year,Cost,Copies,Plot,Genre) values ('"+txtVideoTitle.Text.ToString()+"','"+txtVideoRatting.Text.ToString()+"','"+txtVideoYear.Text.ToString()+"',"+Convert.ToInt32(txtVideoCost.Text.ToString())+","+Convert.ToInt32(txtVideoCopies.Text.ToString())+",'"+txtVideoPlot.Text.ToString()+"','"+txtVideoGenre.Text.ToString()+"')";
                obj_Video.DataOperation(operation);

                operation = "";
                operation = "insert into VideoCount (VideoTitle,VideoCopies) values ('"+txtVideoTitle.Text.ToString()+"','"+txtVideoCopies.Text.ToString()+"')";
                obj_Video.DataOperation(operation);

                MessageBox.Show("Video Column field are saved in the data base ");

                txtVideoCopies.Text = "";
                txtVideoCost.Text = "";
                txtVideoGenre.Text = "";
                txtVideoPlot.Text = "";
                txtVideoRatting.Text = "";
                txtVideoTitle.Text = "";
                txtVideoYear.Text = "";
                reset();

            }
            else {
                MessageBox.Show("Write all the details of the video to store ");
            }

        }

        private void btnVideoDelete_Click(object sender, EventArgs e)
        {
            if (!TxtVideoId.Text.ToString().Equals("")) {

                // verify the video is already or on bookig or not 
                if (obj_Video.CountRecord(Convert.ToInt32(TxtVideoId.Text.ToString())) <= 0)
                {

                    // pass the record for better working 
                    String operation = "delete from Video where ID=" + Convert.ToInt32(TxtVideoId.Text.ToString()) + "";
                    obj_Video.DataOperation(operation);

                    operation = "";
                    operation = "delete from VideoCount  where VideoTitle='" + txtVideoTitle.Text.ToString() + "'";
                    obj_Video.DataOperation(operation);


                    MessageBox.Show("Selected Video is deleted from the Data base ");
                }
                else {
                    MessageBox.Show("this Video is already booked by the customer so can't be delete now ");
                }
                txtVideoCopies.Text = "";
                txtVideoCost.Text = "";
                txtVideoGenre.Text = "";
                txtVideoPlot.Text = "";
                txtVideoRatting.Text = "";
                txtVideoTitle.Text = "";
                txtVideoYear.Text = "";
                reset();

            }
            else {
                MessageBox.Show("Select the video detail to delete it must be not booked ");
            }
        }

        private void btnVideoUpdate_Click(object sender, EventArgs e)
        {
            if (!TxtVideoId.Text.ToString().Equals("")) {
                if (!txtVideoTitle.Text.ToString().Equals("") && !txtVideoRatting.Text.ToString().Equals("") && !txtVideoYear.Text.ToString().Equals("") && !txtVideoCost.Text.ToString().Equals("") && !txtVideoCopies.Text.ToString().Equals("") && !txtVideoPlot.Text.ToString().Equals("") && !txtVideoGenre.Text.ToString().Equals("")) {
                    String operation = "update Video set Title='"+txtVideoTitle.Text.ToString()+"',Ratting='"+txtVideoRatting.Text.ToString()+"',Year='"+txtVideoYear.Text.ToString()+"',Cost="+Convert.ToInt32(txtVideoCost.Text.ToString())+",Copies="+Convert.ToInt32(txtVideoCopies.Text.ToString())+",Plot='"+txtVideoPlot.Text.ToString()+"',Genre='"+txtVideoGenre.Text.ToString()+"' where ID="+Convert.ToInt32(TxtVideoId.Text.ToString())+"";
                    obj_Video.DataOperation(operation);


                    operation = "";
                    operation = "update VideoCount set VideoCopies='"+txtVideoCopies.Text.ToString()+"' where VideoTitle='" + txtVideoTitle.Text.ToString() + "'";
                    obj_Video.DataOperation(operation);


                    MessageBox.Show("Video Record is updated ");

                    txtVideoCopies.Text = "";
                    txtVideoCost.Text = "";
                    txtVideoGenre.Text = "";
                    txtVideoPlot.Text = "";
                    txtVideoRatting.Text = "";
                    txtVideoTitle.Text = "";
                    txtVideoYear.Text = "";
                    reset();


                }
                else {
                    MessageBox.Show("Must fill all the values to update the record ");
                }
            }
            else {
                MessageBox.Show("Select the video to update the record ");
            }


        }

        private void btnRentalBooking_Click(object sender, EventArgs e)
        {
            if (!TxtCustomerId.Text.ToString().Equals("") && !TxtVideoId.Text.ToString().Equals("") ) {

                // count the booking video of the customer who came here to book another one 
                int customerBooking = obj_Member.CountRecord(Convert.ToInt32(TxtCustomerId.Text.ToString()));

                if (customerBooking < 2)
                {

                    int movieCount = obj_Video.CountRecord(Convert.ToInt32(TxtVideoId.Text.ToString()));
                    if (movieCount < Convert.ToInt32(txtVideoCopies.Text.ToString()))
                    { 
                        // operation to insert the record in the table for issue an video on rent 
                        String operation = "insert into Rent(CustomerID,VideoID,BookDate,ReturnDate) values ('" + TxtCustomerId.Text.ToString() + "','" + TxtVideoId.Text.ToString() + "','" + dtpBooking.Text.ToString() + "','Booked')";
                        obj_Rental.DataOperation(operation);
                        MessageBox.Show("Movie is booked on Rent");

                        DataTable obj = new DataTable();
                        obj = obj_Rental.SearchOperation("select * from Rent");
                        if (obj.Rows.Count <= 0)
                        {
                            TxtRentId.Text = "1";
                        }
                        else
                        {
                            TxtRentId.Text = "" + (obj.Rows.Count + 1);
                        }

                        reset();


                    }
                    else {
                        MessageBox.Show("All Video booked already ");
                    }
                    TxtCustomerId.Text = "";
                    TxtVideoId.Text = "";
                }
                else {
                    MessageBox.Show("You have 2 VIdeo's on rent so return any one from these ");
                }
            }
            else {
                MessageBox.Show("Choose the Customer and Movie both to book movie on rent ");
            }
        }

        private void btnRentalDelete_Click(object sender, EventArgs e)
        {
            if (!TxtRentId.Text.ToString().Equals("") && !TxtCustomerId.Text.ToString().Equals("") && !TxtVideoId.Text.ToString().Equals("")) {

                
                if (obj_Rental.CountRecord(Convert.ToInt32(TxtRentId.Text.ToString())) <= 0)
                {

                    String operation = "";
                    operation = "delete from Rent where ID=" + Convert.ToInt32(TxtRentId.Text.ToString()) + "";
                    obj_Rental.DataOperation(operation);
                    MessageBox.Show("Record is Deleted ");

                }
                else {
                    MessageBox.Show("Video is already booked so we can't delete ");
                }

                TxtCustomerId.Text = "";
                TxtVideoId.Text = "";

                DataTable obj = new DataTable();
                obj = obj_Rental.SearchOperation("select * from Rent");

                if (obj.Rows.Count <= 0)
                {
                    TxtRentId.Text = "1";
                }
                else
                {
                    TxtRentId.Text = "" + (obj.Rows.Count + 1);
                }
                reset();


            }
            else {
                MessageBox.Show("Select the video to delete but the video must be returned ");
            }

        }

        private void btnRentalReturn_Click(object sender, EventArgs e)
        {
            if (!TxtCustomerId.Text.ToString().Equals("") && !TxtVideoId.Text.ToString().Equals("") && !TxtRentId.Text.ToString().Equals(""))
            {

                

                DataTable tbl = obj_Video.SearchOperation("select * from Video where ID=" + Convert.ToInt32(TxtVideoId.Text.ToString()) + "");

                int cost = Convert.ToInt32(tbl.Rows[tbl.Rows.Count - 1]["Cost"].ToString());


                DateTime current_date = DateTime.Now;

                //convert the old date from string to Date fromat
                DateTime old_date = Convert.ToDateTime(dtpBooking.Text.ToString());


                //get the difference in the days fromat
                String Daysdiff = (current_date - old_date).TotalDays.ToString();


                // calculate the round off value 
                Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));



                int totalCharges  = Convert.ToInt32(DaysInterval) * cost;


                String operation = "update Rent set CustomerID='" + TxtCustomerId.Text.ToString() + "',VideoID='" + TxtVideoId.Text.ToString() + "',BookDate='" + dtpBooking.Text.ToString() + "',ReturnDate='" + dtpReturn.Text.ToString() + "' where ID=" + Convert.ToInt32(TxtRentId.Text.ToString()) + "";

                obj_Rental.SearchOperation(operation);

                MessageBox.Show("Total Charges is =$" + totalCharges);


                TxtCustomerId.Text = "";

                TxtVideoId.Text = "";

                DataTable obj = new DataTable();
                obj = obj_Rental.SearchOperation("select * from Rent");
                if (obj.Rows.Count <= 0)
                {
                    TxtRentId.Text = "1";
                }
                else
                {
                    TxtRentId.Text = "" + (obj.Rows.Count + 1);
                }


                reset();

            }
            else {
                MessageBox.Show("Select the video to return ");
            }



        }




        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (rent==1) {
              //  MessageBox.Show("rent");
                TxtRentId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                TxtCustomerId.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TxtVideoId.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();

                dtpBooking.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();


                rent = 0;
            }
             if (video==1) {
               // MessageBox.Show("video");
                TxtVideoId.Text =  dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtVideoTitle.Text =  dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtVideoRatting.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtVideoYear.Text =  dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtVideoCost.Text =  dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtVideoCopies.Text =  dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtVideoPlot.Text =  dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtVideoGenre.Text =  dataGridView1.CurrentRow.Cells[7].Value.ToString();


                video = 0;
            }
            if (customer==1) {
               // MessageBox.Show("customer");
                TxtCustomerId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtCustomerName.Text =  dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtCustomerMObile.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtCustomerAddress.Text =  dataGridView1.CurrentRow.Cells[3].Value.ToString();



                customer = 0;
            }
            else {
                    
            }
        }

        private void btnMostMovie_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Best Movie of our Rental Store is " + obj_Video.returnName());


        }

        private void btnMostCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Best Cusomer of our Rental Store is " + obj_Member.returnName());

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {
            DataTable obj = new DataTable();
            obj = obj_Member.SearchOperation("Select * from Member ");
            dataGridView1.DataSource = obj;
            customer = 1;
            rent = 0;
            video = 0;


        }

        private void lblRental_Click(object sender, EventArgs e)
        {
            DataTable obj = new DataTable();
            obj = obj_Member.SearchOperation("Select * from Rent");
            dataGridView1.DataSource = obj;
            customer = 0;
            rent = 1;
            video = 0;

        }
    }
}
