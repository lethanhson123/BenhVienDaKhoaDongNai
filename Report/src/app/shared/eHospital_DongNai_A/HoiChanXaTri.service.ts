import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoiChanXaTri } from './HoiChanXaTri.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoiChanXaTriService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HoiChanXaTri_Id', 'SoPhieu', 'BenhAn_Id', 'BacSiChuNhiem_Id', 'BacSiDieuTri_Id', 'ChanDoanLamSang', 'GiaiPhauBenhLy', 'DieuTriTruoc', 'LamSang', 'CanLamSang', 'ViTriChieuXa', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'NgayTao'];

    List: HoiChanXaTri[] | undefined;
    ListFilter: HoiChanXaTri[] | undefined;
    FormData!: HoiChanXaTri;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoiChanXaTri";
    }
}

