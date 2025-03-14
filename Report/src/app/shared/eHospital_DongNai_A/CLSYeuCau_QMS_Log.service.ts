import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CLSYeuCau_QMS_Log } from './CLSYeuCau_QMS_Log.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CLSYeuCau_QMS_LogService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CLSYeuCau_Id', 'SoTT', 'HangDoi_Idx', 'HangDoi_Details', 'KhuVuc', 'App'];

    List: CLSYeuCau_QMS_Log[] | undefined;
    ListFilter: CLSYeuCau_QMS_Log[] | undefined;
    FormData!: CLSYeuCau_QMS_Log;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CLSYeuCau_QMS_Log";
    }
}

