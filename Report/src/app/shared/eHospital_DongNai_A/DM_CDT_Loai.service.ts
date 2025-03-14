import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_CDT_Loai } from './DM_CDT_Loai.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_CDT_LoaiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CDT_Loai_Id', 'MaLoaiCDT', 'TenLoaiCDT', 'STT', 'Cap', 'CapTren_Id', 'TamNgung', 'NguoiTao_ID', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat'];

    List: DM_CDT_Loai[] | undefined;
    ListFilter: DM_CDT_Loai[] | undefined;
    FormData!: DM_CDT_Loai;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_CDT_Loai";
    }
}

