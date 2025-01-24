import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAnPhauThuat_EKip } from './BenhAnPhauThuat_EKip.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAnPhauThuat_EKipService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnPhauThuat_EKip_Id', 'BenhAnPhauThuat_Id', 'NhanVien_Id', 'VaiTro_Id', 'Idx'];

    List: BenhAnPhauThuat_EKip[] | undefined;
    ListFilter: BenhAnPhauThuat_EKip[] | undefined;
    FormData!: BenhAnPhauThuat_EKip;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAnPhauThuat_EKip";
    }
}

