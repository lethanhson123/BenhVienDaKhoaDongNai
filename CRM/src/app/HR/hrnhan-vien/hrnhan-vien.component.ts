import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { HRNhanVien } from 'src/app/shared/HRNhanVien.model';
import { HRNhanVienService } from 'src/app/shared/HRNhanVien.service';

import { DanhMucPhongBan } from 'src/app/shared/DanhMucPhongBan.model';
import { DanhMucPhongBanService } from 'src/app/shared/DanhMucPhongBan.service';

@Component({
  selector: 'app-hrnhan-vien',
  templateUrl: './hrnhan-vien.component.html',
  styleUrls: ['./hrnhan-vien.component.css']
})
export class HRNhanVienComponent implements OnInit {

  @ViewChild('HRNhanVienSort') HRNhanVienSort: MatSort;
  @ViewChild('HRNhanVienPaginator') HRNhanVienPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public HRNhanVienService: HRNhanVienService,
    public DanhMucPhongBanService: DanhMucPhongBanService,
  ) { }

  ngOnInit(): void {
  
  }
  ngAfterViewInit() {
    this.DanhMucPhongBanSearch();
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
  DanhMucPhongBanSearch() {
    this.DanhMucPhongBanService.ComponentGetAllToListAsync(this.HRNhanVienService);
  }
  HRNhanVienSearch() {
    if (this.HRNhanVienService.BaseParameter.SearchString.length > 0) {
      this.HRNhanVienService.BaseParameter.SearchString = this.HRNhanVienService.BaseParameter.SearchString.trim();
      if (this.HRNhanVienService.DataSource) {
        this.HRNhanVienService.DataSource.filter = this.HRNhanVienService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.HRNhanVienService.IsShowLoading = true;
      this.HRNhanVienService.GetAllToListAsync().subscribe(
        res => {
          this.HRNhanVienService.List = (res as any[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));

          if (this.HRNhanVienService.BaseParameter.ParentID == 0) {
            this.HRNhanVienService.ListFilter = this.HRNhanVienService.List;
          }
          else {
            this.HRNhanVienService.ListFilter = this.HRNhanVienService.List.filter(item => item.ParentID == this.HRNhanVienService.BaseParameter.ParentID);
          }
          
          this.HRNhanVienService.DataSource = new MatTableDataSource(this.HRNhanVienService.ListFilter);
          this.HRNhanVienService.DataSource.sort = this.HRNhanVienSort;
          this.HRNhanVienService.DataSource.paginator = this.HRNhanVienPaginator;
        },
        err => {
        },
        () => {
          this.HRNhanVienService.IsShowLoading = false;
        }
      );
    }
  }
  HRNhanVienSave(element: HRNhanVien) {
    this.HRNhanVienService.FormData = element;
    this.NotificationService.warn(this.HRNhanVienService.ComponentSaveAll(this.HRNhanVienSort, this.HRNhanVienPaginator));
  }
  HRNhanVienDelete(element: HRNhanVien) {
    this.HRNhanVienService.FormData = element;
    this.NotificationService.warn(this.HRNhanVienService.ComponentDeleteAll(this.HRNhanVienSort, this.HRNhanVienPaginator));
  }  
}
