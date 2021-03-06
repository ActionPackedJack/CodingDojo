import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';  

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) {
    this.getTasks();   
  }
  getTasks(){
    // // our http response is an Observable, store it in a variable
    // let tempObservable = this._http.get('/tasks');
    // // subscribe to the Observable and provide the code we would like to do with our data from the response
    // tempObservable.subscribe(data => console.log("Got our tasks!", data));
    return this._http.get('/tasks/');
 }
 viewTask(id){
   console.log("HERE IS THE REQUESTED ID")
   console.log(id);
   return this._http.get('/task/'+id)
 }
 addTask(newtask){
   console.log(newtask);
  return this._http.post('/new/:title/:description/:completed', newtask)
}
} 
