using Odev_4.Classes;

namespace Odev_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string secilenLogTipi = cmbLog.SelectedItem.ToString();
            string durum = txtDurum.Text;

            ILog log = LoggerFactory.LoglamaYontemi(secilenLogTipi);
            string message = log.Log(durum);
            lblSonuc.Text = message;
        }
    }
}
