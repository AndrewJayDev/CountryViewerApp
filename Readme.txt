OBJECTIVES: 

Task 0) Create a Repository and add git@vengaglobal.com as collaborator. **COMPLETED**

Task 1) Through the API make a call to the data
source(https://restcountries.eu/). To return the list of country names to the UI.  **COMPLETED**

Task 3) Cache the call to the data source(https://restcountries.eu/) so the call is **NOT COMPLETED*
not called on every request.

		Note: I am not as familiar with data-cacheing enough to implement this in this project in c# at this time. 
		Once the page is loaded there are no more calls to the API since all country information 
		would have already been loaded 

Task 4) Paginate the list of countries on the UI, displaying the country name
and the flag of the country using a .Net Core API endpoint.							**COMPLETED**

Task 5) Ability to click on a country and display extra information on the country   **COMPLETED**
i.e. population, time zones, currencies, language, capital city and bordering
countries using a .Net Core API endpoint.

Task 6) Call from UI to an endpoint with a Post request with a country and have    **NOT COMPLETED**
the backend Http API Post
to  https://enruolvzz04.x.pipedream.net/vengatest with it.

NOTE: I was unable to properly implement this. I have left the incomplete code so that we can talk about this during the interview. 


FINAL NOTE: There are a number of things I would like to improve in the future, such as performance, since the application has to load a lot of resources on page load for instance.
I also was unable to follow the traditonal mvc model since in the index and partial views I am manipulating and sorting data which should be done in the controller 
but due to time I was unable to implement these changes since I have just recently began to learn c#. Up until now I have worked mainly on javascript and front end web development projects.

