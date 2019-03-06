using eStudentRestaurant_UI.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eStudentRestaurant_UI.Main
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }
        
        private void LogutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }
       
    }
}
