using System;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.LogicalTree;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;
using Avalonia.VisualTree;
using TreeDataGridDemo.Models;
using TreeDataGridDemo.ViewModels;

namespace TreeDataGridDemo
{
    public class MainWindow : Window
    {
        private readonly TabControl _tabs;

        public MainWindow()
        {
            InitializeComponent();
           
            DataContext = new MainWindowViewModel();

            Activated += MainWindow_Activated;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void MainWindow_Activated(object? sender, EventArgs e)
        {
           
        }

        private void SelectedPath_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                var vm = (MainWindowViewModel)DataContext!;
                vm.Files.SelectedPath = ((TextBox)sender!).Text;
            }
        }

     
    }
}
