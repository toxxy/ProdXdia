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
    public partial class CONVERSION_DIARIA : Form
    {
        EAC_Framework.eac_sqlConnector connection, connection2;
        EAC_Framework.eac_dataGridView gridView,gridview,gridsview,gridVIEW;
        public CONVERSION_DIARIA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new EAC_Framework.eac_sqlConnector("ASUS-ROG", "ProdXdia", "Prodxdia", "cris", "12345678");
            connection2 = new EAC_Framework.eac_sqlConnector("ASUS-ROG", "ProdXdia", "repomanodeobra", "cris", "12345678");
          
            gridView = new EAC_Framework.eac_dataGridView(ref CONVERSIONDIARIA, ref connection);
            gridView.fillGridFromSqlSelect("select * from prodxdia", ref connection);

            gridview = new EAC_Framework.eac_dataGridView(ref REPORTEMANODEOBRA, ref connection);
            gridview.fillGridFromSqlSelect("select * from repomanodeobra", ref connection);

            gridsview = new EAC_Framework.eac_dataGridView(ref SUMMARYMANODEOBRA, ref connection);
            gridsview.fillGridFromSqlSelect("select SUM(HORAS), SUM(CANTIDAD) from repomanodeobra", ref connection);

            gridVIEW = new EAC_Framework.eac_dataGridView(ref SUMMARYCONVERSIONDIARIA, ref connection);
            gridVIEW.fillGridFromSqlSelect("select SUM(CANTIDAD) from prodxdia", ref connection);

            //Cheats
            gridView.setAutoUpdate(true);
            gridView.setAutoInsert(true);
        }

    }
}
