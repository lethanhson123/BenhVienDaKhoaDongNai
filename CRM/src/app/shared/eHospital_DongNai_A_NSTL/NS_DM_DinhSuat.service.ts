import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_DinhSuat } from './NS_DM_DinhSuat.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_DinhSuatService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'MaDinhSuat', 'TenDinhSuat', 'DonGia', 'GhiChu'];

    List: NS_DM_DinhSuat[] | undefined;
    ListFilter: NS_DM_DinhSuat[] | undefined;
    FormData!: NS_DM_DinhSuat;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_DinhSuat";
    }
}

