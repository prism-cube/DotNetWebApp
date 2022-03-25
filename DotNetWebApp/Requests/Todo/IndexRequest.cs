using System.ComponentModel.DataAnnotations;

namespace DotNetWebApp.Requests.Todo;

public class IndexRequest : IValidatableObject
{
    [Required(ErrorMessage = "Nameは必須です")]
    public string? Name { get; set; }

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

