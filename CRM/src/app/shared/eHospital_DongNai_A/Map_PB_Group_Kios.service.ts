import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Map_PB_Group_Kios } from './Map_PB_Group_Kios.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Map_PB_Group_KiosService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Map_PB_Group_Kios_id', 'Group_PB_Kios_Id', 'PhongBan_Id'];

    List: Map_PB_Group_Kios[] | undefined;
    ListFilter: Map_PB_Group_Kios[] | undefined;
    FormData!: Map_PB_Group_Kios;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Map_PB_Group_Kios";
    }
}

