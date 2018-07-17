import { Component, OnInit } from '@angular/core';
import { HttpService } from './http.service';   

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  newTask: any;
  tasks = [];
  taskTitle= "";
  taskDescription= "";
  chosentask= null;
  constructor(private _httpService: HttpService){}
  ngOnInit(){
    this.newTask = { title: "", description: "" }
     this.getTasksFromService();
   }
  viewTask(id){
    console.log(id);
    let observable = this._httpService.viewTask(id);
    observable.subscribe(data => {console.log("Task found!", data);
    console.log("HERE IS THE DATA", data);
    this.chosentask = data;
    console.log("HERE IS THE CHOSEN TASK", this.chosentask);
    console.log("TASK TITLE IS THUS: ", data["data"]['title'], this.chosentask.title);
    this.taskTitle= data['title'];
    this.taskDescription= data['description'];
    //console.log(data);
    //console.log(this.taskTitle);
    //console.log(this.taskDescription);
    })
  }
  
  getTasksFromService(){
    let observable = this._httpService.getTasks();
    observable.subscribe(data => {console.log("Got our tasks!", data);
    console.log(data) 
    console.log(data['tasks'])
    this.tasks = data['tasks'];
  })
}
}