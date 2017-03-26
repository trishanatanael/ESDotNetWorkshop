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
    public partial class Ex1_1 : Form
    {
        public Ex1_1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string strCN = "data source=(local);integrated security=SSPI;initial catalog=Dafesty";
            SqlConnection cn = new SqlConnection(strCN);
            cn.Open();

            string sqlCMVidCode = "UPDATE movies SET RentalPrice = @UP WHERE VideoCode = @VC";
            SqlCommand cm = new SqlCommand(sqlCMVidCode, cn);

            SqlParameter VC = new SqlParameter("VC", SqlDbType.NVarChar);//instatiation
            SqlParameter UP = new SqlParameter("UP", SqlDbType.NVarChar);
            
            cm.Parameters.Add(VC);
            cm.Parameters.Add(UP);
            VC.Value = txtVideoCode.Text;
            UP.Value = txtRentalPrice.Text;

            cm.ExecuteNonQuery();
            cn.Close();
        }
    }
}
