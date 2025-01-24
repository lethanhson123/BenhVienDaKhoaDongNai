import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CDT_KyThuatTuyenDuoi } from './CDT_KyThuatTuyenDuoi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CDT_KyThuatTuyenDuoiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CDT_KyThuatTuyenDuoi_Id', 'KyThuat_Id', 'BenhVien_Id', 'TrangThai_Id', 'NgayQuanLy', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'NhanVien_Id', 'NhanVienTuyenDuoi_Id', 'GhiChu', 'TenBenhNhan', 'NamSinh', 'GioiTinh', 'ChanDoanICD_Id', 'ChanDoan', 'BacSiPT_Id', 'BacSiPT2_Id', 'BacSiPT3_Id', 'BacSiGM_Id', 'BacSiGM2_Id', 'DieuDuongPV_Id', 'DieuDuongPV1_Id', 'DieuDuongPV2_Id', 'DieuDuongPV3_Id', 'DieuDuongPV4_Id'];

    List: CDT_KyThuatTuyenDuoi[] | undefined;
    ListFilter: CDT_KyThuatTuyenDuoi[] | undefined;
    FormData!: CDT_KyThuatTuyenDuoi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CDT_KyThuatTuyenDuoi";
    }
}

