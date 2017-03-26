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
            short srchVidCode = Convert.ToInt16(tbxVideoCode.ToString());
            DafestyEntities2 context = new DafestyEntities2();
            Movie m = context.Movies1.Where(x => x.VideoCode == @srchVidCode).First();
            tbxVideoCode.Text = m.VideoCode.ToString();
            tbxMovTitle.Text = m.MovieTitle.ToString();
            tbxGenre.Text = m.Genre.ToString();
            m.RentalCost = Convert.ToInt32(tbxRentalCost.ToString()) ;
            context.SaveChanges();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DafestyEntities2 context = new DafestyEntities2();
            Movie movIn = new Movie();
            movIn.VideoCode = Convert.ToInt16(tbxVideoCode.ToString());//id should be 400
            movIn.MovieTitle = tbxMovTitle.ToString();
            movIn.Genre = tbxGenre.ToString();
            movIn.Producer.ProducerName = "Warner Brothers";
            movIn.RentalCost = Convert.ToInt32(tbxRentalCost.ToString());
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
