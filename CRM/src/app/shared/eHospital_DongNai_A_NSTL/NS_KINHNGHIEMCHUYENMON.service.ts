import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_KINHNGHIEMCHUYENMON } from './NS_KINHNGHIEMCHUYENMON.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_KINHNGHIEMCHUYENMONService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'id', 'MaUngVien', 'Tenchuyenmon', 'Trinhdo'];

    List: NS_KINHNGHIEMCHUYENMON[] | undefined;
    ListFilter: NS_KINHNGHIEMCHUYENMON[] | undefined;
    FormData!: NS_KINHNGHIEMCHUYENMON;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_KINHNGHIEMCHUYENMON";
    }
}

