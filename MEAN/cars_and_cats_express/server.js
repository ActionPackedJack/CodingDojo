// Load the express module and store it in the variable express (Where do you think this comes from?)
var express = require("express");
// invoke express and store the result in the variable app
var app = express();
var bodyParser = require('body-parser');
//var path = require('path');
app.set('views', __dirname + '/views');
app.set('view engine', 'ejs');
app.use(express.static(__dirname + "/static")); 
app.use(bodyParser.urlencoded({extended:true}));

app.get('/', function(request, response) {
    // just for fun, take a look at the request and response objects
   console.log("The request object", request);
   console.log("The response object", response);
   // use the response object's .send() method to respond with an h1
   //response.send("<h1>Hello Express</h1>");
   response.render('index');
})

app.get("/cars", function (request, response){
    // hard-coded user data
    var cars_array = [
        {name: "DSC01680.jpg"}, 
        {name: "Ford-Model-T-Touring-front-34-900x600.jpg"}, 
        {name: "stealth02.jpg"}, 
        {name: "vxl-blog-2016-274.jpg"}
    ];
    response.render('cars', {cars: cars_array});
})

app.get("/cats", function (request, response){
    // hard-coded user data
    var cats_array = [
        {name: "Cat_Herd.jpg"}, 
        {name: "Cat_Pile.jpg"}, 
        {name: "cat-bath-671.jpg"}, 
        {name: "cat-stalking-crop.jpg"},
    ];
    response.render('cats', {cats: cats_array});
})

app.get("/form", function (request, response){
    response.render('form');
})
// tell the express app to listen on port 8000, always put this at the end of your server.js file
app.listen(8000, function() {
  console.log("listening on port 8000");
})          