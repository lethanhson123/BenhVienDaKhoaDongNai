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
import { LoginComponent } from './login/login.component';
import { DanhMucBenhVienComponent } from './danh-muc-benh-vien/danh-muc-benh-vien.component';
import { DanhMucPhongBanComponent } from './danh-muc-phong-ban/danh-muc-phong-ban.component';
import { DanhMucChucDanhComponent } from './danh-muc-chuc-danh/danh-muc-chuc-danh.component';
import { DanhMucChucNangComponent } from './danh-muc-chuc-nang/danh-muc-chuc-nang.component';
import { ThanhVienComponent } from './thanh-vien/thanh-vien.component';
import { ThanhVienDetailComponent } from './thanh-vien-detail/thanh-vien-detail.component';
import { DanhMucThanhVienComponent } from './danh-muc-thanh-vien/danh-muc-thanh-vien.component';
import { CongViecComponent } from './cong-viec/cong-viec.component';
import { CongViecDetailComponent } from './cong-viec-detail/cong-viec-detail.component';
import { DanhMucTinhTrangComponent } from './danh-muc-tinh-trang/danh-muc-tinh-trang.component';
import { GioiThieuComponent } from './gioi-thieu/gioi-thieu.component';
import { CongViec001Component } from './cong-viec001/cong-viec001.component';
import { CongViecDetail001Component } from './cong-viec-detail001/cong-viec-detail001.component';
import { CongViec002Component } from './cong-viec002/cong-viec002.component';
import { CongViec002DetailComponent } from './cong-viec002-detail/cong-viec002-detail.component';
import { CongViec003Component } from './cong-viec003/cong-viec003.component';
import { CongViec003DetailComponent } from './cong-viec003-detail/cong-viec003-detail.component';
import { DanhMucBieuMauComponent } from './danh-muc-bieu-mau/danh-muc-bieu-mau.component';
import { DanhMucHinhThucThanhToanComponent } from './danh-muc-hinh-thuc-thanh-toan/danh-muc-hinh-thuc-thanh-toan.component';
import { ToChucComponent } from './to-chuc/to-chuc.component';
import { ToChucDetailComponent } from './to-chuc-detail/to-chuc-detail.component';
import { DuAnComponent } from './du-an/du-an.component';
import { DuAnDetailComponent } from './du-an-detail/du-an-detail.component';
import { DanhMucBieuMauDetailComponent } from './danh-muc-bieu-mau-detail/danh-muc-bieu-mau-detail.component';
import { DuAnThuChiDetailComponent } from './du-an-thu-chi-detail/du-an-thu-chi-detail.component';
import { DuAnQuyetDinhDetailComponent } from './du-an-quyet-dinh-detail/du-an-quyet-dinh-detail.component';
import { DuAn001Component } from './du-an001/du-an001.component';
import { DuAnInfoComponent } from './du-an-info/du-an-info.component';
import { DuAnQuyetDinhInfoComponent } from './du-an-quyet-dinh-info/du-an-quyet-dinh-info.component';
import { DuAnThuChiInfoComponent } from './du-an-thu-chi-info/du-an-thu-chi-info.component';




@NgModule({
  declarations: [
    AppComponent,
    LoadingComponent,
    HomepageComponent,
    LoginComponent,
    DanhMucBenhVienComponent,
    DanhMucPhongBanComponent,
    DanhMucChucDanhComponent,
    DanhMucChucNangComponent,
    ThanhVienComponent,
    ThanhVienDetailComponent,
    DanhMucThanhVienComponent,
    CongViecComponent,
    CongViecDetailComponent,
    DanhMucTinhTrangComponent,
    GioiThieuComponent,
    CongViec001Component,
    CongViecDetail001Component,
    CongViec002Component,
    CongViec002DetailComponent,
    CongViec003Component,
    CongViec003DetailComponent,
    DanhMucBieuMauComponent,
    DanhMucHinhThucThanhToanComponent,
    ToChucComponent,
    ToChucDetailComponent,
    DuAnComponent,
    DuAnDetailComponent,
    DanhMucBieuMauDetailComponent,
    DuAnThuChiDetailComponent,
    DuAnQuyetDinhDetailComponent,
    DuAn001Component,
    DuAnInfoComponent,
    DuAnQuyetDinhInfoComponent,
    DuAnThuChiInfoComponent,    
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
