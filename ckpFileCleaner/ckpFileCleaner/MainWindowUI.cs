using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    

    public partial class MainForm : Form
    {
        public string ChosenFile = "";
        public string file = "";
        public string result = "";
        string[] removeArray = new string[] 
        {   "	:obj_name ", 
            "			:Table (network_objects)\r\n",
            "	:obj_table (network_objects)\r\n", 
            "		:update_url (\"network_objects:\")\r\n",
            "		:update_logic (override)\r\n", 
            "		:update_id_param (@)\r\n", 
            "			:ClassName (host_plain)\r\n", 
            "		:type (host)\r\n", 
            "			:table (network_objects)\r\n", 
            "		:Wiznum (-1)\r\n", 
            "			:icon (\"NetworkObjects/Nodes/Host\")\r\n", 
            "		:read_community ()\r\n", 
            "		:sysContact ()\r\n", 
            "		:sysDescr ()\r\n", 
            "		:sysLocation ()\r\n", 
            "		:sysName ()\r\n", 
            "		:write_community ()\r\n", 
            "		:add_adtr_rule (false)\r\n", 
            "		:certificates ()\r\n", 
            "		:data_source (not-installed)\r\n", 
            "		:edges ()\r\n", 
            "		:enforce_gtp_rate_limit (false)\r\n", 
            "		:gtp_rate_limit (2048)\r\n", 
            "		:interfaces ()\r\n", 
            "		:os_info ()\r\n", 
            "		:DAG (false)\r\n", 
            "		:NAT ()\r\n", 
            "		:SNMP ()\r\n", 
            "		:VPN ()\r\n", 
            "		:additional_products ()\r\n", 
            "		:color (black)\r\n", 
            "		:comments ()\r\n", 
            "		:connectra (false)\r\n", 
            "		:connectra_settings ()\r\n", 
            "		:cp_products_installed (false)\r\n", 
            "		:data_source_settings ()\r\n", 
            "		:firewall (not-installed)\r\n", 
            "		:floodgate (not-installed)\r\n",
            "       :AdminInfo\r\n",
            "			:chkpf_uid \"{",
            "				:name "};
        //int stringIndex = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            ChosenFile = openFileDialog1.FileName;
            labelFileSelected.Text = ChosenFile;
            labelFileSelected.TextChanged +=new System.EventHandler(this.labelFileSelected_TextChanged);
            StreamReader streamReader = new StreamReader(ChosenFile);
            file = streamReader.ReadToEnd();
            streamReader.Close();
        }

        private void buttonExecuteProcess_Click(object sender, EventArgs e)
        {
            result = file.Replace("\0", string.Empty); //we remove all the null's from the file

            foreach (string i in removeArray)
            {
                result = result.Replace(i, String.Empty); //remove a bunch of other garbage from the file
            }
            result = result.Replace("(", string.Empty); //remove parens
            result = result.Replace(")", string.Empty);
            
            //stringIndex = result.IndexOf("./export_details"); //remove the contents upto this point in the file. I think that I can probably do this early on and reduce the removeArray
            //result = result.Remove(0, stringIndex);

            //stringIndex = result.IndexOf("mkgroup"); // remove from here down in the file
            //result = result.Remove(0, stringIndex);

            result = result.Replace("mkgroup\r\n", string.Empty); //remove mkgroup from the list

            //stringIndex = result.IndexOf("servers-no-internet"); //remove some more stuff
            //result = result.Remove(stringIndex);
            
            //begin writing the file to disk
            StreamWriter streamWriter = new StreamWriter(ChosenFile + ".txt");
            streamWriter.Write(result);
            streamWriter.Close();
            // change the text of a label
            labelOutputFile.Text = ChosenFile + ".txt";
            labelOutputFile.TextChanged += new System.EventHandler(this.labelOutputFile_TextChanged);

        }

        private void labelFileSelected_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelFileSelected_Click(object sender, EventArgs e)
        {
        }

        private void labelOutputFile_TextChanged(object sender, EventArgs e)
        {
        }
    }
}