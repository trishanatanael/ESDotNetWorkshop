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
    public partial class EFPractice1Winform : Form
    {
        public EFPractice1Winform()
        {
            InitializeComponent();
        }

        private void btnRetrieveAll_Click(object sender, EventArgs e)
        {
            //LINQ
            //DafestyEntities1 context = new DafestyEntities1();
            //var ret = from q in context.Movies1
            //          select q;
            //dgvAllMovies.DataSource = ret.ToList();

            //LAMBDA
            DafestyEntities1 context = new DafestyEntities1();
            dgvAllMovies.DataSource = context.Movies1.ToList();

        }

        private void btnByMovTitleAsc_Click(object sender, EventArgs e)
        {
            //LINQ
            DafestyEntities1 context = new DafestyEntities1();
            var ret = from q in context.Movies1
                      orderby q.MovieTitle
                      select q;
            dgvAllMovies.DataSource = ret.ToList();

            //LAMBDA
            //DafestyEntities1 context = new DafestyEntities1();
            //dgvAllMovies.DataSource = context.Movies1.OrderBy(x => x.MovieTitle).ToList();
        }

        private void btnByRPDesc_Click(object sender, EventArgs e)
        {
            //LINQ
            DafestyEntities1 context = new DafestyEntities1();
            var ret = from q in context.Movies1
                      orderby q.RentalPrice descending
                      select q;
            dgvAllMovies.DataSource = ret.ToList();

            //LAMBDA
            //DafestyEntities1 context = new DafestyEntities1();
            //dgvAllMovies.DataSource = context.Movies1.OrderByDescending(x => x.RentalPrice).ToList();
        }

        private void btnRetrieveRRated_Click(object sender, EventArgs e)
        {
            //LINQ
            //DafestyEntities1 context = new DafestyEntities1();
            //var ret = from q in context.Movies1
            //          where q.Rating == "R"
            //          select q;
            //dgvAllMovies.DataSource = ret.ToList();

            //LAMBDA
            DafestyEntities1 context = new DafestyEntities1();
            dgvAllMovies.DataSource = context.Movies1.Where(x => x.Rating == "R").ToList();
        }

        private void btnRetrieveAllSciFicbyWarner_Click(object sender, EventArgs e)
        {
            //LINQ
            //DafestyEntities1 context = new DafestyEntities1();
            //var ret = from q in context.Movies1
            //          where q.ProducerID == "Warner" && q.MovieType =="Sci-fi"
            //          select q;
            //dgvAllMovies.DataSource = ret.ToList();

            //LAMBDA
            DafestyEntities1 context = new DafestyEntities1();
            dgvAllMovies.DataSource = context.Movies1.Where(x => x.ProducerID == "Warner" && x.MovieType == "Sci-fi").ToList();
        }

        private void btnTotalActMov_Click(object sender, EventArgs e)
        {
            //LINQ
            DafestyEntities1 context = new DafestyEntities1();
            var ret = from q in context.Movies1
                      where q.MovieType == "Action"
                      select q;
            lblShow.Text = ret.Count().ToString();

            //LAMBDA
            //DafestyEntities1 context = new DafestyEntities1();
            //int? totalActionMov = context.Movies1.Count(x => x.MovieType == "Action");
            //lblShow.Text = totalActionMov.ToString();
        }

        private void btnTotalStockofActMov_Click(object sender, EventArgs e)
        {
            //LINQ
            DafestyEntities1 context = new DafestyEntities1();
            var ret = from q in context.Movies1
                      where q.MovieType == "Action"
                      select new Sum(q.TotalStock);
            lblShow.Text = ret.Count().ToString();

            //LAMBDA
            //DafestyEntities1 context = new DafestyEntities1();
            //int? totalStockActionMov = context.Movies1.Where(y => y.MovieType == "Action").Sum(x => x.TotalStock);
            //lblShow.Text = totalStockActionMov.ToString();
        }
    }
}
