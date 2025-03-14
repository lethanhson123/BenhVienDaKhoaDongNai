import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { XacNhanChiPhi_DEL } from './XacNhanChiPhi_DEL.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class XacNhanChiPhi_DELService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'Ma_File', 'Ma_Lk', 'XacNhanChiPhi_Id', 'TiepNhan_Id', 'BenhAn_Id', 'BenhNhan_Id', 'SoBHYT', 'Loai', 'NgayVao', 'NgayRa', 'NgayDel', 'isExport'];

    List: XacNhanChiPhi_DEL[] | undefined;
    ListFilter: XacNhanChiPhi_DEL[] | undefined;
    FormData!: XacNhanChiPhi_DEL;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "XacNhanChiPhi_DEL";
    }
}

