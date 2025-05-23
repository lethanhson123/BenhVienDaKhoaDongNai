﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HRBangLuongChiTiet } from './HRBangLuongChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HRBangLuongChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName', 'NgayGhiNhan', 'Year', 'Month', 'Day', 'SoLuong', 'DonGia', 'HeSo', 'TongCong', 'DanhMucBacLuongID', 'DanhMucBacLuongName', 'DanhMucLuongCoBanID', 'DanhMucLuongCoBanName', 'DanhMucThueID', 'DanhMucThueName', 'DanhMucPhuCapID', 'DanhMucPhuCapName', 'DanhMucGiamTruID', 'DanhMucGiamTruName'];

    List: HRBangLuongChiTiet[] | undefined;
    ListFilter: HRBangLuongChiTiet[] | undefined;
    FormData!: HRBangLuongChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HRBangLuongChiTiet";
    }
}

