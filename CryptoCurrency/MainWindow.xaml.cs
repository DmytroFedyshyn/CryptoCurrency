namespace CryptoCurrencyWPF;

using CryptoCurrencyWPF.Primitives;
using CryptoCurrencyWPF.Views;
using System.Globalization;
using System.Threading;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

        InitializeComponent();

        Title = "CryptoCurrencyWPF - Homepage";
    }
}