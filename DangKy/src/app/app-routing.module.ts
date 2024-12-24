import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomepageComponent } from './homepage/homepage.component';
import { FullComponent } from './full/full.component';



const routes: Routes = [
  { path: '', redirectTo: '/Full', pathMatch: 'full' },
  {
    path: 'Homepage', component: HomepageComponent,
  },  
  {
    path: 'Full', component: FullComponent,
  },  
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true, initialNavigation: 'enabled' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }









































































