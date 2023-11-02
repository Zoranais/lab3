using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab3;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly string[] ports;
    public MainWindow()
    {
        ports = new string[]
        {
            "Port of Los Angeles",
            "Port of Shenzhen",
            "Port of Singapore",
            "Port of Rotterdam",
            "Port of Ningbo-Zhoushan",
            "Port of Shanghai"
        };
        InitializeComponent();
    }

    private void Submit_Click(object sender, RoutedEventArgs e)
    {
        Output.Items.Clear();
        try 
        {
            var n = Convert.ToInt32(CountInput.Text);
            var transport = new List<Transport>();
            for (int i = 0; i < n; i++) 
            {
                transport.Add(new Plane(Random.Shared.Next(1, 10), 
                    Random.Shared.Next(1, 10)));
                transport.Add(new Ship(Random.Shared.Next(1, 10),
                    ports[Random.Shared.Next(0, ports.Length)]));
            }

            foreach (var item in transport)
            {
                Output.Items.Add(item.Show());
            }

            AvgOutput.Content = transport.Any() ? transport.Average(x => x.GetPrice()) : 0;
        }
        catch 
        {
            MessageBox.Show("Invalid input");
        }
    }
}
