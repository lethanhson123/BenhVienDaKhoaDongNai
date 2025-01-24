import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Cus_DoiTac_NoiXuat } from './Cus_DoiTac_NoiXuat.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Cus_DoiTac_NoiXuatService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DoiTac_NoiXuat_id', 'DoiTac_id', 'ViTri_id', 'DS_Duoc_id', 'TamNgung'];

    List: Cus_DoiTac_NoiXuat[] | undefined;
    ListFilter: Cus_DoiTac_NoiXuat[] | undefined;
    FormData!: Cus_DoiTac_NoiXuat;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Cus_DoiTac_NoiXuat";
    }
}

