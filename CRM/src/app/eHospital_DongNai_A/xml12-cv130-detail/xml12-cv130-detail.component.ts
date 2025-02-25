import { Component, OnInit, Inject, ElementRef, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';



import { XML12_CV130 } from 'src/app/shared/eHospital_DongNai_A//XML12_CV130.model';
import { XML12_CV130Service } from 'src/app/shared/eHospital_DongNai_A//XML12_CV130.service';

@Component({
  selector: 'app-XML12-cv130-detail',
  templateUrl: './XML12-cv130-detail.component.html',
  styleUrls: ['./XML12-cv130-detail.component.css']
})
export class XML12CV130DetailComponent implements OnInit {

  constructor(
    public DialogRef: MatDialogRef<XML12CV130DetailComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,

    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public XML12_CV130Service: XML12_CV130Service,

  ) { }

  ngOnInit(): void {
   
  }  
  Close() {
    this.DialogRef.close();
  }  
  XML12_CV130Save() {
    this.XML12_CV130Service.IsShowLoading = true;
    this.XML12_CV130Service.SaveAsync().subscribe(
      res => {
        this.XML12_CV130Service.FormData = res as XML12_CV130;       
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.XML12_CV130Service.IsShowLoading = false;
      }
    );
  }


}