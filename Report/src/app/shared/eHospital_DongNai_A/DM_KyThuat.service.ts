import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_KyThuat } from './DM_KyThuat.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_KyThuatService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KyThuat_Id', 'MaKyThuat', 'TenKyThuat', 'TenKyThuat_En', 'TenKyThuat_Ru', 'TamNgung', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: DM_KyThuat[] | undefined;
    ListFilter: DM_KyThuat[] | undefined;
    FormData!: DM_KyThuat;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_KyThuat";
    }
}

