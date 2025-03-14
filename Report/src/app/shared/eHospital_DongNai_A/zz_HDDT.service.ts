import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zz_HDDT } from './zz_HDDT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zz_HDDTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Fkey', 'CusCode', 'CusName', 'CusAddress', 'CusPhone'];

    List: zz_HDDT[] | undefined;
    ListFilter: zz_HDDT[] | undefined;
    FormData!: zz_HDDT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zz_HDDT";
    }
}

