import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { TiepNhan } from 'src/app/shared/eHospital_DongNai_A/TiepNhan.model';
import { TiepNhanService } from 'src/app/shared/eHospital_DongNai_A/TiepNhan.service';

@Component({
  selector: 'app-tiep-nhan2025',
  templateUrl: './tiep-nhan2025.component.html',
  styleUrls: ['./tiep-nhan2025.component.css']
})
export class TiepNhan2025Component implements OnInit {

  constructor(
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public TiepNhanService: TiepNhanService,   
  ) { }

  ngOnInit(): void {
  }
  ngAfterViewInit() {
   
  }
  TiepNhanSave() {  
  }
}
