import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomepageComponent } from './homepage/homepage.component';
import { GroupComponent } from './group/group.component';
import { M2Component } from './m2/m2.component';



const routes: Routes = [
  { path: '', redirectTo: '/M2/NoiSoi1/NoiSoi2/4', pathMatch: 'full' },
  {
    path: 'Homepage/:Code01/:Code02/:Number', component: HomepageComponent,
  }, 
  {
    path: 'Group/:GroupOrder', component: GroupComponent,
  }, 
  {
    path: 'M2/:Code01/:Code02/:Number', component: M2Component,
  }, 
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true, initialNavigation: 'enabled' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }









































































