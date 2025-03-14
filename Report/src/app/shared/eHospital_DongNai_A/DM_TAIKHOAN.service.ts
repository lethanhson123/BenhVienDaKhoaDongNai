import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_TAIKHOAN } from './DM_TAIKHOAN.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_TAIKHOANService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'SoTaiKhoan', 'TenTaiKhoan', 'Cap', 'CapTren', 'InPut', 'CongNo', 'DangSuDung', 'TKTrungGian', 'Module', 'LoaiTien', 'PostModule'];

    List: DM_TAIKHOAN[] | undefined;
    ListFilter: DM_TAIKHOAN[] | undefined;
    FormData!: DM_TAIKHOAN;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_TAIKHOAN";
    }
}

