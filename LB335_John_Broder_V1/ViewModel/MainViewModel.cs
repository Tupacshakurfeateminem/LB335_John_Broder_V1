﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LB335_John_Broder_V1.ViewModel;

public partial class MainViewModel : ObservableObject
{


    public MainViewModel()
    {
        Items = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string text;

    [RelayCommand]
    void Add()
    {
        if (string.IsNullOrWhiteSpace(Text))
             return;
        Items.Add(Text);

        Text = string.Empty;
    }
    [RelayCommand]

    void Delete(string s )
    {
        if(items.Contains(s))
        {
            Items.Remove(s);
        }
    }
     
}