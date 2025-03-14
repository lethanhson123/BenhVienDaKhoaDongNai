import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_PhuCap } from './NS_DM_PhuCap.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_PhuCapService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NS_DM_PhuCap_Id', 'MaPhongBan', 'PC_DacThuNgheNghiep', 'PC_DocHaiHienVat'];

    List: NS_DM_PhuCap[] | undefined;
    ListFilter: NS_DM_PhuCap[] | undefined;
    FormData!: NS_DM_PhuCap;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_PhuCap";
    }
}

