using System.ComponentModel.DataAnnotations;
using DotNetWebApp.Utils.Constants;

namespace DotNetWebApp.Utils.Filters;

public class MetaValidationAttribute : ValidationAttribute
{
    public bool IsMultiple { get; set; }

    public MetaValidationAttribute()
    {
        IsMultiple = false;
        ErrorMessage = "{0}は不正な値です";
    }

    public override bool IsValid(object? value)
    {
        if (value != null && int.TryParse(value.ToString(), out int v))
        {
            return Meta.ContainsKey(v);
        }
        return false;
    }
}
