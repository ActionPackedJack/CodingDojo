var students = [ 
     {first_name:  'Michael', last_name : 'Jordan'},
     {first_name : 'John', last_name : 'Rosales'},
     {first_name : 'Mark', last_name : 'Guillen'},
     {first_name : 'KB', last_name : 'Tonel'}
];

function printNames(arr){
  for(var i=0; i<arr.length;i++){
    console.log(i+ " - " + arr[i].first_name +" " + arr[i].last_name + " - " + (arr[i].first_name.length + arr[i].last_name.length));
  }
}

//printNames(students)

var users = {
 'Students': [ 
     {first_name:  'Michael', last_name : 'Jordan'},
     {first_name : 'John', last_name : 'Rosales'},
     {first_name : 'Mark', last_name : 'Guillen'},
     {first_name : 'KB', last_name : 'Tonel'}
  ],
 'Instructors': [
     {first_name : 'Michael', last_name : 'Choi'},
     {first_name : 'Martin', last_name : 'Puryear'}
  ]
 }
 
 function printAll(obj){
   for (var property in obj){
    console.log(property);
    console.log(printNames(obj[property]));
   }
 }
 
 printAll(users);