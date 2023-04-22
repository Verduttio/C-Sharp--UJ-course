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

namespace Zadanie2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var kghm = new CompanyInfoGrid("KGHM", 100.0, 0, Company1Rate, Company1Change, Company1Color);
            Company1Name.Content = kghm.Name;

            var pkoBp = new CompanyInfoGrid("PKO BP", 150.0, 0, Company2Rate, Company2Change, Company2Color);
            Company2Name.Content = pkoBp.Name;

            var lotos = new CompanyInfoSpan("LOTOS", 80.0, 0, Company3Rate, Company3Change, Company3Color);
            Company3Name.Content = lotos.Name;

            var orlen = new CompanyInfoSpan("ORLEN", 200.0, 0, Company4Rate, Company4Change, Company4Color);
            Company4Name.Content = orlen.Name;
        }
    }
}
