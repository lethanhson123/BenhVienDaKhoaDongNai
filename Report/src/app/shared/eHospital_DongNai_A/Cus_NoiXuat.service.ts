import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Cus_NoiXuat } from './Cus_NoiXuat.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Cus_NoiXuatService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ViTri_id', 'TenViTri', 'Loai', 'Khu', 'KhoDuoc_id', 'TamNgung'];

    List: Cus_NoiXuat[] | undefined;
    ListFilter: Cus_NoiXuat[] | undefined;
    FormData!: Cus_NoiXuat;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Cus_NoiXuat";
    }
}

