import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { City } from '../Models/city';
import { Photo } from '../Models/photo';

@Injectable({
  providedIn: 'root'
})
export class CityService {

constructor(private HttpClient:HttpClient) { }
path="http://localhost:61062/api/";
getCities():Observable<City[]>{
  return this.HttpClient.get<City[]>(this.path+"cities")
}
getCityById(cityId: any):Observable<City>{
  return this.HttpClient.get<City>(this.path + "cities/detail/?id=" + cityId )
}
getPhotosByCity(cityId:any):Observable<Photo[]>{
  return this.HttpClient.get<Photo[]>(this.path + "cities/photos/?cityId=" + cityId )

}
}
