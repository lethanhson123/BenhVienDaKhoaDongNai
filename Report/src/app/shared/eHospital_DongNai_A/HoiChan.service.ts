import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoiChan } from './HoiChan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoiChanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HoiChan_Id', 'TiepNhan_Id', 'BenhNhan_Id', 'LoaiHoiChan', 'TomTat_TienSuBenh', 'TinhTrang', 'ChanDoan_TuyenDuoi', 'TomTat_DienBienBenh', 'ChanDoan', 'HuongXuTri', 'ChamSoc', 'KetLuan', 'CachXuTri', 'NgayHoiChan', 'ThoiGianDuTinhPT', 'ThoiGianHenNhapVien', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'SoPhieuHoiChan', 'LoaiHoiChan_Id', 'BenhAn_Id', 'LuuTru_Id', 'PhongBan_Id', 'BacSi_Id', 'LyDoHoiChan_Id', 'HinhThucHoiChan_Id', 'YeuCauHoiChan', 'ThoiGianHoiChan', 'CLSYeuCau_Id', 'PhongMo_Id', 'NgayMo', 'MauDuTru'];

    List: HoiChan[] | undefined;
    ListFilter: HoiChan[] | undefined;
    FormData!: HoiChan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoiChan";
    }
}

