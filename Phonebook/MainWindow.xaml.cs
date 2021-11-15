using Phonebook.Providers;
using Phonebook.Services;
using Phonebook.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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

namespace Phonebook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly AboutViewModel _aboutViewModel;
        private readonly ContactsViewModel _contactsViewModel;

        public MainWindow()
        {

            _aboutViewModel = new AboutViewModel();
            _contactsViewModel = new ContactsViewModel(new RepositoryService(new List<IDataProvider>() { new PersonProvider(), new CompanyProvider() }));

            InitializeComponent();
        }

        public void About_Click(Object sender, RoutedEventArgs e)
        {
            DataContext = _aboutViewModel;
        }

        public void Contacts_Click(Object sender, RoutedEventArgs e)
        {
            DataContext = _contactsViewModel;
        }
    }
}
