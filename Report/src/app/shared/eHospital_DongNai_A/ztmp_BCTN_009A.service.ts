import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BCTN_009A } from './ztmp_BCTN_009A.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BCTN_009AService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TenPhongBan', 'SoVaoVien', 'ThoiGianTN', 'NgayTN', 'ThoiGianKB', 'NgayKB', 'ThoiGianTT', 'NgayTT', 'TenBenhNhan', 'SoBHYT', 'Tuoi', 'GioiTinh', 'TenDoiTuong', 'NgheNghiep', 'DiaChiLienHe', 'HinhThuc', 'BacSiKham', 'ChanDoanICD', 'HuongGiaiQuyet'];

    List: ztmp_BCTN_009A[] | undefined;
    ListFilter: ztmp_BCTN_009A[] | undefined;
    FormData!: ztmp_BCTN_009A;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BCTN_009A";
    }
}

