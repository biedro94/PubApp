import { Component } from '@angular/core';
//import {FormBuilder, Validators, Control, ControlGroup, FORM_DIRECTIVES} from "@angular/common";
import { NavController } from 'ionic-angular';
//import  {FormBuilder} from '@angular/common';
import {FormBuilder, Validators} from "@angular/forms";
import { LoadingController } from 'ionic-angular';

/*
  Generated class for the Registration page.

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
  selector:'page-registration',
  templateUrl: 'registration.html'
})
export class RegistrationPage {

  public registrationForm:any;

  constructor(public navCtrl: NavController, public _form:FormBuilder, public loadingCtrl: LoadingController) {
  this.registrationForm = this._form.group({
    "email":["",Validators.required],
    "password":["",Validators.required]//, GlobalValidator.mailFormat]
  })

  }

    ionViewDidLoad() {
      console.log('Hello RegistrationPage Page');
    }

  submit(){
    console.log(this.registrationForm.value);
  }
  presentLoading() {
    let loader = this.loadingCtrl.create({
      content: "Please wait...",
      duration: 2000
    });
    loader.present();
  }
}


