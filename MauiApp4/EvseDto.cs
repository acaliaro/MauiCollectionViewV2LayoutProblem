using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp4
{
    public partial class EvseDto : ObservableObject
    {
        [ObservableProperty] string _name;
        [ObservableProperty] bool _hasData;
    }
}
