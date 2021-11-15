using Phonebook.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.ViewModels
{
    public class ContactsViewModel : INotifyPropertyChanged
    {
        public string SearchText { get; set; }
        public IEnumerable<string> Results { get; set; }
        private readonly RepositoryService _repositoryService;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ContactsViewModel(RepositoryService repositoryService)
        {
            _repositoryService = repositoryService;
            Results = new List<string>(){ "Hello", "how", "are", "you"};
            SearchText = "";
        }

        public void ExecuteList()
        {
            Results = _repositoryService.List().Select(x => x.ToString());
            PropertyChanged(this, new PropertyChangedEventArgs("Results"));
        }

        public void ExecuteSearch()
        {
            Results = _repositoryService.Search(SearchText).Select(x => x.ToString());
            PropertyChanged(this, new PropertyChangedEventArgs("Results"));
            SearchText = "";
            PropertyChanged(this, new PropertyChangedEventArgs("SearchText"));
        }
    }
}
