import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Query1$ } from './Query1$.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Query1$Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhongBan_Id', 'TenPhongBan', 'TenPhongBan_En', 'TenPhongBan_Ru', 'Loai'];

    List: Query1$[] | undefined;
    ListFilter: Query1$[] | undefined;
    FormData!: Query1$;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Query1$";
    }
}

