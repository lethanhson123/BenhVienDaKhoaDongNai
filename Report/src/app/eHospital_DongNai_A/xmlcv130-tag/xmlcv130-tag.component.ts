import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';



import { XML1_CV130 } from 'src/app/shared/eHospital_DongNai_A//XML1_CV130.model';
import { XML1_CV130Service } from 'src/app/shared/eHospital_DongNai_A//XML1_CV130.service';
import { XMLCV130Tag } from 'src/app/shared/eHospital_DongNai_A/XMLCV130Tag.model';

@Component({
  selector: 'app-xmlcv130-tag',
  templateUrl: './xmlcv130-tag.component.html',
  styleUrls: ['./xmlcv130-tag.component.css']
})
export class XMLCV130TagComponent implements OnInit {

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public XML1_CV130Service: XML1_CV130Service,
  ) { }

  ngOnInit(): void {
    this.XML1_CV130Search();
  }
  XML1_CV130Search() {
    this.XML1_CV130Service.GetXMLCV130TagAsync().subscribe(
      res => {
        this.XML1_CV130Service.XMLCV130Tag = (res as XMLCV130Tag);

      },
      err => {
      },
      () => {
      }
    );
  }
  XML1_CV130Save() {
    this.XML1_CV130Service.IsShowLoading = true;
    this.XML1_CV130Service.SaveXMLCV130TagAsync().subscribe(
      res => {        
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.XML1_CV130Service.IsShowLoading = false;
      }
    );
  }
}
