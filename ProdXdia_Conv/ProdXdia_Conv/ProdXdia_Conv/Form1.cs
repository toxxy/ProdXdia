using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProdXdia_Conv
{
    public partial class Form1 : Form
    { 
        EAC_Framework.eac_dataGridView  gridView;
        EAC_Framework.eac_sqlConnector connection; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //HELLO 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new EAC_Framework.eac_sqlConnector("rio-sql01", "prodxdia", "", "cgaadmin", "cgaadmin201");
            gridView = new EAC_Framework.eac_dataGridView(ref dataGridView1, ref connection);
            gridView.fillGridFromSqlSelect("select * FROM [prodxdia].[dbo].[prod_diaria]", ref connection);

        }
    }
}
