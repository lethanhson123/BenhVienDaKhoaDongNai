import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoiChan_EKipMo } from './HoiChan_EKipMo.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoiChan_EKipMoService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HoiChan_EKipMo_Id', 'HoiChan_Id', 'NhanVien_Id', 'VaiTro_Id', 'Idx'];

    List: HoiChan_EKipMo[] | undefined;
    ListFilter: HoiChan_EKipMo[] | undefined;
    FormData!: HoiChan_EKipMo;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoiChan_EKipMo";
    }
}

