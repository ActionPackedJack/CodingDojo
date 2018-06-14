const bodyParser = require('body-parser');
var mongoose = require('mongoose');
mongoose.connect('mongodb://localhost/1955');
const taskSchema = new mongoose.Schema({
    title: {type: String, default: "Twiddle thumbs"},
    description: {type: String, default: ''},
    completed: {type: Boolean, default: false}
}, {timestamps: true});
const tasks = mongoose.model('tasks', taskSchema);
// configure body-parser to read JSON
var express = require('express');
var app = express();
app.use(bodyParser.json());
app.get('/', function(req, res){
    tasks.find({}, function(err, tasks){
        if(err){
           console.log("Returned error", err);
            // respond with JSON
           res.json({message: "Error", error: err})
        }   
        else {
            // respond with JSON
           res.json({message: "Success", data: tasks})
        }
    })
})
app.post('/new/:title/:description/:completed', function(req,res){
    var newtask= new tasks({
        title: req.params.title,
        description: req.params.description,
        completed: req.params.completed,
    })
    console.log(newtask);
    newtask.save();
    res.redirect('/');      
})
app.delete('/delete/:id', function(req,res){
    tasks.remove({_id: req.params.id}, function(err){
    })
    res.redirect('/')    
})
app.put('/edit/:id/:title/:description/:completed', function(req,res){
    tasks.findOne({_id: req.params.id}, function(err, changed){
        changed.title= req.params.title,
        changed.description= req.params.description,
        changed.completed= req.params.completed,
        changed.save();
    })
    res.redirect('/')
})
app.get('/:id', function(req, res){
    console.log(req);
    tasks.find({_id:req.params.id}, function(err, scrutinized){
    console.log("HERE IS THE QUESTIONED TASK: ", scrutinized);
    res.json({message: "success", data: scrutinized})
})})
app.listen(8000, function() {
    console.log("listening on port 8000");
})