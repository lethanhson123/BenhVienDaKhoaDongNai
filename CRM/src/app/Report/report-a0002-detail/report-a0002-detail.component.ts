import { Component, OnInit, Inject, ElementRef, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { ThongKeChiTiet } from 'src/app/shared/ThongKeChiTiet.model';
import { ThongKeChiTietService } from 'src/app/shared/ThongKeChiTiet.service';

@Component({
  selector: 'app-report-a0002-detail',
  templateUrl: './report-a0002-detail.component.html',
  styleUrls: ['./report-a0002-detail.component.css']
})
export class ReportA0002DetailComponent implements OnInit {

  constructor(
    private Dialog: MatDialog,
    public DialogRef: MatDialogRef<ReportA0002DetailComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public ThongKeChiTietService: ThongKeChiTietService,
  ) { }

  ngOnInit(): void {
  }
  Close() {
    this.DialogRef.close();
  }
}
