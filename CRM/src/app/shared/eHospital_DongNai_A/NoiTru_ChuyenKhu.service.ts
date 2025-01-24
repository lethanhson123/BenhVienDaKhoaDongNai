import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NoiTru_ChuyenKhu } from './NoiTru_ChuyenKhu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NoiTru_ChuyenKhuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NoiTru_ChuyenKhu_ID', 'TiepNhan_ID', 'BenhNhan_ID', 'BenhAn_ID', 'SoBenhAn', 'BacSiChiDinhChuyen_ID', 'DoiTuongChuyen_ID', 'KhoaChuyen_ID', 'LoaiBenhAnChuyen_ID', 'ICD_Chuyen_ID', 'NgayChuyen', 'ThoiGianChuyen', 'NguoiChuyen_ID', 'KhoaDen_ID', 'BacSiDen_ID', 'BacSiChiDinhNhan_ID', 'KhoaDieuTri_ID', 'LoaiBenhAnNhan_ID', 'NguoiNhan_ID', 'NgayNhan', 'ThoiGianNhan', 'SiteCode', 'IsHuy', 'SoLuuTru', 'BenhVien_KCB_Id', 'TuyenKhamBenh_Id', 'ChanDoan', 'TongTamUng', 'TongChiPhi', 'SoBHYT', 'CoPhatSinhCLS', 'CoPhatSinhThuoc', 'TongTienHoTro', 'NgayLap', 'ThoiGianLap', 'NgayVaoVien', 'ThoiGianVaoVien', 'ChanDoanKhamBenh', 'DoiTuongDen_ID'];

    List: NoiTru_ChuyenKhu[] | undefined;
    ListFilter: NoiTru_ChuyenKhu[] | undefined;
    FormData!: NoiTru_ChuyenKhu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NoiTru_ChuyenKhu";
    }
}

