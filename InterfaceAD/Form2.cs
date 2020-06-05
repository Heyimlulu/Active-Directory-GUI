using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.Management.Automation;
using System.Windows.Forms;

namespace InterfacePowShell
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();

            this.Hide();
        }

        private void ButAffiche_Click(object sender, EventArgs e)
        {
            DirectoryEntry Ldap = new DirectoryEntry("LDAP://Forest.Gump", "Administrateur", "Serveur2019");
            DirectorySearcher searcher = new DirectorySearcher(Ldap);

            if (comboBoxAD.Text == "Services List")
            {
                String donneeDomaineServ = "";
                PowerShell shell = PowerShell.Create();
                shell.AddCommand("Get-Service")
                     .AddStatement();


                foreach (PSObject result in shell.Invoke())
                {
                    donneeDomaineServ = (donneeDomaineServ + result + "\r\n");
                }
                textBoxAD.Text = (donneeDomaineServ);

            }
            else if (comboBoxAD.Text == "ADUser List Path")
            {
                String donneeDomaineServ = "";
                PowerShell shell = PowerShell.Create();
                shell.AddCommand("Get-ADUser").AddParameter("Filter", "*");


                foreach (PSObject result in shell.Invoke())
                {
                    donneeDomaineServ = (donneeDomaineServ + result + "\r\n");
                }

                textBoxAD.Text = (donneeDomaineServ);
            }
            else if (comboBoxAD.Text == "HardDisks List")
            {
                String donneeDomaineServ = "";
                PowerShell shell = PowerShell.Create();
                shell.AddCommand("Get-Disk")
                     .AddStatement();


                foreach (PSObject result in shell.Invoke())
                {
                    donneeDomaineServ = (donneeDomaineServ + result + "\r\n");
                }
                textBoxAD.Text = (donneeDomaineServ);
            }
            else if (comboBoxAD.Text == "DNS List")
            {
                String donneeDomaineServ = "";
                PowerShell shell = PowerShell.Create();
                shell.AddCommand("Get-DnsClient")
                     .AddStatement();


                foreach (PSObject result in shell.Invoke())
                {
                    donneeDomaineServ = (donneeDomaineServ + result + "\r\n");
                }
                textBoxAD.Text = (donneeDomaineServ);

            }
            else if (comboBoxAD.Text == "Firewall List")
            {
                String donneeDomaineServ = "Get-NetFirewallProfile";
                PowerShell shell = PowerShell.Create();
                shell.AddCommand("")
                     .AddStatement();


                foreach (PSObject result in shell.Invoke())
                {
                    donneeDomaineServ = (donneeDomaineServ + result + "\r\n");
                }
                textBoxAD.Text = (donneeDomaineServ);

            }
        }
    }
}
