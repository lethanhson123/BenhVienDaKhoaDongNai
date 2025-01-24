import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Cust_SyncHDDT_Temp } from './Cust_SyncHDDT_Temp.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Cust_SyncHDDT_TempService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'Fkey', 'IsNoiTru', 'Status', 'Synchronized', 'SyncCreateDate', 'SoChungTu', 'LoaiChungTu', 'BenhAn_id', 'PhatSinh_Noi_id', 'PhatSinh_Nguoi_id', 'PhatSinh_ThoiGian', 'NguoiTao'];

    List: Cust_SyncHDDT_Temp[] | undefined;
    ListFilter: Cust_SyncHDDT_Temp[] | undefined;
    FormData!: Cust_SyncHDDT_Temp;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Cust_SyncHDDT_Temp";
    }
}

