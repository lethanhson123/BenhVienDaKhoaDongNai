import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_CUST_BCTH_002 } from './ztmp_CUST_BCTH_002.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_CUST_BCTH_002Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'MaYTe', 'SoBenhAn', 'TenBenhNhan', 'NamSinh', 'GioiTinh', 'SoBHYT', 'NoiDungThucHien', 'SoLuong', 'DonGia', 'ThanhTien', 'NguoiChiDinh'];

    List: ztmp_CUST_BCTH_002[] | undefined;
    ListFilter: ztmp_CUST_BCTH_002[] | undefined;
    FormData!: ztmp_CUST_BCTH_002;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_CUST_BCTH_002";
    }
}

