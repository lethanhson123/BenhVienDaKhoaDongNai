import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { me_DM_Cua } from './me_DM_Cua.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class me_DM_CuaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Cua_id', 'TenCua', 'Pos_id', 'ToaDo_X', 'ToaDo_Y', 'ThoiGianTao'];

    List: me_DM_Cua[] | undefined;
    ListFilter: me_DM_Cua[] | undefined;
    FormData!: me_DM_Cua;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "me_DM_Cua";
    }
}

