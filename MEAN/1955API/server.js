
const bodyParser = require('body-parser');
var mongoose = require('mongoose');
mongoose.connect('mongodb://localhost/1955');
const fiftiesSchema = new mongoose.Schema({
    name: {type: String},
}, {timestamps: true});
const fiftyfivers = mongoose.model('fiftyfivers', fiftiesSchema);
// configure body-parser to read JSON
var express = require('express');
var app = express();
app.use(bodyParser.json());
app.get('/', function(req, res){
    fiftyfivers.find({}, function(err, fiftyfivers){
        if(err){
           console.log("Returned error", err);
            // respond with JSON
           res.json({message: "Error", error: err})
        }   
        else {
            // respond with JSON
           res.json({message: "Success", data: fiftyfivers})
        }
    })
})
app.get('/new/:name', function(req,res){
    var newfiver= new fiftyfivers({
        name: req.params.name
    })
    newfiver.save();
    res.redirect('/');      
})
app.get('/remove/:name', function(req,res){
    fiftyfivers.remove({name: req.params.name}, function(err){
    })
    res.redirect('/')    
})
app.get('/:name', function(req, res){
    console.log(req);
    fiftyfivers.find({name:req.params.name}, function(err, scrutinized){
    console.log("HERE IS THE QUESTIONED DUCK: ", scrutinized);
    res.json({message: "success", data: scrutinized})
})})
app.listen(8000, function() {
    console.log("listening on port 8000");
})