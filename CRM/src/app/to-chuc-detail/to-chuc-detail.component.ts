import { Component, OnInit, Inject, ElementRef, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';



import { ToChuc } from 'src/app/shared/ToChuc.model';
import { ToChucService } from 'src/app/shared/ToChuc.service';
import { ToChucTaiKhoan } from 'src/app/shared/ToChucTaiKhoan.model';
import { ToChucTaiKhoanService } from 'src/app/shared/ToChucTaiKhoan.service';

@Component({
  selector: 'app-to-chuc-detail',
  templateUrl: './to-chuc-detail.component.html',
  styleUrls: ['./to-chuc-detail.component.css']
})
export class ToChucDetailComponent implements OnInit {

  @ViewChild('ToChucTaiKhoanSort') ToChucTaiKhoanSort: MatSort;
  @ViewChild('ToChucTaiKhoanPaginator') ToChucTaiKhoanPaginator: MatPaginator;


  ActiveAllToChucTaiKhoan: boolean = false;

  MatKhauIsActive: boolean = true;

  constructor(
    private Dialog: MatDialog,
    public DialogRef: MatDialogRef<ToChucDetailComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,

    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ToChucService: ToChucService,
    public ToChucTaiKhoanService: ToChucTaiKhoanService,

  ) { }

  ngOnInit(): void {
    this.ToChucSearch();
  }
  Close() {
    this.DialogRef.close();
  }

  ToChucSearch() {
    this.ToChucService.GetByIDAsync().subscribe(
      res => {
        this.ToChucService.FormData = res as ToChuc;      
        this.ToChucTaiKhoanSearch();
      },
      err => {
      }
    );
  }

  ToChucSave() {
    this.ToChucService.IsShowLoading = true;
    this.ToChucService.SaveAsync().subscribe(
      res => {
        this.ToChucService.FormData = res as ToChuc;
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.ToChucService.IsShowLoading = false;
      }
    );
  }

  ToChucTaiKhoanSearch() {
    this.ToChucTaiKhoanService.BaseParameter.ParentID = this.ToChucService.FormData.ID;
    this.ToChucTaiKhoanService.SearchByParentID(this.ToChucTaiKhoanSort, this.ToChucTaiKhoanPaginator, this.ToChucService);
  }
  ToChucTaiKhoanSave(element: ToChucTaiKhoan) {
    element.ParentID = this.ToChucService.FormData.ID;
    element.Name = this.ToChucService.FormData.Name;
    this.ToChucTaiKhoanService.FormData = element;
    this.NotificationService.warn(this.ToChucTaiKhoanService.ComponentSaveByParentID(this.ToChucTaiKhoanSort, this.ToChucTaiKhoanPaginator, this.ToChucService));
  }
  ToChucTaiKhoanDelete(element: ToChucTaiKhoan) {
    this.ToChucTaiKhoanService.BaseParameter.ID = element.ID;
    this.NotificationService.warn(this.ToChucTaiKhoanService.ComponentDeleteByParentID(this.ToChucTaiKhoanSort, this.ToChucTaiKhoanPaginator, this.ToChucService));
  }
}

