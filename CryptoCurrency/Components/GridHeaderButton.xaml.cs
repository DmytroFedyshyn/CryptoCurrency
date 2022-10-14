using Kasay;
using System.ComponentModel;
using System.Windows.Input;
using Component = CryptoCurrencyWPF.Primitives.Component;

namespace CryptoCurrencyWPF.Components;

public partial class GridHeaderButton : Component
{
    [Bind] public ICommand Command { get; set; }
    [Bind] public string Column { get; set; }
    [Bind] public string SortedBy { get; set; }
    [Bind] public ListSortDirection SortDirection { get; set; }
    [Bind] public bool DarkMode { get; set; }

    public GridHeaderButton()
    {
        InitializeComponent();
    }
}
