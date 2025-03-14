import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KiemDiemTuVong } from './KiemDiemTuVong.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KiemDiemTuVongService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KiemDiemTuVong_Id', 'BenhNhan_Id', 'BenhAn_Id', 'TiepNhan_Id', 'KhoaKiemDiem_Id', 'NgayKiemDiem', 'ThoiGianKiemDiem', 'NguoiLienHe', 'DienThoai', 'ThoiGianTuVong', 'KhoaTuVong_Id', 'NguyenNhan_Id', 'NguyenNhan', 'ICD_TuVong', 'TienSu', 'TinhTrangVaoVien', 'ChanDoan', 'ICD_ChanDoan', 'DienBien', 'TiepDonBenh', 'ThamKham', 'DieuTri', 'ChamSoc', 'QuanHeVoiGiaDinhBenhNhan', 'YKienBoSung', 'KetLuan', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'KhoaDieuTri_Id'];

    List: KiemDiemTuVong[] | undefined;
    ListFilter: KiemDiemTuVong[] | undefined;
    FormData!: KiemDiemTuVong;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KiemDiemTuVong";
    }
}

