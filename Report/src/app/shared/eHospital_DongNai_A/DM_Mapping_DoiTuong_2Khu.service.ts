import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_Mapping_DoiTuong_2Khu } from './DM_Mapping_DoiTuong_2Khu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_Mapping_DoiTuong_2KhuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Mapping_ID', 'DoiTuong_ID', 'DoiTuong_OtherSite_ID', 'NguoiTao_ID', 'NgayTao', 'NguoiCapNhat_ID', 'NgayCapNhat'];

    List: DM_Mapping_DoiTuong_2Khu[] | undefined;
    ListFilter: DM_Mapping_DoiTuong_2Khu[] | undefined;
    FormData!: DM_Mapping_DoiTuong_2Khu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_Mapping_DoiTuong_2Khu";
    }
}

