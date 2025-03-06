using System.Windows.Forms;

namespace ControllerScouting.Screens
{
    public partial class QRCodeForm : Form
    {
        public QRCodeForm()
        {
            InitializeComponent();

            qrCodeBox.Image = DatabaseCode.GenerateQRCode();
        }
    }
}
