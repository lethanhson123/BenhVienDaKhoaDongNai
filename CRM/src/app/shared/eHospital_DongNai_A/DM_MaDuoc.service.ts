import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_MaDuoc } from './DM_MaDuoc.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_MaDuocService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaDuoc'];

    List: DM_MaDuoc[] | undefined;
    ListFilter: DM_MaDuoc[] | undefined;
    FormData!: DM_MaDuoc;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_MaDuoc";
    }
}

