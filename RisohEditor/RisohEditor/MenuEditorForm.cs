using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisohEditor
{
    public partial class MenuEditorForm : Form
    {
        private ResourceEntry m_entry;

        public MenuEditorForm(ResourceEntry entry)
        {
            m_entry = entry;
            InitializeComponent();
        }


        public byte[] GetResourceData()
        {
            return m_entry.Data;
        }
    }
}
