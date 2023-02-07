using System.Collections.ObjectModel;

namespace AIComparator;

public static class GameManager
{
    public static ObservableCollection<PlayerItem> Players { get; set; }

    static GameManager()
    {
        Players = new ObservableCollection<PlayerItem>
        {
            new PlayerItem { X = 100, Y = 100 },
            new PlayerItem { X = 200, Y = 200 }
        };
    }
}