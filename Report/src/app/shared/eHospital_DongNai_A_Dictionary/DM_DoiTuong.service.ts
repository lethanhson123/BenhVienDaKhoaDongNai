import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_DoiTuong } from './DM_DoiTuong.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_DoiTuongService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DoiTuong_Id', 'MaDoiTuong', 'NhomDoiTuong_Id', 'TenDoiTuong', 'TenDoiTuong_En', 'TenDoiTuong_Ru', 'MienPhi', 'TyLeGiam', 'NgayNhap', 'NgayHieuLuc', 'NgayHetHieuLuc', 'TamNgung', 'GhiChu', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Booking_Duoc', 'Booking_KhoDuoc_Id', 'GioiHan_1', 'TyLe_1', 'GioiHan_2', 'TyLe_2', 'GioiHan_3', 'TyLe_3', 'GioiHan_4', 'TyLe_4', 'SiteCode', 'Mapping_Public_Id', 'GiaBanCoLoi', 'MucHuongKTC'];

    List: DM_DoiTuong[] | undefined;
    ListFilter: DM_DoiTuong[] | undefined;
    FormData!: DM_DoiTuong;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_DoiTuong";
    }
}

