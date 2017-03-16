using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESDotNetWorkshop
{
    public partial class DafestyEDMWinform : Form
    {
        public DafestyEDMWinform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //instantiate the data set
            DafestyEntities context = new DafestyEntities();
            ///*dataGridView1.DataSource = context.Customers.ToList();*/

            //LINQ
            //var q = from x in context.Customers
            //        where x.CustomerID == "1001"
            //        select x;
            //rhs = objt query
            //Customer c = q.First();//sql command fired here
            //label1.Text = c.CustomerName;

            //var qq = from x 
            //         in context.Customers
            //         orderby x.CustomerName
            //         //where x.Age>50 && x.CustomerName.Substring(0,1) == "S"
            //         select new { x.CustomerID, x.CustomerName, x.MemberStatus };
            //dataGridView1.DataSource = qq.ToList();

            //lambda
            //dataGridView1.DataSource = context.Customers.Where(x =>x.Age >=50 && x.MemberStatus == "A").ToList();
            //dataGridView1.DataSource = context.Customers.Where(y => y.MemberStatus == "A").OrderBy(x => x.CustomerName).ToList();
            decimal? amt = context.Customers.Sum(x => x.AmountSpent);
            label1.Text = amt.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //object x = "ISS";
            //var y = "ISS";
            //object i = 5;
            //var j = 6;
            //label2.Text = ((string)x).Substring(1, 1);
        }
    }
}
