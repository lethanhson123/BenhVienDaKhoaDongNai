import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KSK_HopDong } from './KSK_HopDong.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KSK_HopDongService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HopDong_ID', 'Congty_id', 'So_HD', 'Ngay_HD', 'GiaTri_HD', 'NgayHieuLuc_HD', 'NgayHetHieuLuc_HD', 'TrangThai_HD', 'Soluong_BN', 'Loai_HD', 'HinhThucThanhToan_PhatSinh', 'GiaTri_TamUng', 'GiaTri_PhatSinh', 'DienGiai', 'ThoiGiankham', 'ThoiGianLayMau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'TyLeChietKhau', 'GiaTriChietKhau', 'TienChiNhanVien'];

    List: KSK_HopDong[] | undefined;
    ListFilter: KSK_HopDong[] | undefined;
    FormData!: KSK_HopDong;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KSK_HopDong";
    }
}

