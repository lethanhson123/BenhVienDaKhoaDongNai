import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { LichHen_BenhNhan } from './LichHen_BenhNhan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class LichHen_BenhNhanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'LichHen_BenhNhan_Id', 'KhamBenh_Id', 'BenhAn_Id', 'BenhNhan_Id', 'NgayHen_BatDau', 'ThoiGianHen_BatDau', 'NgayHen_KetThuc', 'ThoiGianHen_KetThuc', 'PhongBan_Id', 'BacSi_Id', 'DichVu_Id', 'TrangThai_Id', 'LoaiCuocHen_Id', 'GhiChu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'TiepNhan_Id', 'TenBenhNhan'];

    List: LichHen_BenhNhan[] | undefined;
    ListFilter: LichHen_BenhNhan[] | undefined;
    FormData!: LichHen_BenhNhan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "LichHen_BenhNhan";
    }
}

