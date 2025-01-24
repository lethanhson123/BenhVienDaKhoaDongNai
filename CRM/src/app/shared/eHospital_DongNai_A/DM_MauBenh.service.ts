import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_MauBenh } from './DM_MauBenh.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_MauBenhService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MauBenh_Id', 'MaMauBenh', 'TenMauBenh', 'TenKhongDau', 'TamNgung'];

    List: DM_MauBenh[] | undefined;
    ListFilter: DM_MauBenh[] | undefined;
    FormData!: DM_MauBenh;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_MauBenh";
    }
}

