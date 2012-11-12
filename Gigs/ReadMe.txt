Readme

- Most recently I've been working with C# and OData. I chose those technologies per instruction to choose language of choice.
- REST interface by default returns ATOM feed format.
- It could could return JSON format. Format GET request need to set header    
		accept: application/json;odata=verbose 
- Deployed the service on Azure
	1) http://gigs.azurewebsites.net/Gigs.svc/   <-- REST interface (support OData protocol)
	2) http://gigs.azurewebsites.net/TestConsole.html   <-- Issues select REST api calls and dumps data in IFrame.
	3) http://gigs.azurewebsites.net/Gigs.html   <-- HTML view over the data from REST interface.
	
- Service exposes three resources
     http://gigs.azurewebsites.net/Gigs.svc/
	 
	 <?xml version="1.0" encoding="utf-8"?>
		<service xml:base="http://gigs.azurewebsites.net/Gigs.svc/" xmlns="http://www.w3.org/2007/app" xmlns:atom="http://www.w3.org/2005/Atom">
		  <workspace>
			<atom:title>Default</atom:title>
			<collection href="Abouts">
			  <atom:title>Abouts</atom:title>     <-- http://gigs.azurewebsites.net/Gigs.svc/Abouts
			</collection>
			<collection href="Positions">
			  <atom:title>Positions</atom:title>  <-- http://gigs.azurewebsites.net/Gigs.svc/Positions
			</collection>
			<collection href="Trainings">
			  <atom:title>Trainings</atom:title>  <-- http://gigs.azurewebsites.net/Gigs.svc/Trainings
			</collection>
			<collection href="Notes">
			  <atom:title>Notes</atom:title>      <-- http://gigs.azurewebsites.net/Gigs.svc/Notes
			</collection>
			<collection href="Extras">
			  <atom:title>Extras</atom:title>     <-- http://gigs.azurewebsites.net/Gigs.svc/Extras
			</collection>
		  </workspace>
		</service>
- Object model
		About { FullName, LastName, Email, Phone, 
			Positions { Title, Employer, City, State, Country, From, To, 
				Notes { Blurb } }, 
			Trainings { Degree, Institution, City, State, Country, GraduationYear }, 
			Extras { Blurb } }

- Pretty html view: 
        http://gigs.azurewebsites.net/gigs.html
		Data is driven by javascript. I used an OData help javascript library from http://datajs.codeplex.com/releases/view/87114

- Test console 
		http://gigs.azurewebsites.net/testConsole.html
		Select test from the drop down and click "Go". Result will be shown in IFrame in the same page.