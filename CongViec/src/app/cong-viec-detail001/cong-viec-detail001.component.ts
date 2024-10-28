import { Component, OnInit, Inject, ElementRef, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';
import { from } from 'rxjs';
import { distinct } from 'rxjs/operators';

import { DanhMucPhongBan } from 'src/app/shared/DanhMucPhongBan.model';
import { DanhMucPhongBanService } from 'src/app/shared/DanhMucPhongBan.service';
import { DanhMucTinhTrang } from 'src/app/shared/DanhMucTinhTrang.model';
import { DanhMucTinhTrangService } from 'src/app/shared/DanhMucTinhTrang.service';

import { ThanhVien } from 'src/app/shared/ThanhVien.model';
import { ThanhVienService } from 'src/app/shared/ThanhVien.service';

import { CongViec } from 'src/app/shared/CongViec.model';
import { CongViecService } from 'src/app/shared/CongViec.service';
import { CongViecTapTinDinhKem } from 'src/app/shared/CongViecTapTinDinhKem.model';
import { CongViecTapTinDinhKemService } from 'src/app/shared/CongViecTapTinDinhKem.service';

@Component({
  selector: 'app-cong-viec-detail001',
  templateUrl: './cong-viec-detail001.component.html',
  styleUrls: ['./cong-viec-detail001.component.css']
})
export class CongViecDetail001Component implements OnInit {

  @ViewChild('CongViecTapTinDinhKemSort') CongViecTapTinDinhKemSort: MatSort;
  @ViewChild('CongViecTapTinDinhKemPaginator') CongViecTapTinDinhKemPaginator: MatPaginator;

  constructor(
    private Dialog: MatDialog,
    public DialogRef: MatDialogRef<CongViecDetail001Component>,
    @Inject(MAT_DIALOG_DATA) public data: any,

    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucPhongBanService: DanhMucPhongBanService,
    public DanhMucTinhTrangService: DanhMucTinhTrangService,

    public ThanhVienService: ThanhVienService,

    public CongViecService: CongViecService,
    public CongViecTapTinDinhKemService: CongViecTapTinDinhKemService,

  ) { }

  ngOnInit(): void {
    this.CongViecSearch();
  }
  Close() {
    this.DialogRef.close();
  }
  DateNgayYeuCau(value) {
    this.CongViecService.FormData.NgayYeuCau = new Date(value);
  }
  DateNgayHoanThanh(value) {
    this.CongViecService.FormData.NgayHoanThanh = new Date(value);
  }
  DanhMucPhongBanSearch() {
    this.DanhMucPhongBanService.ComponentGetAllToListAsync(this.CongViecService);
  }
  DanhMucTinhTrangSearch() {
    this.DanhMucTinhTrangService.ComponentGetAllToListAsync(this.CongViecService);
  }
  ThanhVienSearch() {
    this.ThanhVienService.ComponentGetAllToListAsync(this.CongViecService);
  }

  CongViecSearch() {
    this.CongViecService.GetByIDAsync().subscribe(
      res => {
        this.CongViecService.FormData = res as CongViec;
        if (this.CongViecService.FormData.ID == environment.InitializationNumber) {
          var ThanhVienID = localStorage.getItem(environment.ThanhVienID);
          if (ThanhVienID) {
            this.CongViecService.FormData.ThanhVienYeuCauID = Number(ThanhVienID);
          }
        }
        this.DanhMucPhongBanSearch();
        this.DanhMucTinhTrangSearch();
        this.ThanhVienSearch();
        this.CongViecTapTinDinhKemSearch();
      },
      err => {
      }
    );
  }

  CongViecSave() {
    this.CongViecService.IsShowLoading = true;
    this.CongViecService.SaveAsync().subscribe(
      res => {
        this.CongViecService.FormData = res as CongViec;

        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.CongViecService.IsShowLoading = false;
      }
    );
  }

  CongViecTapTinDinhKemSearch() {
    this.CongViecTapTinDinhKemService.BaseParameter.ParentID = this.CongViecService.FormData.ID;
    this.CongViecTapTinDinhKemService.SearchByParentID(this.CongViecTapTinDinhKemSort, this.CongViecTapTinDinhKemPaginator, this.CongViecService);
  }
  CongViecTapTinDinhKemSave(element: CongViecTapTinDinhKem) {
    this.CongViecService.IsShowLoading = true;
    element.ParentID = this.CongViecService.FormData.ID;
    this.CongViecTapTinDinhKemService.FormData = element;
    this.CongViecTapTinDinhKemService.SaveAndUploadFilesAsync().subscribe(
      res => {
        this.CongViecTapTinDinhKemSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.CongViecService.IsShowLoading = false;
      }
    );
  }
  CongViecTapTinDinhKemDelete(element: CongViecTapTinDinhKem) {
    this.CongViecTapTinDinhKemService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.CongViecTapTinDinhKemService.ComponentDeleteByParentID(this.CongViecTapTinDinhKemSort, this.CongViecTapTinDinhKemPaginator, this.CongViecService));
  }
  CongViecTapTinDinhKemChangeFile(files: FileList) {
    if (files) {
      this.CongViecTapTinDinhKemService.FileToUpload = files;
    }
  }
}