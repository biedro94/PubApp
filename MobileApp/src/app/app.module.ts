import { NgModule } from '@angular/core';
import { IonicApp, IonicModule } from 'ionic-angular';
import { MyApp } from './app.component';
import { Menu } from '../pages/menu/menu';
import { ItemDetailsPage } from '../pages/item-details/item-details';
import { ListPage } from '../pages/list/list';
import {RegistrationPage} from '../pages/registration/registration'

@NgModule({
  declarations: [
    MyApp,
    Menu,
    ItemDetailsPage,
    ListPage,
    RegistrationPage
  ],
  imports: [
    IonicModule.forRoot(MyApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    Menu,
    ItemDetailsPage,
    ListPage,
    RegistrationPage
  ],
  providers: []
})
export class AppModule {}
