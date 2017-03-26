using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ESDotNetWorkshop
{
    public partial class Ex1_3Difficult : Form
    {
        SqlConnection cnnct;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmb;
        int position = 0;
        public Ex1_3Difficult()
        {
            InitializeComponent();
        }
        private void PopulateTextBox()
        {
            tbxCustID.Text = ds.Tables["Customers"].Rows[position]["CustomerID"].ToString();
            tbxCustName.Text = ds.Tables["Customers"].Rows[position]["CustomerName"].ToString();
            tbxMemberCategory.Text = ds.Tables["Customers"].Rows[position]["MemberCategory"].ToString();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["CustomerID"].ToString() == tbxFind.Text)
                    break;
            }
            if (i < ds.Tables[0].Rows.Count)
            {
                position = i;
                PopulateTextBox();
            }
            else
                tspStatus.Text = "Record not found";
        
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
           
            da.Fill(ds, "Customers");

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            da.Fill(ds, "Customers");
            tbxCustID.Text = ds.Tables["Customers"].Rows[0]["CustomerID"].ToString();
            tbxCustName.Text = ds.Tables["Customers"].Rows[0]["CustomerName"].ToString();
            tbxMemberCategory.Text = ds.Tables["Customers"].Rows[0]["MemberCategory"].ToString();
        }

        private void Ex1_3Difficult_Load(object sender, EventArgs e)
        {
            cnnct = new SqlConnection("data source=(local);integrated security=SSPI;initial catalog=Dafest");

            string strCmd = "SELECT CustomerID, CustomerName, MemberCategory FROM Customers";
            cmd = new SqlCommand(strCmd, cnnct);

            da = new SqlDataAdapter(cmd);
            cmb = new SqlCommandBuilder(da);

            ds = new DataSet();
        }

        private void btnNextCustomer_Click(object sender, EventArgs e)
        {
            if (position < ds.Tables[0].Rows.Count)
            {
                position++;
                PopulateTextBox();
            }
            tspStatus.Text = "Record: " + position;
        }

        private void btnPreviousCustomer_Click(object sender, EventArgs e)
        {
            if (position>0)
            {
                position--;
                PopulateTextBox();
            }
            tspStatus.Text = "Record: " + position;
        }

        private void btnLastCustomer_Click(object sender, EventArgs e)
        {
            position = ds.Tables[0].Rows.Count-1;
            PopulateTextBox();
            tspStatus.Text = "Record: " + position;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RetrieveTextBox();
            da.Update(ds,"Customers");
        }

        private void RetrieveTextBox()
        {
            ds.Tables["Customers"].Rows[position]["CustomerID"] = tbxCustID.Text;
            ds.Tables["Customers"].Rows[position]["CustomerName"] = tbxCustName.Text;
            ds.Tables["Customers"].Rows[position]["MemberCategory"] = tbxMemberCategory.Text;
        }

        private void btnFirstCustomer_Click(object sender, EventArgs e)
        {
            position = 0;
            PopulateTextBox();
            tspStatus.Text = "Record: " + position;
        }
    }
}
