using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
namespace OrdenesdeCompraWerner
{
    public partial class AlmacenarOCRealizadas : Form
    {
        public AlmacenarOCRealizadas()
        {
            InitializeComponent();
        }

        private void AlmacenarOCRealizadas_Load(object sender, EventArgs e)
        {
            OdbcConnection conector = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; Dsn=hotelsancarlos; UID=root; PWD=1234; Database=hotelsancarlosv2; ");
            conector.Open();

            try
            {



                OdbcCommand sentencia = new OdbcCommand();
                sentencia.Connection = conector;
                sentencia.CommandText = "SELECT id_oc from hotelsancarlosv2.ORDENESDECOMPRA";

                OdbcDataAdapter da1 = new OdbcDataAdapter(sentencia);
                DataTable dt = new DataTable();
                da1.Fill(dt);


                comboBox1.ValueMember = "id_oc";
                comboBox1.DisplayMember = "id_oc";

                comboBox1.DataSource = dt;

            }
            catch (OdbcException ex)
            {
                MessageBox.Show("no encntrado. " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
