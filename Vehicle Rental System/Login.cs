using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Rental_System
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        public Login()
        {
            Thread thread = new Thread(new ThreadStart(start_form));
            thread.Start();
            Thread.Sleep(8000);
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skin_manager = MaterialSkin.MaterialSkinManager.Instance;
            skin_manager.AddFormToManage(this);
            skin_manager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            thread.Abort();
        }

        public void start_form()
        {
            Application.Run(new SplashScreen());
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }



}
