import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { PhieuMoPhong } from './PhieuMoPhong.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class PhieuMoPhongService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhieuMoPhong_ID', 'SoPhieu', 'CLSYeuCau_ID', 'CLSYeuCauChiTiet_ID', 'BenhNhan_ID', 'TiepNhan_ID', 'BenhAn_ID', 'KhoaGoiDen_ID', 'ChanDoanGiaiDoan', 'ChuanBiTruoc', 'NguoiTao_ID', 'ThoiGianTao', 'NguoiCapNhat_ID', 'ThoiGianCapNhat', 'LoaiMoPhong', 'ThoiGianMoPhong', 'NgayMoPhong', 'BacSi_ID', 'NgayCapNhat'];

    List: PhieuMoPhong[] | undefined;
    ListFilter: PhieuMoPhong[] | undefined;
    FormData!: PhieuMoPhong;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "PhieuMoPhong";
    }
}

