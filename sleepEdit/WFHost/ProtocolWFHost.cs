using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using ProtocolUi;

namespace WFHost
{
    public partial class ProtocolWFHost : Form
    {
        public ProtocolWFHost()
        {
            InitializeComponent();
        }
        private ElementHost _ctrlHost;
        private ProtocolWPF _protocolWPFCtrl;
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
