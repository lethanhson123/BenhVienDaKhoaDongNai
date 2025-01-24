import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { PhieuDieuTri } from './PhieuDieuTri.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class PhieuDieuTriService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhieuDieuTri_Id', 'BenhNhan_Id', 'SoPhieuDieuTri', 'STT', 'NgayCap', 'NgayHieuLuc', 'NgayHetHieuLuc', 'TamNgung', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat'];

    List: PhieuDieuTri[] | undefined;
    ListFilter: PhieuDieuTri[] | undefined;
    FormData!: PhieuDieuTri;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "PhieuDieuTri";
    }
}

