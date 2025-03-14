import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BCDM_006 } from './ztmp_BCDM_006.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BCDM_006Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TenLoaiDuoc', 'MaDuoc', 'String1', 'DonViTinh', 'PhamVi', 'String3', 'String2', 'String5', 'number1', 'number2'];

    List: ztmp_BCDM_006[] | undefined;
    ListFilter: ztmp_BCDM_006[] | undefined;
    FormData!: ztmp_BCDM_006;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BCDM_006";
    }
}

