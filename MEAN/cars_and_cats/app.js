// get the http module:
var http = require('http');
// fs module allows us to read and write content for responses!!
var fs = require('fs');

var nStatic = require('node-static');           
// creating a server using http module:
var server = http.createServer(function (request, response){
    // see what URL the clients are requesting:
    console.log('client request URL: ', request.url);
    // this is how we do routing:
    if(request.url === '/cars') {
        fs.readFile('./views/cars.html', 'utf8', function (errors, contents){
            response.writeHead(200, {'Content-Type': 'text/html'});
            response.write(contents); 
            response.end();
        });
    }
    else if(request.url === '/cats') {
        fs.readFile('views/cats.html', 'utf8', function (errors, contents){
            response.writeHead(200, {'Content-Type': 'text/html'});  // send data about response
            response.write(contents);  //  send response body
            response.end(); // finished!
        });
    }
    else if (request.url === '/images/cat-bath-671.jpg'){
        fs.readFile('./images/cat-bath-671.jpg', function(errors, contents){
            response.writeHead(200, {'Content-type': 'image/jpg'});
            response.write(contents);
            response.end(); 
       })  
    }
    else if (request.url === '/images/Cat_Herd.jpg'){
        console.log("CAT HERD");
        fs.readFile('./images/Cat_Herd.jpg', function(errors, contents){
            response.writeHead(200, {'Content-type': 'image/jpg'});
            response.write(contents);
            response.end();  
       })  
    }
        else if (request.url === '/images/Cat_Pile.jpg'){
            console.log("CAT PILE");
            fs.readFile('./images/Cat_Pile.jpg', function(errors, contents){
                response.writeHead(200, {'Content-type': 'image/jpg'});
                response.write(contents);
                response.end(); 
        })  
    }
        else if (request.url === '/images/cat-stalking-crop.jpg'){
            fs.readFile('./images/cat-stalking-crop.jpg', function(errors, contents){
                response.writeHead(200, {'Content-type': 'image/jpg'});
                response.write(contents);
                response.end();   
        })  
    }
    else if (request.url === '/images/FatCat411.jpg'){
        fs.readFile('./images/FatCat411.jpg', function(errors, contents){
            response.writeHead(200, {'Content-type': 'image/jpg'});
            response.write(contents);
            response.end();   
    })  
}
    else if (request.url === '/images/DSC01680.jpg'){
        fs.readFile('./images/DSC01680.jpg', function(errors, contents){
            response.writeHead(200, {'Content-type': 'image/jpg'});
            response.write(contents);
            response.end(); 
    })  
}
    else if (request.url === '/images/vxl-blog-2016-274.jpg'){
        fs.readFile('./images/vxl-blog-2016-274.jpg', function(errors, contents){
            response.writeHead(200, {'Content-type': 'image/jpg'});
            response.write(contents);
            response.end(); 
    })  
}
    else if (request.url === '/images/stealth02.jpg'){
        fs.readFile('./images/stealth02.jpg', function(errors, contents){
            response.writeHead(200, {'Content-type': 'image/jpg'});
            response.write(contents);
            response.end();  
    })  
}
    else if (request.url === '/images/Ford-Model-T-Touring-front-34-900x600.jpg'){
        fs.readFile('./images/Ford-Model-T-Touring-front-34-900x600.jpg', function(errors, contents){
            response.writeHead(200, {'Content-type': 'image/jpg'});
            response.write(contents);
            response.end(); 
    })  
}
    else if (request.url === '/cars/new') {
         fs.readFile('views/add_car.html', 'utf8', function (errors, contents){
             response.writeHead(200, {'Content-Type': 'text/html'});
             response.write(contents); 
             response.end();
         });
    }
    // request didn't match anything:
    else {
        response.end('File not found!!!');
    }
});
// tell your server which port to run on
server.listen(6789);
// print to terminal window
console.log("Running in localhost at port 6789");