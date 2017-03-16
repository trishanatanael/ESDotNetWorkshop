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
            //DafestyEntities2 context = new DafestyEntities2();
            //Movie m = context.Movies1.Where(x => x.VideoCode == 5).First();
            //m.RentalCost = "1.8";
            //context.SaveChanges();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DafestyEntities2 context = new DafestyEntities2();
            Movie m = context.Movies1.Where(x => x.VideoCode == 5).First();
        }
    }
}
