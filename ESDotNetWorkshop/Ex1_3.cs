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
    public partial class Ex1_3 : Form
    {
        SqlConnection cnnct;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        int i = 0;

        public Ex1_3()
        {
            InitializeComponent();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            string strCmdRetrieve = "SELECT MovieTitle, RentalPrice FROM Movies WHERE VideoCode = @VC";
            cmd = new SqlCommand(strCmdRetrieve, cnnct);
            SqlParameter inptVC = new SqlParameter("VC", SqlDbType.NVarChar);
            cmd.Parameters.Add(inptVC);
            inptVC.Value = tbxVidCode.Text;
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Movies");
            tbxMovTitle.Text = ds.Tables["Movies"].Rows[0]["MovieTitle"].ToString();
            tbxRentalPrice.Text = ds.Tables["Movies"].Rows[0]["RentalPrice"].ToString();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (i = 0; i < ds.Tables["Movies"].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["VideoCode"].ToString() == tbxVidCode.Text)
                {
                    i += i;
                    ds.Tables["Movies"].Rows[i]["MovieTitle"] = tbxMovTitle.Text;
                    ds.Tables["Movies"].Rows[i]["RentalPrice"] = tbxRentalPrice.Text;
                    da.Update(ds, "Movies");
                    break;
                }
            }
        }

        private void Ex1_3_Load(object sender, EventArgs e)
        {
            string strCnnct = "data source=(local);integrated security=SSPI;initial catalog=Dafesty";
            cnnct = new SqlConnection(strCnnct);
            ds = new DataSet();

        }

    }
}