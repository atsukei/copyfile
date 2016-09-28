using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace copyfile
{
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
            FormLoad();
        }
        private void FormLoad()
        {
            FileControl inputbox_data = new FileControl();

            input_box.Text = inputbox_data.SetDataPath();
        }
    }
}
