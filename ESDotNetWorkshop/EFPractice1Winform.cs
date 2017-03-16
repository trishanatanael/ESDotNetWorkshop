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
            //LINQ?? how to get action only ??
            //DafestyEntities1 context = new DafestyEntities1();
            //var ret = from x in context.Movies1
            //          group x by x.MovieType into g
            //          //group x by (x.MovieType == "Action") into g
            //          //select new { g.Key.Where() copies = g.Sum(y => y.TotalStock) };
            //lblShow.Text = ret.ToString();


            //LAMBDA
            DafestyEntities1 context = new DafestyEntities1();
            int? totalStockActionMov = context.Movies1.Where(y => y.MovieType == "Action").Sum(x => x.TotalStock);
            lblShow.Text = totalStockActionMov.ToString();
        }

        private void btnAvgPriceComMov_Click(object sender, EventArgs e)
        {
            //LINQ??
            DafestyEntities1 context = new DafestyEntities1();
            var ret = from q in context.Movies1
                      where q.MovieType == "Comedy"
                      select q.RentalPrice;
            lblShow.Text = ret.Average().ToString();

            //LAMBDA
            //DafestyEntities1 context = new DafestyEntities1();
            //double? avgPriceComMov = context.Movies1.Where(y => y.MovieType == "Comedy").Average(x => x.RentalPrice);
            //lblShow.Text = avgPriceComMov.ToString();
        }

        private void btnRetrieveRRated3Col_Click(object sender, EventArgs e)
        {
            //LINQ
            DafestyEntities1 context = new DafestyEntities1();
            var ret = from q in context.Movies1
                      where q.Rating == "R"
                      select new { q.VideoCode, q.MovieTitle, q.RentalPrice};
            dgvAllMovies.DataSource = ret.ToList();

            //LAMBDA
            //DafestyEntities1 context = new DafestyEntities1();
            //dgvAllMovies.DataSource = context.Movies1.Where(x => x.Rating == "R").Select(q => new {q.VideoCode, q.MovieTitle, q.RentalPrice}).ToList();
        }

        private void btnTotalStockofMov_Click(object sender, EventArgs e)
        {
            //LINQ??
            DafestyEntities1 context = new DafestyEntities1();
            var ret = from x in context.Movies1
                      group x by x.MovieType into g
                      select new { MovieType = g.Key, copies = g.Sum(y => y.TotalStock) };
            dgvAllMovies.DataSource = ret.ToList();

            //LAMBDA??
            //no pure lambda available??
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //??object not instantiated
            DafestyEntities1 context = new DafestyEntities1();
            var q = from x in context.Movies1
                    where x.VideoCode == 5
                    select x;

            Movies m = new Movies();
            m = q.First();
            lblShow.Text = m.MovieTitle + " " + m.Rating + " " + m.Producer.ProducerName;

        }

        private void btnRetrieveAllbyWaltDisney_Click(object sender, EventArgs e)
        {
            DafestyEntities1 context = new DafestyEntities1();
            var ret = from q in context.Movies1
                      where q.ProducerID == "Walt"
                      select new {q.Producer.ProducerName, q.MovieTitle, q.MovieType};

            dgvAllMovies.DataSource = ret.ToList();
        }

        private void btnRetrieveAll4Col_Click(object sender, EventArgs e)
        {
            DafestyEntities1 context = new DafestyEntities1();
            var ret = from q in context.Movies1
                      select new { q.MovieTitle, q.Rating, q.MovieType, q.Producer.ProducerName };
            dgvAllMovies.DataSource = ret.ToList();
        }
    }
}
