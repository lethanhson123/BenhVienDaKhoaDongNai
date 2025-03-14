import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BCDN_001 } from './ztmp_BCDN_001.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BCDN_001Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'str1', 'str2', 'num1', 'num2', 'num3', 'Str10', 'Str11', 'Str12'];

    List: ztmp_BCDN_001[] | undefined;
    ListFilter: ztmp_BCDN_001[] | undefined;
    FormData!: ztmp_BCDN_001;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BCDN_001";
    }
}

