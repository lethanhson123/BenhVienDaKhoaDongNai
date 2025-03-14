import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CDT_KSK_PhanLoaiDoTuoi } from './CDT_KSK_PhanLoaiDoTuoi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CDT_KSK_PhanLoaiDoTuoiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KSK_PhanLoaiDoTuoi_Id', 'KSK_NgoaiVien_Id', 'DoTuoi_Id', 'SoCa', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CDT_KSK_PhanLoaiDoTuoi[] | undefined;
    ListFilter: CDT_KSK_PhanLoaiDoTuoi[] | undefined;
    FormData!: CDT_KSK_PhanLoaiDoTuoi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CDT_KSK_PhanLoaiDoTuoi";
    }
}

