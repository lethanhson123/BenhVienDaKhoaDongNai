import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucThanhVien } from 'src/app/shared/DanhMucThanhVien.model';
import { DanhMucThanhVienService } from 'src/app/shared/DanhMucThanhVien.service';
import { DanhMucBenhVien } from 'src/app/shared/DanhMucBenhVien.model';
import { DanhMucBenhVienService } from 'src/app/shared/DanhMucBenhVien.service';
import { DanhMucPhongBan } from 'src/app/shared/DanhMucPhongBan.model';
import { DanhMucPhongBanService } from 'src/app/shared/DanhMucPhongBan.service';
import { DanhMucChucDanh } from 'src/app/shared/DanhMucChucDanh.model';
import { DanhMucChucDanhService } from 'src/app/shared/DanhMucChucDanh.service';

import { ThanhVien } from 'src/app/shared/ThanhVien.model';
import { ThanhVienService } from 'src/app/shared/ThanhVien.service';
import { ThanhVienChucNang } from 'src/app/shared/ThanhVienChucNang.model';
import { ThanhVienChucNangService } from 'src/app/shared/ThanhVienChucNang.service';
import { ThanhVienUngDung } from 'src/app/shared/ThanhVienUngDung.model';
import { ThanhVienUngDungService } from 'src/app/shared/ThanhVienUngDung.service';
import { ThanhVienDichVu } from 'src/app/shared/ThanhVienDichVu.model';
import { ThanhVienDichVuService } from 'src/app/shared/ThanhVienDichVu.service';
import { ThanhVienQuayDichVu } from 'src/app/shared/ThanhVienQuayDichVu.model';
import { ThanhVienQuayDichVuService } from 'src/app/shared/ThanhVienQuayDichVu.service';


@Component({
  selector: 'app-thanh-vien-info',
  templateUrl: './thanh-vien-info.component.html',
  styleUrls: ['./thanh-vien-info.component.css']
})
export class ThanhVienInfoComponent implements OnInit {

  @ViewChild('ThanhVienChucNangSort') ThanhVienChucNangSort: MatSort;
  @ViewChild('ThanhVienChucNangPaginator') ThanhVienChucNangPaginator: MatPaginator;

  @ViewChild('ThanhVienUngDungSort') ThanhVienUngDungSort: MatSort;
  @ViewChild('ThanhVienUngDungPaginator') ThanhVienUngDungPaginator: MatPaginator;

  @ViewChild('ThanhVienDichVuSort') ThanhVienDichVuSort: MatSort;
  @ViewChild('ThanhVienDichVuPaginator') ThanhVienDichVuPaginator: MatPaginator;

  @ViewChild('ThanhVienQuayDichVuSort') ThanhVienQuayDichVuSort: MatSort;
  @ViewChild('ThanhVienQuayDichVuPaginator') ThanhVienQuayDichVuPaginator: MatPaginator;

  IsThanhVienChucNangActiveAll: boolean = false;

  IsThanhVienUngDungActiveAll: boolean = false;

  MatKhauIsActive: boolean = true;

  constructor(
    public ActiveRouter: ActivatedRoute,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucThanhVienService: DanhMucThanhVienService,
    public DanhMucBenhVienService: DanhMucBenhVienService,
    public DanhMucPhongBanService: DanhMucPhongBanService,
    public DanhMucChucDanhService: DanhMucChucDanhService,

    public ThanhVienService: ThanhVienService,
    public ThanhVienChucNangService: ThanhVienChucNangService,
    public ThanhVienUngDungService: ThanhVienUngDungService,
    public ThanhVienDichVuService: ThanhVienDichVuService,
    public ThanhVienQuayDichVuService: ThanhVienQuayDichVuService,
  ) { }

  ngOnInit(): void {
    this.ThanhVienService.BaseParameter.ID = Number(this.ActiveRouter.snapshot.params.ID);
    this.ThanhVienSearch();
  }
  MatKhauChangeType() {
    this.MatKhauIsActive = !this.MatKhauIsActive;
  }
  DanhMucThanhVienSearch() {
    this.DanhMucThanhVienService.ComponentGetAllToListAsync(this.ThanhVienService);
  }
  DanhMucBenhVienSearch() {
    this.DanhMucBenhVienService.ComponentGetAllToListAsync(this.ThanhVienService);
  }
  DanhMucPhongBanSearch() {
    this.DanhMucPhongBanService.ComponentGetAllToListAsync(this.ThanhVienService);
  }
  DanhMucChucDanhSearch() {
    this.DanhMucChucDanhService.ComponentGetAllToListAsync(this.ThanhVienService);
  }
  ThanhVienSearch() {
    this.ThanhVienService.GetByIDAsync().subscribe(
      res => {
        this.ThanhVienService.FormData = res as ThanhVien;
        if (this.ThanhVienService.FormData.ID == environment.InitializationNumber) {
        }
        this.DanhMucThanhVienSearch();
        this.DanhMucBenhVienSearch();
        this.DanhMucPhongBanSearch();
        this.DanhMucChucDanhSearch();
        this.ThanhVienChucNangSearch();  
        this.ThanhVienUngDungSearch();        
      },
      err => {
      }
    );
  }
  ThanhVienSave() {
    this.ThanhVienService.IsShowLoading = true;
    this.ThanhVienService.SaveAsync().subscribe(
      res => {
        this.ThanhVienService.FormData = res as ThanhVien;
        this.ThanhVienSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.ThanhVienService.IsShowLoading = false;
      }
    );
  }

