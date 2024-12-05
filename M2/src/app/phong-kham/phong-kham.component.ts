import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';

import { GoiSo } from 'src/app/shared/GoiSo.model';
import { GoiSoService } from 'src/app/shared/GoiSo.service';

import { GoiSoChiTiet } from 'src/app/shared/GoiSoChiTiet.model';
import { GoiSoChiTietService } from 'src/app/shared/GoiSoChiTiet.service';

import { DanhMucPhongKham } from 'src/app/shared/DanhMucPhongKham.model';
import { DanhMucPhongKhamService } from 'src/app/shared/DanhMucPhongKham.service';

import { DanhMucTinhThanh } from 'src/app/shared/DanhMucTinhThanh.model';
import { DanhMucTinhThanhService } from 'src/app/shared/DanhMucTinhThanh.service';

import { DanhMucQuanHuyen } from 'src/app/shared/DanhMucQuanHuyen.model';
import { DanhMucQuanHuyenService } from 'src/app/shared/DanhMucQuanHuyen.service';

import { DanhMucXaPhuong } from 'src/app/shared/DanhMucXaPhuong.model';
import { DanhMucXaPhuongService } from 'src/app/shared/DanhMucXaPhuong.service';

import { KhachHang } from 'src/app/shared/KhachHang.model';
import { KhachHangService } from 'src/app/shared/KhachHang.service';

import { DanhMucDichVu } from 'src/app/shared/DanhMucDichVu.model';
import { DanhMucDichVuService } from 'src/app/shared/DanhMucDichVu.service';

@Component({
  selector: 'app-phong-kham',
  templateUrl: './phong-kham.component.html',
  styleUrls: ['./phong-kham.component.css']
})
export class PhongKhamComponent implements OnInit {

  @ViewChild('DanhMucPhongKhamSort') DanhMucPhongKhamSort: MatSort;
  @ViewChild('DanhMucPhongKhamPaginator') DanhMucPhongKhamPaginator: MatPaginator;

  constructor(
    public ActiveRouter: ActivatedRoute,

    public KhachHangService: KhachHangService,
    public DanhMucDichVuService: DanhMucDichVuService,
    public DanhMucPhongKhamService: DanhMucPhongKhamService,
    public DanhMucTinhThanhService: DanhMucTinhThanhService,
    public DanhMucQuanHuyenService: DanhMucQuanHuyenService,
    public DanhMucXaPhuongService: DanhMucXaPhuongService,

    public GoiSoService: GoiSoService,
    public GoiSoChiTietService: GoiSoChiTietService,
  ) { }

