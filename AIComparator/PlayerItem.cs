using System.Windows;
using System.Windows.Controls;

namespace AIComparator;

public class PlayerItem : ContentControl
{
    private readonly Player _player;
    public static readonly DependencyProperty XProperty = DependencyProperty.Register("X", typeof(int), typeof(PlayerItem));
    public static readonly DependencyProperty YProperty = DependencyProperty.Register("Y", typeof(int), typeof(PlayerItem));
    public static readonly DependencyProperty TeamProperty = DependencyProperty.Register("Team", typeof(int), typeof(PlayerItem));

    public int X
    {
        get => (int)GetValue(XProperty);
        set => SetValue(XProperty, value);
    }

    public int Y
    {
        get => (int)GetValue(YProperty);
        set => SetValue(YProperty, value);
    }

    public int Team
    {
        get => (int)GetValue(TeamProperty);
        set => SetValue(TeamProperty, value);
    }

    public PlayerItem(Player player)
    {
        _player = player;
        Refresh();
    }

    public void Refresh()
    {
        X = _player.X;
        Y = _player.Y;
        Team = _player.Team;
    }
}