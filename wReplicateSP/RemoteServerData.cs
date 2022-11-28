using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wreplicaesp;

namespace wReplicateSP
{
    public class RemoteServerData
    {
        public RemoteServerControls rsc;
        private DB dB;
        public BackgroundWorker worker;

        public RemoteServerData(Data con, RemoteServerControls rsc)
        {
            this.rsc = rsc;
            worker = new BackgroundWorker();
            dB = new(con.Server, con.User, con.Password, con.Database);
        }

        public RemoteServerControls GetServerControls()
        {
            return rsc;
        }

        public bool Error()
        {
            return dB.error;
        }

        public void Connect()
        {
            if (rsc != null)
            {
                dB.OpenConnection();

            }
        }

        public string TransferAllDbObjects(BackgroundWorker bw, List<string> storedProcedureList, bool Overwrite, bool Create)
        {
            string errResult = string.Empty;
            foreach (string sp in storedProcedureList)
            {
                if (bw.CancellationPending) return "Operation cancelled.";
                errResult += TransferOneDbObject(sp);
            }
            return errResult;
        }

        public void ShowConnectionStatus()
        {
            if (dB.connectionOpen)
            {
                rsc.PutDBOk();
                rsc.PutStatusMsg("Ready");
            }
            else
            {
                rsc.PutDBError();
                rsc.PutStatusMsg("Connection error");
                rsc.SpinnerSetError();
            }
        }

        public void ShowGuiPreTask()
        {
            rsc.PutDBOk();
            rsc.PutStatusMsg("Sending data...");
            rsc.spinnerEnableSpinner();
        }

        public void ShowGuiPostTask(string errMsg)
        {
            /// Wait on parallel tasks
            if (errMsg.Length > 0 || dB.error) {
                rsc.PutDBError();
                if (!dB.error)
                {
                    rsc.PutStatusMsg(errMsg);
                }
                rsc.SpinnerSetError();
            }
            else {
                rsc.PutDBOk();
                rsc.PutStatusMsg("DB object sent OK");
                rsc.SpinnerSetSuccess();
            }
        }

        public string TransferOneDbObject(string query)
        {
            if (rsc != null)
            {
                if (dB.OpenConnection())
                {
                    return "Connection error";
                }
                else
                {
                    dB.RunQuery(query); 

                    if (dB.error)
                    {
                        return "Error sending data";
                    }
                    else
                    {
                        return "Error sending data";
                    }
                }
            }
            else {
                return "Error on config data";
            }
        }

   
    }
}
