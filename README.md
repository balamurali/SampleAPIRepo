# SampleAPIRepo
# This is a simple asp.net core project in which i tried to access one of the APIs of the Flightaware (https://flightaware.com/commercial/flightxml/documentation2.rvt) and create an API (one get method) which will return an airports weather conditions based on AIrport code we give. 
# API i accessed is http://flightxml.flightaware.com/json/FlightXML2/MetarEx?airport=KJFK&startTime=0&howMany=1&offset=0 and tried to return only subset of the MetarExResult entty
# The API needs username and an API Key to be send along with the request header in order to be accessible.Have stored the username and APIkey on the appsettings.json
# Have included swagger for testing purpose as well on /swagger of the base url.
# Tried to demonstrate Repository pattern and Factory pattern of httpclient (created and assigned an httpclient services added on startup class).Used IHttpClientFactory on repository class using inbuilt core Dependency Injection.
# Created Unit test for the controller actionmethod
