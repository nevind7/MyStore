TSS Coding Assignment


Please have each qualified candidate provide source code with the following application structure.

Candidate can take as long as they need to produce a product for this assessment.  It doesn’t have to be an overly elaborate solution and can be a partial solution.  They can use their own resources and any available tools they like. Assessment will be used to determine and evaluate programing style, form and understanding of concepts.  

They can provide the finished source via GitHub as most developers will post source to GitHub these days.  (or a similar code share/repository service GitLab, BitBucket, LaunchPad, Google Cloud Source Repositories, AWS CodeCommit, etc.).


Using Visual Studio, C#, and front-end technologies (such as bootstrap, jquery, css, html, etc.), create an MVC web app with the following suggested features:
•	Data is provided via a backing database
•	Display a listing of products
•	Allow the user to Create, Edit, or Delete a product (control access to this if you wish)
•	Allow the user to select any product in the list and display details for the product
•	Allow the user to add any product to a cart / wish list
•	Allow the user to view the contents of the cart / wish list
•	Allow the user to run a few different reports to the screen against the products, for example:
o	Products grouped by Type, with subtotals/totals on value
o	Products that were created in the last 5 days
o	Products that were deleted in the last 10 days


Notes: 

1) I implemented a partial solution for this code assessment - specifically the API
	(or the MC in MVC). Swagger is implemented to easily query the data.
	I do have front-end experience, however I by no means would consider myself
	an expert in UX/UI. I am decently experienced with bootstrap and CSS.

	If you are looking for an expert front-end developer, It is unlikely that I am the correct
	person for this position. Looking over your requirements, I am fairly strong in:

	- .NET and C#
	- MVC architecture
	- Entity Framework
	- Experience with webservices/API
	- Databases/SQL
	- Microsoft .NET 4.x, Visual Studio 2019
	
	I will let you decide if I may be an ideal candidate for this position. 
	I would also love to talk more in detail about my experience as well
	as other areas that aren't listed.



2) Here are some items that I did not implement,
   and instead offers some solutions of how I would
   likely go about it:

[
•	Allow the user to add any product to a cart / wish list
•	Allow the user to view the contents of the cart / wish list]

1. Add new Cart table that includes property of a list of products
2. Implement desired functionality similar, similar to how products is done
]

[
o	Products that were created in the last 5 days
o	Products that were deleted in the last 10 days

1. Have a DateCreated and DateDeleted properties on model. 
2. Make sure change deletion of products in OnModelCreating
	to DeleteBehavior.NoAction/DeleteBehavior.SetNull

Query: .Where(i => (DateTime.Today - i.DateDeleted || DateCreated).TotalDays <= 5 || 10)..
]
