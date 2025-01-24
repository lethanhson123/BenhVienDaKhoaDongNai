import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { me_PhanQuyen } from './me_PhanQuyen.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class me_PhanQuyenService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhanQuyen_id', 'User_id', 'App_id', 'Menu_id', 'TamNgung'];

    List: me_PhanQuyen[] | undefined;
    ListFilter: me_PhanQuyen[] | undefined;
    FormData!: me_PhanQuyen;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "me_PhanQuyen";
    }
}

