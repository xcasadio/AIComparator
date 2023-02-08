using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AIComparator;

public static class GameViewModel
{
    public static ObservableCollection<PlayerItem>? PlayerItems { get; private set; }

    public static void CreateAllPlayerItem(IList<Player> players)
    {
        PlayerItems = new ObservableCollection<PlayerItem>(GameManager.Players.Select(x => new PlayerItem(x)));
    }
}