using Microsoft.AspNetCore.Mvc;
using MovieReviewPlatform.Models;

namespace MovieReviewPlatform.Controllers
{
    public class MovieReviewController : Controller
    {
        // GET REQUEST
        [HttpGet]
        public IActionResult AddReview()
        {
            return View();
        }

        // POST REQUEST
        [HttpPost]
        public IActionResult AddReview(Movie movie)
        {
            if (ModelState.IsValid)
            {
                
                //if a valid review
                return RedirectToAction("ReviewSuccess");
            }

            //if invalid
            return View(movie);
        }

        // SUCCESS PAGE
        public IActionResult ReviewSuccess()
        {
            return View("ReviewSuccess");
        }
    }
}