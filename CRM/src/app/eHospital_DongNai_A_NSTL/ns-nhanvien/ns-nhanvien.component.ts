import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { NS_NHANVIEN } from 'src/app/shared/eHospital_DongNai_A_NSTL/NS_NHANVIEN.model';
import { NS_NHANVIENService } from 'src/app/shared/eHospital_DongNai_A_NSTL/NS_NHANVIEN.service';

@Component({
  selector: 'app-ns-nhanvien',
  templateUrl: './ns-nhanvien.component.html',
  styleUrls: ['./ns-nhanvien.component.css']
})
export class NSNHANVIENComponent implements OnInit {

  @ViewChild('NS_NHANVIENSort') NS_NHANVIENSort: MatSort;
  @ViewChild('NS_NHANVIENPaginator') NS_NHANVIENPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public NS_NHANVIENService: NS_NHANVIENService,
  ) { }

  ngOnInit(): void {
    this.NS_NHANVIENSearch();
  }

  NS_NHANVIENSearch() {
    if (this.NS_NHANVIENService.BaseParameter.SearchString.length > 0) {
      this.NS_NHANVIENService.BaseParameter.SearchString = this.NS_NHANVIENService.BaseParameter.SearchString.trim();
      if (this.NS_NHANVIENService.DataSource) {
        this.NS_NHANVIENService.DataSource.filter = this.NS_NHANVIENService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.NS_NHANVIENService.GetAllToListAsync().subscribe(
        res => {
          this.NS_NHANVIENService.List = (res as NS_NHANVIEN[])//.sort((a, b) => (a.Ten > b.Ten ? 1 : -1));
          for (let index = 0; index < this.NS_NHANVIENService.List.length; index++) {
            this.NS_NHANVIENService.List[index].HoTen = this.NS_NHANVIENService.List[index].Ho + " " + this.NS_NHANVIENService.List[index].Ten;
          }
          //this.NS_NHANVIENService.List = this.NS_NHANVIENService.List.sort((a, b) => (a.HoTen > b.HoTen ? 1 : -1));
          this.NS_NHANVIENService.DataSource = new MatTableDataSource(this.NS_NHANVIENService.List);
          this.NS_NHANVIENService.DataSource.sort = this.NS_NHANVIENSort;
          this.NS_NHANVIENService.DataSource.paginator = this.NS_NHANVIENPaginator;
        },
        err => {
        },
        () => {
        }
      );
    }
  }
  NS_NHANVIENSave(element: NS_NHANVIEN) {
    this.NS_NHANVIENService.FormData = element;
    this.NotificationService.warn(this.NS_NHANVIENService.ComponentSaveAll(this.NS_NHANVIENSort, this.NS_NHANVIENPaginator));
  }
  NS_NHANVIENDelete(element: NS_NHANVIEN) {
    this.NS_NHANVIENService.FormData = element;
    this.NotificationService.warn(this.NS_NHANVIENService.ComponentDeleteAll(this.NS_NHANVIENSort, this.NS_NHANVIENPaginator));
  }
}