  ngOnInit(): void {
    this.StartTimer1000();
    this.DanhMucTinhThanhSearch();
    this.GoiSoChiTietSearch();
  }
  StartTimer1000() {
    setInterval(() => {
      this.GoiSoChiTietService.BaseParameter.KetThuc = new Date();
    }, 1000)
  }
  DanhMucDichVuSearch() {     
    this.DanhMucDichVuService.GetAllToListAsync().subscribe(
      res => {
        this.DanhMucDichVuService.List = (res as any[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        this.DanhMucDichVuService.ListFilter = this.DanhMucDichVuService.List;
      },
      err => {
      },
      () => {        
      }
    );
  }
  DanhMucPhongKhamSearch() {
    if (this.DanhMucPhongKhamService.BaseParameter.SearchString.length > 0) {
      this.DanhMucPhongKhamService.BaseParameter.SearchString = this.DanhMucPhongKhamService.BaseParameter.SearchString.trim();
      if (this.DanhMucPhongKhamService.DataSource) {
        this.DanhMucPhongKhamService.DataSource.filter = this.DanhMucPhongKhamService.BaseParameter.SearchString.toLowerCase();
      }
    }
    else {
      this.DanhMucPhongKhamService.BaseParameter.ParentID = Number(this.ActiveRouter.snapshot.params.DanhMucKhuVucID);
      this.DanhMucPhongKhamService.GetSQLByParentIDToListAsync().subscribe(
        res => {
          this.DanhMucPhongKhamService.List = (res as DanhMucPhongKham[]);
          this.DanhMucPhongKhamService.DataSource = new MatTableDataSource(this.DanhMucPhongKhamService.List);
          this.DanhMucPhongKhamService.DataSource.sort = this.DanhMucPhongKhamSort;
          this.DanhMucPhongKhamService.DataSource.paginator = this.DanhMucPhongKhamPaginator;
        },
        err => {
        },
        () => {
        }
      );
    }
  }
  DanhMucPhongKhamActiveChange(element: DanhMucPhongKham) {
    if (element.Active == true) {
      this.DanhMucPhongKhamService.FormData = element;
      for (let i = 0; i < this.DanhMucPhongKhamService.List.length; i++) {
        this.DanhMucPhongKhamService.List[i].Active = false;
        if (this.DanhMucPhongKhamService.FormData.ID == this.DanhMucPhongKhamService.List[i].ID) {
          this.DanhMucPhongKhamService.List[i].Active = true;
        }
      }      
    }
  }
  DanhMucTinhThanhSearch() {
    this.DanhMucTinhThanhService.BaseParameter.Active = true;
    this.DanhMucTinhThanhService.GetByActiveToListAsync().subscribe(
      res => {
        this.DanhMucTinhThanhService.List = (res as DanhMucTinhThanh[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        if (this.GoiSoChiTietService.FormData.DanhMucTinhThanhID > 0) {
        }
        else {
          if (this.DanhMucTinhThanhService.List.length > 0) {
            this.GoiSoChiTietService.FormData.DanhMucTinhThanhID = this.DanhMucTinhThanhService.List[0].ID;
          }
        }
        this.DanhMucQuanHuyenSearch();
      },
      err => {
      },
      () => {
      }
    );
  }
  DanhMucTinhThanhChange() {
    this.DanhMucQuanHuyenSearch();
  }
  DanhMucQuanHuyenSearch() {
    this.DanhMucQuanHuyenService.BaseParameter.ParentID = this.GoiSoChiTietService.FormData.DanhMucTinhThanhID;
    this.DanhMucQuanHuyenService.GetByParentIDToListAsync().subscribe(
      res => {
        this.DanhMucQuanHuyenService.List = (res as DanhMucQuanHuyen[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        if (this.GoiSoChiTietService.FormData.DanhMucQuanHuyenID > 0) {
        }
        else {
          if (this.DanhMucQuanHuyenService.List.length > 0) {
            this.GoiSoChiTietService.FormData.DanhMucQuanHuyenID = this.DanhMucQuanHuyenService.List[0].ID;
          }
        }
        this.DanhMucXaPhuongSearch();
      },
      err => {
      },
      () => {
      }
    );
  }
  DanhMucQuanHuyenChange() {
    this.DanhMucXaPhuongSearch();
  }
  DanhMucXaPhuongSearch() {
    this.DanhMucXaPhuongService.BaseParameter.ParentID = this.GoiSoChiTietService.FormData.DanhMucQuanHuyenID;
    this.DanhMucXaPhuongService.GetByParentIDToListAsync().subscribe(
      res => {
        this.DanhMucXaPhuongService.List = (res as DanhMucXaPhuong[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
        if (this.GoiSoChiTietService.FormData.DanhMucXaPhuongID > 0) {
        }
        else {
          if (this.DanhMucXaPhuongService.List.length > 0) {
            this.GoiSoChiTietService.FormData.DanhMucXaPhuongID = this.DanhMucXaPhuongService.List[0].ID;
          }
        }
      },
      err => {
      },
      () => {
      }
    );
  }
  GoiSoChiTietSearch() {
    this.GoiSoChiTietService.BaseParameter.ID = environment.InitializationNumber;
    this.GoiSoChiTietService.GetByIDAsync().subscribe(
      res => {
        this.GoiSoChiTietService.FormData = (res as GoiSoChiTiet);
        this.DanhMucPhongKhamSearch();
        if (this.GoiSoChiTietService.FormData.DanhMucTinhThanhID > 0) {
        }
        else {
          if (this.DanhMucTinhThanhService.List.length > 0) {
            this.GoiSoChiTietService.FormData.DanhMucTinhThanhID = this.DanhMucTinhThanhService.List[0].ID;
          }
        }
        if (this.GoiSoChiTietService.FormData.DanhMucQuanHuyenID > 0) {
        }
        else {
          if (this.DanhMucQuanHuyenService.List.length > 0) {
            this.GoiSoChiTietService.FormData.DanhMucQuanHuyenID = this.DanhMucQuanHuyenService.List[0].ID;
          }
        }
        if (this.GoiSoChiTietService.FormData.DanhMucXaPhuongID > 0) {
        }
        else {
          if (this.DanhMucXaPhuongService.List.length > 0) {
            this.GoiSoChiTietService.FormData.DanhMucXaPhuongID = this.DanhMucXaPhuongService.List[0].ID;
          }
        }        
      },
      err => {
      },
      () => {
      }
    );
  }
  GoiSoChiTietSave() {
    if (this.DanhMucPhongKhamService.FormData.ID > 0) {
      this.GoiSoChiTietService.SaveAsync().subscribe(
        res => {
          this.GoiSoChiTietService.FormData = (res as GoiSoChiTiet);
          if (this.GoiSoChiTietService.FormData) {
            if (this.GoiSoChiTietService.FormData.ID > 0) {
              this.GoiSoSave();
              this.GoiSoChiTietSearch();
            }
          }
        },
        err => {
        },
        () => {
        }
      );
    }
    else {
      alert("Vui lòng chọn phòng khám!");
    }
  }
  GoiSoSave() {
    this.GoiSoService.BaseParameter.DanhMucPhongKhamID = this.DanhMucPhongKhamService.FormData.ID;
    this.GoiSoService.BaseParameter.GoiSoChiTietID = this.GoiSoChiTietService.FormData.ID;
    this.GoiSoService.SaveByDanhMucPhongKhamID_GoiSoChiTietIDAsync().subscribe(
      res => {
        this.GoiSoService.FormData = (res as GoiSo);
      },
      err => {
      },
      () => {
      }
    );
  }
  KhachHangCovertToGoiSoChiTiet() {
    this.GoiSoChiTietService.FormData.KhachHangID = this.KhachHangService.FormData.ID;
    this.GoiSoChiTietService.FormData.Code = this.KhachHangService.FormData.Code;
    this.GoiSoChiTietService.FormData.BHYT = this.KhachHangService.FormData.BHYT;
    this.GoiSoChiTietService.FormData.CCCD = this.KhachHangService.FormData.CCCD;
    this.GoiSoChiTietService.FormData.DienThoai = this.KhachHangService.FormData.DienThoai;
    this.GoiSoChiTietService.FormData.HoTen = this.KhachHangService.FormData.HoTen;
    this.GoiSoChiTietService.FormData.GioiTinh = this.KhachHangService.FormData.GioiTinh;
    this.GoiSoChiTietService.FormData.DiaChi = this.KhachHangService.FormData.DiaChi;
    this.GoiSoChiTietService.FormData.NamSinh = this.KhachHangService.FormData.NamSinh;
    this.GoiSoChiTietService.FormData.DanhMucTinhThanhID = this.KhachHangService.FormData.DanhMucTinhThanhID;
    this.GoiSoChiTietService.FormData.DanhMucQuanHuyenID = this.KhachHangService.FormData.DanhMucQuanHuyenID;
    this.GoiSoChiTietService.FormData.DanhMucXaPhuongID = this.KhachHangService.FormData.DanhMucXaPhuongID;
  }
  NgayCapSoSoThuTuStringKeyPress(event: KeyboardEvent) {
    if (event.keyCode == 13) {
      this.GoiSoChiTietService.BaseParameter.NgayCapSoSoThuTuString = this.GoiSoChiTietService.FormData.NgayCapSoSoThuTuString;
      this.GoiSoChiTietService.GetNgayCapSoSoThuTuStringToAsync().subscribe(
        res => {
          this.GoiSoChiTietService.FormData = (res as GoiSoChiTiet);
          if (this.GoiSoChiTietService.FormData.ID > 0) {
            this.DanhMucTinhThanhSearch();
          }
        },
        err => {
        },
        () => {
        }
      );
    }
  }
  CodeKeyPress(event: KeyboardEvent) {
    if (event.keyCode == 13) {
      this.KhachHangService.BaseParameter.SearchString = this.GoiSoChiTietService.FormData.Code;
      this.KhachHangService.GetByCodeToAsync().subscribe(
        res => {
          this.KhachHangService.FormData = (res as KhachHang);
          if (this.KhachHangService.FormData.ID > 0) {
            this.KhachHangCovertToGoiSoChiTiet();
          }
        },
        err => {
        },
        () => {
        }
      );
    }
  }
  BHYTKeyPress(event: KeyboardEvent) {
    if (event.keyCode == 13) {
      this.KhachHangService.BaseParameter.SearchString = this.GoiSoChiTietService.FormData.BHYT;
      this.KhachHangService.GetByBHYTToAsync().subscribe(
        res => {
          this.KhachHangService.FormData = (res as KhachHang);
          if (this.KhachHangService.FormData.ID > 0) {
            this.KhachHangCovertToGoiSoChiTiet();
          }
        },
        err => {
        },
        () => {
        }
      );
    }
  }
  CCCDKeyPress(event: KeyboardEvent) {
    if (event.keyCode == 13) {
      this.KhachHangService.BaseParameter.SearchString = this.GoiSoChiTietService.FormData.CCCD;
      this.KhachHangService.GetByCCCDToAsync().subscribe(
        res => {
          this.KhachHangService.FormData = (res as KhachHang);
          if (this.KhachHangService.FormData.ID > 0) {
            this.KhachHangCovertToGoiSoChiTiet();
          }
        },
        err => {
        },
        () => {
        }
      );
    }
  }
  DienThoaiKeyPress(event: KeyboardEvent) {
    if (event.keyCode == 13) {
      this.KhachHangService.BaseParameter.SearchString = this.GoiSoChiTietService.FormData.DienThoai;
      this.KhachHangService.GetByDienThoaiToAsync().subscribe(
        res => {
          this.KhachHangService.FormData = (res as KhachHang);
          if (this.KhachHangService.FormData.ID > 0) {
            this.KhachHangCovertToGoiSoChiTiet();
          }
        },
        err => {
        },
        () => {
        }
      );
    }
  }
}
