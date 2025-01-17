import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { Lst_Dictionary } from 'src/app/shared/eHospital_DongNai_A_Dictionary/Lst_Dictionary.model';
import { Lst_DictionaryService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/Lst_Dictionary.service';

import { Lst_Dictionary_Type } from 'src/app/shared/eHospital_DongNai_A_Dictionary/Lst_Dictionary_Type.model';
import { Lst_Dictionary_TypeService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/Lst_Dictionary_Type.service';

@Component({
  selector: 'app-lst-dictionary',
  templateUrl: './lst-dictionary.component.html',
  styleUrls: ['./lst-dictionary.component.css']
})
export class LstDictionaryComponent implements OnInit {

  @ViewChild('Lst_DictionarySort') Lst_DictionarySort: MatSort;
  @ViewChild('Lst_DictionaryPaginator') Lst_DictionaryPaginator: MatPaginator;

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public Lst_DictionaryService: Lst_DictionaryService,
    public Lst_Dictionary_TypeService: Lst_Dictionary_TypeService,
  ) { }

  ngOnInit(): void {
    this.Lst_Dictionary_TypeSearch();
  }
  Lst_Dictionary_TypeSearch() {
    this.Lst_Dictionary_TypeService.ComponentGetAllToListAsync(this.Lst_DictionaryService);
    this.Lst_Dictionary_TypeService.GetAllToListAsync().subscribe(
      res => {
        this.Lst_Dictionary_TypeService.List = (res as Lst_Dictionary_Type[]).sort((a, b) => (a.Dictionary_Type_Name > b.Dictionary_Type_Name ? 1 : -1));;        
      },
      err => {
      },
      () => {
      }
    );
  }

  Lst_DictionarySearch() {
    if (this.Lst_DictionaryService.BaseParameter.SearchString.length > 0) {
      this.Lst_DictionaryService.BaseParameter.SearchString = this.Lst_DictionaryService.BaseParameter.SearchString.trim();
      if (this.Lst_DictionaryService.DataSource) {
        this.Lst_DictionaryService.DataSource.filter = this.Lst_DictionaryService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.Lst_DictionaryService.GetByDictionary_Type_IdAndEmptyToListAsync().subscribe(
        res => {
          this.Lst_DictionaryService.List = (res as Lst_Dictionary[]);
          this.Lst_DictionaryService.DataSource = new MatTableDataSource(this.Lst_DictionaryService.List);
          this.Lst_DictionaryService.DataSource.sort = this.Lst_DictionarySort;
          this.Lst_DictionaryService.DataSource.paginator = this.Lst_DictionaryPaginator;
        },
        err => {
        },
        () => {
        }
      );
    }

  }
  Lst_DictionarySave(element: Lst_Dictionary) {
    this.Lst_DictionaryService.IsShowLoading = true;
    this.Lst_DictionaryService.FormData = element;
    this.Lst_DictionaryService.SaveAsync().subscribe(
      res => {
        this.Lst_DictionaryService.FormData = res as Lst_Dictionary;
        this.Lst_DictionarySearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.Lst_DictionaryService.IsShowLoading = false;
      }
    );    
  }
  Lst_DictionaryDelete(element: Lst_Dictionary) {
    this.Lst_DictionaryService.FormData = element;
    this.NotificationService.warn(this.Lst_DictionaryService.ComponentDeleteAll(this.Lst_DictionarySort, this.Lst_DictionaryPaginator));
  }
}
