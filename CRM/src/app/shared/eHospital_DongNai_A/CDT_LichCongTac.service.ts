import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CDT_LichCongTac } from './CDT_LichCongTac.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CDT_LichCongTacService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CDT_LichCongTac_Id', 'CDT_Loai_Id', 'NoiDungCongViec', 'NgayThucHien', 'ThoiGianThucHien', 'ThanhPhanThamGiaDuKien', 'KinhPhiDuKien', 'NguoiLap_Id', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CDT_LichCongTac[] | undefined;
    ListFilter: CDT_LichCongTac[] | undefined;
    FormData!: CDT_LichCongTac;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CDT_LichCongTac";
    }
}

