import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CLSKetQuaYeuCau } from './CLSKetQuaYeuCau.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CLSKetQuaYeuCauService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CLSKetQua_Id', 'CLSYeuCau_Id'];

    List: CLSKetQuaYeuCau[] | undefined;
    ListFilter: CLSKetQuaYeuCau[] | undefined;
    FormData!: CLSKetQuaYeuCau;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CLSKetQuaYeuCau";
    }
}

