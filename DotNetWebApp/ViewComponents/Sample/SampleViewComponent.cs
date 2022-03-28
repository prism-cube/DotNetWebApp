using System;
using Microsoft.AspNetCore.Mvc;

namespace DotNetWebApp.ViewComponents.Sample;

public class SampleViewComponent: ViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(SampleViewComponentParam param)
	{
		var result = await GetTextAsync(param.Text);

		var resultModel = new SampleViewComponentModel()
		{
			Text = result,
        };
		return View(resultModel);
	}

	private async Task<string> GetTextAsync(string text)
    {
		await Task.Run(() =>
		{
			Thread.Sleep(100);
		});
		return text;
    }
}

public class SampleViewComponentParam
{
	public string Text { get; set; } = string.Empty;
}

public class SampleViewComponentModel
{
	public string? Text { get; set; }
}

