using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DotNetWebApp.Utils.Filters;

namespace DotNetWebApp.Requests.Todo;

public class IndexRequest : IValidatableObject
{
    [Display(Name = "なまえ")]
    [Required(ErrorMessage = "{0}は必須です")]
    [StringLength(10)]
    public string? Name { get; set; }

    [DisplayName("めた")]
    [CustomRequired]
    [MetaValidation]
    public int? Meta { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (Name == "NG")
        {
            yield return new ValidationResult("NameにNGは指定できません", new[] { nameof(Name) });
        }

        if (Name == "ng")
        {
            yield return new ValidationResult("Nameにngは指定できません", new[] { nameof(Name) });
        }
    }
}

