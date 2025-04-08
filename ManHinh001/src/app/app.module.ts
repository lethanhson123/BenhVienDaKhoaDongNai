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
import { GroupComponent } from './group/group.component';
import { M2Component } from './m2/m2.component';
import { QRCodeComponent } from './qrcode/qrcode.component';
import { C5Component } from './c5/c5.component';
import { M24Component } from './m24/m24.component';
import { M4Component } from './m4/m4.component';
import { M6Component } from './m6/m6.component';
import { M40Component } from './m40/m40.component';
import { M60Component } from './m60/m60.component';
import { M12Component } from './m12/m12.component';
import { M120Component } from './m120/m120.component';
import { BHYTComponent } from './bhyt/bhyt.component';



@NgModule({
  declarations: [
    AppComponent,
    LoadingComponent,
    HomepageComponent,
    GroupComponent,
    M2Component,
    QRCodeComponent,
    C5Component,
    M24Component,
    M4Component,
    M6Component,
    M40Component,
    M60Component,
    M12Component,
    M120Component,
    BHYTComponent,

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
