// require express
var express = require("express");
// path module -- try to figure out where and why we use this
var path = require("path");
var session = require('express-session');
// create the express app
var app = express();
var bodyParser = require('body-parser');
// use it!
app.use(bodyParser.urlencoded({ extended: true }));
// static content
app.use(express.static(path.join(__dirname, "./static")));
// setting up ejs and our views folder
app.use(session({
    secret: 'keyboardkitteh',
    resave: false,
    saveUninitialized: true,
    cookie: { maxAge: 60000 }
  }))
app.set('views', path.join(__dirname, './views'));
app.set('view engine', 'ejs');
// root route to render the index.ejs view
app.get('/', function(req, res) {   
        res.render("index");
    }   
)
// post route for adding a user
app.post('/posted', function (req, res){
    // set the name property of session.  
    req.session.data = req.body;
    console.log(req.session.data);
    //code to add user to db goes here!
    // redirect the user back to the root route. 
    res.render("posted", {user: req.session.data});
});
// tell the express app to listen on port 8000
app.listen(8000, function() {
 console.log("listening on port 8000");
});     