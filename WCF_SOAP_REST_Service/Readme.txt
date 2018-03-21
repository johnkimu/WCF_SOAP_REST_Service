
In this mandatory assignment, we have made REST and SOAP web service applications. Then, we have made a client side application which is a windows universal application that is consuming the services from our two web services.The REST web service is exposing the  data through Https and the SOAP is exposing the data through WSDL file. 

WCF is a messaging framework for building web services. What this means is that you can write methods in C# (or any of the .NET languages) and then apply a bunch of configurations to the code that make your code accessible to others and turn your code into a web service.

Those "bunch of configurations" are WCF. WCF allows you to expose your methods to other computers or applications using REST if you set up the WCF configurations around your C# code to expose it as a RESTful service. Or, you can easily take the same C# methods and make them available via the SOAP protocol.

For example in this app, we have made a method called "GetEmployees()", then we have set up the WCF configuration to make that method available in a service that is hosted in IIS. When someone calls that service, they can send an HTTP GET request to "http://localhost:5599/Service.svc/XmlService/Employees"", and the "GetEmployees method will receive the request and send back a HTTP response message which contains message Status-Line, HTTP Version, Status Code and Response Header Fields. When you make a GET request over HTTP, you're using the REST. REST is pretty much tied to HTTP as the transport protocol. REST also has no standard message format. Whatever you want to send in your HTTP message, and however you want to send it is OK. You can send XML, or JSON, or just plain text. You can use POST, or GET or PUT or any of the HTTP verbs as well.

With SOAP, your messages can be sent to the service using any transport protocol meaning that your request is not tied to HTTP. SOAP messages are designed to be transport neutral. They are encoded in XML and the XML always has a head and a body node inside an envelope node. With SOAP, you get a WSDL file that is a XML-based interface definition language that is used for describing the functionality SOAP.


