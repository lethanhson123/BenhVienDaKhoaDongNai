import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BCTN_009 } from './ztmp_BCTN_009.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BCTN_009Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TenBenhNhan', 'DiaChiBenhNhan', 'Nam', 'Nu', 'KhoaKhamBenh', 'TuyenDuoi', 'PhongKham', 'NgayKham', 'SoBHYT', 'NoiGioiThieu', 'ChiDinhDieuTri', 'Ratoa', 'VaoVien', 'NgoaiTru', 'ChuyenVien', 'HenTaiKham', 'GiaiQuyetKhac', 'VienPhi', 'BHYT', 'MienGiam', 'DoiTuongKhac', 'P32', 'XN'];

    List: ztmp_BCTN_009[] | undefined;
    ListFilter: ztmp_BCTN_009[] | undefined;
    FormData!: ztmp_BCTN_009;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BCTN_009";
    }
}

