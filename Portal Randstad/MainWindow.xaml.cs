using System;
using System.Collections.Generic;
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

namespace Portal_Randstad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //Portal_Randstad.BDA_DS bDA_DS = ((Portal_Randstad.BDA_DS)(this.FindResource("bDA_DS")));
            //// Load data into the table Ambito_VOC. You can modify this code as needed.
            //Portal_Randstad.BDA_DSTableAdapters.Ambito_VOCTableAdapter bDA_DSAmbito_VOCTableAdapter = new Portal_Randstad.BDA_DSTableAdapters.Ambito_VOCTableAdapter();
            //bDA_DSAmbito_VOCTableAdapter.Fill(bDA_DS.Ambito_VOC);
            //System.Windows.Data.CollectionViewSource ambito_VOCViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("ambito_VOCViewSource")));
            //ambito_VOCViewSource.View.MoveCurrentToFirst();
            //// Load data into the table apps. You can modify this code as needed.
            //Portal_Randstad.BDA_DSTableAdapters.appsTableAdapter bDA_DSappsTableAdapter = new Portal_Randstad.BDA_DSTableAdapters.appsTableAdapter();
            //bDA_DSappsTableAdapter.Fill(bDA_DS.apps);
            //System.Windows.Data.CollectionViewSource appsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("appsViewSource")));
            //appsViewSource.View.MoveCurrentToFirst();
            //// Load data into the table dadospess. You can modify this code as needed.
            //Portal_Randstad.BDA_DSTableAdapters.dadospessTableAdapter bDA_DSdadospessTableAdapter = new Portal_Randstad.BDA_DSTableAdapters.dadospessTableAdapter();
            //bDA_DSdadospessTableAdapter.Fill(bDA_DS.dadospess);
            //System.Windows.Data.CollectionViewSource dadospessViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("dadospessViewSource")));
            //dadospessViewSource.View.MoveCurrentToFirst();
            //// Load data into the table Concelho. You can modify this code as needed.
            //Portal_Randstad.BDA_DSTableAdapters.ConcelhoTableAdapter bDA_DSConcelhoTableAdapter = new Portal_Randstad.BDA_DSTableAdapters.ConcelhoTableAdapter();
            //bDA_DSConcelhoTableAdapter.Fill(bDA_DS.Concelho);
            //System.Windows.Data.CollectionViewSource concelhoViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("concelhoViewSource")));
            //concelhoViewSource.View.MoveCurrentToFirst();
        }
    }
}
