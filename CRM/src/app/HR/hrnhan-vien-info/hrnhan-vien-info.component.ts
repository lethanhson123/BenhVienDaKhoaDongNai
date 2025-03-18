import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { HRNhanVien } from 'src/app/shared//HRNhanVien.model';
import { HRNhanVienService } from 'src/app/shared//HRNhanVien.service';
import { HRNhanVienTapTinDinhKem } from 'src/app/shared/HRNhanVienTapTinDinhKem.model';
import { HRNhanVienTapTinDinhKemService } from 'src/app/shared/HRNhanVienTapTinDinhKem.service';
import { HRNhanVienNganHang } from 'src/app/shared/HRNhanVienNganHang.model';
import { HRNhanVienNganHangService } from 'src/app/shared/HRNhanVienNganHang.service';

import { DanhMucPhongBan } from 'src/app/shared/DanhMucPhongBan.model';
import { DanhMucPhongBanService } from 'src/app/shared/DanhMucPhongBan.service';
import { DanhMucTinhThanh } from 'src/app/shared/DanhMucTinhThanh.model';
import { DanhMucTinhThanhService } from 'src/app/shared/DanhMucTinhThanh.service';
import { DanhMucQuanHuyen } from 'src/app/shared/DanhMucQuanHuyen.model';
import { DanhMucQuanHuyenService } from 'src/app/shared/DanhMucQuanHuyen.service';
import { DanhMucXaPhuong } from 'src/app/shared/DanhMucXaPhuong.model';
import { DanhMucXaPhuongService } from 'src/app/shared/DanhMucXaPhuong.service';
import { DanhMucNganHang } from 'src/app/shared/DanhMucNganHang.model';
import { DanhMucNganHangService } from 'src/app/shared/DanhMucNganHang.service';

@Component({
  selector: 'app-hrnhan-vien-info',
  templateUrl: './hrnhan-vien-info.component.html',
  styleUrls: ['./hrnhan-vien-info.component.css']
})
export class HRNhanVienInfoComponent implements OnInit {

  @ViewChild('HRNhanVienTapTinDinhKemSort') HRNhanVienTapTinDinhKemSort: MatSort;
  @ViewChild('HRNhanVienTapTinDinhKemPaginator') HRNhanVienTapTinDinhKemPaginator: MatPaginator;

  @ViewChild('HRNhanVienNganHangSort') HRNhanVienNganHangSort: MatSort;
  @ViewChild('HRNhanVienNganHangPaginator') HRNhanVienNganHangPaginator: MatPaginator;

  constructor(
    public ActiveRouter: ActivatedRoute,
    public Router: Router,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public HRNhanVienService: HRNhanVienService,
    public HRNhanVienTapTinDinhKemService: HRNhanVienTapTinDinhKemService,
    public HRNhanVienNganHangService: HRNhanVienNganHangService,

    public DanhMucPhongBanService: DanhMucPhongBanService,
    public DanhMucTinhThanhService: DanhMucTinhThanhService,
    public DanhMucQuanHuyenService: DanhMucQuanHuyenService,
    public DanhMucXaPhuongService: DanhMucXaPhuongService,
    public DanhMucNganHangService: DanhMucNganHangService,
  ) { }

