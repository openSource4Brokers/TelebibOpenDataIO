using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelebibOpenDataIO
{
    public partial class FrmTelebibOpenDataIO : Form
    {
        public string dbJetProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=";
        public string dbmarLocatie = "";

        public string dbQualifiersSQL = "select * from A_DE_QUALIFIANT";
        public string dbValeursSQL = "select * from VALEUR";
        public string cnnChosen = "";

        public FrmTelebibOpenDataIO()
        {
            InitializeComponent();
        }

        private void FrmTelebibOpenDataIO_Load(object sender, EventArgs e)
        {
            Text = "Telebib IO";            
            tbLocalConnectionstring.Text = Properties.Settings.Default.LocalSQLSetting;
            tbHostedConnectionstring.Text = Properties.Settings.Default.HostedSQLSetting;            
        }

        private void BtnGetTelebib2Location_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog MarntOpenFileDialog = new OpenFileDialog())
            {
                MarntOpenFileDialog.InitialDirectory = "c:\\";
                MarntOpenFileDialog.Filter = "mdb files (*.mdb)|*.mdb|All files (*.*)|*.*";
                MarntOpenFileDialog.FilterIndex = 1;
                MarntOpenFileDialog.RestoreDirectory = true;

                if (MarntOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileContent = string.Empty;
                    string filePath = string.Empty;

                    //Get the path of specified file
                    filePath = MarntOpenFileDialog.FileName;
                    tb2Location.Text = dbJetProvider + MarntOpenFileDialog.FileName;
                    btnGetTelebib2Location.Text = "OK";
                    tb2Location.Enabled = false;
                    _ = MessageBox.Show("File at path: " + filePath);
                    groupBox1.Visible = true;

                    // Properties.Settings.Default.MdvSetting = tbMarLocatie.Text;
                }
            }
        }

        private void BtnCheckLocalSqlServer_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LocalSQLSetting = tbLocalConnectionstring.Text;
        }

        private void BtnCheckHostedSqlServer_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HostedSQLSetting = tbHostedConnectionstring.Text;
        }

        private void RbLocal_CheckedChanged(object sender, EventArgs e)
        {
            cnnChosen =tbLocalConnectionstring.Text;
            btnReadMdb.Enabled = true;
        }

        private void RbHosted_CheckedChanged(object sender, EventArgs e)
        {
            cnnChosen = tbHostedConnectionstring.Text;
            btnReadMdb.Enabled = true;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnReadMdb_Click(object sender, EventArgs e)
        {
            // Qualifiers and Valeurs
            MessageBox.Show("Start transfer qualifiers and valeurs. For every 2000 records moving to hosting account it will take one or more minutes");
            Cursor.Current = Cursors.WaitCursor;
            
            MdbDataTb2 dbQandV = new MdbDataTb2();
            dbQandV.DataOrgTbInsert(tb2Location.Text, dbQualifiersSQL, dbValeursSQL, cnnChosen);

            Cursor.Current = Cursors.Default;
            MessageBox.Show("Transfer Qualifiers and Valeurs finished");
        }
    }
}
