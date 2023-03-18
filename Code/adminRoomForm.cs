using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Khali_Wali2
{
    public partial class adminRoomForm : Form
    {
        public adminRoomForm()
        {
            InitializeComponent();
            btnInsertInRoom.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                DataTable dt = new DataTable();

           

                string query = "insert into room(person_id, b_id , roomNumber) values('" + txt_inPersonID.Text + "' ,'" + txt_inB_ID.Text + "'," + txt_inRoomNo.Text + ")";
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                oracleDataAdapter.Fill(dt);



              //  con.Open();
                OracleCommand cmd = new OracleCommand("select current_ppl from room where b_id = '" + txt_inB_ID.Text + "' AND roomNumber =  " + txt_inRoomNo.Text + " ", con);
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read() || !dr.Read())
                {

                    string str = dr["current_ppl"].ToString();

                    int currcap = int.Parse(str);

                    if (currcap >= 5)
                    {
                        MessageBox.Show("Room is Full", "BOOOMMMM");
                        string queryy = " delete from room where person_id = :txt_inPersonID ";


                        OracleCommand cmdd = new OracleCommand(queryy, con);
                      
                        cmdd.Parameters.Add("txt_inPersonID ", txt_inPersonID.Text);
                        cmdd.ExecuteNonQuery();
                    
                    
                        OracleDataAdapter adp = new OracleDataAdapter("select *  from room", con);
                        adp.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        query = "update room set current_ppl = current_ppl + 1 where roomNUmber = '" + txt_inRoomNo.Text + "' AND b_id = '" + txt_inB_ID.Text + "' ";
                        OracleDataAdapter adpp = new OracleDataAdapter(query, con);
                        adpp.Fill(dt);

                        //query = "update room set (select current_ppl from romm where b_id = '" + txt_inB_ID.Text + "' AND roomnumber = '" + txt_inRoomNo.Text + "') = (select max(current_ppl) from room where b_id = '" + txt_inB_ID.Text + "' AND roomnumber = '" + txt_inRoomNo.Text + "') ";
                        //OracleDataAdapter adppp = new OracleDataAdapter(query, con);
                        //adppp.Update(dt);
                        //adppp.Fill(dt);

                        OracleDataAdapter adp = new OracleDataAdapter("select *  from room", con);
                        adp.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
        
            }
            //btnInsertInRoom.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                DataTable dt = new DataTable();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btn_RoomChange_Click(object sender, EventArgs e)
        {
            try
            {

                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                DataTable dt = new DataTable();




                string query = "insert into room( b_id , roomNumber) values('" + txt_inB_ID.Text + "' , " + txt_inRoomNo.Text + " )";
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                oracleDataAdapter.Fill(dt);



                //  con.Open();
                OracleCommand cmd = new OracleCommand("select current_ppl from room where b_id = '" + txt_inB_ID.Text + "' AND roomNumber =  " + txt_inRoomNo.Text + " ", con);
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read() || !dr.Read())
                {

                    string str = dr["current_ppl"].ToString();

                    int currcap = int.Parse(str);

                    if (currcap >= 6)
                    {
                        MessageBox.Show("Room is Full, Select another room plz", "BOOOMMMM");

                        string queryy = " delete from room where person_id = :'' ";
                        OracleCommand cmdd = new OracleCommand(queryy, con);

                        cmdd.Parameters.Add("txt_inPersonID ", txt_inPersonID.Text);
                        cmdd.ExecuteNonQuery();


                        OracleDataAdapter adp = new OracleDataAdapter("select *  from room", con);
                        adp.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        query = "DELETE FROM room WHERE person_id IS null";
                        OracleDataAdapter aadpp = new OracleDataAdapter(query, con);
                        aadpp.Fill(dt);

                        OracleCommand cmmd = new OracleCommand("select roomNumber from room where person_id = '" + txt_inPersonID.Text + "' ", con);
                        OracleDataReader ddr = cmmd.ExecuteReader();

                        string sstr = "", sstrr = "";
                        if (ddr.Read())
                        {
                            sstrr = ddr["roomNumber"].ToString();
                        }

                        OracleCommand ccmd = new OracleCommand("select b_id from room where person_id = '" + txt_inPersonID.Text + "' ", con);
                        OracleDataReader drr = ccmd.ExecuteReader();
                        if (drr.Read())
                        {
                            sstr = drr["b_id"].ToString();
                        }


                        query = "DELETE FROM room WHERE person_id = '" + txt_inPersonID.Text + "' ";
                        OracleDataAdapter aaadpp = new OracleDataAdapter(query, con);
                        aaadpp.Fill(dt);


                        query = "update room set current_ppl = current_ppl - 1 where roomNUmber = '" + sstr.ToString() + "' AND b_id = '" + sstrr.ToString() + "' ";
                        OracleDataAdapter addpp = new OracleDataAdapter(query, con);
                        addpp.Fill(dt);


                        for (int i = dt.Rows.Count - 1; i >= 0; i--)
                        {
                            if (dt.Rows[i][1] == DBNull.Value)
                                dt.Rows[i].Delete();
                        }
                        dt.AcceptChanges();


                        query = "insert into room(person_id, b_id , roomNumber) values('" + txt_inPersonID.Text + "' ,'" + txt_inB_ID.Text + "'," + txt_inRoomNo.Text + ")";
                        OracleDataAdapter oracleDataAdapterr = new OracleDataAdapter(query, con);
                        oracleDataAdapterr.Fill(dt);

                        query = "update room set current_ppl = current_ppl + 1 where roomNUmber = '" + txt_inRoomNo.Text + "' AND b_id = '" + txt_inB_ID.Text + "' ";
                        OracleDataAdapter adpp = new OracleDataAdapter(query, con);
                        adpp.Fill(dt);



                        //OracleDataAdapter adp = new OracleDataAdapter("select *  from room", con);
                        //adp.Fill(dt);
                        //dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                con.ConnectionString = "Data Source = localhost; User Id=system; Password=system; ";
                DataTable dt = new DataTable();

                OracleDataAdapter adp = new OracleDataAdapter("select *  from room where b_id = '" + txt_inB_ID.Text + "' AND roomNumber = " + txt_inRoomNo.Text + "", con);
                adp.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void adminRoomForm_Load(object sender, EventArgs e)
        {
   
        }
    }
}

