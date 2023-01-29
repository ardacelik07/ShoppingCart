# ShoppingCart

## model layer
<br/>This is the simple web application task from Megaventory.I used .Net 5.0 in this project. I have 3 layers in my project.Controller Client and models.<br/>
<br/>I could use solutions when ı add the layers. But ı prefer to keep it simple and ı just add folders to one solution.<br/>
<br/> models layer has the mventities,MegaventoryHttpModels and my Dto's. <br/>
<br/>I made update models for the every entity that ı wanted to insert.<br/>
<br/>They have properties that T entity object,mvrecord and apikey.<br/>
<br/> the basehttpmodel that only have apikey the other all updatemodels inherit this class and the<br/>
<br/>IMegaventoryModel that the main interface all other updatemodels and megaventorybasehttpmodel inherit that class.<br/>
<br/>I used that interface because ı wanted to make my code clean and use the oop best practise (polimorfizm).<br/>

## Client layer

<br/>this is the layer that acts as a middleware.(repository)<br/>
<br/> this class  has two folder that ConcreteClient and IClient.<br/>
<br/>I just only have interface called IClient in the IClients folder.<br/>
<br/>it is a generic interface and include models. there is only Insert method sign in this interface.<br/>
<br/>I have BaseClient and MegaventoryClient in the concrete client folder.<br/>
<br/>I am making new httpclient object in this class and MegaventoryClient inherit this class.<br/>
<br/>I only made MegaventoryClient class because of we dont need a spesific methods for every model.<br/>
<br/>I am generally making  genericrepository for crud operation in my projects.
So we can think that megaventory client is act like a genericrepository.<br/>
<br/>MegaventoryClientClass has the only insert model.it is making http post request to megaventory api.

## Controller layer.
I have to controllers for every model that ı wanna send request. 





