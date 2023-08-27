
using System.Data;
using System.Data.SqlClient;


namespace CRUD_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3GALLQ3\\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetEmpList();
        }

        private void Insert_Btn_Click(object sender, EventArgs e)
        {
            int empid = int.Parse(txtEmpID.Text);
            string empname = txtEmpName.Text, address = txtAddress.Text, contact = txtContact.Text, sex = "";
            double age = double.Parse(txtAge.Text);
            DateTime dtStart = DateTime.Parse(dtStarted.Text);
            if (rdoMale.Checked == true)
            {
                sex = "Male";
            }
            else
            {
                sex = "Female";
            }

            con.Open();
            SqlCommand c = new SqlCommand("exec InsertEmp_SP @EmpID, @EmpName, @Address, @Age, @Contact, @Sex, @Date_Start", con);
            c.Parameters.AddWithValue("@EmpID", empid);
            c.Parameters.AddWithValue("@EmpName", empname);
            c.Parameters.AddWithValue("@Address", address);
            c.Parameters.AddWithValue("@Age", age);
            c.Parameters.AddWithValue("@Contact", contact);
            c.Parameters.AddWithValue("@Sex", sex);
            c.Parameters.AddWithValue("@Date_Start", dtStart);

            c.ExecuteNonQuery();
            MessageBox.Show("Information is Successfully Inserted!");
            GetEmpList();
        }

        void GetEmpList()
        {
            SqlCommand c = new SqlCommand("exec ListEmp_SP", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }


        private void Upd_Btn_Click(object sender, EventArgs e)
        {


            int empid = int.Parse(txtEmpID.Text);
            string empname = txtEmpName.Text, address = txtAddress.Text, contact = txtContact.Text, sex = "";
            double age = double.Parse(txtAge.Text);
            DateTime dtStart = DateTime.Parse(dtStarted.Text);
            if (rdoMale.Checked == true)
            {
                sex = "Male";
            }
            else
            {
                sex = "Female";
            }

            con.Open();
            SqlCommand c = new SqlCommand("exec UpdateEmp_SP @EmpID, @EmpName, @Address, @Age, @Contact, @Sex, @Date_Start", con);
            c.Parameters.AddWithValue("@EmpID", empid);
            c.Parameters.AddWithValue("@EmpName", empname);
            c.Parameters.AddWithValue("@Address", address);
            c.Parameters.AddWithValue("@Age", age);
            c.Parameters.AddWithValue("@Contact", contact);
            c.Parameters.AddWithValue("@Sex", sex);
            c.Parameters.AddWithValue("@Date_Start", dtStart);

            c.ExecuteNonQuery();
            MessageBox.Show("Information is Successfully Updated!");
            GetEmpList();

        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you sure to delete this information", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int empid = int.Parse(txtEmpID.Text);

                con.Open();
                SqlCommand c = new SqlCommand("exec DeleteEmp_SP '" + empid + "'", con);
                c.Parameters.AddWithValue("@EmpID", empid);


                c.ExecuteNonQuery();
                MessageBox.Show("Information is Successfully Deleted!");
                GetEmpList();

            }


        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int searchEmpID;
            if (int.TryParse(txtSearch.Text, out searchEmpID))
            {
                string connectionString = "Data Source=DESKTOP-3GALLQ3\\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True;";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SearchEmp_SP", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmpID", searchEmpID);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dataGridView1.DataSource = dt; // Assuming dgvSearchResults is the DataGridView
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Employee ID.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }
    }
}