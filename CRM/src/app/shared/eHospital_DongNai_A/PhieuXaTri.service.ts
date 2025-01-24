import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { PhieuXaTri } from './PhieuXaTri.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class PhieuXaTriService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhieuXaTri_ID', 'BenhAn_Id', 'BenhNhan_ID', 'NgayXaTri', 'TruongChieu_Id', 'HuongDan', 'Pha', 'NangLuong', 'DiemThamChieu', 'TongLieu', 'SoPhanLieu', 'PhanLieu', 'LichChieuXa', 'BacSiXaTri_ID', 'KyThuatVien_1', 'KyThuatVien_2', 'SSD', 'GocThanMay', 'GocCollimator', 'GocNem', 'DinhTuThe', 'PhimKiemTra', 'MU', 'Chi', 'GhiChu', 'BachCau', 'CanNang', 'Hb', 'MoPhong', 'NgayTao', 'NguoiTao_ID', 'NgayCapNhat', 'NguoiCapNhat_ID', 'TrangThai', 'CLSYeuCau_ID'];

    List: PhieuXaTri[] | undefined;
    ListFilter: PhieuXaTri[] | undefined;
    FormData!: PhieuXaTri;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "PhieuXaTri";
    }
}

