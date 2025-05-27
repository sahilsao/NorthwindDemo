using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

public class CookieService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CookieService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    // Method to set a cookie with an expiry time
    public void SetCookie(string key, string value, int expireTimeInMinutes = 10)
    {
        var options = new CookieOptions
        {
            Expires = DateTime.Now.AddMinutes(expireTimeInMinutes),  // Set expiration
            HttpOnly = true,  // Ensure security: can't be accessed by JS
            SameSite = SameSiteMode.Strict  // Prevent cross-site attacks
        };

        _httpContextAccessor.HttpContext?.Response.Cookies.Append(key, value, options);
    }

    // Method to get the cookie value
    public string GetCookie(string key) 
    {
        return _httpContextAccessor.HttpContext?.Request.Cookies[key]!;
    }

    // Method to delete a cookie
    public void DeleteCookie(string key)
    {
        _httpContextAccessor.HttpContext?.Response.Cookies.Delete(key);
    }
}
