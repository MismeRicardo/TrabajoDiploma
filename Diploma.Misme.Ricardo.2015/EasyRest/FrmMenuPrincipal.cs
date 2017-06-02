using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
namespace EasyRest
{
    public partial class FrmMenuPrincipal : MetroForm
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }


        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmMenuPrincipal_Load_1(object sender, EventArgs e)
        {
            lblNomUsu.BackColor = Color.SteelBlue;
            lblHora.BackColor = Color.SteelBlue;
           
           
        }

      

       
    
     
    }
}
