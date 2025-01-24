import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NoiTru_GiuongBenh } from './NoiTru_GiuongBenh.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NoiTru_GiuongBenhService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NoiTru_GiuongBenh_Id', 'LuuTru_Id', 'LuuTruChiTiet_Id', 'NgayThu', 'ThoiGianThu', 'DonGiaDoanhThu', 'DonGiaHoTro', 'DonGiaHoTroChiTra', 'DonGiaThanhToan', 'SoLuong', 'SoTienThucTe', 'SoTienMienGiam', 'SoTienThatThu', 'SoTienConLai', 'SoTienDaThanhToan', 'DienGiai', 'NguoiThu', 'NgayTao', 'NguoiTao', 'NgayCapNhat', 'NguoiCapNhat', 'LoaiGia_Id', 'Huy', 'DoiTuong_Id', 'BaoHiem', 'DonGiaChenhLech', 'DonGiaHoTroChenhLech'];

    List: NoiTru_GiuongBenh[] | undefined;
    ListFilter: NoiTru_GiuongBenh[] | undefined;
    FormData!: NoiTru_GiuongBenh;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NoiTru_GiuongBenh";
    }
}

