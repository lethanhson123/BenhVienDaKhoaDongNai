import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { GhiChuDuoc } from './GhiChuDuoc.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class GhiChuDuocService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'GhiChuDuoc_Id', 'NoiDung', 'BacSi_Id'];

    List: GhiChuDuoc[] | undefined;
    ListFilter: GhiChuDuoc[] | undefined;
    FormData!: GhiChuDuoc;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "GhiChuDuoc";
    }
}

