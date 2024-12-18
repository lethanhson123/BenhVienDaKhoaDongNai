import { Component, OnInit, Inject, ElementRef, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucTinhThanhToaDo } from 'src/app/shared/DanhMucTinhThanhToaDo.model';
import { DanhMucTinhThanhToaDoService } from 'src/app/shared/DanhMucTinhThanhToaDo.service';

@Component({
  selector: 'app-danh-muc-tinh-thanh-toa-do-detail',
  templateUrl: './danh-muc-tinh-thanh-toa-do-detail.component.html',
  styleUrls: ['./danh-muc-tinh-thanh-toa-do-detail.component.css']
})
export class DanhMucTinhThanhToaDoDetailComponent implements OnInit {

  @ViewChild('DanhMucTinhThanhToaDoSort') DanhMucTinhThanhToaDoSort: MatSort;
  @ViewChild('DanhMucTinhThanhToaDoPaginator') DanhMucTinhThanhToaDoPaginator: MatPaginator;

  constructor(    
    private Dialog: MatDialog,
    public DialogRef: MatDialogRef<DanhMucTinhThanhToaDoDetailComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucTinhThanhToaDoService: DanhMucTinhThanhToaDoService,
  ) { }

  ngOnInit(): void {    
    this.DanhMucTinhThanhToaDoSearch();
  }

  DanhMucTinhThanhToaDoSearch() {
    this.DanhMucTinhThanhToaDoService.SearchByParentID(this.DanhMucTinhThanhToaDoSort, this.DanhMucTinhThanhToaDoPaginator, this.DanhMucTinhThanhToaDoService);
  }
  DanhMucTinhThanhToaDoSave(element: DanhMucTinhThanhToaDo) {
    element.ParentID = this.DanhMucTinhThanhToaDoService.BaseParameter.ParentID;
    this.DanhMucTinhThanhToaDoService.FormData = element;
    this.NotificationService.warn(this.DanhMucTinhThanhToaDoService.ComponentSaveByParentID(this.DanhMucTinhThanhToaDoSort, this.DanhMucTinhThanhToaDoPaginator, this.DanhMucTinhThanhToaDoService));
  }
  DanhMucTinhThanhToaDoDelete(element: DanhMucTinhThanhToaDo) {
    this.DanhMucTinhThanhToaDoService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucTinhThanhToaDoService.ComponentDeleteByParentID(this.DanhMucTinhThanhToaDoSort, this.DanhMucTinhThanhToaDoPaginator, this.DanhMucTinhThanhToaDoService));
  }
  Close() {
    this.DialogRef.close();
  }  
}
