import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BCQR_01 } from './ztmp_BCQR_01.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BCQR_01Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'sTT', 'soHoaDon', 'soTaiKhoan', 'soHoaDonQR', 'giaTriHoaDon', 'thoiGianHoaDon', 'LoaiThu', 'soVaoVien', 'maDotDieuTri', 'tenBenhNhan', 'namSinh', 'soThamChieu', 'maGiaoDich', 'nguoiThu', 'dienGiai'];

    List: ztmp_BCQR_01[] | undefined;
    ListFilter: ztmp_BCQR_01[] | undefined;
    FormData!: ztmp_BCQR_01;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BCQR_01";
    }
}

