import { Component, OnInit } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucQRCode } from 'src/app/shared/DanhMucQRCode.model';
import { DanhMucQRCodeService } from 'src/app/shared/DanhMucQRCode.service';

import { interval } from 'rxjs';

@Component({
  selector: 'app-qrcode',
  templateUrl: './qrcode.component.html',
  styleUrls: ['./qrcode.component.css']
})
export class QRCodeComponent implements OnInit {

  Giay: number = 60;
  constructor(
    public DownloadService: DownloadService,
    public DanhMucQRCodeService: DanhMucQRCodeService,
  ) { }

  ngOnInit(): void {
    this.DanhMucQRCodeSearch();
    this.StartTimerInterval();
  }
  StartTimerInterval() {
    setInterval(() => {
      this.DanhMucQRCodeSearch();
    }, 60000)
    setInterval(() => {
      this.Giay = this.Giay - 1;
    }, 1000)
  }
  DanhMucQRCodeSearch() {
    this.DanhMucQRCodeService.IsShowLoading = true;
    this.DanhMucQRCodeService.BaseParameter.Number = 4;
    this.DanhMucQRCodeService.GetByNumberToListAsync().subscribe(
      res => {
        this.DanhMucQRCodeService.List = (res as DanhMucQRCode[]);
        this.Giay = 60;
      },
      err => {
        console.log(err);
      },
      () => {
        this.DanhMucQRCodeService.IsShowLoading = false;
      }
    );
  }
}
