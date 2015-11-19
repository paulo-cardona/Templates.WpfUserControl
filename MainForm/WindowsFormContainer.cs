using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace MainForm
{
    public partial class WindowsFormContainer : Form
    {
        public readonly ElementHost _elementHost;
        private Views.MainWindow _mainView;

        public WindowsFormContainer()
        {
            InitializeComponent();

            _mainView = new Views.MainWindow(); //Create Instance of WPF View
            _elementHost = new ElementHost();   //Create ElementHost (System.Windows.Forms.Integration)
            _elementHost.Child = _mainView;     //Set our WPF View as elementhost.child.
            this.Controls.Add(_elementHost);    //Add elementhost to form controls collection.
            FormatWindow();                     //I haven't found a better way to do this yet.
        }

        public void FormatWindow()
        {
            //Set all Container window properties here (ie. Size/Title)
            //_elementHost.Width = xxx;
            //_elementHost.Height = xxx;
            //Width = _elementHost.Width + 20;
            //Height = _elementHost.Height + 40;
        }
    }
}
