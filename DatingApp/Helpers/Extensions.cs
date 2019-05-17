using Microsoft.AspNetCore.Http;
using System;

namespace DatingApp.Helpers
{
    public static class Extensions
    {
        public static void AddApplictationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Errror",message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin","*");

        }
        public static int CalculateAge(this DateTime thedatetime)
        {
            var age = DateTime.Today.Year - thedatetime.Year;
            if (thedatetime.AddYears(age) > DateTime.Today)
            {
                age--;
            }
            return age;
        }
    }
}