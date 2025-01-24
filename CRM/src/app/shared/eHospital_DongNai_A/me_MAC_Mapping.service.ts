import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { me_MAC_Mapping } from './me_MAC_Mapping.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class me_MAC_MappingService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Mapping_id', 'MAC_id', 'Cua_id', 'KhuVuc_id', 'TamNgung', 'NgayMapping', 'SoDaCap', 'ThoiGianCap', 'SoDaGoi', 'ThoiGianGoi'];

    List: me_MAC_Mapping[] | undefined;
    ListFilter: me_MAC_Mapping[] | undefined;
    FormData!: me_MAC_Mapping;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "me_MAC_Mapping";
    }
}

