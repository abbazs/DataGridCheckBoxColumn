using System.Collections.Generic;
using System.Windows;

namespace DataGridColIssue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int CurrentOperation;
        public List<Operation> Operations;
        public MainWindow()
        {
            InitializeComponent();
            Operations = new List<Operation>();
            CurrentOperation = 0;
        }

        private void AddItems_Click(object sender, RoutedEventArgs e)
        {
            CurrentOperation++;
            Operations.Add(new Operation(CurrentOperation));
            DataGridTesting.Items.Refresh();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           DataGridTesting.ItemsSource = Operations;
           DataGridTesting.Items.Refresh();
        }
    }
}
