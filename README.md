# ShoppingCart

## model layer
This is the simple web application task from Megaventory.I used .Net 5.0 in this project. I have 3 layers in my project.Controller Client and models.
I could use solutions when ı add the layers. But ı prefer to keep it simple and ı just add folders when I added my layers.
in the models layer ı have the mventities,MegaventoryHttpModels and my Dto's. 
I made update models for the every entity that ı wanted to insert.
They have properties that T entity object,mvrecord and apikey.
I also added salesorderstatus property in salesorderupdate model.
I also have that the basehttpmodel that only have apikey the other all updatemodels inherit this class.and I have the
IMegaventoryModel that the main interface all other updatemodels and megaventorybasehttp model inherit that class.
I used that interface because ı wanted to make my code clean and use the oop best practise (polimorfizm).

##Client layer

this is the layer that acts as a middleware.(repository)
in this class ı have two folder that ConcreteClient and IClient.
I just only have interface called IClient in the IClients folder.
it is a generic interface and include models. I only have Insert method in this interface.
I have BaseClient and MegaventoryClient in the concrete client folder.
I only making making new httpclient object in this class and MegaventoryClient class inherit this class.
I only made MegaventoryClient class because of we dont need a spesific methods for every model.
I am generally making  genericrepository for crud operation in my projects.
So we can think that megaventory client is like a genericrepository.
I have the only  insert method inside of MegaventoryClientClass.it is making http post request to megaventory api.

## Controller layer.
I have to controllers for every model that ı wanna send request. 





