import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { GoiSoChiTiet } from 'src/app/shared/GoiSoChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class GoiSoChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName', 'DanhMucKhuVucID', 'DanhMucKhuVucName', 'DanhMucKhuVucCode', 'DanhMucDichVuID', 'DanhMucDichVuName', 'DanhMucDichVuCode', 'DanhMucQuayDichVuID', 'DanhMucQuayDichVuName', 'DanhMucQuayDichVuCode', 'DanhMucPhongKhamID', 'DanhMucPhongKhamName', 'DanhMucPhongKhamCode', 'SoThuTu', 'NgayCapSo', 'NgayDangKy', 'NgayThanhToan', 'NgayKham', 'NguoiKhamHoTen', 'NguoiKhamNamSinh', 'NguoiKhamDienThoai', 'NguoiKhamCCCD', 'NguoiKhamBHYT', 'NguoiKhamDiaChi'];
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "GoiSoChiTiet";
    }
}

