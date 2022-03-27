using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DotNetWebApp.Utils.Filters;

namespace DotNetWebApp.Requests.Todo;

public class DetailRequest
{
    [Display(Name = "DetailParam")]
    public string? DetailParam { get; set; }
}

