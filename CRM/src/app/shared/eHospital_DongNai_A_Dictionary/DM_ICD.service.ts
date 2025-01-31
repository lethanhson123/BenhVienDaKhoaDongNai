import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_ICD } from './DM_ICD.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_ICDService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ICD_Id', 'MaICD', 'TenICD', 'TenICD_En', 'TenICD_Ru', 'MucICD', 'ICD_Nhom_Id', 'PhanNhom', 'Loai', 'BenhTruyenNhiem', 'TamNgung', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Ma', 'SiteCode', 'Mapping_Public_Id'];

    List: DM_ICD[] | undefined;
    ListFilter: DM_ICD[] | undefined;
    FormData!: DM_ICD;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_ICD";
    }
}

