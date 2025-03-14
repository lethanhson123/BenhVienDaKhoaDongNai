import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { LichLamViecChiTiet } from './LichLamViecChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class LichLamViecChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'LichLamViecChiTiet_Id', 'NhanVien_Id', 'PhongBan_Id', 'Ngay', 'ThoiGianBatDau', 'ThoiGianKetThuc', 'Schedule_id', 'ScheduleDetail_Id', 'Huy', 'TamNgung', 'NguoiTao_Id', 'NguoiCapNhat', 'NgayTao', 'NgayCapNhat', 'NhanVienTao_id', 'NhanVienCapNhat_id', 'LyDoCapNhat', 'GhiChu', 'Schedule_Type_Id', 'Block', 'PrecentOfBlock', 'isHoliday', 'Holiday_Id'];

    List: LichLamViecChiTiet[] | undefined;
    ListFilter: LichLamViecChiTiet[] | undefined;
    FormData!: LichLamViecChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "LichLamViecChiTiet";
    }
}

