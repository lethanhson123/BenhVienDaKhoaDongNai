import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_TinhTrangQuanHe } from './NS_DM_TinhTrangQuanHe.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_TinhTrangQuanHeService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TinhTrangQuanHe_Id', 'MaTinhTrang', 'TenTinhTrang', 'TamNgung'];

    List: NS_DM_TinhTrangQuanHe[] | undefined;
    ListFilter: NS_DM_TinhTrangQuanHe[] | undefined;
    FormData!: NS_DM_TinhTrangQuanHe;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_TinhTrangQuanHe";
    }
}

