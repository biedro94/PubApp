import { Component } from '@angular/core';
import {Products} from '../../app/models/products';
import 'rxjs/add/operator/map';
import {Promise} from 'es6-promise';
import { HttpModule, Http, Response} from '@angular/http';
import 'rxjs/add/operator/toPromise';
import { NavController } from 'ionic-angular';


@Component({
  templateUrl: 'menu.html'
})
export class Menu {


  public configuredModules: Products;
  public http: Http;

  constructor(public navCtrl: NavController,private _http: Http) {
    this.http = _http;
  }

  public getListOfProducts(){

    this.getModules().then(modules => this.configuredModules = modules);
    console.log('finished configuredModules');
  }


  public getModules(): Promise<Products> {
    return this.http.get('http://localhost:56448/Product/List')
      .toPromise()
      .then(response => response.json().modules as Products);
  }

  ngOnInit() {
    this.getListOfProducts();
  }

  buttonClicked(){
    console.log('button clicked');
    console.log(this.configuredModules);
  }
}
