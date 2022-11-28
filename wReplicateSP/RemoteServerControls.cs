namespace wReplicateSP
{
    public class RemoteServerControls
    {
        public PictureBox? pbRemoteServerDB;
        public Label? lRemoteServerStatus;
        public PictureBox? pbRemoteServerSpinner;
        public Button? bRemoteServerCancel;
        public CheckBox? cbTransfer;

        public RemoteServerControls()
        {
            CreateControls();
        }

        public void SetSelectForTransfer(bool value)
        {
            if (cbTransfer != null) {
                cbTransfer.Checked = !value;
            }
            return;
        }

        public bool GetSelectForTransfer()
        {
            if (cbTransfer != null)
            {
                return cbTransfer.Checked;
            }
            return false;
        }

        public void PutDBError()
        {
            PutDB("error");
            return;
        }

        public void PutDBDisabled()
        {
            PutDB("disabled");
            return;
        }

        public void PutDBNormal()
        {
            PutDB("normal");
            return;
        }

        public void PutDBOk()
        {
            PutDB("ok");
            return;
        }

        public void PutDBBlack()
        {
            PutDB("black");
            return;
        }

        public void PutDB(string state) 
        {
            Image? img = null;

            switch (state) {
                case "disabled":
                    img = Properties.Resources.db_disabled;
                    break;
                case "error":
                    img = Properties.Resources.db_error;
                    break;
                case "normal":
                    img = Properties.Resources.db;
                    break;
                case "ok":
                    img = Properties.Resources.db_ok;
                    break;
            }
            if (img != null && pbRemoteServerDB != null) {
                pbRemoteServerDB.Image = img;
            }
        }

        public void PutStatusMsg(string msg) 
        {
            if (lRemoteServerStatus != null)
            {
                lRemoteServerStatus.Text = msg;
            }
        }

        public void SpinnerEnable()
        {
            SpinnerSetState(false);
        }

        public void SpinnerDisable()
        {
            SpinnerSetState(true);
        }

        private void SpinnerSetState(bool state)
        {
            if (pbRemoteServerSpinner != null)
            {
                pbRemoteServerSpinner.Enabled = state;
            }
        }

        public void SpinnerSetSuccess()
        {
            SpinnerSetImage("success");
            pbRemoteServerSpinner.Enabled = true;
            pbRemoteServerSpinner.Visible = true;
        }

        public void SpinnerSetError()
        {
            SpinnerSetImage("error");
            pbRemoteServerSpinner.Enabled = true;
            pbRemoteServerSpinner.Visible = true;
        }
        
        public void SpinnerSetSpinner()
        {
            SpinnerSetImage("spinner");
        }

        public void spinnerEnableSpinner()
        {
            SpinnerSetSpinner();
            pbRemoteServerSpinner.Enabled = true;
            pbRemoteServerSpinner.Visible = true;
        }

        public void spinnerDisableSpinner()
        {
            SpinnerSetSpinner();
            pbRemoteServerSpinner.Enabled = false;
            pbRemoteServerSpinner.Visible = false;
        }

        private void SpinnerSetImage(string image)
        {
            Image img = image switch
            {
                "success" => Properties.Resources.success,
                "error" => Properties.Resources.error,
                "spinner" => Properties.Resources.Spinner,
                _ => Properties.Resources.Spinner,
            };
            if (img != null && pbRemoteServerSpinner != null)
            {
                pbRemoteServerSpinner.Image = img;
            }
        }

        public void CreateControls() {
            // Create controls
            cbTransfer = new()
            {
                Dock = DockStyle.Left,
                Location = new Point(6, 40),
                Size = new Size(15, 14),
                Name = "cbTransfer",
                TabIndex = 0,
                Checked = true,
                TabStop = true,
                UseVisualStyleBackColor = true
            };
            
            pbRemoteServerDB = new()
            {
                Anchor = (AnchorStyles.Top | AnchorStyles.Left),
                Location = new Point(20, 0),
                Size = new Size(64, 64),
                Name = "pbDb",
                Image = Properties.Resources.db,
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabIndex = 1,
                TabStop = false
            };
            lRemoteServerStatus = new()
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point),
                Name = "lStatus",
                Size = new Size(260, 26),
                Location = new Point(85, 21),
                AutoSize = false,
                TabIndex = 2,
                Text = "Standing by..."
            };
            pbRemoteServerSpinner = new()
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Image = Properties.Resources.Spinner,
                Location = new Point(348, 0),
                Name = "pbSpinner",
                Size = new Size(64, 64),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Margin = new Padding(2),
                TabIndex = 3,
                TabStop = false,
                Enabled = false,
                Visible = false
            };
            bRemoteServerCancel = new()
            {
                Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right),
                //Font = new System.Drawing.Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point),
                Image = Properties.Resources.stop,
                Location = new Point(415, -4),
                Name = "bCancel",
                Size = new Size(72, 72),
                TabIndex = 4,
                //TextAlign = ContentAlignment.BottomCenter,
                TextImageRelation = TextImageRelation.Overlay,
                Enabled = false,
            };
            return;
        }
    }
}
