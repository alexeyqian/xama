using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Office.Utility;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Office.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectListView : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ProjectListView()
        {
            InitializeComponent();

            this.BindingContext = ViewModelLocator.ProjectListViewModel;
        }
    }
}
