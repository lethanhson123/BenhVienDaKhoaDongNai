import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_DoiTuongCDT } from './DM_DoiTuongCDT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_DoiTuongCDTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DoiTuong_Id', 'MaDoiTuong', 'TenDoiTuong', 'TamNgung', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: DM_DoiTuongCDT[] | undefined;
    ListFilter: DM_DoiTuongCDT[] | undefined;
    FormData!: DM_DoiTuongCDT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_DoiTuongCDT";
    }
}

