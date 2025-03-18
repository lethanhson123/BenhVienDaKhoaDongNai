import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomepageComponent } from './homepage/homepage.component';
import { GroupComponent } from './group/group.component';
import { M2Component } from './m2/m2.component';
import { QRCodeComponent } from './qrcode/qrcode.component';
import { C5Component } from './c5/c5.component';



const routes: Routes = [
  { path: '', redirectTo: '/C5/C1/4', pathMatch: 'full' },
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









































































