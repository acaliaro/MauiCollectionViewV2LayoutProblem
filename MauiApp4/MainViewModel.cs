using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp4
{
    public partial class MainViewModel : ObservableObject
    {

        [ObservableProperty] bool _isRefreshingEvseList;
        [ObservableProperty] ObservableCollection<EvseDto> _evseList;


        private async Task ReloadItems()
        {
            var tmpEvseList = new List<EvseDto>();
            for (int i = 0; i < 1; i++)
            {
                tmpEvseList.Add(new EvseDto() { Name = $"EVSE {i}", HasData = false });
            }

            EvseList = new ObservableCollection<EvseDto>(tmpEvseList);

            await Task.Delay(2000);

            for (int i = 0; i < 1; i++)
            {
                EvseList[i].HasData = true;
            }
        }

        [RelayCommand]
        public async Task Appare()
        {
            try
            {
                await ReloadItems();
            }
            catch(Exception ex)
            {
                // Handle exceptions
            }
        }

        [RelayCommand]
        public async Task RefreshEvseList()
        {
            try
            {
                await ReloadItems();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
            finally
            {
                IsRefreshingEvseList = false;
            }
        }
    }

}
