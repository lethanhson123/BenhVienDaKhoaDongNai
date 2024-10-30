import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuAnThuChi } from 'src/app/shared/DuAnThuChi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuAnThuChiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName', 'SoHoSo', 'SoButToan', 'BenDauTuID', 'BenDauTuName', 'BenDauTuSoTaiKhoan', 'BenDauTuNganHang', 'BenThucHienID', 'BenThucHienName', 'BenThucHienSoTaiKhoan', 'BenThucHienNganHang', 'SoLuong', 'DonGia', 'ThanhTien', 'HeSo', 'GhiCo', 'GhiNo', 'NguoiDauTuID', 'NguoiDauTuName', 'NguoiThucHienID', 'NguoiThucHienName', 'DanhMucBieuMauID', 'DanhMucBieuMauName', 'DanhMucHinhThucThanhToanID', 'DanhMucHinhThucThanhToanName'];
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuAnThuChi";
    }
}

