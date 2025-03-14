import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { XepLichMo_EKipMo } from './XepLichMo_EKipMo.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class XepLichMo_EKipMoService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'XepLichMo_EKipMo_Id', 'LichMo_Id', 'NhanVien_Id', 'VaiTro_Id', 'Idx'];

    List: XepLichMo_EKipMo[] | undefined;
    ListFilter: XepLichMo_EKipMo[] | undefined;
    FormData!: XepLichMo_EKipMo;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "XepLichMo_EKipMo";
    }
}

