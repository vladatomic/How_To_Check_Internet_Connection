using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
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

namespace How_to_check_internet_connection
{
    /// Potrebno je kao prvo uključiti namespace System.Runtime i System.Runtime.InteropSevices
    /// 
    /// Preko [DllImport("wininet.dll")]  
    /// private static extern bool InternetGetConnectedState(out int description,int reservedValue);
    /// 
    /// definišemo koja će metoda iz wininet.dll biti pozvana 
    /// metoda mora biti static kao i to da sa extern označavamo da metoda dolazi iz spolja a ne iz naše app
    /// 
    /// -------------------------------------------------------------------------------------------------------
    /// Definicija za extern modifier:
    /// The extern modifier is used to declare a method that is implemented externally. 
    /// A common use of the extern modifier is with the DllImport attribute when you are using Interop services 
    /// to call into unmanaged code.
    /// 
    ///       private static extern metodaDllModulaKojaNasZanima
    /// -------------------------------------------------------------------------------------------------------
    /// 
    /// wininet.dll je modul koji sadrži funkcije vezane za Internet  a njih koriste Windows applikacije. 
    /// Spisak finkcija se može naći na 
    /// https://source.winehq.org/WineAPI/wininet.html



    public partial class MainWindow : Window
    {
        [DllImport("wininet.dll")]
        private static extern bool InternetGetConnectedState(out int description, int reservedValue);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCheckInternet_Click(object sender, RoutedEventArgs e)
        {
            int desc;
            var result = InternetGetConnectedState(out desc, 0);
            if (result)
            {
                lblDisplayStatusOfInternet.Content = "Connected to internet";
            }
            else
            {
                lblDisplayStatusOfInternet.Content = "No connection to internet";
            }


        }
    }
}
