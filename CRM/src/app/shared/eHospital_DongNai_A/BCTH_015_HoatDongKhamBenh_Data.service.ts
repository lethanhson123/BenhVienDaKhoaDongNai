import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BCTH_015_HoatDongKhamBenh_Data } from './BCTH_015_HoatDongKhamBenh_Data.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BCTH_015_HoatDongKhamBenh_DataService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TenPhongBan', 'TongSo', 'VienPhi', 'BHYT', 'KhongThuDuoc', 'VaoVien', 'ChuyenVien', 'CapCuu', 'Nguoi_NgoaiTru', 'Ngay_NgoaiTru', 'TC', 'Phongban_id', 'CapTren_id', 'Thang', 'Nam'];

    List: BCTH_015_HoatDongKhamBenh_Data[] | undefined;
    ListFilter: BCTH_015_HoatDongKhamBenh_Data[] | undefined;
    FormData!: BCTH_015_HoatDongKhamBenh_Data;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BCTH_015_HoatDongKhamBenh_Data";
    }
}

