using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DotNetWebApp.ViewModels.Todo;

public class IndexViewModel
{
    [Display(Name = "名前")]
    public string? Name { get; set; }

    [Display(Name = "メタ")]
    public int? Meta { get; set; }

    [Display(Name = "数字")]
    public int? Number { get; set; }

    [Display(Name = "現在日時")]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
    public DateTime? DateTimeNow { get; set; }
}

