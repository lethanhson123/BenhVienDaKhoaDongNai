import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Import_DM_DonViHanhChinh } from './Import_DM_DonViHanhChinh.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Import_DM_DonViHanhChinhService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaPX', 'TenPX', 'TenPXTat', 'TenTiengAnh', 'Cap', 'PhuongXa_Id', 'MaQH', 'TenQH', 'TenQHTat', 'QuanHuyen_Id', 'MaTinh', 'TenTinh', 'TenTinhTat', 'Tinh_Id'];

    List: Import_DM_DonViHanhChinh[] | undefined;
    ListFilter: Import_DM_DonViHanhChinh[] | undefined;
    FormData!: Import_DM_DonViHanhChinh;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Import_DM_DonViHanhChinh";
    }
}

