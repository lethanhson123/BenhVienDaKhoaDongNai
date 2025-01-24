import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzz_BS_YLenh_A } from './zzz_BS_YLenh_A.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzz_BS_YLenh_AService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'MaBS', 'NgayYL', 'NgayYL2'];

    List: zzz_BS_YLenh_A[] | undefined;
    ListFilter: zzz_BS_YLenh_A[] | undefined;
    FormData!: zzz_BS_YLenh_A;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzz_BS_YLenh_A";
    }
}

