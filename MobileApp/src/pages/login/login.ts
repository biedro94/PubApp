import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import {FormBuilder, Validators} from "@angular/forms";
import { LoadingController } from 'ionic-angular';
import {RegistrationPage} from '../registration/registration';
//import {ValidationService} from '../../Validation/Validation';
/*
  Generated class for the Registration page.

  See http://ionicframework.com/docs/v2/components/#navigation for more info on
  Ionic pages and navigation.
*/
@Component({
  selector:'page-login',
  templateUrl: 'login.html'
})
export class LoginPage {

  public registrationForm:any;

  constructor(public navCtrl: NavController, public _form:FormBuilder, public loadingCtrl: LoadingController) {
  this.registrationForm = this._form.group({
    "email":["",Validators.compose([Validators.required, Validators.minLength(3)])],
    "password":["",Validators.compose([Validators.required, Validators.minLength(3)])]//, ValidationService.emailValidator()] //todo valid email
  })

  }

    ionViewDidLoad() {
      console.log('Hello Login Page');
    }

  submit(){
    console.log(this.registrationForm.value);
  }
  presentLoading() {
    let loader = this.loadingCtrl.create({
      content: "Please wait...",
      duration: 1000
    });
    loader.present();
  }
  goToRegister(){
    this.navCtrl.push(RegistrationPage);
  }
}


