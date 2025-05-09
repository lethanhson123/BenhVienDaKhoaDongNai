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

import { DanhMucThanhVien } from 'src/app/shared/DanhMucThanhVien.model';
import { DanhMucThanhVienService } from 'src/app/shared/DanhMucThanhVien.service';

import { ThanhVien } from 'src/app/shared/ThanhVien.model';
import { ThanhVienService } from 'src/app/shared/ThanhVien.service';


@Component({
  selector: 'app-thanh-vien-thong-tin',
  templateUrl: './thanh-vien-thong-tin.component.html',
  styleUrls: ['./thanh-vien-thong-tin.component.css']
})
export class ThanhVienThongTinComponent implements OnInit {

  MatKhauIsActive: boolean = true;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucThanhVienService: DanhMucThanhVienService,   

    public ThanhVienService: ThanhVienService,

  ) { }

  ngOnInit(): void {
    
  }
  ngAfterViewInit() {
    this.ThanhVienSearch();
  }
  MatKhauChangeType() {
    this.MatKhauIsActive = !this.MatKhauIsActive;
  }
  DanhMucThanhVienSearch() {
    this.DanhMucThanhVienService.ComponentGetAllToListAsync(this.ThanhVienService);
  }  
  ThanhVienSearch() {
    this.ThanhVienService.GetLogin();
    if (this.ThanhVienService.FormDataLogin) {
      if (this.ThanhVienService.FormDataLogin.ID > 0) {
        this.ThanhVienService.BaseParameter.ID = this.ThanhVienService.FormDataLogin.ID;
        this.ThanhVienService.GetByIDAsync().subscribe(
          res => {
            this.ThanhVienService.FormData = res as ThanhVien;             
          },
          err => {
          }
        );
      }
    }
  }

  ThanhVienSave() {
    this.ThanhVienService.IsShowLoading = true;
    this.ThanhVienService.SaveAsync().subscribe(
      res => {
        this.ThanhVienService.FormData = res as ThanhVien;
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
