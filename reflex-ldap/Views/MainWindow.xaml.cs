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
using System.Windows.Shapes;
using reflex_ldap.Models;

namespace reflex_ldap.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        { 
            List<LDAPPacket> _list = new List<LDAPPacket>();
            
            _list.Add(new LDAPPacket(Name));
            
            InitializeComponent();
        }
    }
}
