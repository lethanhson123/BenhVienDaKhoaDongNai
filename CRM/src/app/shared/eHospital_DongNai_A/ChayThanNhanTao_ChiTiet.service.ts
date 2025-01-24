import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ChayThanNhanTao_ChiTiet } from './ChayThanNhanTao_ChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ChayThanNhanTao_ChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnTongQuat_LienQuanBenh_Id', 'BenhAnTongQuat_Id', 'Gio', 'MHA', 'VTMAU', 'ALTM', 'UFTHUC', 'XUTRI', 'TENDD'];

    List: ChayThanNhanTao_ChiTiet[] | undefined;
    ListFilter: ChayThanNhanTao_ChiTiet[] | undefined;
    FormData!: ChayThanNhanTao_ChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ChayThanNhanTao_ChiTiet";
    }
}

