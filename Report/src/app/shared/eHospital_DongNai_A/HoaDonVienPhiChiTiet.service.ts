import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoaDonVienPhiChiTiet } from './HoaDonVienPhiChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoaDonVienPhiChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HoaDonChiTiet_Id', 'HoaDonVienPhi_Id', 'NoiDung_Id', 'SoPhatSinh', 'MienPhi', 'TyLeMienGiam', 'SoThucThu', 'DienGiai'];

    List: HoaDonVienPhiChiTiet[] | undefined;
    ListFilter: HoaDonVienPhiChiTiet[] | undefined;
    FormData!: HoaDonVienPhiChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoaDonVienPhiChiTiet";
    }
}

