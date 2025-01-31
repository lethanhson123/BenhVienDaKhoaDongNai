import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { DanhMucChucNang } from 'src/app/shared/DanhMucChucNang.model';
import { DanhMucChucNangService } from 'src/app/shared/DanhMucChucNang.service';

@Component({
  selector: 'app-danh-muc-chuc-nang',
  templateUrl: './danh-muc-chuc-nang.component.html',
  styleUrls: ['./danh-muc-chuc-nang.component.css']
})
export class DanhMucChucNangComponent implements OnInit {

  @ViewChild('DanhMucChucNangSort') DanhMucChucNangSort: MatSort;
  @ViewChild('DanhMucChucNangPaginator') DanhMucChucNangPaginator: MatPaginator;

  DanhMucUngDungID: number = environment.InitializationNumber;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public DanhMucChucNangService: DanhMucChucNangService,
  ) { }

  ngOnInit(): void {
    this.DanhMucChucNangSearch001();
  }
  DanhMucChucNangSearch001() {
    this.DanhMucChucNangService.IsShowLoading = true;
    this.DanhMucChucNangService.GetAllToListAsync().subscribe(
      res => {
        this.DanhMucChucNangService.ListFilter001 = (res as any[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        this.DanhMucChucNangService.ListFilter001 = this.DanhMucChucNangService.ListFilter001.filter(item => item.ParentID == 0);
      },
      err => {
      },
      () => {
        this.DanhMucChucNangService.IsShowLoading = false;
      }
    );
  }
  DanhMucChucNangSearch() {
    this.DanhMucChucNangService.SearchByParentID(this.DanhMucChucNangSort, this.DanhMucChucNangPaginator, this.DanhMucChucNangService);
  }

  DanhMucChucNangSave(element: DanhMucChucNang) {
    this.DanhMucChucNangService.FormData = element;
    this.NotificationService.warn(this.DanhMucChucNangService.ComponentSaveByParentID(this.DanhMucChucNangSort, this.DanhMucChucNangPaginator, this.DanhMucChucNangService));
  }

  DanhMucChucNangDelete(element: DanhMucChucNang) {
    this.DanhMucChucNangService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.DanhMucChucNangService.ComponentDeleteByParentID(this.DanhMucChucNangSort, this.DanhMucChucNangPaginator, this.DanhMucChucNangService));
  }
}