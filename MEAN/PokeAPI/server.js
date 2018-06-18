const bodyParser = require('body-parser');
//mongoose.connect('mongodb://localhost/1955');
// configure body-parser to read JSON
var express = require('express');
var app = express();
app.use(bodyParser.json());
app.use(express.static( __dirname + '/poke-app/dist/poke-app'));
app.listen(8000, function() {
    console.log("listening on port 8000");
})