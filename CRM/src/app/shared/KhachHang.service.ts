import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhachHang } from 'src/app/shared/KhachHang.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KhachHangService extends BaseService {
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName', 'DanhMucTinhThanhID', 'DanhMucTinhThanhName', 'DanhMucQuanHuyenID', 'DanhMucQuanHuyenName', 'DanhMucXaPhuongID', 'DanhMucXaPhuongName', 'DiaChi', 'HoTen', 'NamSinh', 'NgaySinh', 'GioiTinh', 'CCCD', 'DienThoai', 'Email', 'Zalo', 'BHYT'];

    DisplayColumns002: string[] = ['STT', 'ID', 'Code', 'HoTen', 'CCCD', 'DienThoai', 'NamSinh', 'DanhMucTinhThanhName', 'DanhMucQuanHuyenName', 'DanhMucXaPhuongName', 'GioiTinh', 'Save'];

    List: KhachHang[] | undefined;
    ListFilter: KhachHang[] | undefined;
    FormData!: KhachHang;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KhachHang";
    }
}

