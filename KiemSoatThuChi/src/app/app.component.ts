import { Component } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { DomSanitizer } from '@angular/platform-browser';
import { environment } from 'src/environments/environment';
import { Router, NavigationEnd } from '@angular/router';
import { DownloadService } from 'src/app/shared/Download.service';
import { NotificationService } from 'src/app/shared/Notification.service';

import { DanhMucChucNang } from 'src/app/shared/DanhMucChucNang.model';
import { DanhMucChucNangService } from 'src/app/shared/DanhMucChucNang.service';

import { ThanhVien } from 'src/app/shared/ThanhVien.model';
import { ThanhVienService } from 'src/app/shared/ThanhVien.service';
import { ThanhVienToken } from 'src/app/shared/ThanhVienToken.model';
import { ThanhVienTokenService } from 'src/app/shared/ThanhVienToken.service';
import { ThanhVienLichSuTruyCap } from 'src/app/shared/ThanhVienLichSuTruyCap.model';
import { ThanhVienLichSuTruyCapService } from 'src/app/shared/ThanhVienLichSuTruyCap.service';



@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  PageTitle = environment.PageTitle;
  PageDescription = environment.PageDescription;
  PageTitleShort = environment.PageTitleShort;
  domainName = environment.DomainDestination;
  domainURL = environment.DomainURL;
  queryString: string = environment.InitializationString;
  queryStringSub: string = environment.InitializationString;
  Token: string = environment.InitializationString;
  constructor(
    public Sanitizer: DomSanitizer,
    public Router: Router,
    public DownloadService: DownloadService,
    public NotificationService: NotificationService,

    public DanhMucChucNangService: DanhMucChucNangService,

    public ThanhVienService: ThanhVienService,
    public ThanhVienTokenService: ThanhVienTokenService,
    public ThanhVienLichSuTruyCapService: ThanhVienLichSuTruyCapService,

  ) {
    this.GetByQueryString();
  }
  ngAfterViewInit() {
  }

  GetByQueryString() {
    this.Router.events.forEach((event) => {
      if (event instanceof NavigationEnd) {
        this.queryString = event.url;
        if (this.queryString.indexOf(environment.Token) > -1) {
          localStorage.setItem(environment.Token, this.queryString.split('=')[this.queryString.split('=').length - 1]);
        }
        this.AuthenticationToken();
      }
    });
  }
  AuthenticationToken() {
    this.Token = localStorage.getItem(environment.Token);
    let isLogin = true;
    if (this.Token == null) {
      isLogin = false;
    }
    else {
      this.ThanhVienTokenService.BaseParameter.Token = this.Token;
      this.ThanhVienTokenService.AuthenticationByTokenAsync().subscribe(
        res => {
          this.ThanhVienTokenService.FormData = res as ThanhVienToken;
          if (this.ThanhVienTokenService.FormData != null) {
            if (this.ThanhVienTokenService.FormData.ParentID > 0) {
              this.ThanhVienService.BaseParameter.ID = this.ThanhVienTokenService.FormData.ParentID;
              let Bearer = this.ThanhVienService.Headers.getAll("Authorization")[0];
              if (Bearer == environment.Bearer) {
                this.ThanhVienService.Headers = new HttpHeaders();
                this.ThanhVienService.Headers = this.ThanhVienService.Headers.append('Authorization', 'Bearer ' + this.Token);
              }
              this.ThanhVienService.GetByIDAsync().subscribe(
                res => {
                  this.ThanhVienService.FormDataLogin = res as ThanhVien;
                  if (this.ThanhVienService.FormDataLogin) {
                    if (this.ThanhVienService.FormDataLogin.ParentID == null) {
                      this.ThanhVienService.FormDataLogin.ParentID = environment.InitializationNumber;
                    }
                    localStorage.setItem(environment.ThanhVienID, this.ThanhVienService.FormDataLogin.ID.toString());
                    localStorage.setItem(environment.ThanhVienParentID, this.ThanhVienService.FormDataLogin.ParentID.toString());
                    localStorage.setItem(environment.ThanhVienTaiKhoan, this.ThanhVienService.FormDataLogin.TaiKhoan);
                    localStorage.setItem(environment.ThanhVienHoTen, this.ThanhVienService.FormDataLogin.Name);
                    localStorage.setItem(environment.ThanhVienFileName, this.ThanhVienService.FormDataLogin.FileName);
                    this.DanhMucChucNangGetByThanhVienIDToListAsync();
                    //this.ThanhVienLichSuTruyCapSaveNewAsync(this.queryString);
                    //this.GetByParentID_ReadJSONFileToListAsync();
                    //this.StartTimer();
                  }
                  else {
                    isLogin = false;
                    if (isLogin == false) {
                      this.Router.navigate(['/' + environment.Login]);
                    }
                  }
                },
                err => {
                  isLogin = false;
                  if (isLogin == false) {
                    this.Router.navigate(['/' + environment.Login]);
                  }
                }
              );
            }
            else {
              isLogin = false;
              if (isLogin == false) {
                this.Router.navigate(['/' + environment.Login]);
              }
            }
          }
          else {
            isLogin = false;
            if (isLogin == false) {
              this.Router.navigate(['/' + environment.Login]);
            }
          }
        },
        err => {
          isLogin = false;
          if (isLogin == false) {
            this.Router.navigate(['/' + environment.Login]);
          }
        }
      );
    }
    if (isLogin == false) {
      this.Router.navigate(['/' + environment.Login]);
    }
  }
  DanhMucChucNangGetByThanhVienIDToListAsync() {
    if (this.queryString) {
      if (this.queryString.length > 0) {
        this.queryStringSub = this.queryString.substring(1, this.queryString.length);
      }
    }
    let Bearer = this.DanhMucChucNangService.Headers.getAll("Authorization")[0];
    if (Bearer == environment.Bearer) {
      this.DanhMucChucNangService.Headers = new HttpHeaders();
      this.DanhMucChucNangService.Headers = this.DanhMucChucNangService.Headers.append('Authorization', 'Bearer ' + this.Token);
    }
    this.DanhMucChucNangService.GetSQLByThanhVienID_ActiveToListAsync().subscribe(
      res => {
        this.DanhMucChucNangService.ListChild = (res as DanhMucChucNang[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        this.DanhMucChucNangService.ListParent = [];
        let isLogin = false;
        for (var i = 0; i < this.DanhMucChucNangService.ListChild.length; i++) {
          if (this.queryStringSub == this.DanhMucChucNangService.ListChild[i].Code) {
            this.DanhMucChucNangService.ListChild[i].Active = true;
          }
          else {
            this.DanhMucChucNangService.ListChild[i].Active = false;
          }
          if (this.queryStringSub.indexOf(this.DanhMucChucNangService.ListChild[i].Code) > -1) {
            isLogin = true;
          }
          this.DanhMucChucNangService.ListChild[i].Code = environment.DomainDestination + this.DanhMucChucNangService.ListChild[i].Code;
        }
        for (var i = 0; i < this.DanhMucChucNangService.ListChild.length; i++) {
          if (this.DanhMucChucNangService.ListChild[i].ParentID == 0) {
            this.DanhMucChucNangService.ListChild[i].Active = false;
            this.DanhMucChucNangService.ListChild[i].ListChild = [];
            for (var j = 0; j < this.DanhMucChucNangService.ListChild.length; j++) {
              if (this.DanhMucChucNangService.ListChild[i].ID == this.DanhMucChucNangService.ListChild[j].ParentID) {
                this.DanhMucChucNangService.ListChild[i].ListChild.push(this.DanhMucChucNangService.ListChild[j]);
                if (this.DanhMucChucNangService.ListChild[j].Active == true) {
                  this.DanhMucChucNangService.ListChild[i].Active = true;
                }
              }
            }
            this.DanhMucChucNangService.ListParent.push(this.DanhMucChucNangService.ListChild[i]);
          }
        }
        if (this.queryStringSub.indexOf("Info") > -1) {
          isLogin = true;
        }
        if (this.queryStringSub.indexOf("ThanhVienThongTin") > -1) {
          isLogin = true;
        }
        if (this.queryStringSub.indexOf("Homepage") > -1) {
          isLogin = true;
        }
        if (this.queryStringSub.indexOf("GioiThieu") > -1) {
          isLogin = true;
        }
        if (isLogin == false) {
          this.Router.navigate(['/' + environment.Login]);
        }
      },
      err => {
      }
    );
  }
  ThanhVienLichSuTruyCapSaveAsync(url: string) {
    url = environment.DomainURL + "#" + url;
    this.ThanhVienLichSuTruyCapService.FormData.URL = url;
    this.ThanhVienLichSuTruyCapService.FormData.Name = this.ThanhVienService.FormDataLogin.Name;
    this.ThanhVienLichSuTruyCapService.FormData.Code = this.ThanhVienService.FormDataLogin.TaiKhoan;
    this.ThanhVienLichSuTruyCapService.FormData.Token = this.Token;
    this.ThanhVienLichSuTruyCapService.FormData.ParentID = this.ThanhVienService.FormDataLogin.ID;


    this.DownloadService.GetIPAddress().then(res => {
      this.DownloadService.IPAddress = res["ip"];
      this.ThanhVienLichSuTruyCapService.FormData.Description = this.DownloadService.IPAddress;

      let Bearer = this.ThanhVienLichSuTruyCapService.Headers.getAll("Authorization")[0];
      if (Bearer == environment.Bearer) {
        this.ThanhVienLichSuTruyCapService.Headers = new HttpHeaders();
        this.ThanhVienLichSuTruyCapService.Headers = this.ThanhVienLichSuTruyCapService.Headers.append('Authorization', 'Bearer ' + this.Token);
      }
      this.ThanhVienLichSuTruyCapService.SaveAsync().subscribe(
        res => {
        },
        err => {
        }
      );
    }).catch(error => {
      this.ThanhVienLichSuTruyCapService.SaveAsync().subscribe(
        res => {
        },
        err => {
        }
      );
    });
  }

  ThanhVienLichSuTruyCapSaveNewAsync(url: string) {
    url = environment.DomainURL + "#" + url;
    this.ThanhVienLichSuTruyCapService.FormData.URL = url;
    this.ThanhVienLichSuTruyCapService.FormData.Name = this.ThanhVienService.FormDataLogin.Name;
    this.ThanhVienLichSuTruyCapService.FormData.Code = this.ThanhVienService.FormDataLogin.TaiKhoan;
    this.ThanhVienLichSuTruyCapService.FormData.Token = this.Token;
    this.ThanhVienLichSuTruyCapService.FormData.ParentID = this.ThanhVienService.FormDataLogin.ID;
    this.ThanhVienLichSuTruyCapService.FormData.IPAddress = localStorage.getItem(environment.IPRegistryIP);

    if ((this.ThanhVienLichSuTruyCapService.FormData.IPAddress == null) || (this.ThanhVienLichSuTruyCapService.FormData.IPAddress.length == 0)) {

      this.DownloadService.GetIPData().then(res => {
        this.ThanhVienLichSuTruyCapService.FormData.IPAddress = res["ip"];
        this.ThanhVienLichSuTruyCapService.FormData.TypeName = res["user_agent"]["device"]["type"];
        this.ThanhVienLichSuTruyCapService.FormData.KinhDo = res["location"]["longitude"];
        this.ThanhVienLichSuTruyCapService.FormData.ViDo = res["location"]["latitude"];
        this.ThanhVienLichSuTruyCapService.FormData.DanhMucQuocGiaName = res["location"]["country"]["name"];
        this.ThanhVienLichSuTruyCapService.FormData.DanhMucTinhThanhName = res["location"]["region"]["name"];
        this.ThanhVienLichSuTruyCapService.FormData.DanhMucQuanHuyenName = res["location"]["city"];

        localStorage.setItem(environment.IPRegistryIP, this.ThanhVienLichSuTruyCapService.FormData.IPAddress);
        localStorage.setItem(environment.IPRegistryDevice, this.ThanhVienLichSuTruyCapService.FormData.TypeName);
        localStorage.setItem(environment.IPRegistryLongitude, this.ThanhVienLichSuTruyCapService.FormData.KinhDo);
        localStorage.setItem(environment.IPRegistryLatitude, this.ThanhVienLichSuTruyCapService.FormData.ViDo);
        localStorage.setItem(environment.IPRegistryCountryName, this.ThanhVienLichSuTruyCapService.FormData.DanhMucQuocGiaName);
        localStorage.setItem(environment.IPRegistryRegionName, this.ThanhVienLichSuTruyCapService.FormData.DanhMucTinhThanhName);
        localStorage.setItem(environment.IPRegistryCityName, this.ThanhVienLichSuTruyCapService.FormData.DanhMucQuanHuyenName);

      }).catch(error => {
      }).finally(() => {
        this.ThanhVienLichSuTruyCapService.SaveAsync().subscribe(
          res => {
          },
          err => {
          }
        );
      });

    }
    else {
      this.ThanhVienLichSuTruyCapService.FormData.IPAddress = localStorage.getItem(environment.IPRegistryIP);
      this.ThanhVienLichSuTruyCapService.FormData.TypeName = localStorage.getItem(environment.IPRegistryDevice);
      this.ThanhVienLichSuTruyCapService.FormData.KinhDo = localStorage.getItem(environment.IPRegistryLongitude);
      this.ThanhVienLichSuTruyCapService.FormData.ViDo = localStorage.getItem(environment.IPRegistryLatitude);
      this.ThanhVienLichSuTruyCapService.FormData.DanhMucQuocGiaName = localStorage.getItem(environment.IPRegistryCountryName);
      this.ThanhVienLichSuTruyCapService.FormData.DanhMucTinhThanhName = localStorage.getItem(environment.IPRegistryRegionName);
      this.ThanhVienLichSuTruyCapService.FormData.DanhMucQuanHuyenName = localStorage.getItem(environment.IPRegistryCityName);
      this.ThanhVienLichSuTruyCapService.SaveAsync().subscribe(
        res => {
        },
        err => {
        }
      );
    }

  }

  MenuClick(itemParent: DanhMucChucNang) {
    for (var i = 0; i < this.DanhMucChucNangService.ListParent.length; i++) {
      this.DanhMucChucNangService.ListParent[i].CSS = 'display: none;';
      this.DanhMucChucNangService.ListParent[i].CSS = this.Sanitizer.bypassSecurityTrustStyle(this.DanhMucChucNangService.ListParent[i].CSS);
      this.DanhMucChucNangService.ListParent[i].CSSMobile = 'display: none;';
      this.DanhMucChucNangService.ListParent[i].CSSMobile = this.Sanitizer.bypassSecurityTrustStyle(this.DanhMucChucNangService.ListParent[i].CSSMobile);
      let left = 130 * i;
      let height = itemParent.ListChild.length * 44;
      if (itemParent.ID == this.DanhMucChucNangService.ListParent[i].ID) {
        itemParent.Active = !itemParent.Active;
        if (itemParent.Active == true) {
          itemParent.CSS = "transform-origin: 100% 0px; opacity: 1; transform: scaleX(1) scaleY(1); display: block; width: 300px; height: " + height + "px; top: 64px; left: " + left + "px;";
          itemParent.CSS = this.Sanitizer.bypassSecurityTrustStyle(itemParent.CSS);

          itemParent.CSSMobile = "display: block;";
          itemParent.CSSMobile = this.Sanitizer.bypassSecurityTrustStyle(itemParent.CSSMobile);
        }
      }
    }
  }

  Logout() {
    localStorage.setItem(environment.Token, environment.InitializationString);
    localStorage.setItem(environment.ThanhVienID, environment.InitializationString);
    this.Router.navigate(['/' + environment.Login]);
  }
  interval;
  StartTimer() {
    this.interval = setInterval(() => {
      this.GetByParentID_ReadJSONFileToListAsync();
    }, environment.Interval)
  }
  GetByParentID_ReadJSONFileToListAsync() {
  }
}