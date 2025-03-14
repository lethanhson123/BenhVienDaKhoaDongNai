import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzz_TyLeApTran } from './zzz_TyLeApTran.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzz_TyLeApTranService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'SoVaoVien', 'NgayVao', 'NgayRa'];

    List: zzz_TyLeApTran[] | undefined;
    ListFilter: zzz_TyLeApTran[] | undefined;
    FormData!: zzz_TyLeApTran;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzz_TyLeApTran";
    }
}

