
using System.Collections.ObjectModel;

namespace ExoSiegeTradeCalc
{
    public partial class MainPage : ContentPage
    {
        public IEnumerable<ResourceType> ResourceTypes =>
            Enum.GetValues<ResourceType>();

        ObservableCollection<Trade> Trades = new ObservableCollection<Trade>();
        Trade currentTrade = new Trade();

        public MainPage()
        {
            InitializeComponent();
            SaveData.LoadAsync().ContinueWith(task =>
            {
                Trades = new ObservableCollection<Trade>(task.Result);
                Dispatcher.Dispatch(() =>
                {
                    //TradeListView.ItemsSource = Trades;
                });
            });
        }
    }
}
