using Microsoft.AspNetCore.Mvc;
using System.IO;

public class HomeController : Controller
{
    // Index action
    public IActionResult Index()
    {
        return View();
    }

    // About action
    public IActionResult About()
    {
        return View();
    }

    // Projects action
    public IActionResult Projects()
    {
        return View();
    }

    // Contact action
    public IActionResult Contact()
    {
        return View();
    }

    // Resume download action
    public IActionResult DownloadResume()
    {
        // Define the path to your resume
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Resumes", "Bhavishya Reddy .Net Developer.pdf");

        // Check if the file exists
        if (!System.IO.File.Exists(filePath))
        {
            return NotFound("File not found!"); // Return 404 if file is not found
        }

        // Specify the MIME type for a PDF file
        var mimeType = "application/pdf";

        // Return the file for download
        return PhysicalFile(filePath, mimeType, "Bhavishya_Reddy_Resume.pdf");
    }
}
