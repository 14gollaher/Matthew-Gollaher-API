<h1>
Matthew Gollaher API
</h1>

My personal REST API. The application is a "Service Orientated Architecture" like application to serve data for numerous applications/purposes. 

<hr/>
<h3>WiiU Super Smash Bros 4 API</h3>
Data is for a friend's Android application idea. He wanted to be able to access the game's fighter data, and step-by-step moves of a given fighter and their frame data. The API calls an Azure SQL Server and Azure Blob Storage for data, and provides the data in a REST format to given urls. I am also in progress of implementing my own web applicaiton to consume this data, found here: https://github.com/14gollaher/Gollaher-Games

<br/>
<br/>

<ul>
  <li>
  GET - ALL fighters (slow) : http://matthewgollaher.azurewebsites.net/WiiUSmash4/fighter/
  </li>
  <li>
  GET - Specific fighter    : http://matthewgollaher.azurewebsites.net/WiiUSmash4/fighter/4
  </li>
  <li>
  GET - ALL fighter cards   : http://matthewgollaher.azurewebsites.net/WiiUSmash4/card
  </li>
</ul>

<br/>
Technologies used: C#, MVC, ASP.NET Core, and Azure.


