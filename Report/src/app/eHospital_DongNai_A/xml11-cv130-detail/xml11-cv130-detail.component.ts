import { Component, OnInit, Inject, ElementRef, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';



import { XML11_CV130 } from 'src/app/shared/eHospital_DongNai_A//XML11_CV130.model';
import { XML11_CV130Service } from 'src/app/shared/eHospital_DongNai_A//XML11_CV130.service';

@Component({
  selector: 'app-XML11-cv130-detail',
  templateUrl: './XML11-cv130-detail.component.html',
  styleUrls: ['./XML11-cv130-detail.component.css']
})
export class XML11CV130DetailComponent implements OnInit {

  constructor(
    public DialogRef: MatDialogRef<XML11CV130DetailComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,

    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public XML11_CV130Service: XML11_CV130Service,

  ) { }

  ngOnInit(): void {
   
  }  
  Close() {
    this.DialogRef.close();
  }  
  XML11_CV130Save() {
    this.XML11_CV130Service.IsShowLoading = true;
    this.XML11_CV130Service.SaveAsync().subscribe(
      res => {
        this.XML11_CV130Service.FormData = res as XML11_CV130;       
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.XML11_CV130Service.IsShowLoading = false;
      }
    );
  }


}