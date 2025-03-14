import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { me_DM_MACAddress } from './me_DM_MACAddress.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class me_DM_MACAddressService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MAC_id', 'MacAddress', 'MoTa', 'NgayTao', 'NgayCapNhat'];

    List: me_DM_MACAddress[] | undefined;
    ListFilter: me_DM_MACAddress[] | undefined;
    FormData!: me_DM_MACAddress;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "me_DM_MACAddress";
    }
}

