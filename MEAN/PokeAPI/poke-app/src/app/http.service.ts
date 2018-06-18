import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'; 

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) {
    this.getPokemon();
}
getPokemon(){
    let greninja = this._http.get('https://pokeapi.co/api/v2/pokemon/658/');
    greninja.subscribe(data => {console.log("Found Greninja!", data)
      let greninjabilities= (data["abilities"]);
      let greninjabilityFacts = "Here are the abilities of " + data["name"] + ":"
      for (var ability of greninjabilities){
        console.log(ability);
        greninjabilityFacts+=" " + ability["ability"]["name"] + "! ";
        
      }
      console.log (greninjabilityFacts)
      let torrent = this._http.get('https://pokeapi.co/api/v2/ability/67/');
      torrent.subscribe(data => {console.log("Found Torrent!", data)
      let torrentsharers = data["pokemon"];
      console.log("Here are the other pokemon that have the ability torrent:");
      for (var pokemon of torrentsharers){
        console.log (pokemon["pokemon"]["name"])
      }
      
    });

    // console.log(Object.entries(greninja));
    // console.log(greninja["abilities"]);
    //console.log(greninjavalues) ;
    // for(var key in greninja){
    //   console.log(key.value);
    // }
  }
} 
