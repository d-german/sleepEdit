using System;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using ProtocolUi;

namespace WFHost
{
    public partial class ProtocolWFHost : Form
    {
        private ElementHost _ctrlHost;
        private ProtocolWPF _protocolWPFCtrl;

        public ProtocolWFHost()
        {
            InitializeComponent();
        }

        private void ProtocolWFHost_Load(object sender, EventArgs e)
        {
            _ctrlHost = new ElementHost {Dock = DockStyle.Fill};
            _protocolWPFCtrl = new ProtocolWPF();
            _protocolWPFCtrl.InitializeComponent();
            _ctrlHost.Child = _protocolWPFCtrl;
            ui_WPFHostPanel.Controls.Add(_ctrlHost);
        }
    }
}