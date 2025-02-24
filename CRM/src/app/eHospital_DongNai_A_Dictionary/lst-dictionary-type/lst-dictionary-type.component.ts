import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { Lst_Dictionary_Type } from 'src/app/shared/eHospital_DongNai_A_Dictionary/Lst_Dictionary_Type.model';
import { Lst_Dictionary_TypeService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/Lst_Dictionary_Type.service';

@Component({
  selector: 'app-lst-dictionary-type',
  templateUrl: './lst-dictionary-type.component.html',
  styleUrls: ['./lst-dictionary-type.component.css']
})
export class LstDictionaryTypeComponent implements OnInit {

  @ViewChild('Lst_Dictionary_TypeSort') Lst_Dictionary_TypeSort: MatSort;
  @ViewChild('Lst_Dictionary_TypePaginator') Lst_Dictionary_TypePaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public Lst_Dictionary_TypeService: Lst_Dictionary_TypeService,
  ) { }

  ngOnInit(): void {
    this.Lst_Dictionary_TypeSearch();
  }

  Lst_Dictionary_TypeSearch() {
    this.Lst_Dictionary_TypeService.SearchAll(this.Lst_Dictionary_TypeSort, this.Lst_Dictionary_TypePaginator);
  }
  Lst_Dictionary_TypeSave(element: Lst_Dictionary_Type) {
    this.Lst_Dictionary_TypeService.FormData = element;
    this.NotificationService.warn(this.Lst_Dictionary_TypeService.ComponentSaveAll(this.Lst_Dictionary_TypeSort, this.Lst_Dictionary_TypePaginator));
  }
  Lst_Dictionary_TypeDelete(element: Lst_Dictionary_Type) {
    this.Lst_Dictionary_TypeService.FormData = element;
    this.NotificationService.warn(this.Lst_Dictionary_TypeService.ComponentDeleteAll(this.Lst_Dictionary_TypeSort, this.Lst_Dictionary_TypePaginator));
  }
  Lst_Dictionary_TypeKhoiPhuc() {
    this.Lst_Dictionary_TypeService.IsShowLoading = true;
    this.Lst_Dictionary_TypeService.KhoiPhucAsync().subscribe(
      res => {
        this.Lst_Dictionary_TypeService.List = (res as Lst_Dictionary_Type[]);
        this.Lst_Dictionary_TypeService.DataSource = new MatTableDataSource(this.Lst_Dictionary_TypeService.List);
        this.Lst_Dictionary_TypeService.DataSource.sort = this.Lst_Dictionary_TypeSort;
        this.Lst_Dictionary_TypeService.DataSource.paginator = this.Lst_Dictionary_TypePaginator;
      },
      err => {
      },
      () => {
        this.Lst_Dictionary_TypeService.IsShowLoading = false;
      }
    );
  }
}