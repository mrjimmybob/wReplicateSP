namespace wreplicaesp
{
    public partial class fMainForm : Form
    {
        public fMainForm()
        {
            InitializeComponent();
            cbObjectType.SelectedIndex  = 0;
        }

        
        private void cbObjectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lObjectTypeName.Text= cbObjectType.SelectedItem.ToString();
        }
        

 
    }
}