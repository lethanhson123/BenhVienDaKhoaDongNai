import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomepageComponent } from './homepage/homepage.component';
import { GroupComponent } from './group/group.component';
import { M2Component } from './m2/m2.component';
import { QRCodeComponent } from './qrcode/qrcode.component';
import { C5Component } from './c5/c5.component';
import { M24Component } from './m24/m24.component';
import { M4Component } from './m4/m4.component';
import { M6Component } from './m6/m6.component';



const routes: Routes = [
  { path: '', redirectTo: '/M6/T118/T119/T98/T99/T120/T121/3', pathMatch: 'full' },
  {
    path: 'Homepage/:Code01/:Code02/:Number', component: HomepageComponent,
  }, 
  {
    path: 'Group/:GroupOrder', component: GroupComponent,
  }, 
  {
    path: 'M2/:Code01/:Code02/:Number', component: M2Component,
  }, 
  {
    path: 'M24/:Code01/:Code02/:Number', component: M24Component,
  }, 
  {
    path: 'M4/:Code01/:Code02/:Code03/:Code04/:Number', component: M4Component,
  }, 
  {
    path: 'M6/:Code01/:Code02/:Code03/:Code04/:Code05/:Code06/:Number', component: M6Component,
  },
  {
    path: 'C5/:Code01/:Number', component: C5Component,
  }, 
  {
    path: 'QRCode', component: QRCodeComponent,
  }, 
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true, initialNavigation: 'enabled' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }









































































