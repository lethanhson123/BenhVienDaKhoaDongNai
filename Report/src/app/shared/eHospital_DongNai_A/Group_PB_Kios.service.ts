import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Group_PB_Kios } from './Group_PB_Kios.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Group_PB_KiosService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Group_PB_Kios_Id', 'MaGroup', 'TenGroup'];

    List: Group_PB_Kios[] | undefined;
    ListFilter: Group_PB_Kios[] | undefined;
    FormData!: Group_PB_Kios;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Group_PB_Kios";
    }
}

