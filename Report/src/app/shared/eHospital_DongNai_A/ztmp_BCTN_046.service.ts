import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BCTN_046 } from './ztmp_BCTN_046.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BCTN_046Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'str1', 'str2', 'str3', 'str4', 'date1', 'date2', 'str5'];

    List: ztmp_BCTN_046[] | undefined;
    ListFilter: ztmp_BCTN_046[] | undefined;
    FormData!: ztmp_BCTN_046;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BCTN_046";
    }
}