  ngOnInit(): void {
   
  }
  ngAfterViewInit() {
    this.HRNhanVienService.BaseParameter.ID = Number(this.ActiveRouter.snapshot.params.ID);
    this.HRNhanVienSearch();
  }
  DanhMucPhongBanFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.DanhMucPhongBanService.ListFilter = this.DanhMucPhongBanService.List.filter(item => item.Name.toString().toLocaleLowerCase().indexOf(searchString) !== -1 || item.Code.toLocaleLowerCase().indexOf(searchString) !== -1);
    }
    else {
      this.DanhMucPhongBanService.ListFilter = this.DanhMucPhongBanService.List;
    }
  }
  DanhMucTinhThanhFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.DanhMucTinhThanhService.ListFilter = this.DanhMucTinhThanhService.List.filter(item => item.Name.toString().toLocaleLowerCase().indexOf(searchString) !== -1 || item.Code.toLocaleLowerCase().indexOf(searchString) !== -1);
    }
    else {
      this.DanhMucTinhThanhService.ListFilter = this.DanhMucTinhThanhService.List;
    }
  }
  DanhMucQuanHuyenFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.DanhMucQuanHuyenService.ListFilter = this.DanhMucQuanHuyenService.List.filter(item => item.Name.toString().toLocaleLowerCase().indexOf(searchString) !== -1 || item.Code.toLocaleLowerCase().indexOf(searchString) !== -1);
    }
    else {
      this.DanhMucQuanHuyenService.ListFilter = this.DanhMucQuanHuyenService.List;
    }
  }
  DanhMucXaPhuongFilter(searchString: string) {
    if (searchString.length > 0) {
      searchString = searchString.trim();
      searchString = searchString.toLocaleLowerCase();
      this.DanhMucXaPhuongService.ListFilter = this.DanhMucXaPhuongService.List.filter(item => item.Name.toString().toLocaleLowerCase().indexOf(searchString) !== -1 || item.Code.toLocaleLowerCase().indexOf(searchString) !== -1);
    }
    else {
      this.DanhMucXaPhuongService.ListFilter = this.DanhMucXaPhuongService.List;
    }
  }
  DanhMucPhongBanSearch() {
    this.DanhMucPhongBanService.ComponentGetAllToListAsync(this.HRNhanVienService);
  }
  DanhMucNganHangSearch() {
    this.DanhMucNganHangService.ComponentGetAllToListAsync(this.HRNhanVienService);
  }
  DanhMucTinhThanhSearch() {
    this.DanhMucTinhThanhService.GetAllToListAsync().subscribe(
      res => {
        this.DanhMucTinhThanhService.List = (res as DanhMucTinhThanh[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        this.DanhMucTinhThanhService.ListFilter = this.DanhMucTinhThanhService.List;
        if (this.DanhMucTinhThanhService.List) {
          if (this.DanhMucTinhThanhService.List.length > 0) {
            this.DanhMucQuanHuyenSearch();
          }
        }
      },
      err => {
      },
      () => {
      }
    );
  }
  DanhMucQuanHuyenSearch() {
    this.DanhMucQuanHuyenService.BaseParameter.ParentID = this.HRNhanVienService.FormData.DanhMucTinhThanhID;
    this.DanhMucQuanHuyenService.GetByParentIDToListAsync().subscribe(
      res => {
        this.DanhMucQuanHuyenService.List = (res as DanhMucQuanHuyen[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        this.DanhMucQuanHuyenService.ListFilter = this.DanhMucQuanHuyenService.List;
        if (this.DanhMucQuanHuyenService.List) {
          if (this.DanhMucQuanHuyenService.List.length > 0) {
            this.DanhMucXaPhuongSearch();
          }
        }
      },
      err => {
      },
      () => {
      }
    );
  }
  DanhMucXaPhuongSearch() {
    this.DanhMucXaPhuongService.BaseParameter.ParentID = this.HRNhanVienService.FormData.DanhMucQuanHuyenID;
    this.DanhMucXaPhuongService.GetByParentIDToListAsync().subscribe(
      res => {
        this.DanhMucXaPhuongService.List = (res as DanhMucXaPhuong[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        this.DanhMucXaPhuongService.ListFilter = this.DanhMucXaPhuongService.List;
        if (this.DanhMucXaPhuongService.List) {
          if (this.DanhMucXaPhuongService.List.length > 0) {
          }
        }
      },
      err => {
      },
      () => {
      }
    );
  }
  HRNhanVienAdd() {
    this.Router.navigateByUrl(environment.HRNhanVienInfo + environment.InitializationNumber);
    this.HRNhanVienService.BaseParameter.ID = environment.InitializationNumber;
    this.HRNhanVienSearch();
  }
  HRNhanVienSearch() {
    this.HRNhanVienService.IsShowLoading = true;
    this.HRNhanVienService.GetByIDAsync().subscribe(
      res => {
        this.HRNhanVienService.FormData = res as HRNhanVien;
        this.DanhMucNganHangSearch();
        this.DanhMucPhongBanSearch();
        this.DanhMucTinhThanhSearch();
        this.HRNhanVienTapTinDinhKemSearch();
        this.HRNhanVienNganHangSearch();
      },
      err => {
      },
      () => {
        this.HRNhanVienService.IsShowLoading = false;
      }
    );
  }
  HRNhanVienFileNameChange(files: FileList) {
    if (files) {
      this.HRNhanVienService.FileToUpload = files;
      this.HRNhanVienService.File = files.item(0);
      var reader = new FileReader();
      reader.onload = (event: any) => {
        this.HRNhanVienService.FormData.FileName = event.target.result;
      };
      reader.readAsDataURL(this.HRNhanVienService.File);
    }
  }
  HRNhanVienSave() {
    this.HRNhanVienService.IsShowLoading = true;
    this.HRNhanVienService.SaveAndUploadFileAsync().subscribe(
      res => {
        this.HRNhanVienService.FormData = res as HRNhanVien;
        this.Router.navigateByUrl(environment.HRNhanVienInfo + this.HRNhanVienService.FormData.ID);
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.HRNhanVienService.IsShowLoading = false;
      }
    );
  }
  HRNhanVienTapTinDinhKemFileNameChange(files: FileList) {
    if (files) {
      this.HRNhanVienTapTinDinhKemService.FileToUpload = files;     
    }
  }
  HRNhanVienTapTinDinhKemSearch() {
    this.HRNhanVienTapTinDinhKemService.BaseParameter.ParentID = this.HRNhanVienService.FormData.ID;
    this.HRNhanVienTapTinDinhKemService.SearchByParentID(this.HRNhanVienTapTinDinhKemSort, this.HRNhanVienTapTinDinhKemPaginator, this.HRNhanVienService);
  }
  HRNhanVienTapTinDinhKemSave(element: HRNhanVienTapTinDinhKem) {
    element.ParentID = this.HRNhanVienService.FormData.ID;
    this.HRNhanVienTapTinDinhKemService.FormData = element;
    this.NotificationService.warn(this.HRNhanVienTapTinDinhKemService.ComponentSaveByParentID(this.HRNhanVienTapTinDinhKemSort, this.HRNhanVienTapTinDinhKemPaginator, this.HRNhanVienService));
  }
  HRNhanVienTapTinDinhKemDelete(element: HRNhanVienTapTinDinhKem) {
    element.ParentID = this.HRNhanVienService.FormData.ID;
    this.HRNhanVienTapTinDinhKemService.FormData = element;
    this.NotificationService.warn(this.HRNhanVienTapTinDinhKemService.ComponentDeleteByParentID(this.HRNhanVienTapTinDinhKemSort, this.HRNhanVienTapTinDinhKemPaginator, this.HRNhanVienService));
  }
  HRNhanVienNganHangSearch() {
    this.HRNhanVienNganHangService.BaseParameter.ParentID = this.HRNhanVienService.FormData.ID;
    this.HRNhanVienNganHangService.SearchByParentID(this.HRNhanVienNganHangSort, this.HRNhanVienNganHangPaginator, this.HRNhanVienService);
  }
  HRNhanVienNganHangSave(element: HRNhanVienNganHang) {
    element.ParentID = this.HRNhanVienService.FormData.ID;
    this.HRNhanVienNganHangService.FormData = element;
    this.NotificationService.warn(this.HRNhanVienNganHangService.ComponentSaveByParentID(this.HRNhanVienNganHangSort, this.HRNhanVienNganHangPaginator, this.HRNhanVienService));
  }
  HRNhanVienNganHangDelete(element: HRNhanVienNganHang) {
    element.ParentID = this.HRNhanVienService.FormData.ID;
    this.HRNhanVienNganHangService.FormData = element;
    this.NotificationService.warn(this.HRNhanVienNganHangService.ComponentDeleteByParentID(this.HRNhanVienNganHangSort, this.HRNhanVienNganHangPaginator, this.HRNhanVienService));
  }
}