import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class HoteldetailsService {

  constructor(private http:HttpClient) { }

  public gethoteldetails():Observable<any>{
    return this.http.get("https://localhost:7046/api/Hotels/1001");
  }
  public getmenustarter():Observable<any>{
    return this.http.get("https://localhost:7046/api/Products/menu?id=201");
  }
  public getmenuLunch():Observable<any>{
   return this.http.get("https://localhost:7046/api/Products/menu?id=202")
  }
  public getmenudinner():Observable<any>{
    return this.http.get("https://localhost:7046/api/Products/menu?id=203")
  }

  
  public AddNew(Hotellist: any): Observable<any> {
    return this.http.post('https://localhost:7046/api/Hotels',
      Hotellist
    );
  }
  public deleteById(id: number): Observable<any> {
    return this.http.delete('https://localhost:7046/api/Hotels/' + id
    );
  }
    public updatedetails(id:number,Products:any):Observable<any> {
      let url= 'https://localhost:7046/api/Hotels/' + id
      return this.http.put(url,Products)
    }
    public getall(): Observable<any> {
      return this.http.get('https://localhost:7046/api/Hotels');
    }

//menu

    public Addnewmenu(Hotellist: any): Observable<any> {
      return this.http.post('https://localhost:7046/api/Products',
        Hotellist
      );
    }
    public deletemenubyid(id: number): Observable<any> {
      return this.http.delete('https://localhost:7046/api/Products/' + id
      );
    }
      public updatemenus(id:number,Products:any):Observable<any> {
        let url= 'https://localhost:7046/api/Products/' + id
        return this.http.put(url,Products)
      }
      public getallproducts(): Observable<any> {
        return this.http.get('https://localhost:7046/api/Products');
      }
}
