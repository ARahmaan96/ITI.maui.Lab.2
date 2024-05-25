using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Lab2;

public partial class List2 : ContentPage
{
    public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>
    {
        "Ahmed Samy",
        "Mohamed Ali",
        "Mostafa Mahmoud",
        "Omar Youssef",
        "Youssef Ibrahim",
        "Ali Khaled",
        "Ibrahim Hassan",
        "Khaled Mohamed",
        "Hassan Mostafa",
        "Mahmoud Omar",
        "Amr Youssef",
        "Hussein Ali",
        "Mustafa Ibrahim",
        "Tarek Khaled",
        "Samir Hassan",
        "Nader Mohamed",
        "Farid Mostafa",
        "Gamal Omar",
        "Hany Youssef",
        "Wael Ali"
    };

    public List2()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {

    }

    private void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
    {
        string? searchText = ((SearchBar)sender).Text;
        Trace.WriteLine(searchText);
        if (searchText == null) return;
        itemList.ItemsSource = Items.Where(x => x.ToLower().Contains(searchText.ToLower())).ToList();
    }
}