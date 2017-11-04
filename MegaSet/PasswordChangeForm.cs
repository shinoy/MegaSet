using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaSet
{
    public partial class PasswordChangeForm : Form
    {
        private string keyFileName = System.Environment.CurrentDirectory + @"\keyE";

        private UserPassDateSetCLS myDataset = new UserPassDateSetCLS();

        private string currentUser = String.Empty;

        public PasswordChangeForm(string userName)
        {
            currentUser = userName;
            InitializeComponent();
        }

        // encrypt/decrypt key file
        private string EDncpytString(string input, bool type)
        {
            if (type)
            {
                return System.Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(input));
            }
            else
            {
                return System.Text.Encoding.Unicode.GetString(System.Convert.FromBase64String(input));
            }
        }

        private TextReader LoadEncrytedKeyFile()
        {
            try
            {
                StreamReader keyReader = new StreamReader(keyFileName);
                string keyXmlStr = keyReader.ReadToEnd();
                string content = EDncpytString(keyXmlStr, false);
                keyReader.Close();
                return new StringReader(content);
            }
            catch (FileNotFoundException)
            {
                return null;
                // TBD, do we need to create a default key file here?
            }
            catch (FormatException ex)
            {
                return null;
                //TBD, the key file format is not correct, do we need to create a default key file?
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void WriteEncryptedKeyFile(DataSet dataset)
        {
            try
            {
                FileStream fs = new FileStream(keyFileName, FileMode.Truncate);
                StreamWriter sw = new StreamWriter(fs);
                string keyXmlStr = dataset.GetXml();
                string encpytedXML = EDncpytString(keyXmlStr, true);
                sw.Write(encpytedXML);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            UserPassDateSetCLS.AccountRow row = (UserPassDateSetCLS.AccountRow)myDataset.Account.Select(string.Format("UserName = '{0}'", currentUser))[0];
            if (row.Password != this.oldpassTextB.Text)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("原密码错误");
                this.oldpassTextB.Text = "";
                return;
            }

            if (string.IsNullOrEmpty(this.newPass1TextB.Text) || string.IsNullOrEmpty(this.newPass2TextB.Text) || (this.newPass1TextB.Text != this.newPass2TextB.Text))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请确认新密码非空并且两次输入正确");
                return;
            }

            row.Password = this.newPass1TextB.Text;
            WriteEncryptedKeyFile(myDataset);
            DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("用户{0}密码修改成功！", currentUser));
            DialogResult = System.Windows.Forms.DialogResult.OK;
           
        }

        private void PasswordChangeForm_Load(object sender, EventArgs e)
        {
            try
            {
                // read key file
                myDataset.ReadXml(LoadEncrytedKeyFile());
            }
            catch (Exception ex)
            {
                MessageBox.Show("用户数据库文件损坏，无法修改密码");
                DialogResult = System.Windows.Forms.DialogResult.Abort;
            }

        }
    }
}
