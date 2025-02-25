import { Component, OnInit, Inject, ElementRef, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';



import { XML9_CV130 } from 'src/app/shared/eHospital_DongNai_A//XML9_CV130.model';
import { XML9_CV130Service } from 'src/app/shared/eHospital_DongNai_A//XML9_CV130.service';

@Component({
  selector: 'app-XML9-cv130-detail',
  templateUrl: './XML9-cv130-detail.component.html',
  styleUrls: ['./XML9-cv130-detail.component.css']
})
export class XML9CV130DetailComponent implements OnInit {

  constructor(
    public DialogRef: MatDialogRef<XML9CV130DetailComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,

    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public XML9_CV130Service: XML9_CV130Service,

  ) { }

  ngOnInit(): void {
   
  }  
  Close() {
    this.DialogRef.close();
  }  
  XML9_CV130Save() {
    this.XML9_CV130Service.IsShowLoading = true;
    this.XML9_CV130Service.SaveAsync().subscribe(
      res => {
        this.XML9_CV130Service.FormData = res as XML9_CV130;       
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.XML9_CV130Service.IsShowLoading = false;
      }
    );
  }


}