using System.ComponentModel.DataAnnotations;

namespace DotNetWebApp.Utils.Filters;

public class CustomRequiredAttribute : RequiredAttribute
{
    public CustomRequiredAttribute()
    {
        ErrorMessage = "{0}は必須です";
    }
}

