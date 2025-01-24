import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzz_BS_YLenh_B } from './zzz_BS_YLenh_B.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzz_BS_YLenh_BService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'MaBS', 'NgayYL', 'NgayYL2'];

    List: zzz_BS_YLenh_B[] | undefined;
    ListFilter: zzz_BS_YLenh_B[] | undefined;
    FormData!: zzz_BS_YLenh_B;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzz_BS_YLenh_B";
    }
}

