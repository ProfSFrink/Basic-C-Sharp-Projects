// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// FINAL PROJECT: Final Challenge
// AUTHOR: Steven Partlow
// DATE: 16/03/2023

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalChallenge.Pages
{

    public class PrivacyModel : PageModel
    {

        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string dateTime = DateTime.Now.ToShortDateString();
            ViewData["TimeStamp"] = dateTime;
        } // End OnGET Method

    } // End CLASS

} // End FinalChallenge.Pages NAMESPACE