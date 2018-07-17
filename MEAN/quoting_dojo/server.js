var mongoose = require('mongoose');
mongoose.connect('mongodb://localhost/quoting_dojo');
const quoteSchema = new mongoose.Schema({
    name: {type: String, required: true},
    quote: {type: String, required: true}  
}, {timestamps: true});
const quote = mongoose.model('quote', quoteSchema);
var session = require('express-session');
const flash = require('express-flash');
// Require the Express Module
var express = require('express');
// Create an Express App
var app = express();
// Require body-parser (to receive post data from clients)
var bodyParser = require('body-parser');
// Integrate body-parser with our App
app.use(bodyParser.urlencoded({ extended: true }));
// Require path
var path = require('path');
// Setting our Static Folder Directory
app.use(express.static(path.join(__dirname, './static')));
app.use(session({secret: 'glomp'}));
app.use(flash());   
// Setting our Views Folder Directory
app.set('views', path.join(__dirname, './views'));
// Setting our View Engine set to EJS
app.set('view engine', 'ejs');
// Routes
// Root Request
app.get('/', function (req,res) {
    res.render('index');
})
app.get('/quotes', function(req, res) {
    quote.find({}, function(err,quotes){
        res.render('quotes', {quotations: quotes});
    })
})  
app.post('/add', function(req, res) {
    console.log("POST DATA", req.body);
    var newquote= new quote({
        name: req.body.name,
        quote: req.body.quote
    });
    console.log("YOUR QUOTE: " , newquote);
    newquote.save(function(err){
        if (err) {
            console.log(err);
            for(var key in err.errors){{
                req.flash('registration', err.errors[key].message);
            }
            res.redirect('/');
            }
        }
        else{
            res.redirect('/quotes');
        }
        // console.log ("HERE IS QUOTES");
        // console.log(quote);
        // console.log ("THIS IS NO LONGER QUOTES")
        //res.render('quotes', {quotations: quotes});
    })
})  
// Setting our Server to Listen on Port: 8000
app.listen(8000, function() {
    console.log("listening on port 8000");
})