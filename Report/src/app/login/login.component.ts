import { Component, OnInit, Inject, ElementRef, ViewChild, Renderer2 } from '@angular/core';
import { Router, NavigationEnd } from '@angular/router';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { ThanhVien } from 'src/app/shared/ThanhVien.model';
import { ThanhVienService } from 'src/app/shared/ThanhVien.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  PageTitle: string = environment.PageTitle;
  PageDescription: string = environment.PageDescription;
  MatKhauIsActive: boolean = true;
  private bodyClickListener?: () => void;
  constructor(
    private Renderer: Renderer2,
    public Router: Router,
    public NotificationService: NotificationService,
    public ThanhVienService: ThanhVienService,
  ) { }

  ngOnInit(): void {
    this.GetByQueryString();
    this.BodyListener();
  }

  ngOnDestroy(): void {

  }
  MatKhauChangeType() {
    this.MatKhauIsActive = !this.MatKhauIsActive;
  }
  BodyListener() {
    this.bodyClickListener = this.Renderer.listen(
      document.body,
      'keyup',
      (event) => {
        if (event) {
          if (event["keyCode"] == 13) {
            this.Login();
          }
        }
      }
    );
  }
  GetByQueryString() {
    //this.ThanhVienService.IsShowLoading = true;
    this.ThanhVienService.BaseParameter.ID = environment.InitializationNumber;
    this.ThanhVienService.GetByIDAsync().subscribe(
      res => {
        this.ThanhVienService.FormData = res as ThanhVien;
        if (this.ThanhVienService.FormData.DanhMucUngDungID == null) {
          this.ThanhVienService.FormData.DanhMucUngDungID = environment.DanhMucUngDungID;
        }
      },
      err => {
      },
      () => {
        //this.ThanhVienService.IsShowLoading = false;
      }
    );
  }
  Login() {
    this.ThanhVienService.IsShowLoading = true;
    if (this.ThanhVienService.FormData.DanhMucUngDungID == null) {
      this.ThanhVienService.FormData.DanhMucUngDungID = environment.DanhMucUngDungID;
    }
    this.ThanhVienService.AuthenticationAsync().subscribe(
      res => {
        this.ThanhVienService.FormDataLogin = res as ThanhVien;
        if (this.ThanhVienService.FormDataLogin) {
          if (this.ThanhVienService.FormDataLogin.HTMLContent) {            
            localStorage.setItem(environment.Token, this.ThanhVienService.FormDataLogin.HTMLContent);
            localStorage.setItem(environment.ThanhVienID, this.ThanhVienService.FormDataLogin.ID.toString());
            localStorage.setItem(environment.ThanhVienParentID, this.ThanhVienService.FormDataLogin.ParentID.toString());
            localStorage.setItem(environment.ThanhVienTaiKhoan, this.ThanhVienService.FormDataLogin.TaiKhoan);
            localStorage.setItem(environment.ThanhVienHoTen, this.ThanhVienService.FormDataLogin.Name);
            localStorage.setItem(environment.ThanhVienFileName, this.ThanhVienService.FormDataLogin.FileName);
            this.Router.navigate(['/' + environment.Homepage]);
          }
          else {
            this.NotificationService.success(environment.LoginNotSuccess);
          }
        }
      },
      err => {
        this.NotificationService.warn(environment.LoginNotSuccess);
      },
      () => {
        this.ThanhVienService.IsShowLoading = false;
      }
    );
  }
}