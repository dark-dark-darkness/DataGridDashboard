using System;
using System.Collections.ObjectModel;

using DataGridDashboard.Models;

namespace DataGridDashboard.ViewModels;

public class MainViewModel : BaseViewModel
{
    public string Greeting => "Welcome to Avalonia!";

    public ObservableCollection<Member> Members { get; set; } =
    [

            new Member { Number = "1", Character = "J", Color = "#1098AD", Name = "John Doe", Position = "Coach", Email = "john.doe@gmail.com", Phone = "415-954-1475" },
            new Member { Number = "2", Character = "R", Color = "#1E88E5", Name = "Reza Alavi", Position = "Administrator", Email = "reza110@hotmail.com", Phone = "254-451-7893" },
            new Member { Number = "3", Character = "D", Color = "#FF8F00", Name = "Dennis Castillo", Position = "Coach", Email = "deny.cast@gmail.com", Phone = "125-520-0141" },
            new Member { Number = "4", Character = "G", Color = "#FF5252", Name = "Gabriel Cox", Position = "Coach", Email = "coxcox@gmail.com", Phone = "808-635-1221" },
            new Member { Number = "5", Character = "L", Color = "#0CA678", Name = "Lena Jones", Position = "Manager", Email = "lena.offi@hotmail.com", Phone = "320-658-9174" },
            new Member { Number = "6", Character = "B", Color = "#6741D9", Name = "Benjamin Caliword", Position = "Administrator", Email = "beni12@hotmail.com", Phone = "114-203-6258" },
            new Member { Number = "7", Character = "S", Color = "#FF6D00", Name = "Sophia Muris", Position = "Coach", Email = "sophi.muri@gmail.com", Phone = "852-233-6854" },
            new Member { Number = "8", Character = "A", Color = "#FF5252", Name = "Ali Pormand", Position = "Manager", Email = "alipor@yahoo.com", Phone = "968-378-4849" },
            new Member { Number = "9", Character = "F", Color = "#1E88E5", Name = "Frank Underwood", Position = "Manager", Email = "frank@yahoo.com", Phone = "301-584-6966" },
           new Member { Number = "10", Character = "S", Color = "#0CA678", Name = "Saeed Dasman", Position = "Coach", Email = "saeed.dasi@hotmail.com", Phone = "817-320-5052" },
        ];
}
