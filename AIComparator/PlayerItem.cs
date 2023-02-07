using System.Windows;
using System.Windows.Controls;

namespace AIComparator;

public class PlayerItem : ContentControl
{
    public static readonly DependencyProperty XProperty = DependencyProperty.Register("X", typeof(int), typeof(PlayerItem));
    public static readonly DependencyProperty YProperty = DependencyProperty.Register("Y", typeof(int), typeof(PlayerItem));

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

    public PlayerItem()
    {
        Height = 30;
        Width = 30;
    }
}