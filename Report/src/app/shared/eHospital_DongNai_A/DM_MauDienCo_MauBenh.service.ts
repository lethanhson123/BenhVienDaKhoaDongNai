import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_MauDienCo_MauBenh } from './DM_MauDienCo_MauBenh.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_MauDienCo_MauBenhService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MauDienCo_MauBenh_Id', 'MauDienCo_Id', 'MauBenh_Id'];

    List: DM_MauDienCo_MauBenh[] | undefined;
    ListFilter: DM_MauDienCo_MauBenh[] | undefined;
    FormData!: DM_MauDienCo_MauBenh;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_MauDienCo_MauBenh";
    }
}

