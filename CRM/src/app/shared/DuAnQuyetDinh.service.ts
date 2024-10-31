import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuAnQuyetDinh } from 'src/app/shared/DuAnQuyetDinh.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuAnQuyetDinhService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName', 'NgayKy', 'SoHoSo', 'SoQuyetDinh', 'BenDauTuID', 'BenDauTuName', 'BenDauTuMaSoThue', 'BenDauTuDienThoai', 'BenDauTuDiaChi', 'BenDauTuEmail', 'BenDauTuTaiKhoanID', 'BenDauTuSoTaiKhoan', 'BenDauTuNganHang', 'GhiCo', 'GhiNo', 'ConLai', 'MucDauTu'];
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuAnQuyetDinh";
    }
}

