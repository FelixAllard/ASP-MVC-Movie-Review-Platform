Tasks:
1. Create the Movie Model:
   • Design a model class named Movie that includes the following properties:
   o Title (string): The title of the movie (required).
   o Director (string): The name of the movie's director (required).
   o ReleaseYear (int): The year the movie was released (required, between 1900 and
   the current year).
   o Rating (int): The movie's rating, which must be a number between 1 and 5
   (required).
   o Review (string): A brief user review of the movie (optional).
2. Create a MovieReviewController:
   • Create a controller named MovieReviewController that handles the following actions:
   o GET AddReview: Displays the form where users can enter movie details and
   submit their reviews.
   o POST AddReview: Handles the form submission, validates the input, and
   redirects users to a success page or back to the form in case of validation errors.
3. Design the AddReview.cshtml View:
   • Create a form in the AddReview.cshtml view to collect the movie details from users.
   The form should include:
   o A text box for the movie's title.
   o A text box for the movie's director.
   o A number input for the release year.
   o A number input for the rating (1-5 stars).
   o A textarea for the user to write a review.
   • Use ASP.NET Tag Helpers to bind the form fields to the Movie model properties.
   • Include server-side and client-side validation for the form fields using data annotations
   and validation scripts.
4. Implement Validation Logic:
   pg. 2
   • Ensure that the Title, Director, and ReleaseYear fields are required, and the Rating
   must be between 1 and 5.
   • Implement server-side validation using data annotations in the Movie model.
   • Enable client-side validation in the AddReview.cshtml view using jQuery validation
   and unobtrusive validation scripts.
5. Display a Success Page:
   • After a successful form submission, redirect the user to a simple success page
   (Success.cshtml) confirming that their review has been submitted.
   Guidelines for Submission:
   • Model: Properly implement the Movie class with data annotations for validation.
   • Controller: Implement both the GET and POST actions in the MovieReviewController to
   handle form display and submission.
   • Views: Create the AddReview.cshtml view for the form and the Success.cshtml view
   for the confirmation page.
   • Validation: Ensure both server-side and client-side validation work seamlessly.
   Deliverables:
   • A fully functional ASP.NET MVC web application that allows users to submit movie
   reviews.
   • The solution should demonstrate a clear understanding of the Model-View-Controller
   pattern and the implementation of validation in ASP.NET MVC.
   Bonus:
   • Add functionality to display a list of all submitted movie reviews on a separate page
   (AllReviews.cshtml), where users can view the reviews submitted by others