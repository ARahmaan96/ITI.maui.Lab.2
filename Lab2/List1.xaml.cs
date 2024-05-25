using Microsoft.Maui.Animations;
using System.Collections.ObjectModel;

namespace Lab2;

public partial class List1 : ContentPage
{
    private List<String> names = [
        "Ahmed",
        "Mohmed",
        "Samy",
        "Nada",
        "Hoda",
        "Soha",
        "Shimaa",
        "A.Rrhman",
        "Rana",
        "Aya"
        ];
    public ObservableCollection<UserContact> ContactList { get; set; }

    public int Counter
    {
        get { return count; }
        set
        {
            count = value;
            OnPropertyChanged();
        }
    }
    int count = 0;

    public List1()
    {
        InitializeComponent();
        ContactList = new ObservableCollection<UserContact>()
            {
                new UserContact(){Name="A.Rahman",PhoneNum="01255647153",Status=Status.OffLine,Image="https://source.unsplash.com/random/background?id=4"},
                new UserContact(){Name="Emman",PhoneNum="01022453651",Status=Status.OffLine,Image="https://source.unsplash.com/random/background?id=1"} ,
                new UserContact(){Name="Nada",PhoneNum="01255413654",Status=Status.OffLine,Image="https://source.unsplash.com/random/background?id=2"} ,
                new UserContact(){Name="Rana",PhoneNum="01166457845",Status=Status.Online,Image="https://source.unsplash.com/random/background?id=3"} ,
                new UserContact(){Name="Mosada",PhoneNum="01566412358",Status=Status.OffLine,Image="https://source.unsplash.com/random/background?id=4"}
            };

        lst.ItemsSource = ContactList;
        BindingContext = this;
    }

    private void lst_Refreshing(object sender, EventArgs e)
    {
        Status status = (new Random()).Next(10) % 2 == 0 ? Status.Online : Status.OffLine;

        string name = names[(new Random()).Next(9)];

        ContactList.Add(new UserContact() { Name = name, PhoneNum = "01288387875", Status = status, Image = $"https://source.unsplash.com/random/background?id={DateTime.Now}" });

        lst.IsRefreshing = false;

    }

}

