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
    public partial class EFOPDafestyEDMWinform : Form
    {
        public EFOPDafestyEDMWinform()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DafestyEntities2 context = new DafestyEntities2();
            //Movie m = context.Movies1.Where(x => x.VideoCode == tbxVideoCode.Value).First();
            Movie m = context.Movies1.Where(x => x.VideoCode == 5).First();
            tbxVideoCode.Text = m.VideoCode.ToString();
            tbxMovTitle.Text = m.MovieTitle.ToString();
            tbxGenre.Text = m.Genre.ToString();
            tbxRentalCost.Text = m.RentalCost.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //how to do the rental cost??
            DafestyEntities2 context = new DafestyEntities2();
            Movie m = context.Movies1.Where(x => x.VideoCode == 5).First();
            m.RentalCost = 18 / 10;
            context.SaveChanges();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DafestyEntities2 context = new DafestyEntities2();
            Movie movIn = new Movie();
            movIn.VideoCode = 400;
            movIn.MovieTitle = "Sully";
            movIn.Genre = "Drama";
            movIn.Producer.ProducerName = "Warner Brothers";
            movIn.RentalCost = 25 / 10;
            movIn.Rating = "U";
            movIn.TotalStock = 4;
            context.Movies1.Add(movIn);
            context.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DafestyEntities2 context = new DafestyEntities2();
            Movie movDel = context.Movies1.Where(x => x.VideoCode == 400).First();
            context.Movies1.Remove(movDel);
            context.SaveChanges();
        }
    }
}
