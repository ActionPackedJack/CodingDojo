const bodyParser = require('body-parser');
var mongoose = require('mongoose');
mongoose.connect('mongodb://localhost/1955');
const productSchema = new mongoose.Schema({
    name: {type: String, default: "Twiddle thumbs"},
    price: {type: String, default: ''},
    image: {type: String, default: false}
}, {timestamps: true});
const tasks = mongoose.model('products', productSchema);
// configure body-parser to read JSON
var express = require('express');
var app = express();
app.use(bodyParser.json());
app.use(express.static( __dirname + '/public/dist/public'));
app.listen(8000, function() {
    console.log("listening on port 8000");
})