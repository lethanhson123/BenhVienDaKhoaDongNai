import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucTinhThanh } from 'src/app/shared/DanhMucTinhThanh.model';
import { DanhMucTinhThanhService } from 'src/app/shared/DanhMucTinhThanh.service';
import { DanhMucQuanHuyen } from 'src/app/shared/DanhMucQuanHuyen.model';
import { DanhMucQuanHuyenService } from 'src/app/shared/DanhMucQuanHuyen.service';
import { DanhMucTinhThanhToaDo } from 'src/app/shared/DanhMucTinhThanhToaDo.model';
import { DanhMucTinhThanhToaDoService } from 'src/app/shared/DanhMucTinhThanhToaDo.service';
import { DanhMucTinhThanhToaDoDetailComponent } from '../danh-muc-tinh-thanh-toa-do-detail/danh-muc-tinh-thanh-toa-do-detail.component';

@Component({
  selector: 'app-danh-muc-quan-huyen',
  templateUrl: './danh-muc-quan-huyen.component.html',
  styleUrls: ['./danh-muc-quan-huyen.component.css']
})
export class DanhMucQuanHuyenComponent implements OnInit {

  @ViewChild('DanhMucQuanHuyenSort') DanhMucQuanHuyenSort: MatSort;
  @ViewChild('DanhMucQuanHuyenPaginator') DanhMucQuanHuyenPaginator: MatPaginator;

  constructor(    
    private Dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucTinhThanhService: DanhMucTinhThanhService,
    public DanhMucQuanHuyenService: DanhMucQuanHuyenService,
    public DanhMucTinhThanhToaDoService: DanhMucTinhThanhToaDoService,
  ) { }

  ngOnInit(): void { 
    
  }
  ngAfterViewInit() {
    this.DanhMucTinhThanhSearch();
  }
  DanhMucTinhThanhSearch() {
    this.DanhMucTinhThanhService.ComponentGetAllToListAsync(this.DanhMucQuanHuyenService);
  }
  DanhMucQuanHuyenSearch() {
    this.DanhMucQuanHuyenService.SearchByParentID(this.DanhMucQuanHuyenSort, this.DanhMucQuanHuyenPaginator, this.DanhMucQuanHuyenService);   
  }
  DanhMucQuanHuyenSave(element: DanhMucQuanHuyen) {
    this.DanhMucQuanHuyenService.FormData = element;
    this.NotificationService.warn(this.DanhMucQuanHuyenService.ComponentSaveByParentID(this.DanhMucQuanHuyenSort, this.DanhMucQuanHuyenPaginator, this.DanhMucQuanHuyenService));
  }
  DanhMucQuanHuyenDelete(element: DanhMucQuanHuyen) {
    this.DanhMucQuanHuyenService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucQuanHuyenService.ComponentDeleteByParentID(this.DanhMucQuanHuyenSort, this.DanhMucQuanHuyenPaginator, this.DanhMucQuanHuyenService));
  }  
   DanhMucTinhThanhToaDoAdd(element: DanhMucTinhThanh) {
      this.DanhMucTinhThanhToaDoService.BaseParameter.ParentID = element.ID;
      this.DanhMucTinhThanhToaDoService.BaseParameter.Name = element.Name;
      const dialogConfig = new MatDialogConfig();
      dialogConfig.disableClose = true;
      dialogConfig.autoFocus = true;
      dialogConfig.width = environment.DialogConfigWidth;
      dialogConfig.data = { ID: element.ID };
      const dialog = this.Dialog.open(DanhMucTinhThanhToaDoDetailComponent, dialogConfig);
      dialog.afterClosed().subscribe(() => {
      });
    }
}