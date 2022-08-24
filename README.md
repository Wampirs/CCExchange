# CCExchange

***At this project used COINCAP API 2.0***
Multipaging implemented by using hot switch of view model at single place.
## First page
Represents a list of top 10 crypto currencies. By double click on each of them you can open detail info about it.
## Second page
Represents all currencies (probably not all just 100) with detail info about each of them. At datait info you can see offers from exchanges connected to this currency.
Double click on one of them will show you information about exchange. 
At this page implemented search field.
## Third page
Represents list of all exchanges with same posibilities like at second page.
At detail info you can click button to open exchange site in your browser.

Application supports light and dark theme. You can change theme by click on button at right part of top toolbar.


Used tecnologies:
- C# .Net 6.0
- Newtonsoft.Json for work with JSONs
- Microsoft.Extensions.Hosting to implement dependency injection
