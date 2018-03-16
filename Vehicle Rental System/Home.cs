using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Rental_System
{
    public partial class Home : MaterialSkin.Controls.MaterialForm
    {
        public Home()
        {
            MaterialSkin.MaterialSkinManager skin_manager = MaterialSkin.MaterialSkinManager.Instance;
            skin_manager.AddFormToManage(this);
            skin_manager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            //materialSkinManager.ColorScheme = new ColorScheme(
            //    Primary.Blue400, Primary.ggr
            //    Primary.Blue500, Accent.LightBlue200,
            //    TextShade.WHITE
            //);
            InitializeComponent();
        }
    }
}
