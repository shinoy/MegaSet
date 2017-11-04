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

            FileStream fs = new FileStream(keyFileName+"E", FileMode.Truncate);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("test");
            sw.Flush();
            sw.Close();
            fs.Close();
            //dataset.ReadXml(keyReader);
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserPassDateSetCLS myDataset = new UserPassDateSetCLS();
            myDataset.ReadXml(LoadEncrytedKeyFile());
            MessageBox.Show(myDataset.Account[0].UserName);
            myDataset.Account.Rows.Add("test1", "test1", 1);
            WriteEncryptedKeyFile(myDataset);
        }
    }
}
