import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BCCLS_020 } from './ztmp_BCCLS_020.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BCCLS_020Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'str1', 'str2', 'str3', 'str4', 'str5', 'str6', 'str7', 'str8', 'str9', 'str10', 'str11', 'str12', 'str13', 'DiaChi', 'num1', 'num2', 'num3', 'num4', 'num5', 'num6', 'num7', 'num8', 'num9', 'num10', 'date1', 'date2', 'date3', 'date4', 'date5', 'date6', 'date7', 'date9', 'date10'];

    List: ztmp_BCCLS_020[] | undefined;
    ListFilter: ztmp_BCCLS_020[] | undefined;
    FormData!: ztmp_BCCLS_020;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BCCLS_020";
    }
}

