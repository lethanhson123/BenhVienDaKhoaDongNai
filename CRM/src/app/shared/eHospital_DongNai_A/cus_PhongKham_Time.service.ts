import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { cus_PhongKham_Time } from './cus_PhongKham_Time.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class cus_PhongKham_TimeService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhongBan_id', 'TGKham_Phut'];

    List: cus_PhongKham_Time[] | undefined;
    ListFilter: cus_PhongKham_Time[] | undefined;
    FormData!: cus_PhongKham_Time;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "cus_PhongKham_Time";
    }
}

