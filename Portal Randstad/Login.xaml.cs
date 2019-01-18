using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Portal_Randstad.BDA_DS;

namespace Portal_Randstad
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl,ISwitchable
    {
        public Login()
        {
            InitializeComponent();
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            BDA_DSTableAdapters.dadospessTableAdapter da = new BDA_DSTableAdapters.dadospessTableAdapter();
            DataTable log = da.GetUserLogin();
            if(log.Select("NIF='"+ usertxt.Text +"' AND PassPortal='"+ passtxt.Password+"' AND FKFuncao in (49)").Count() > 0 )
            {
                Session.IsLogged = true;
                Switcher.Switch(new MainMenu());
            }
            else
            {
                MessageBox.Show("Utilizador ou password incorrectos!");
            }
        }
    }
}
