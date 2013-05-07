WebServiceExamples.NET
======================

Creating a web service using .NET with 8 different approaches


Invoking the Awesome
====================
    Service Implementation                            Result Type
    ASMX -> Add web references  						          SOAP
    WCF -> Add service reference						          SOAP
    WCFAJAX -> /Service1.scv/ToUpper?input=somestring	JSON (wrapped in "d" property)
    WCFREST -> /Service1.scv/ToUpper/somestring			  JSON
    MVC3 -> /Service/ToUpper/somestring					      JSON
    MVC4 -> /Api/ToUpper/somestring						        JSON
    NANCY -> /ToUpper/somestring						          JSON
    SERVICESTACK -> /ToUpper/somestring?format=JSON 	JSON (wrapped in "output" property)


