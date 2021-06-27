using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patch_Master.Forms
{
    public partial class TableColumnConnector : Form
    {
        string clickedElementName = "";
        public TableColumnConnector()
        {
            InitializeComponent();
        }

        public TableColumnConnector(string elementName)
        {
            InitializeComponent();
            string clickedElementName = elementName;
        }
    }
}
