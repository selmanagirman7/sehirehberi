import { Component, OnInit } from '@angular/core';
import { from } from 'rxjs';
import { City } from '../Models/city';
import { CityService } from '../services/city.service';


@Component({
  selector: 'app-city',
  templateUrl: './city.component.html',
  styleUrls: ['./city.component.css'],
  providers:[CityService]
})
export class CityComponent implements OnInit {

  constructor(private CityService:CityService) { }
  cities!: City[];



  ngOnInit(): void {
    this.CityService.getCities().subscribe(data=>{
      this.cities=data;
    })
  }

}
