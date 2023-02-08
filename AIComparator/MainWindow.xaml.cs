using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using AIComparator.GamePlay;

namespace AIComparator
{
    public partial class MainWindow : Window
    {
        private volatile bool _isClosed = false;
        private Task? _taskGameLoop;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnActivated(object? sender, EventArgs e)
        {
            _taskGameLoop = Task.Factory.StartNew(GameLoop);
        }

        private void MainWindow_OnClosing(object? sender, CancelEventArgs e)
        {
            _isClosed = true;
            if (_taskGameLoop != null)
            {
                Task.WaitAll(_taskGameLoop);
            }
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            GameManager.Initialize();
            GameManager.StrategyTeam1 = new BasicStrategy(GameManager.Team1, GameManager.Team2);
            GameViewModel.CreateAllPlayerItem(GameManager.Players);
            GameArea.ItemsSource = GameViewModel.PlayerItems;
        }

        private void GameLoop()
        {
            var timer = new Stopwatch();
            timer.Start();

            while (!_isClosed)
            {
                GameManager.Update(timer.ElapsedMilliseconds / 1000.0f);
                timer.Restart();

                Application.Current.Dispatcher.InvokeAsync(() =>
                {
                    GameViewModel.PlayerItems?.All(x =>
                    {
                        x.Refresh();
                        return true;
                    });
                }, DispatcherPriority.Render);

                Thread.Sleep(33); //33 = 30fps, 16 = 60fps
            }
        }
    }
}
