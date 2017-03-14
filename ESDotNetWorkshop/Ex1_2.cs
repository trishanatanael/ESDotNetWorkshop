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
    public partial class Ex1_2 : Form
    {
        public Ex1_2()
        {
            InitializeComponent();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            string strCN = "data source=(local);integrated security=SSPI;initial catalog=Dafesty";
            SqlConnection cn = new SqlConnection(strCN);

            string sqlCMovieList = "SELECT MovieTitle FROM movies";
            SqlCommand cm = new SqlCommand(sqlCMovieList, cn);

            cn.Open();
            SqlDataReader rd = cm.ExecuteReader();
            //lbxMovieList.Text = "";
            while (rd.Read())
            {
                lbxMovieList.Items.Add(rd["MovieTitle"].ToString()+Environment.NewLine);
            }
            rd.Close();
            cn.Close();
        }
    }
}
