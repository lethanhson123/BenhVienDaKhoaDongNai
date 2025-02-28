import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhamBenh_ToaThuoc } from './KhamBenh_ToaThuoc.model';
import { BaseService } from './Base.service';

import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';

import { DM_KhoDuoc } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_KhoDuoc.model';
import { DM_KhoDuocService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_KhoDuoc.service';

import { Report } from 'src/app/shared/APIReport/Report.model';
import { ReportService } from 'src/app/shared/APIReport/Report.service';

@Injectable({
    providedIn: 'root'
})
export class KhamBenh_ToaThuocService extends BaseService {
    DisplayColumns001: string[] = ['Save', 'STT', 'KhamBenh_ToaThuoc_Id', 'SoThuTuToa', 'LoaiToaThuoc', 'KhamBenh_Id', 'BacSi_Id', 'NgayToaThuoc', 'ThoiGianToaThuoc', 'HuyToaThuoc', 'GhiChu', 'ChungTuPhatThuoc_Id', 'TrangThai', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'KhoXuat_Id', 'Duyet', 'NgayDuyet', 'ThoiGianDuyet', 'NguoiDuyet_Id', 'ThoiGianTao'];
    DisplayColumns002: string[] = ['STT', 'KhamBenh_ToaThuoc_Id', 'SoThuTuToa', 'LoaiToaThuoc', 'KhamBenh_Id', 'KhoXuat_Id', 'ChungTuPhatThuoc_Id', 'BacSi_Id', 'ThoiGianTao', 'ThoiGianToaThuoc', 'HuyToaThuoc', 'GhiChu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];
    List: KhamBenh_ToaThuoc[] | undefined;
    ListFilter: KhamBenh_ToaThuoc[] | undefined;
    FormData!: KhamBenh_ToaThuoc;
    constructor(
        public httpClient: HttpClient,
        public DM_KhoDuocService: DM_KhoDuocService,

        public ReportService: ReportService,
    ) {
        super(httpClient);
        this.Controller = "KhamBenh_ToaThuoc";

        this.DM_KhoDuocSearch();
    }
    DM_KhoDuocSearch() {
        this.DM_KhoDuocService.ComponentGetAllToListAsync(this.DM_KhoDuocService);
    }
    RenderToListTransfer(Sort: MatSort, Paginator: MatPaginator) {
        var List = [...new Map(this.List.map(item => [item.KhoXuat_Id, item])).values()];
        var ListID = List.map(function (a) { return a.KhoXuat_Id; });
        this.BaseParameter.Note = environment.InitializationString;

        this.ReportService.ListFilter = [];
        for (let i = 0; i < ListID.length; i++) {
            let ListSub = this.List.filter(item => item.KhoXuat_Id == ListID[i]);
            if (ListSub) {
                let Model = this.DM_KhoDuocService.List.filter(item => item.KhoDuoc_Id == ListID[i]);
                if (Model) {
                    if (Model.length) {
                        this.BaseParameter.Note = this.BaseParameter.Note + ", " + Model[0].TenKho + " (" + ListSub.length + ")";

                        this.ReportService.FormTemporary = {
                            ID: environment.InitializationNumber,
                            Name: environment.InitializationString,
                            Year: environment.InitializationNumber,
                            Month: environment.InitializationNumber,
                            Day: environment.InitializationNumber,
                            Hour: environment.InitializationNumber,
                            TinhThanhName: environment.InitializationString,
                            QuanHuyenName: environment.InitializationString,
                            XaPhuongName: environment.InitializationString,
                            TinhThanhID: environment.InitializationNumber,
                            QuanHuyenID: environment.InitializationNumber,
                            XaPhuongID: environment.InitializationNumber,
                            ThongKe001: environment.InitializationNumber,
                            ThongKe002: environment.InitializationNumber,
                            ThongKe003: environment.InitializationNumber,
                            ThongKe004: environment.InitializationNumber,
                            ThongKe005: environment.InitializationNumber,
                            ThongKe006: environment.InitializationNumber,
                            ThongKe007: environment.InitializationNumber,
                            ThongKe008: environment.InitializationNumber,
                            ThongKe009: environment.InitializationNumber,
                            ThongKe010: environment.InitializationNumber,
                            ThongKe011: environment.InitializationNumber,
                            ThongKe012: environment.InitializationNumber,
                            ThongKe013: environment.InitializationNumber,
                            ThongKe014: environment.InitializationNumber,
                            ThongKe015: environment.InitializationNumber,
                        }
                        this.ReportService.FormTemporary.Name = Model[0].TenKho;
                        this.ReportService.FormTemporary.ThongKe001 = ListSub.length;
                        this.ReportService.ListFilter.push(this.ReportService.FormTemporary);

                    }
                }
            }
        }

        for (let i = 0; i < this.List.length; i++) {
            let DM_KhoDuoc = this.DM_KhoDuocService.List.filter(item => item.KhoDuoc_Id == this.List[i].KhoXuat_Id);
            if (DM_KhoDuoc) {
                if (DM_KhoDuoc.length) {
                    this.List[i].KhoXuatName = DM_KhoDuoc[0].TenKho + " - " + DM_KhoDuoc[0].MaKho;
                }
            }
        }
        this.DataSource = new MatTableDataSource(this.List);
        this.DataSource.sort = Sort;
        this.DataSource.paginator = Paginator;
        this.IsShowLoading = false;
    }
    GetByKhamBenh_ToaThuoc_IdAsync() {
        let url = this.APIURL + this.Controller + '/GetByKhamBenh_ToaThuoc_IdAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByNgayToaThuoc_SearchStringToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByNgayToaThuoc_SearchStringToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByYear_Month_Day_SearchStringToListAsync() {
        if (this.BaseParameter.BatDau == null) {
            this.BaseParameter.BatDau = new Date();
        }
        this.BaseParameter.Year = this.BaseParameter.BatDau.getFullYear();
        this.BaseParameter.Month = this.BaseParameter.BatDau.getMonth() + 1;
        this.BaseParameter.Day = this.BaseParameter.BatDau.getDate();
        let url = this.APIURL + this.Controller + '/GetByYear_Month_Day_SearchStringToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

