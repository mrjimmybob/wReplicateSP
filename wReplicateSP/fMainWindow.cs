using DocumentFormat.OpenXml.Drawing.Diagrams;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Resources;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using wReplicateSP;
using wReplicateSP.Properties;
using YamlDotNet.Serialization.NamingConventions;
using System;
using System.Threading;
using System.Windows.Forms;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office2013.Excel;

namespace wreplicaesp
{
    public partial class fMainForm : Form
    {
        List<RemoteServerData> connectionList = new();
        string configFileName = "C:\\Users\\mr_ji\\source\\repos\\wReplicateSP\\wReplicateSP\\wReplicateSP\\replicatesp.yaml";
        bool selected = false;
        private List<Task<bool>> SqlProcesses = new();

        public fMainForm()
        {
            InitializeComponent();
            cbObjectType.SelectedIndex = 0;
            LoadDatabaseCombobox();
            LoadDbObjectsCombobox();
            ReadConfigurationFile(configFileName);
            RemotServersShowConnectionStatus();
        }


        private void cbObjectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lObjectTypeName.Text = cbObjectType.SelectedItem.ToString();
        }

        private void LoadDatabaseCombobox()
        {
            if (tbServer.Text.Length > 0) {
                try {
                    string auth = (tbUsername.Text.Length == 0 && tbPassword.Text.Length == 0) ? "Integrated Security=true;" : "User Id=" + tbUsername.Text + ";Password=" + tbPassword.Text + ";";
                    string connectionString = "Data Source=" + tbServer.Text + ";Initial Catalog=master;" + auth;
                    using SqlConnection connection = new SqlConnection(connectionString);
                    SqlDataAdapter da = new SqlDataAdapter("SELECT [name] FROM sys.databases ORDER BY [name];  ", connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbDatabase.DataSource = dt;
                    cbDatabase.DisplayMember = "name";
                    cbDatabase.ValueMember = "name";
                }
                catch {
                    // Handle error
                }
            }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            LoadDatabaseCombobox();
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            LoadDatabaseCombobox();
        }

        private void LoadDbObjectsCombobox()
        {
            if (tbServer.Text.Length > 0)
            {
                string query = cbObjectType.SelectedItem.Equals("Stored Procedure")
                    ? "SELECT [name], [definition] FROM sys.objects o INNER JOIN sys.sql_modules m ON o.object_id = m.object_id WHERE type = 'P' ORDER BY [name];"
                    : "SELECT [name], [definition] FROM sys.sql_modules m INNER JOIN sys.objects o ON m.object_id=o.object_id WHERE type_desc like '%function%' ORDER BY [name];";
                try
                {
                    string dbName = cbDatabase.GetItemText(cbDatabase.SelectedItem);
                    string auth = (tbUsername.Text.Length == 0 && tbPassword.Text.Length == 0) ? "Integrated Security=true;" : "User Id=" + tbUsername.Text + ";Password=" + tbPassword.Text + ";";
                    string connectionString = "Data Source=" + tbServer.Text + ";Initial Catalog=" + dbName + ";" + auth;
                    using SqlConnection connection = new SqlConnection(connectionString);
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbDatabaseObjects.DataSource = dt;
                    cbDatabaseObjects.DisplayMember = "name";
                    cbDatabaseObjects.ValueMember = "name";
                }
                catch
                {
                    // Handle error
                }
            }
        }

        private void cbObjectType_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDbObjectsCombobox();
        }

