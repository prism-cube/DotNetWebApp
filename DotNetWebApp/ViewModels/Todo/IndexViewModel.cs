using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DotNetWebApp.ViewModels.Todo;

public class IndexViewModel
{
    [Display(Name = "なまえ")]
    public string? Name { get; set; }

    [Display(Name = "めた")]
    public int? Meta { get; set; }

    [Display(Name = "すうじ")]
    public int? Number { get; set; }
}

