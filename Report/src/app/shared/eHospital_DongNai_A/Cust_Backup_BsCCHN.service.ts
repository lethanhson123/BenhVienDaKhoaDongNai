import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Cust_Backup_BsCCHN } from './Cust_Backup_BsCCHN.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Cust_Backup_BsCCHNService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'BenhAn_id', 'KhamBenh_id', 'BsKham_Old_id', 'BsKham_New_id', 'ThoiGianTao'];

    List: Cust_Backup_BsCCHN[] | undefined;
    ListFilter: Cust_Backup_BsCCHN[] | undefined;
    FormData!: Cust_Backup_BsCCHN;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Cust_Backup_BsCCHN";
    }
}

