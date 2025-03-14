﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ChungTuXuatBenhNhan } from './ChungTuXuatBenhNhan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ChungTuXuatBenhNhanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ChungTuXuatBN_Id', 'ChungTuChiTiet_Id', 'BenhAnPhauThuat_VTYT_ID', 'ToaThuoc_Id', 'BenhAn_Id', 'Duoc_Id', 'SoLoNhap_Id', 'NguonHang_Id', 'SoLuong', 'DonGiaVon', 'DonGiaMua', 'DonGiaHoTro', 'DonGiaHoTroChiTra', 'DonGiaThanhToan', 'DonGiaDoanhThu', 'ToaThuocNgoaiTru_id', 'TiepNhan_id', 'ToaThuocTra_Id', 'CLSHoaChat_VTYT_Id', 'PhatSinhHoaDon', 'Loai_IDRef', 'IDRef', 'GiaTriMienGiam', 'GiaTriThatThu', 'GiaTriDaThanhToan', 'DaThanhToan_MotPhan', 'DaThanhToan_HoanTat', 'DonGiaChenhLech', 'DonGiaHoTroChenhLech', 'GiaTriDaThanhToan_ChenhLech', 'GiaTriDaThanhToan_HoTroChenhLech', 'DaThuTien', 'MienPhi', 'KhamBenh_VTYT_Id', 'ToaThuoc_BA_NgoaiTru_Id', 'GiaTriMienGiam_ChenhLech', 'GiaTriMienGiam_HoTroChenhLech', 'GiaTriMienGiam_CoPhan', 'DonGiaHoTro_KTC', 'DonGiaHoTroChiTra_KTC', 'TyLeKTC'];

    List: ChungTuXuatBenhNhan[] | undefined;
    ListFilter: ChungTuXuatBenhNhan[] | undefined;
    FormData!: ChungTuXuatBenhNhan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ChungTuXuatBenhNhan";
    }
}

