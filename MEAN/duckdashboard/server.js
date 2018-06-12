var mongoose = require('mongoose');
mongoose.connect('mongodb://localhost/duck_dashboard');
const duckSchema = new mongoose.Schema({
    name: {type: String, required: true},
    cuteness: {type: Number, required: true},
    awkwardness: {type: Number, required: true},
}, {timestamps: true});
const ducks = mongoose.model('ducks', duckSchema);
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
    ducks.find({}, function(err,ducks){
        res.render('index', {allducks:ducks});
    })
});
app.get('/ducks/new', function(req, res) {
    res.render('new');
})
app.post('/ducks/edit/:id', function(req,res){
    ducks.findOne({_id:req.params.id}, function(err, duckinquestion){
        duckinquestion.name= req.body.name;
        duckinquestion.cuteness= req.body.cuteness;
        duckinquestion.awkwardness= req.body.awkwardness;
        duckinquestion.save();
    })
    res.redirect('/');
})
app.get('/ducks/delete/:id', function(req, res){
    ducks.remove({_id: req.params.id}, function(err){
   })
   res.redirect('/')
})
app.post('/add', function(req, res) {
    console.log("POST DATA", req.body);
    var newduck = new ducks({
        name: req.body.name,
        cuteness: req.body.cuteness,
        awkwardness: req.body.awkwardness,
    });
    console.log("YOUR DUCK: " , newduck);
    newduck.save(function(err){
        if (err) {
            console.log(err);
            for(var key in err.errors){{
                req.flash('registration', err.errors[key].message);
            }
            //res.redirect('/');
            }
        }
        else{
            res.redirect('/');
        }
    })
})
app.get('/ducks/:id', function(req, res){
    console.log(req);
    ducks.findOne({_id:req.params.id}, function(err, duckinquestion){
    console.log("HERE IS THE QUESTIONED DUCK: ", duckinquestion);
    res.render('view', {duck:duckinquestion});
})})
app.get('/ducks/edit/:id', function(req, res){
    console.log(req);
    ducks.findOne({_id:req.params.id}, function(err, duckinquestion){
    console.log("HERE IS THE QUESTIONED DUCK!!!! ", duckinquestion);
    res.render('edit', {duck:duckinquestion});
})})
// Setting our Server to Listen on Port: 8000
app.listen(8000, function() {
    console.log("listening on port 8000");
})