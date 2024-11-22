import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CKEditorModule } from 'ngx-ckeditor';
import { ChartsModule } from 'ng2-charts';
import { CookieService } from 'ngx-cookie-service';
import { MAT_DATE_LOCALE } from '@angular/material/core';
import { MaterialModule } from './material/material.module';
import { GoogleMapsModule } from '@angular/google-maps';
import { NotificationService } from './shared/Notification.service';
import { AppComponent } from './app.component';
import { LoadingComponent } from './loading/loading.component';
import { HomepageComponent } from './homepage/homepage.component';
import { GComponent } from './g/g.component';
import { CComponent } from './c/c.component';
import { TiepNhanComponent } from './tiep-nhan/tiep-nhan.component';
import { TiepNhanFullComponent } from './tiep-nhan-full/tiep-nhan-full.component';
import { TiepNhanSComponent } from './tiep-nhan-s/tiep-nhan-s.component';
import { HienThiComponent } from './hien-thi/hien-thi.component';
import { HienThi01Component } from './hien-thi01/hien-thi01.component';
import { HienThi02Component } from './hien-thi02/hien-thi02.component';
import { HienThi04Component } from './hien-thi04/hien-thi04.component';
import { HienThi03Component } from './hien-thi03/hien-thi03.component';

@NgModule({
  declarations: [
    AppComponent,
    LoadingComponent,
    HomepageComponent,
    GComponent,
    CComponent,
    TiepNhanComponent,
    TiepNhanFullComponent,
    TiepNhanSComponent,
    HienThiComponent,
    HienThi01Component,
    HienThi02Component,
    HienThi04Component,
    HienThi03Component,

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'serverApp' }),
    FormsModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    GoogleMapsModule,
    ChartsModule,
    CKEditorModule,
  ],
  providers: [
    CookieService,
    NotificationService,
    { provide: MAT_DATE_LOCALE, useValue: 'en-GB' }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
