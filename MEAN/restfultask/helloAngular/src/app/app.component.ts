import { Component, OnInit } from '@angular/core';
import { HttpService } from './http.service';   

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  tasks = []; 
  constructor(private _httpService: HttpService){}
  ngOnInit(){
    this.getTasksFromService();
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