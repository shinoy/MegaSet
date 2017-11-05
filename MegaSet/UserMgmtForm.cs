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
    public partial class UserMgmtForm : Form
    {
        private string keyFileName = System.Environment.CurrentDirectory + @"\keyE";

        private UserPassDateSetCLS myDataset = new UserPassDateSetCLS();

        private Dictionary<string, UserInfo> userInformationDict = new Dictionary<string, UserInfo>();

        public UserMgmtForm()
        {
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

        private void refreshUserList()
        {
            this.comboBox1.Items.Clear();
            userInformationDict.Clear();
             foreach (UserPassDateSetCLS.AccountRow row in myDataset.Account.Rows)
            {
                if (row.UserName != "Admin")
                {
                    this.comboBox1.Items.Add(row.UserName);
                }
                userInformationDict.Add(row.UserName, new UserInfo(row.Password, row.Level));
               
            }
            if (this.comboBox1.Items.Count != 0)
            {
                this.comboBox1.SelectedIndex = 0;
                this.DeleteBtn.Enabled = true;
            }
            else
            {
                this.DeleteBtn.Enabled = false;
                this.comboBox1.Text = "";
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UserPassDateSetCLS.AccountRow row = (UserPassDateSetCLS.AccountRow)myDataset.Account.Select(string.Format("UserName = '{0}'", this.comboBox1.Text))[0];
                if (row != null)
                {
                    myDataset.Account.RemoveAccountRow(row);
                    WriteEncryptedKeyFile(myDataset);
                    refreshUserList();
                }

                DevExpress.XtraEditors.XtraMessageBox.Show("删除成功！");

            }
            catch(Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("删除用户失败，原因：" + ex.Message);
            }
            
        }

        private void UserMgmtForm_Load(object sender, EventArgs e)
        {
          
            try
            {
                // read key file
                myDataset.ReadXml(LoadEncrytedKeyFile());
            }
            catch (Exception ex)
            {
                MessageBox.Show("用户数据库文件损坏，无法执行用户管理");
                DialogResult = System.Windows.Forms.DialogResult.Abort;
            }

            // fill account dictionary and select box
            refreshUserList();
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.textEdit1.Text.Length == 0 || this.textEdit1.Text.Length > 8)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("用户名不可为空或者超过8个字符，请重新填写");
                return;
            }
            else
            {
                if (userInformationDict.ContainsKey(this.textEdit1.Text))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("用户已存在");
                    this.textEdit1.Text = "";
                    return;
                }
                else
                {
                    myDataset.Account.Rows.Add(this.textEdit1.Text, "111111", 1);
                  
                    WriteEncryptedKeyFile(myDataset);
                    DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("{0}添加成功",this.textEdit1.Text));
                    this.textEdit1.Text = "";
                    refreshUserList();
                    return;
                }
            }
        }
    }
}
