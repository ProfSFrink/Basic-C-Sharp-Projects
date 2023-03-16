// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// FINAL PROJECT: Final Challenge
// AUTHOR: Steven Partlow
// DATE: 16/03/2023

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalChallenge.Pages
{

    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet() // This method runs when Index.cshtml is loaded
        {
            string dateTime = Convert.ToString(DateTime.Now); // Define a string variable and cast the current date and time to it as a value
            ViewData["TimeStamp"] = dateTime; // Assign the value of dateTime to the ViewData variable TimeStamp
        } // End OnGet Method

    } // End IndexModel CLASS

} // End FinalChallenge.Pages NAMESPACE