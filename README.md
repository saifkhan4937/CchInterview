# CchInterview
This is poc project in .net core and angular for a interview.

To run the application, make sure to first run the Web API application "CrawfordClaimsHandler.Api.CoreWebApi" in the back-end. Then, in the command line, run the following command:

ng serve

It’ll start your Angular application and watch for file changes. Access the address http://localhost:4200/ with your browser.


App starts with a login form, you may use this testing account: username = gemmela , pwd = Archie


If due to any reason you do any changes to scheme or port then you need to update the path in NG UI app in environment file like " baseUrl: 'https://localhost:44315/api'"


##### Note:- Web Api application has been configured to run on https://localhost:44315/ , If due to any reason you do any chnages to scheme or port then you need to update the baseUrl in NG UI app in environment file like "baseUrl: 'https://localhost:44315/api'"
