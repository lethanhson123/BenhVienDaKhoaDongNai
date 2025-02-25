import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';

import { DownloadService } from 'src/app/shared/eHospital_DongNai_A/Download.service';

import { XML1_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML1_CV130.model';
import { XML1_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML1_CV130.service';
import { XML2_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML2_CV130.model';
import { XML2_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML2_CV130.service';
import { XML3_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML3_CV130.model';
import { XML3_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML3_CV130.service';
import { XML4_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML4_CV130.model';
import { XML4_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML4_CV130.service';
import { XML5_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML5_CV130.model';
import { XML5_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML5_CV130.service';
import { XML6_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML6_CV130.model';
import { XML6_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML6_CV130.service';
import { XML7_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML7_CV130.model';
import { XML7_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML7_CV130.service';
import { XML8_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML8_CV130.model';
import { XML8_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML8_CV130.service';
import { XML9_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML9_CV130.model';
import { XML9_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML9_CV130.service';
import { XML10_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML10_CV130.model';
import { XML10_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML10_CV130.service';
import { XML11_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML11_CV130.model';
import { XML11_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML11_CV130.service';
import { XML12_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML12_CV130.model';
import { XML12_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML12_CV130.service';
import { XML13_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML13_CV130.model';
import { XML13_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML13_CV130.service';
import { XML14_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML14_CV130.model';
import { XML14_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML14_CV130.service';
import { XML15_CV130 } from 'src/app/shared/eHospital_DongNai_A/XML15_CV130.model';
import { XML15_CV130Service } from 'src/app/shared/eHospital_DongNai_A/XML15_CV130.service';
import { XML1CV130DetailComponent } from '../xml1-cv130-detail/xml1-cv130-detail.component';
import { XML2CV130DetailComponent } from '../xml2-cv130-detail/xml2-cv130-detail.component';
import { XML3CV130DetailComponent } from '../xml3-cv130-detail/xml3-cv130-detail.component';
import { XML4CV130DetailComponent } from '../xml4-cv130-detail/xml4-cv130-detail.component';
import { XML5CV130DetailComponent } from '../xml5-cv130-detail/xml5-cv130-detail.component';
import { XML6CV130DetailComponent } from '../xml6-cv130-detail/xml6-cv130-detail.component';
import { XML7CV130DetailComponent } from '../xml7-cv130-detail/xml7-cv130-detail.component';
import { XML8CV130DetailComponent } from '../xml8-cv130-detail/xml8-cv130-detail.component';
import { XML9CV130DetailComponent } from '../xml9-cv130-detail/xml9-cv130-detail.component';
import { XML10CV130DetailComponent } from '../xml10-cv130-detail/xml10-cv130-detail.component';
import { XML11CV130DetailComponent } from '../xml11-cv130-detail/xml11-cv130-detail.component';
import { XML12CV130DetailComponent } from '../xml12-cv130-detail/xml12-cv130-detail.component';
import { XML13CV130DetailComponent } from '../xml13-cv130-detail/xml13-cv130-detail.component';
import { XML14CV130DetailComponent } from '../xml14-cv130-detail/xml14-cv130-detail.component';
import { XML15CV130DetailComponent } from '../xml15-cv130-detail/xml15-cv130-detail.component';


@Component({
  selector: 'app-xml-cv130',
  templateUrl: './xml-cv130.component.html',
  styleUrls: ['./xml-cv130.component.css']
})
export class XMLCV130Component implements OnInit {

  @ViewChild('XML1_CV130Sort') XML1_CV130Sort: MatSort;
  @ViewChild('XML1_CV130Paginator') XML1_CV130Paginator: MatPaginator;
  @ViewChild('XML2_CV130Sort') XML2_CV130Sort: MatSort;
  @ViewChild('XML2_CV130Paginator') XML2_CV130Paginator: MatPaginator;
  @ViewChild('XML3_CV130Sort') XML3_CV130Sort: MatSort;
  @ViewChild('XML3_CV130Paginator') XML3_CV130Paginator: MatPaginator;
  @ViewChild('XML4_CV130Sort') XML4_CV130Sort: MatSort;
  @ViewChild('XML4_CV130Paginator') XML4_CV130Paginator: MatPaginator;
  @ViewChild('XML5_CV130Sort') XML5_CV130Sort: MatSort;
  @ViewChild('XML5_CV130Paginator') XML5_CV130Paginator: MatPaginator;
  @ViewChild('XML6_CV130Sort') XML6_CV130Sort: MatSort;
  @ViewChild('XML6_CV130Paginator') XML6_CV130Paginator: MatPaginator;
  @ViewChild('XML7_CV130Sort') XML7_CV130Sort: MatSort;
  @ViewChild('XML7_CV130Paginator') XML7_CV130Paginator: MatPaginator;
  @ViewChild('XML8_CV130Sort') XML8_CV130Sort: MatSort;
  @ViewChild('XML8_CV130Paginator') XML8_CV130Paginator: MatPaginator;
  @ViewChild('XML9_CV130Sort') XML9_CV130Sort: MatSort;
  @ViewChild('XML9_CV130Paginator') XML9_CV130Paginator: MatPaginator;
  @ViewChild('XML10_CV130Sort') XML10_CV130Sort: MatSort;
  @ViewChild('XML10_CV130Paginator') XML10_CV130Paginator: MatPaginator;
  @ViewChild('XML11_CV130Sort') XML11_CV130Sort: MatSort;
  @ViewChild('XML11_CV130Paginator') XML11_CV130Paginator: MatPaginator;
  @ViewChild('XML12_CV130Sort') XML12_CV130Sort: MatSort;
  @ViewChild('XML12_CV130Paginator') XML12_CV130Paginator: MatPaginator;
  @ViewChild('XML13_CV130Sort') XML13_CV130Sort: MatSort;
  @ViewChild('XML13_CV130Paginator') XML13_CV130Paginator: MatPaginator;
  @ViewChild('XML14_CV130Sort') XML14_CV130Sort: MatSort;
  @ViewChild('XML14_CV130Paginator') XML14_CV130Paginator: MatPaginator;
  @ViewChild('XML15_CV130Sort') XML15_CV130Sort: MatSort;
  @ViewChild('XML15_CV130Paginator') XML15_CV130Paginator: MatPaginator;

  IsLoad: boolean = true;
  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,
    private Dialog: MatDialog,

    public XML1_CV130Service: XML1_CV130Service,
    public XML2_CV130Service: XML2_CV130Service,
    public XML3_CV130Service: XML3_CV130Service,
    public XML4_CV130Service: XML4_CV130Service,
    public XML5_CV130Service: XML5_CV130Service,
    public XML6_CV130Service: XML6_CV130Service,
    public XML7_CV130Service: XML7_CV130Service,
    public XML8_CV130Service: XML8_CV130Service,
    public XML9_CV130Service: XML9_CV130Service,
    public XML10_CV130Service: XML10_CV130Service,
    public XML11_CV130Service: XML11_CV130Service,
    public XML12_CV130Service: XML12_CV130Service,
    public XML13_CV130Service: XML13_CV130Service,
    public XML14_CV130Service: XML14_CV130Service,
    public XML15_CV130Service: XML15_CV130Service,

  ) { }

  ngOnInit(): void {
    this.XML1_CV130Service.BaseParameter.BatDau = new Date();
    this.XMLCV130Search();
  }
  DateBatDau(value) {
    this.XML1_CV130Service.BaseParameter.BatDau = new Date(value);
  }
  XMLCV130Search() {
    this.XML1_CV130Search();
  }
  XMLCV130Download() {
    this.XML1_CV130Service.IsShowLoading = true;
    this.DownloadService.CreateXMLCV130Async(
      this.XML1_CV130Service.List,
      this.XML2_CV130Service.List,
      this.XML3_CV130Service.List,
      this.XML4_CV130Service.List,
      this.XML5_CV130Service.List,
      this.XML6_CV130Service.List,
      this.XML7_CV130Service.List,
      this.XML8_CV130Service.List,
      this.XML9_CV130Service.List,
      this.XML10_CV130Service.List,
      this.XML11_CV130Service.List,
      this.XML12_CV130Service.List,
      this.XML13_CV130Service.List,
      this.XML14_CV130Service.List,
      this.XML15_CV130Service.List,
    ).subscribe(
      res => {
        if (res) {
          window.open(res.toString(), "_blank");
        }
      },
      err => {
      },
      () => {
        this.XML1_CV130Service.IsShowLoading = false;
      }
    );
  }
  XML1_CV130Search() {
    this.XML1_CV130Service.IsShowLoading = true;
    this.XML1_CV130Service.BaseParameter.SearchString = this.XML1_CV130Service.BaseParameter.SearchString.trim();
    this.XML1_CV130Service.GetByYear_Month_Day_SearchStringToListAsync().subscribe(
      res => {
        this.XML1_CV130Service.List = (res as XML1_CV130[]).sort((a, b) => (a.MA_LK > b.MA_LK ? 1 : -1));
        this.XML1_CV130Service.DataSource = new MatTableDataSource(this.XML1_CV130Service.List);
        this.XML1_CV130Service.DataSource.sort = this.XML1_CV130Sort;
        this.XML1_CV130Service.DataSource.paginator = this.XML1_CV130Paginator;
        var List = [...new Map(this.XML1_CV130Service.List.map(item => [item.MA_LK, item])).values()];
        this.XML1_CV130Service.BaseParameter.ListIDString = List.map(function (a) { return a.MA_LK; });
        if (this.IsLoad == true) {
          this.XML2_CV130Search();
          this.XML3_CV130Search();
          this.XML4_CV130Search();
          this.XML5_CV130Search();
          this.XML6_CV130Search();
          this.XML7_CV130Search();
          this.XML8_CV130Search();
          this.XML9_CV130Search();
          this.XML10_CV130Search();
          this.XML11_CV130Search();
          this.XML12_CV130Search();
          this.XML13_CV130Search();
          this.XML14_CV130Search();
          this.XML15_CV130Search();
        }
        else {
          this.XML1_CV130Service.IsShowLoading = false;
        }
      },
      err => {
      },
      () => {
        this.XML1_CV130Service.IsShowLoading = false;
      }
    );
  }
  XML1_CV130Add(element: XML1_CV130) {
    this.XML1_CV130Service.FormData = element;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: environment.InitializationNumber };
    const dialog = this.Dialog.open(XML1CV130DetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.IsLoad = false;
      this.XML1_CV130Search();
    });
  }
  XML2_CV130Add(element: XML2_CV130) {
    this.XML2_CV130Service.FormData = element;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: environment.InitializationNumber };
    const dialog = this.Dialog.open(XML2CV130DetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.XML2_CV130Search();
    });
  }
  XML3_CV130Add(element: XML3_CV130) {
    this.XML3_CV130Service.FormData = element;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: environment.InitializationNumber };
    const dialog = this.Dialog.open(XML3CV130DetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.XML3_CV130Search();
    });
  }
  XML4_CV130Add(element: XML4_CV130) {
    this.XML4_CV130Service.FormData = element;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: environment.InitializationNumber };
    const dialog = this.Dialog.open(XML4CV130DetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.XML4_CV130Search();
    });
  }
  XML5_CV130Add(element: XML5_CV130) {
    this.XML5_CV130Service.FormData = element;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: environment.InitializationNumber };
    const dialog = this.Dialog.open(XML5CV130DetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.XML5_CV130Search();
    });
  }
  XML6_CV130Add(element: XML6_CV130) {
    this.XML6_CV130Service.FormData = element;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: environment.InitializationNumber };
    const dialog = this.Dialog.open(XML6CV130DetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.XML6_CV130Search();
    });
  }
  XML7_CV130Add(element: XML7_CV130) {
    this.XML7_CV130Service.FormData = element;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: environment.InitializationNumber };
    const dialog = this.Dialog.open(XML7CV130DetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.XML7_CV130Search();
    });
  }
  XML8_CV130Add(element: XML8_CV130) {
    this.XML8_CV130Service.FormData = element;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: environment.InitializationNumber };
    const dialog = this.Dialog.open(XML8CV130DetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.XML8_CV130Search();
    });
  }
  XML9_CV130Add(element: XML9_CV130) {
    this.XML9_CV130Service.FormData = element;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: environment.InitializationNumber };
    const dialog = this.Dialog.open(XML9CV130DetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.XML9_CV130Search();
    });
  }
  XML10_CV130Add(element: XML10_CV130) {
    this.XML10_CV130Service.FormData = element;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: environment.InitializationNumber };
    const dialog = this.Dialog.open(XML10CV130DetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.XML10_CV130Search();
    });
  }
  XML11_CV130Add(element: XML11_CV130) {
    this.XML11_CV130Service.FormData = element;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: environment.InitializationNumber };
    const dialog = this.Dialog.open(XML11CV130DetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.XML11_CV130Search();
    });
  }
  XML12_CV130Add(element: XML12_CV130) {
    this.XML12_CV130Service.FormData = element;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: environment.InitializationNumber };
    const dialog = this.Dialog.open(XML12CV130DetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.XML12_CV130Search();
    });
  }
  XML13_CV130Add(element: XML13_CV130) {
    this.XML13_CV130Service.FormData = element;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: environment.InitializationNumber };
    const dialog = this.Dialog.open(XML13CV130DetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.XML13_CV130Search();
    });
  }
  XML14_CV130Add(element: XML14_CV130) {
    this.XML14_CV130Service.FormData = element;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: environment.InitializationNumber };
    const dialog = this.Dialog.open(XML14CV130DetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.XML14_CV130Search();
    });
  }
  XML15_CV130Add(element: XML15_CV130) {
    this.XML15_CV130Service.FormData = element;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = environment.DialogConfigWidth;
    dialogConfig.data = { ID: environment.InitializationNumber };
    const dialog = this.Dialog.open(XML15CV130DetailComponent, dialogConfig);
    dialog.afterClosed().subscribe(() => {
      this.XML15_CV130Search();
    });
  }

  XML15_CV130Search() {
    this.XML1_CV130Service.IsShowLoading = true;
    this.XML15_CV130Service.GetByListIDStringToListAsync().subscribe(
      res => {
        this.XML15_CV130Service.List = (res as XML15_CV130[]).sort((a, b) => (a.MA_LK > b.MA_LK ? 1 : -1));
        this.XML15_CV130Service.DataSource = new MatTableDataSource(this.XML15_CV130Service.List);
        this.XML15_CV130Service.DataSource.sort = this.XML15_CV130Sort;
        this.XML15_CV130Service.DataSource.paginator = this.XML15_CV130Paginator;
        this.XML1_CV130Service.IsShowLoading = false;
      },
      err => {
      },
      () => {
      }
    );
  }
  XML14_CV130Search() {
    this.XML1_CV130Service.IsShowLoading = true;
    this.XML14_CV130Service.BaseParameter.ListIDString = this.XML1_CV130Service.BaseParameter.ListIDString;
    this.XML14_CV130Service.GetByListIDStringToListAsync().subscribe(
      res => {
        this.XML14_CV130Service.List = (res as XML14_CV130[]).sort((a, b) => (a.MA_LK > b.MA_LK ? 1 : -1));
        this.XML14_CV130Service.DataSource = new MatTableDataSource(this.XML14_CV130Service.List);
        this.XML14_CV130Service.DataSource.sort = this.XML14_CV130Sort;
        this.XML14_CV130Service.DataSource.paginator = this.XML14_CV130Paginator;
        this.XML1_CV130Service.IsShowLoading = false;
      },
      err => {
      },
      () => {
      }
    );
  }
  XML13_CV130Search() {
    this.XML1_CV130Service.IsShowLoading = true;
    this.XML13_CV130Service.BaseParameter.ListIDString = this.XML1_CV130Service.BaseParameter.ListIDString;
    this.XML13_CV130Service.GetByListIDStringToListAsync().subscribe(
      res => {
        this.XML13_CV130Service.List = (res as XML13_CV130[]).sort((a, b) => (a.MA_LK > b.MA_LK ? 1 : -1));
        this.XML13_CV130Service.DataSource = new MatTableDataSource(this.XML13_CV130Service.List);
        this.XML13_CV130Service.DataSource.sort = this.XML13_CV130Sort;
        this.XML13_CV130Service.DataSource.paginator = this.XML13_CV130Paginator;
        this.XML1_CV130Service.IsShowLoading = false;
      },
      err => {
      },
      () => {
      }
    );
  }
  XML12_CV130Search() {
    this.XML1_CV130Service.IsShowLoading = true;
    this.XML12_CV130Service.BaseParameter.ListIDString = this.XML1_CV130Service.BaseParameter.ListIDString;
    this.XML12_CV130Service.GetByListIDStringToListAsync().subscribe(
      res => {
        this.XML12_CV130Service.List = (res as XML12_CV130[]).sort((a, b) => (a.NGAY_CHUNG_TU > b.NGAY_CHUNG_TU ? 1 : -1));
        this.XML12_CV130Service.DataSource = new MatTableDataSource(this.XML12_CV130Service.List);
        this.XML12_CV130Service.DataSource.sort = this.XML12_CV130Sort;
        this.XML12_CV130Service.DataSource.paginator = this.XML12_CV130Paginator;
        this.XML1_CV130Service.IsShowLoading = false;
      },
      err => {
      },
      () => {
      }
    );
  }
  XML11_CV130Search() {
    this.XML1_CV130Service.IsShowLoading = true;
    this.XML11_CV130Service.BaseParameter.ListIDString = this.XML1_CV130Service.BaseParameter.ListIDString;
    this.XML11_CV130Service.GetByListIDStringToListAsync().subscribe(
      res => {
        this.XML11_CV130Service.List = (res as XML11_CV130[]).sort((a, b) => (a.MA_LK > b.MA_LK ? 1 : -1));
        this.XML11_CV130Service.DataSource = new MatTableDataSource(this.XML11_CV130Service.List);
        this.XML11_CV130Service.DataSource.sort = this.XML11_CV130Sort;
        this.XML11_CV130Service.DataSource.paginator = this.XML11_CV130Paginator;
        this.XML1_CV130Service.IsShowLoading = false;
      },
      err => {
      },
      () => {
      }
    );
  }
  XML10_CV130Search() {
    this.XML1_CV130Service.IsShowLoading = true;
    this.XML10_CV130Service.BaseParameter.ListIDString = this.XML1_CV130Service.BaseParameter.ListIDString;
    this.XML10_CV130Service.GetByListIDStringToListAsync().subscribe(
      res => {
        this.XML10_CV130Service.List = (res as XML10_CV130[]).sort((a, b) => (a.MA_LK > b.MA_LK ? 1 : -1));
        this.XML10_CV130Service.DataSource = new MatTableDataSource(this.XML10_CV130Service.List);
        this.XML10_CV130Service.DataSource.sort = this.XML10_CV130Sort;
        this.XML10_CV130Service.DataSource.paginator = this.XML10_CV130Paginator;
        this.XML1_CV130Service.IsShowLoading = false;
      },
      err => {
      },
      () => {
      }
    );
  }
  XML9_CV130Search() {
    this.XML1_CV130Service.IsShowLoading = true;
    this.XML9_CV130Service.BaseParameter.ListIDString = this.XML1_CV130Service.BaseParameter.ListIDString;
    this.XML9_CV130Service.GetByListIDStringToListAsync().subscribe(
      res => {
        this.XML9_CV130Service.List = (res as XML9_CV130[]).sort((a, b) => (a.MA_LK > b.MA_LK ? 1 : -1));
        this.XML9_CV130Service.DataSource = new MatTableDataSource(this.XML9_CV130Service.List);
        this.XML9_CV130Service.DataSource.sort = this.XML9_CV130Sort;
        this.XML9_CV130Service.DataSource.paginator = this.XML9_CV130Paginator;
        this.XML1_CV130Service.IsShowLoading = false;
      },
      err => {
      },
      () => {
      }
    );
  }
  XML8_CV130Search() {
    this.XML1_CV130Service.IsShowLoading = true;
    this.XML8_CV130Service.BaseParameter.ListIDString = this.XML1_CV130Service.BaseParameter.ListIDString;
    this.XML8_CV130Service.GetByListIDStringToListAsync().subscribe(
      res => {
        this.XML8_CV130Service.List = (res as XML8_CV130[]).sort((a, b) => (a.MA_LK > b.MA_LK ? 1 : -1));
        this.XML8_CV130Service.DataSource = new MatTableDataSource(this.XML8_CV130Service.List);
        this.XML8_CV130Service.DataSource.sort = this.XML8_CV130Sort;
        this.XML8_CV130Service.DataSource.paginator = this.XML8_CV130Paginator;
        this.XML1_CV130Service.IsShowLoading = false;
      },
      err => {
      },
      () => {
      }
    );
  }
  XML7_CV130Search() {
    this.XML1_CV130Service.IsShowLoading = true;
    this.XML7_CV130Service.BaseParameter.ListIDString = this.XML1_CV130Service.BaseParameter.ListIDString;
    this.XML7_CV130Service.GetByListIDStringToListAsync().subscribe(
      res => {
        this.XML7_CV130Service.List = (res as XML7_CV130[]).sort((a, b) => (a.MA_LK > b.MA_LK ? 1 : -1));
        this.XML7_CV130Service.DataSource = new MatTableDataSource(this.XML7_CV130Service.List);
        this.XML7_CV130Service.DataSource.sort = this.XML7_CV130Sort;
        this.XML7_CV130Service.DataSource.paginator = this.XML7_CV130Paginator;
        this.XML1_CV130Service.IsShowLoading = false;
      },
      err => {
      },
      () => {
      }
    );
  }
  XML2_CV130Search() {
    this.XML1_CV130Service.IsShowLoading = true;
    this.XML2_CV130Service.BaseParameter.ListIDString = this.XML1_CV130Service.BaseParameter.ListIDString;
    this.XML2_CV130Service.GetByListIDStringToListAsync().subscribe(
      res => {
        this.XML2_CV130Service.List = (res as XML2_CV130[]).sort((a, b) => (a.MA_LK > b.MA_LK ? 1 : -1));
        this.XML2_CV130Service.DataSource = new MatTableDataSource(this.XML2_CV130Service.List);
        this.XML2_CV130Service.DataSource.sort = this.XML2_CV130Sort;
        this.XML2_CV130Service.DataSource.paginator = this.XML2_CV130Paginator;
        this.XML1_CV130Service.IsShowLoading = false;
      },
      err => {
      },
      () => {
      }
    );
  }
  XML3_CV130Search() {
    this.XML1_CV130Service.IsShowLoading = true;
    this.XML3_CV130Service.BaseParameter.ListIDString = this.XML1_CV130Service.BaseParameter.ListIDString;
    this.XML3_CV130Service.GetByListIDStringToListAsync().subscribe(
      res => {
        this.XML3_CV130Service.List = (res as XML3_CV130[]).sort((a, b) => (a.MA_LK > b.MA_LK ? 1 : -1));
        this.XML3_CV130Service.DataSource = new MatTableDataSource(this.XML3_CV130Service.List);
        this.XML3_CV130Service.DataSource.sort = this.XML3_CV130Sort;
        this.XML3_CV130Service.DataSource.paginator = this.XML3_CV130Paginator;
        this.XML1_CV130Service.IsShowLoading = false;
      },
      err => {
      },
      () => {
      }
    );
  }
  XML4_CV130Search() {
    this.XML1_CV130Service.IsShowLoading = true;
    this.XML4_CV130Service.BaseParameter.ListIDString = this.XML1_CV130Service.BaseParameter.ListIDString;
    this.XML4_CV130Service.GetByListIDStringToListAsync().subscribe(
      res => {
        this.XML4_CV130Service.List = (res as XML4_CV130[]).sort((a, b) => (a.MA_LK > b.MA_LK ? 1 : -1));
        this.XML4_CV130Service.DataSource = new MatTableDataSource(this.XML4_CV130Service.List);
        this.XML4_CV130Service.DataSource.sort = this.XML4_CV130Sort;
        this.XML4_CV130Service.DataSource.paginator = this.XML4_CV130Paginator;
        this.XML1_CV130Service.IsShowLoading = false;
      },
      err => {
      },
      () => {
      }
    );
  }
  XML5_CV130Search() {
    this.XML1_CV130Service.IsShowLoading = true;
    this.XML5_CV130Service.BaseParameter.ListIDString = this.XML1_CV130Service.BaseParameter.ListIDString;
    this.XML5_CV130Service.GetByListIDStringToListAsync().subscribe(
      res => {
        this.XML5_CV130Service.List = (res as XML5_CV130[]).sort((a, b) => (a.MA_LK > b.MA_LK ? 1 : -1));
        this.XML5_CV130Service.DataSource = new MatTableDataSource(this.XML5_CV130Service.List);
        this.XML5_CV130Service.DataSource.sort = this.XML5_CV130Sort;
        this.XML5_CV130Service.DataSource.paginator = this.XML5_CV130Paginator;
        this.XML1_CV130Service.IsShowLoading = false;
      },
      err => {
      },
      () => {
      }
    );
  }
  XML6_CV130Search() {
    this.XML1_CV130Service.IsShowLoading = true;
    this.XML6_CV130Service.BaseParameter.ListIDString = this.XML1_CV130Service.BaseParameter.ListIDString;
    this.XML6_CV130Service.GetByListIDStringToListAsync().subscribe(
      res => {
        this.XML6_CV130Service.List = (res as XML6_CV130[]).sort((a, b) => (a.MA_LK > b.MA_LK ? 1 : -1));
        this.XML6_CV130Service.DataSource = new MatTableDataSource(this.XML6_CV130Service.List);
        this.XML6_CV130Service.DataSource.sort = this.XML6_CV130Sort;
        this.XML6_CV130Service.DataSource.paginator = this.XML6_CV130Paginator;
        this.XML1_CV130Service.IsShowLoading = false;
      },
      err => {
      },
      () => {
      }
    );
  }
}