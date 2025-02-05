import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_PhongBan_DinhSuat } from './NS_PhongBan_DinhSuat.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_PhongBan_DinhSuatService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'PhongBan_Id', 'DinhSuat_Id'];

    List: NS_PhongBan_DinhSuat[] | undefined;
    ListFilter: NS_PhongBan_DinhSuat[] | undefined;
    FormData!: NS_PhongBan_DinhSuat;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_PhongBan_DinhSuat";
    }
}