        private void cbDatabase_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDbObjectsCombobox();
        }

        private void EnableClearLoadedText(bool enable = true)
        {
            tsbClearLoadedText.Enabled = enable;
            clearLoadedTextToolStripMenuItem.Enabled = enable;
        }

        private void EnableReplicateData(bool enable = true)
        {
            tsbReplicate.Enabled = enable;
        }


        private void bLoad_Click(object sender, EventArgs e)
        {
            EnableClearLoadedText();
            string ObjectName = cbDatabaseObjects.GetItemText(cbDatabaseObjects.SelectedItem);
            GetDbObjectDefinition(ObjectName);
            EnableReplicateData();
        }

        private void GetDbObjectDefinition(string ObjectName)
        {
            if (tbServer.Text.Length > 0)
            {
                string query = cbObjectType.SelectedItem.Equals("Stored Procedure")
                    ? "SELECT [definition] FROM sys.objects o INNER JOIN sys.sql_modules m ON o.object_id = m.object_id WHERE type = 'P' AND [name] = '" + ObjectName + "';"
                    : "SELECT [definition] FROM sys.sql_modules m INNER JOIN sys.objects o ON m.object_id=o.object_id WHERE type_desc like '%function%' AND [name] = '" + ObjectName + "';";
                try
                {
                    string dbName = cbDatabase.GetItemText(cbDatabase.SelectedItem);
                    string auth = (tbUsername.Text.Length == 0 && tbPassword.Text.Length == 0) ? "Integrated Security=true;" : "User Id=" + tbUsername.Text + ";Password=" + tbPassword.Text + ";";
                    string connectionString = "Data Source=" + tbServer.Text + ";Initial Catalog=" + dbName + ";" + auth;
                    using SqlConnection connection = new SqlConnection(connectionString);
                    using SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    tbDbObjectText.Text = reader[0].ToString();
                }
                catch
                {
                    // Handle error
                }
            }
        }

        RemoteServerControls CreateConfigurationControl(string? connectionName)
        {
            // Create group box as main panel for the controls
            GroupBox gbRemoteServer = new()
            {
                Name = "gbRemoteServer",
                Dock = DockStyle.Fill,
                Size = new Size(498, 110),
                Font = new System.Drawing.Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point),
                TabIndex = 0,
                AutoSize = false,
                TabStop = false,
                Text = connectionName
            };
            // Create FlowLayout panel
            Panel flpRemoteServer = new()
            {
                AutoSize = false,
                // AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Dock = DockStyle.Fill,
                Size = new Size(478, 80),
                Name = "flpRemoteServerPanel",
                TabIndex = 0
            };
            // Create controls

            // Now add everithg together
            gbRemoteServer.Controls.Add(flpRemoteServer); // Add FlowPanel to the group box

            RemoteServerControls rsc = new();
            // Add the controls to the flow panel
            flpRemoteServer.Controls.Add(rsc.cbTransfer);
            flpRemoteServer.Controls.Add(rsc.pbRemoteServerDB);
            flpRemoteServer.Controls.Add(rsc.lRemoteServerStatus);
            flpRemoteServer.Controls.Add(rsc.pbRemoteServerSpinner);
            flpRemoteServer.Controls.Add(rsc.bRemoteServerCancel);

            // Finally add each group box with the controls to the main controls panel:
            tlpConfigurationItemsPanel.Controls.Add(gbRemoteServer);
            return rsc;
        }

        private void ReadConfigurationFile(string configFileName)
        {
            Config configuration = ReadConfiguration(configFileName);
            if (configuration != null && configuration.Connections != null)
            {
                for (int i = 0; i < configuration.Connections.Count; i++)
                {
                    string? name = configuration.Connections[i].Name;
                    RemoteServerData rsd = new(configuration.Connections[i],
                        CreateConfigurationControl(name));
                    connectionList.Add(rsd);
                    this.toolTip1.SetToolTip(rsd.rsc.cbTransfer, "Transfer data to this remote server");
                }
            }
        }

        private void RecheckConections()
        {
            foreach (RemoteServerData rsd in connectionList) {
                rsd.Connect();
            }
        }

        private void SelectConectionsAllNone()
        {
            cbSelectAll.Checked = selected;
            cbSelectAll.Text = selected ? "Select None" : "Select All  ";
            selected = !selected;
            foreach (RemoteServerData rsd in connectionList)
            {
                rsd.rsc.SetSelectForTransfer(selected);
            }
        }

        static Config ReadConfiguration(string configFileName)
        {
            string configFile = ReadFileContents(configFileName);
            if (configFile != null)
            {
                try
                {
                    var deserializer = new YamlDotNet.Serialization.DeserializerBuilder()
                        .WithNamingConvention(CamelCaseNamingConvention.Instance)
                        .Build();
                    Config Configuration = deserializer.Deserialize<Config>(configFile);

                    // Print.PrintConfiguration(Configuration);
                    return Configuration;
                }
                catch (YamlDotNet.Core.SemanticErrorException e)
                {
                    // ("Error reading configuration file", "Error", e.Message);
                }
                catch (YamlDotNet.Core.YamlException e)
                {
                    // ("Error reading configuration file", "Error", e.Message);
                }
            }
            return new Config();
        }

        static string ReadFileContents(string fileName)
        {
            try
            {
                using var sr = new StreamReader(fileName);
                string configFile = sr.ReadToEnd();
                return configFile;
            }
            catch
            {
                return string.Empty;
            }
        }

        private void ExitApplication()
        {
            Environment.Exit(0);
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void tsbClearLoadedText_Click(object sender, EventArgs e)
        {
            ClearLoadedText();
            EnableReplicateData(false);
        }

        private void ClearLoadedText()
        {
            EnableClearLoadedText(false);
            tbDbObjectText.Text = string.Empty;
        }

        private void clearLoadedTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearLoadedText();
        }

        private void ClearConfiguration()
        {
            foreach (Control gb in tlpConfigurationItemsPanel.Controls)
            {
                // tlpConfigurationItemsPanel.Controls.Remove(gb);
                // gb.BackColor = Color.Red;
            }
        }

        private void tsbReloadConfiguration_Click(object sender, EventArgs e)
        {
            //ClearConfiguration();
            //ReadConfigurationFile(configFileName);
            RecheckConections();
        }

        private void cbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            SelectConectionsAllNone();
        }

        private void EnableProcessingContorls(bool enable) {
            tbDbObjectText.Enabled = enable;
            flpSourceDBControls.Enabled = enable;
            tsbCancel.Enabled = enable;
        }

        public List<string> ExtractStoredProcedures(string sourcestring)
        {
            List<string> result = new List<string>();
            Regex re = new(@"\b(ALTER|CREATE)\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = re.Matches(sourcestring);
            int start = 0;
            foreach (Match match in matches.Cast<Match>())
            {
                GroupCollection groups = match.Groups;
                int newMatch = groups[0].Index;
                if (start != newMatch)
                {
                    int end = newMatch;
                    result.Add(sourcestring[start..end]);
                    start = end;
                }
            }
            if (sourcestring.Length > start)
            {
                result.Add(sourcestring[start..]);
            }
            return result;
        }

        //public bool RetryOnErrorOK(CmdLineOptions opts, DB db, string sp)
        //{
        //    if (opts.Force)
        //    {
        //        // Only retry on forced execution
        //        switch (db.getErrorNumber())
        //        {
        //            case 2714: // Name exists (when creating)
        //                // Rename procedure and retry CREATE
        //                if (RenameStoredProcedure(opts, db, sp))
        //                {
        //                    RunTask(db, sp);
        //                    if (opts.Debug && db.Error()) Print.Error(db.getErrorMessage(), "Debug", db.getErrorDetail());
        //                    if (db.Error()) return false;
        //                    db.ResetError();
        //                    return true;
        //                }
        //                return false;
        //            case 208: // Name does not exist (when altering)
        //                // rename ALTER to CREATE and retry
        //                string newSp = getRespecifiedSPOperation(opts, sp);
        //                if (opts.Debug) Print.Error("Changed ALTER to CREATE", "Debug", Environment.NewLine + newSp);
        //                if (newSp == string.Empty) return false;
        //                RunTask(db, newSp);
        //                if (opts.Debug && db.Error()) Print.Error(db.getErrorMessage(), "Debug", db.getErrorDetail());
        //                if (db.Error()) return false;
        //                db.ResetError();
        //                return true;
        //        }
        //    }
        //    return true;
        //}

        private bool TransferDbObjectToRemoteServers(BackgroundWorker bw, RemoteServerData rsd, List<string> storedProcedureList, bool Overwrite, bool Create)
        {
            rsd.Connect();
            if (!rsd.Error())
            {
                if (bw.CancellationPending) return true;
                rsd.TransferAllDbObjects(bw, storedProcedureList, Overwrite, Create);
            }
            return rsd.Error();
        }

        //public bool RunTask(RemoteServerData rsd, List<string> storedProcedureList, bool Overwrite, bool Create)
        //{
        //    return TransferDbObjectToRemoteServers(rsd, storedProcedureList, Overwrite, Create);
        //}

        private bool ProcessConfigurationItems(BackgroundWorker bw, RemoteServerData rsd,
            string DbObjectText, bool Overwrite, bool Create)
        {
            bool error = false;
            List<string> storedProcedures = ExtractStoredProcedures(DbObjectText);
            if (storedProcedures.Count >= 0) {
                if (rsd.rsc.cbTransfer.Checked)
                {
                    
                    error |= TransferDbObjectToRemoteServers(bw, rsd, storedProcedures, Overwrite, Create);
                    //rsd.ShowGuiPreTask();
                }
            }
            return error;
        }

        private void RemotServersShowConnectionStatus()
        {
            foreach (RemoteServerData rsd in connectionList)
            {
                if (rsd.rsc.cbTransfer.Checked)
                {
                    rsd.ShowConnectionStatus();
                }
            }
        } 

        private void RemoteServersShowGuiPreTask()
        {
            foreach (RemoteServerData rsd in connectionList)
            {
                if (rsd.rsc.cbTransfer.Checked && !rsd.Error()) {
                        rsd.ShowGuiPreTask();
                }
            }
        }

        private void RemoteServersShowGuiPostTask(string Message)
        {
            foreach (RemoteServerData rsd in connectionList)
            {
                if (rsd.rsc.cbTransfer.Checked)
                {
                    //if (rsd.Error()) {
                        rsd.ShowGuiPostTask(Message);
                    //}
                }
            }
        }

        private void RemoteServersResetErrors()
        {
            foreach (RemoteServerData rsd in connectionList)
            {
                rsd.Connect();
            }
            RemotServersShowConnectionStatus();
        }

        private void RunReplicateCommand()
        {
            bool Overwrite = cbOverwrite.Checked;
            bool Create = cbCreateOnAlter.Checked;
            string DbObjectText = tbDbObjectText.Text;
            List<BackgroundWorker> bgWorkers = new List<BackgroundWorker>();

            EnableProcessingContorls(false);
            RemoteServersShowGuiPreTask();

            foreach (RemoteServerData rsd in connectionList)
            {
                // Worker config
                rsd.worker.WorkerReportsProgress = true;
                rsd.worker.WorkerSupportsCancellation = true;
                // Register callback functions 
                rsd.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(bwTransfer_DoWork);
                rsd.worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(bwTransfer_ProgressChanged);
                rsd.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(bwTransfer_RunWorkerCompleted);
                // Worker arguments
                List<object> arguments = new List<object>();
                arguments.Add(rsd);
                arguments.Add(DbObjectText);
                arguments.Add(Overwrite);
                arguments.Add(Create);
                rsd.worker.RunWorkerAsync(arguments);
            }
        }

        private void tsbReplicate_Click(object sender, EventArgs e)
        {
            RunReplicateCommand();
        }

        private void bwTransfer_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker? bw = sender as BackgroundWorker;
            List<object>? ArgList = e.Argument as List<object>;

            // Extract the arguments.
            if (ArgList != null) {
                RemoteServerData rsd = (RemoteServerData)ArgList[0];
                string? DbObjectText = (string?)ArgList[1];
                bool Overwrite = (bool)ArgList[2];
                bool Create = (bool)ArgList[3];

                e.Result = ProcessConfigurationItems(bw, rsd, DbObjectText, Overwrite, Create);
            }

            // If the operation was canceled by the user, 
            // set the DoWorkEventArgs.Cancel property to true.
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private void bwTransfer_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            string Message = string.Empty;
            if (e.Cancelled)
            {
                // The user canceled the operation.
                Message = "Operation was canceled";
            }
            else if (e.Error != null)
            {
                // There was an error during the operation.
                Message = String.Format("An error occurred: {0}", e.Error.Message);
            }
 
            RemoteServersShowGuiPostTask(Message);
            EnableProcessingContorls(true);
        }

        private void bwTransfer_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            bwTransfer.CancelAsync();
        }
    }
}