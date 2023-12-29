import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  private baseport='https://localhost:7126'

  constructor(private http:HttpClient) { }

 
  // admin
  public getProdt():Observable<any>
  {
    return this.http.get(this.baseport+'/AdminSide/DisplayingAllItems')
  }
  //Add new prdt
  public addPrdt(prdtlist:any):Observable<any>
  {
    return this.http.post(this.baseport +'/AdminSide/Updating the Values/',prdtlist);
  }
  //del by id
  public delbyId(id:number):Observable<any>
  {
    return this.http.delete(this.baseport+"/AdminSide/"+id)
  }
  //update
  public update(id:number,updatedPrdt:any):Observable<any>
  {
    const url = `${this.baseport}/AdminSide/${id}`;
    return this.http.put(url , updatedPrdt);
  }

}