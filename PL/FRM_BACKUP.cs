using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SaleManagementSystem.PL
{
    public partial class FRM_BACKUP : Form
    {
        SqlConnection con = new SqlConnection(@"Server =.\ZAIDSQL; DataBase = DB_POS; Integrated Security = True");
        SqlConnection con1 = new SqlConnection(@"Server =.\ZAIDSQL; DataBase = master; Integrated Security = True");
        SqlCommand cmd;
        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void btnFolderBrowse_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtfolderpath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCreateBackup_Click(object sender, EventArgs e)
        {
            string filename = txtfolderpath.Text + "//DB_POS" + DateTime.Now.ToShortDateString().Replace('/', '-') + "-"+ DateTime.Now.ToShortTimeString().Replace(':','-');
            string strQuery = "Backup Database DB_POS to Disk = '" + filename + ".bak'";
            cmd = new SqlCommand(strQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم انشاء النسخة الاحتياطية بنجاح", "أنشاء نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFileBrowse_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtfilepath.Text = openFileDialog1.FileName;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string strQuery = "ALTER Database DB_POS SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database DB_POS From Disk = '" + txtfilepath.Text + "' WITH REPLACE";
            cmd = new SqlCommand(strQuery, con1);
            con1.Open();
            cmd.ExecuteNonQuery();
            con1.Close();
            MessageBox.Show("تم استعادة النسخة الاحتياطية بنجاح", "استعادة النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
