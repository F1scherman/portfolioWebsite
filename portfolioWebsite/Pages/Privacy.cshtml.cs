using System.Globalization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace portfolioWebsite.Pages;

public class PrivacyModel : PageModel {
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger) {
        _logger = logger;
    }

    public void OnGet() {
        string datetime = DateTime.Now.ToString("d", new CultureInfo("en-US"));
        ViewData["Timestamp"] = datetime;
    }
}