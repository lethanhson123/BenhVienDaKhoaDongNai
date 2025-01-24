import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { cus_BacSiKham_Time } from './cus_BacSiKham_Time.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class cus_BacSiKham_TimeService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BacSiKham_id', 'TGKham_Phut'];

    List: cus_BacSiKham_Time[] | undefined;
    ListFilter: cus_BacSiKham_Time[] | undefined;
    FormData!: cus_BacSiKham_Time;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "cus_BacSiKham_Time";
    }
}

