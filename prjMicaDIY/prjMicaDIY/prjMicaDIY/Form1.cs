using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMicaDIY
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
            
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DBConnect Connection = new DBConnect();
            Connection.OpenConnection();
            

        }
    }
}
