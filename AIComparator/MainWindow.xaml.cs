using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AIComparator
{
    public partial class MainWindow : Window
    {
        private bool _isClosed = false;

        public MainWindow()
        {
            DataContext = GameManager.Players;
            InitializeComponent();
        }

        private void MainWindow_OnActivated(object? sender, EventArgs e)
        {
            var task = new Thread(GameLoop);
            task.Start();
        }

        private void GameLoop()
        {
            while (!_isClosed)
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    GameManager.Players[0].X += 1;
                });

                Thread.Sleep(33); //30fps
            }
        }

        private void MainWindow_OnClosing(object? sender, CancelEventArgs e)
        {
            _isClosed = true;
        }
    }
}
