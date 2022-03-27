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
    [Meta]
    public int? Meta { get; set; }

    [DisplayName("すうじ")]
    [CustomRequired]
    [Int]
    [Range(0, 99)]
    public string? Number { get; set; }

    [Display(Name = "げんざいにちじ")]
    [CustomRequired]
    [Range(typeof(DateTime), "1997/07/17", "2022/12/31 23:59:59")]
    public DateTime? DateTimeNow { get; set; }

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

