import { Component, OnInit } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { DanhMucQuayDichVu } from 'src/app/shared/DanhMucQuayDichVu.model';
import { DanhMucQuayDichVuService } from 'src/app/shared/DanhMucQuayDichVu.service';

import { GoiSoChiTiet } from 'src/app/shared/GoiSoChiTiet.model';
import { GoiSoChiTietService } from 'src/app/shared/GoiSoChiTiet.service';

import { interval } from 'rxjs';

@Component({
  selector: 'app-m12',
  templateUrl: './m12.component.html',
  styleUrls: ['./m12.component.css']
})
export class M12Component implements OnInit {

  constructor(
    public ActiveRouter: ActivatedRoute,
    public DownloadService: DownloadService,
    public DanhMucQuayDichVuService: DanhMucQuayDichVuService,
    public GoiSoChiTietService: GoiSoChiTietService,
  ) { }

  ngOnInit(): void {
    this.DanhMucQuayDichVuSearch();
    this.StartTimerInterval();
  }
  StartTimerInterval() {
    setInterval(() => {
      this.DanhMucQuayDichVuSearch();
    }, environment.Interval)
  }
  DanhMucQuayDichVuSearch() {
    this.DanhMucQuayDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code01;
    this.DanhMucQuayDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData01 = (res as DanhMucQuayDichVu);
        if (this.DanhMucQuayDichVuService.FormData01) {
          if (this.DanhMucQuayDichVuService.FormData01.ID > 0) {
            this.GoiSoChiTietService.BaseParameter.DanhMucQuayDichVuID = this.DanhMucQuayDichVuService.FormData01.ID;
            this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan09ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
                this.GoiSoChiTietService.List01 = this.GoiSoChiTietService.List.filter(item => item.Active == true).sort((a, b) => (a.IsUuTien < b.IsUuTien ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List01.length; i++) {
                  if (this.GoiSoChiTietService.List01[i].NgayTiepNhanSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List01[i].NgayTiepNhanSoThuTuString = "T1118-000";
                    this.GoiSoChiTietService.List01[i].Name = "00000";
                  }
                }                           
              },
              err => {
              },
              () => {
              }
            );
          }
        }
      },
      err => {
      },
      () => {
      }
    );
    this.DanhMucQuayDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code02;
    this.DanhMucQuayDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData02 = (res as DanhMucQuayDichVu);
        if (this.DanhMucQuayDichVuService.FormData02) {
          if (this.DanhMucQuayDichVuService.FormData02.ID > 0) {
            this.GoiSoChiTietService.BaseParameter.DanhMucQuayDichVuID = this.DanhMucQuayDichVuService.FormData02.ID;
            this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan09ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
                this.GoiSoChiTietService.List11 = this.GoiSoChiTietService.List.filter(item => item.Active == true).sort((a, b) => (a.IsUuTien < b.IsUuTien ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List11.length; i++) {
                  if (this.GoiSoChiTietService.List11[i].NgayTiepNhanSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List11[i].NgayTiepNhanSoThuTuString = "T1118-000";
                    this.GoiSoChiTietService.List11[i].Name = "00000";
                  }
                }                     
              },
              err => {
              },
              () => {
              }
            );
          }
        }
      },
      err => {
      },
      () => {
      }
    );
    this.DanhMucQuayDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code03;
    this.DanhMucQuayDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData03 = (res as DanhMucQuayDichVu);
        if (this.DanhMucQuayDichVuService.FormData03) {
          if (this.DanhMucQuayDichVuService.FormData03.ID > 0) {
            this.GoiSoChiTietService.BaseParameter.DanhMucQuayDichVuID = this.DanhMucQuayDichVuService.FormData03.ID;
            this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan09ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
                this.GoiSoChiTietService.List21 = this.GoiSoChiTietService.List.filter(item => item.Active == true).sort((a, b) => (a.IsUuTien < b.IsUuTien ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List21.length; i++) {
                  if (this.GoiSoChiTietService.List21[i].NgayTiepNhanSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List21[i].NgayTiepNhanSoThuTuString = "T1118-000";
                    this.GoiSoChiTietService.List21[i].Name = "00000";
                  }
                }                       
              },
              err => {
              },
              () => {
              }
            );
          }
        }
      },
      err => {
      },
      () => {
      }
    );
    this.DanhMucQuayDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code04;
    this.DanhMucQuayDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData04 = (res as DanhMucQuayDichVu);
        if (this.DanhMucQuayDichVuService.FormData04) {
          if (this.DanhMucQuayDichVuService.FormData04.ID > 0) {
            this.GoiSoChiTietService.BaseParameter.DanhMucQuayDichVuID = this.DanhMucQuayDichVuService.FormData04.ID;
            this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan09ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
                this.GoiSoChiTietService.List31 = this.GoiSoChiTietService.List.filter(item => item.Active == true).sort((a, b) => (a.IsUuTien < b.IsUuTien ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List31.length; i++) {
                  if (this.GoiSoChiTietService.List31[i].NgayTiepNhanSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List31[i].NgayTiepNhanSoThuTuString = "T1118-000";
                    this.GoiSoChiTietService.List31[i].Name = "00000";
                  }
                }                     
              },
              err => {
              },
              () => {
              }
            );
          }
        }
      },
      err => {
      },
      () => {
      }
    );   
    this.DanhMucQuayDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code05;
    this.DanhMucQuayDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData05 = (res as DanhMucQuayDichVu);
        if (this.DanhMucQuayDichVuService.FormData05) {
          if (this.DanhMucQuayDichVuService.FormData05.ID > 0) {
            this.GoiSoChiTietService.BaseParameter.DanhMucQuayDichVuID = this.DanhMucQuayDichVuService.FormData05.ID;
            this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan09ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
                this.GoiSoChiTietService.List41 = this.GoiSoChiTietService.List.filter(item => item.Active == true).sort((a, b) => (a.IsUuTien < b.IsUuTien ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List41.length; i++) {
                  if (this.GoiSoChiTietService.List41[i].NgayTiepNhanSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List41[i].NgayTiepNhanSoThuTuString = "T1118-000";
                    this.GoiSoChiTietService.List41[i].Name = "00000";
                  }
                }                     
              },
              err => {
              },
              () => {
              }
            );
          }
        }
      },
      err => {
      },
      () => {
      }
    );   
    this.DanhMucQuayDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code06;
    this.DanhMucQuayDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData06 = (res as DanhMucQuayDichVu);
        if (this.DanhMucQuayDichVuService.FormData06) {
          if (this.DanhMucQuayDichVuService.FormData06.ID > 0) {
            this.GoiSoChiTietService.BaseParameter.DanhMucQuayDichVuID = this.DanhMucQuayDichVuService.FormData06.ID;
            this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan09ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
                this.GoiSoChiTietService.List51 = this.GoiSoChiTietService.List.filter(item => item.Active == true).sort((a, b) => (a.IsUuTien < b.IsUuTien ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List51.length; i++) {
                  if (this.GoiSoChiTietService.List51[i].NgayTiepNhanSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List51[i].NgayTiepNhanSoThuTuString = "T1118-000";
                    this.GoiSoChiTietService.List51[i].Name = "00000";
                  }
                }                     
              },
              err => {
              },
              () => {
              }
            );
          }
        }
      },
      err => {
      },
      () => {
      }
    );  
    this.DanhMucQuayDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code07;
    this.DanhMucQuayDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData07 = (res as DanhMucQuayDichVu);
        if (this.DanhMucQuayDichVuService.FormData07) {
          if (this.DanhMucQuayDichVuService.FormData07.ID > 0) {
            this.GoiSoChiTietService.BaseParameter.DanhMucQuayDichVuID = this.DanhMucQuayDichVuService.FormData07.ID;
            this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan09ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
                this.GoiSoChiTietService.List61 = this.GoiSoChiTietService.List.filter(item => item.Active == true).sort((a, b) => (a.IsUuTien < b.IsUuTien ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List61.length; i++) {
                  if (this.GoiSoChiTietService.List61[i].NgayTiepNhanSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List61[i].NgayTiepNhanSoThuTuString = "T1118-000";
                    this.GoiSoChiTietService.List61[i].Name = "00000";
                  }
                }                     
              },
              err => {
              },
              () => {
              }
            );
          }
        }
      },
      err => {
      },
      () => {
      }
    );  
    this.DanhMucQuayDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code08;
    this.DanhMucQuayDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData08 = (res as DanhMucQuayDichVu);
        if (this.DanhMucQuayDichVuService.FormData08) {
          if (this.DanhMucQuayDichVuService.FormData08.ID > 0) {
            this.GoiSoChiTietService.BaseParameter.DanhMucQuayDichVuID = this.DanhMucQuayDichVuService.FormData08.ID;
            this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan09ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
                this.GoiSoChiTietService.List71 = this.GoiSoChiTietService.List.filter(item => item.Active == true).sort((a, b) => (a.IsUuTien < b.IsUuTien ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List71.length; i++) {
                  if (this.GoiSoChiTietService.List71[i].NgayTiepNhanSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List71[i].NgayTiepNhanSoThuTuString = "T1118-000";
                    this.GoiSoChiTietService.List71[i].Name = "00000";
                  }
                }                     
              },
              err => {
              },
              () => {
              }
            );
          }
        }
      },
      err => {
      },
      () => {
      }
    );  
    this.DanhMucQuayDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code09;
    this.DanhMucQuayDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData09 = (res as DanhMucQuayDichVu);
        if (this.DanhMucQuayDichVuService.FormData09) {
          if (this.DanhMucQuayDichVuService.FormData09.ID > 0) {
            this.GoiSoChiTietService.BaseParameter.DanhMucQuayDichVuID = this.DanhMucQuayDichVuService.FormData09.ID;
            this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan09ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
                this.GoiSoChiTietService.List81 = this.GoiSoChiTietService.List.filter(item => item.Active == true).sort((a, b) => (a.IsUuTien < b.IsUuTien ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List81.length; i++) {
                  if (this.GoiSoChiTietService.List81[i].NgayTiepNhanSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List81[i].NgayTiepNhanSoThuTuString = "T1118-000";
                    this.GoiSoChiTietService.List81[i].Name = "00000";
                  }
                }                     
              },
              err => {
              },
              () => {
              }
            );
          }
        }
      },
      err => {
      },
      () => {
      }
    );   
    this.DanhMucQuayDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code10;
    this.DanhMucQuayDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData10 = (res as DanhMucQuayDichVu);
        if (this.DanhMucQuayDichVuService.FormData10) {
          if (this.DanhMucQuayDichVuService.FormData10.ID > 0) {
            this.GoiSoChiTietService.BaseParameter.DanhMucQuayDichVuID = this.DanhMucQuayDichVuService.FormData10.ID;
            this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan09ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
                this.GoiSoChiTietService.List91 = this.GoiSoChiTietService.List.filter(item => item.Active == true).sort((a, b) => (a.IsUuTien < b.IsUuTien ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List91.length; i++) {
                  if (this.GoiSoChiTietService.List91[i].NgayTiepNhanSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List91[i].NgayTiepNhanSoThuTuString = "T1118-000";
                    this.GoiSoChiTietService.List91[i].Name = "00000";
                  }
                }                     
              },
              err => {
              },
              () => {
              }
            );
          }
        }
      },
      err => {
      },
      () => {
      }
    );  
    this.DanhMucQuayDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code11;
    this.DanhMucQuayDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData11 = (res as DanhMucQuayDichVu);
        if (this.DanhMucQuayDichVuService.FormData11) {
          if (this.DanhMucQuayDichVuService.FormData11.ID > 0) {
            this.GoiSoChiTietService.BaseParameter.DanhMucQuayDichVuID = this.DanhMucQuayDichVuService.FormData11.ID;
            this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan09ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
                this.GoiSoChiTietService.List101 = this.GoiSoChiTietService.List.filter(item => item.Active == true).sort((a, b) => (a.IsUuTien < b.IsUuTien ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List101.length; i++) {
                  if (this.GoiSoChiTietService.List101[i].NgayTiepNhanSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List101[i].NgayTiepNhanSoThuTuString = "T1118-000";
                    this.GoiSoChiTietService.List101[i].Name = "00000";
                  }
                }                     
              },
              err => {
              },
              () => {
              }
            );
          }
        }
      },
      err => {
      },
      () => {
      }
    );  
    this.DanhMucQuayDichVuService.BaseParameter.Code = this.ActiveRouter.snapshot.params.Code12;
    this.DanhMucQuayDichVuService.GetByCodeAsync().subscribe(
      res => {
        this.DanhMucQuayDichVuService.FormData12 = (res as DanhMucQuayDichVu);
        if (this.DanhMucQuayDichVuService.FormData12) {
          if (this.DanhMucQuayDichVuService.FormData12.ID > 0) {
            this.GoiSoChiTietService.BaseParameter.DanhMucQuayDichVuID = this.DanhMucQuayDichVuService.FormData12.ID;
            this.GoiSoChiTietService.BaseParameter.Number = this.ActiveRouter.snapshot.params.Number;
            this.GoiSoChiTietService.GetGoiSoChiTietTiepNhan09ToListAsync().subscribe(
              res => {
                this.GoiSoChiTietService.List = (res as GoiSoChiTiet[]);
                this.GoiSoChiTietService.List111 = this.GoiSoChiTietService.List.filter(item => item.Active == true).sort((a, b) => (a.IsUuTien < b.IsUuTien ? 1 : -1));
                for (let i = 0; i < this.GoiSoChiTietService.List111.length; i++) {
                  if (this.GoiSoChiTietService.List111[i].NgayTiepNhanSoThuTuString) {
                  }
                  else {
                    this.GoiSoChiTietService.List111[i].NgayTiepNhanSoThuTuString = "T1118-000";
                    this.GoiSoChiTietService.List111[i].Name = "00000";
                  }
                }                     
              },
              err => {
              },
              () => {
              }
            );
          }
        }
      },
      err => {
      },
      () => {
      }
    );  
  }
}