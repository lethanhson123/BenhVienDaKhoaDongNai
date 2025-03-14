import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_GoiDichVuChiTiet } from './CSKH_GoiDichVuChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_GoiDichVuChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'GoiDichVuChiTiet_Id', 'GoiDichVu_Id', 'DichVu_Id', 'TienTe_Id', 'TyGia', 'DonGiaThanhToan', 'DonGiaDichVu', 'TyLe', 'SoLuong', 'GhiChu', 'TamNgung', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Attribute1', 'Attribute2', 'Attribute3', 'Attribute4', 'Attribute5', 'Attribute6', 'Attribute7', 'Attribute8', 'Attribute9', 'QuanHe', 'DonGiaDichVuTrongGoi', 'PhanTram'];

    List: CSKH_GoiDichVuChiTiet[] | undefined;
    ListFilter: CSKH_GoiDichVuChiTiet[] | undefined;
    FormData!: CSKH_GoiDichVuChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_GoiDichVuChiTiet";
    }
}

