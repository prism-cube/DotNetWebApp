using System.ComponentModel.DataAnnotations;
using DotNetWebApp.Utils.Constants;

namespace DotNetWebApp.Utils.Filters;

public class IntAttribute : ValidationAttribute
{
    public IntAttribute()
    {
        ErrorMessage = "{0}は数値で入力してください";
    }

    public override bool IsValid(object? value)
    {
        if (value != null && int.TryParse(value.ToString(), out _))
        {
            return true;
        }
        return false;
    }
}