  ThanhVienChucNangSearch() {
    if (this.ThanhVienChucNangService.BaseParameter.SearchString.length > 0) {
      this.ThanhVienChucNangService.DataSource.filter = this.ThanhVienChucNangService.BaseParameter.SearchString.toLowerCase();
    }
    else {
      this.ThanhVienService.IsShowLoading = true;
      this.ThanhVienChucNangService.BaseParameter.ParentID = this.ThanhVienService.FormData.ID;
      this.ThanhVienChucNangService.GetSQLByParentIDToListAsync().subscribe(
        res => {
          this.ThanhVienChucNangService.List = (res as ThanhVienChucNang[]);
          this.ThanhVienChucNangService.DataSource = new MatTableDataSource(this.ThanhVienChucNangService.List);
          this.ThanhVienChucNangService.DataSource.sort = this.ThanhVienChucNangSort;
          this.ThanhVienChucNangService.DataSource.paginator = this.ThanhVienChucNangPaginator;
        },
        err => {
        },
        () => {
          this.ThanhVienService.IsShowLoading = false;
        }
      );
    }
  }
  ThanhVienChucNangActiveChange(element: ThanhVienChucNang) {
    this.ThanhVienService.IsShowLoading = true;
    this.ThanhVienChucNangService.FormData = element;
    this.ThanhVienChucNangService.FormData.ParentID = this.ThanhVienService.FormData.ID;
    this.ThanhVienChucNangService.SaveAsync().subscribe(
      res => {
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.ThanhVienService.IsShowLoading = false;
      }
    );
  }
  ThanhVienChucNangActiveAllChange() {
    this.ThanhVienService.IsShowLoading = true;
    for (let i = 0; i < this.ThanhVienChucNangService.List.length; i++) {
      this.ThanhVienChucNangService.FormData = this.ThanhVienChucNangService.List[i];
      this.ThanhVienChucNangService.FormData.ParentID = this.ThanhVienService.FormData.ID;
      this.ThanhVienChucNangService.FormData.Active = this.IsThanhVienChucNangActiveAll;
    }
    this.ThanhVienChucNangService.SaveListAsync(this.ThanhVienChucNangService.List).subscribe(
      res => {
        this.ThanhVienChucNangSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.ThanhVienService.IsShowLoading = false;
      }
    );
  }

  ThanhVienUngDungSearch() {
    if (this.ThanhVienUngDungService.BaseParameter.SearchString.length > 0) {
      this.ThanhVienUngDungService.DataSource.filter = this.ThanhVienUngDungService.BaseParameter.SearchString.toLowerCase();
    }
    else {
      this.ThanhVienService.IsShowLoading = true;
      this.ThanhVienUngDungService.BaseParameter.ParentID = this.ThanhVienService.FormData.ID;
      this.ThanhVienUngDungService.GetSQLByParentIDToListAsync().subscribe(
        res => {
          this.ThanhVienUngDungService.List = (res as ThanhVienUngDung[]);
          this.ThanhVienUngDungService.DataSource = new MatTableDataSource(this.ThanhVienUngDungService.List);
          this.ThanhVienUngDungService.DataSource.sort = this.ThanhVienUngDungSort;
          this.ThanhVienUngDungService.DataSource.paginator = this.ThanhVienUngDungPaginator;
        },
        err => {
        },
        () => {
          this.ThanhVienService.IsShowLoading = false;
        }
      );
    }
  }
  ThanhVienUngDungActiveChange(element: ThanhVienUngDung) {
    this.ThanhVienService.IsShowLoading = true;
    this.ThanhVienUngDungService.FormData = element;
    this.ThanhVienUngDungService.FormData.ParentID = this.ThanhVienService.FormData.ID;
    this.ThanhVienUngDungService.SaveAsync().subscribe(
      res => {
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.ThanhVienService.IsShowLoading = false;
      }
    );
  }
  ThanhVienUngDungActiveAllChange() {
    this.ThanhVienService.IsShowLoading = true;
    for (let i = 0; i < this.ThanhVienUngDungService.List.length; i++) {
      this.ThanhVienUngDungService.FormData = this.ThanhVienUngDungService.List[i];
      this.ThanhVienUngDungService.FormData.ParentID = this.ThanhVienService.FormData.ID;
      this.ThanhVienUngDungService.FormData.Active = this.IsThanhVienUngDungActiveAll;
    }
    this.ThanhVienUngDungService.SaveListAsync(this.ThanhVienUngDungService.List).subscribe(
      res => {
        this.ThanhVienUngDungSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.ThanhVienService.IsShowLoading = false;
      }
    );
  }
}