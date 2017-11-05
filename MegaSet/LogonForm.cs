using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace MegaSet
{
    

    public partial class LogonForm : Form
    {

        private string keyFileName = System.Environment.CurrentDirectory + @"\keyE";

        private UserPassDateSetCLS myDataset = new UserPassDateSetCLS();

        private Dictionary<string, UserInfo> userInformationDict = new Dictionary<string, UserInfo>();

        public string LogOnUser = string.Empty;
        public string LogOnLevel = "-1";

        public LogonForm()
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
            catch(FormatException ex)
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
       

        private void button3_Click(object sender, EventArgs e)
        {
            UserPassDateSetCLS dataset = new UserPassDateSetCLS();
            StreamReader keyReader = new StreamReader(keyFileName);
            string keyXmlStr = keyReader.ReadToEnd();
            string EncyptKeyStr = EDncpytString(keyXmlStr, true);

            FileStream fs = new FileStream(keyFileName+"E", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("test");
            sw.Flush();
            sw.Close();
            fs.Close();
            //dataset.ReadXml(keyReader);
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 1)
            {
                MessageBox.Show("请输入密码登录");
            }
            else
            {
                if (userInformationDict[this.comboBox1.Text].Password == this.textBox2.Text)
                {
                    LogOnUser = this.comboBox1.Text;
                    LogOnLevel = userInformationDict[this.comboBox1.Text].Level;
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    this.textBox2.Clear();
                    MessageBox.Show("密码错误");
                }
            }
        }

        private void LogonForm_Load(object sender, EventArgs e)
        {
           
            try
            {
                // read key file
                myDataset.ReadXml(LoadEncrytedKeyFile());


            }
            catch (Exception ex)
            {
                MessageBox.Show("用户数据库损坏，请用默认管理员帐户密码登录");
                // restore default admin user 
                myDataset.Account.Rows.Clear();
                myDataset.Account.Rows.Add("Admin", "Admin", "0");
                WriteEncryptedKeyFile(myDataset);
            }


            // fill account dictionary and select box
            foreach (UserPassDateSetCLS.AccountRow row in myDataset.Account.Rows)
            {
                this.comboBox1.Items.Add(row.UserName);
                userInformationDict.Add(row.UserName, new UserInfo(row.Password, row.Level));
            }
            if (this.comboBox1.Items.Count != 0)
            {
                this.comboBox1.SelectedIndex = 0;
            }
            else
            {
                this.comboBox1.Text = "";
            }
           
           
        }

      

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (textBox2.Text.Length < 1)
                {
                    MessageBox.Show("请输入密码登录");
                }
                else
                {
                    if (userInformationDict[this.comboBox1.Text].Password == this.textBox2.Text)
                    {
                        LogOnUser = this.comboBox1.Text;
                        LogOnLevel = userInformationDict[this.comboBox1.Text].Level;
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {
                        this.textBox2.Clear();
                        MessageBox.Show("密码错误");
                    }
                }
            }
        }


    }
}
