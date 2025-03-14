import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_DoTuoiCDT } from './DM_DoTuoiCDT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_DoTuoiCDTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DoTuoi_Id', 'MaDoTuoi', 'TenDoTuoi', 'TamNgung', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: DM_DoTuoiCDT[] | undefined;
    ListFilter: DM_DoTuoiCDT[] | undefined;
    FormData!: DM_DoTuoiCDT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_DoTuoiCDT";
    }
}

