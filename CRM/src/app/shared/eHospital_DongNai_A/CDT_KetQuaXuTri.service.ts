import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CDT_KetQuaXuTri } from './CDT_KetQuaXuTri.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CDT_KetQuaXuTriService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CDT_KetQua_Id', 'TiepNhan_Id', 'BenhNhan_Id', 'KetQuaXuTri', 'XuTriDacBiet', 'TamNgung', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'ChanDoanTuyenDuoi', 'XuTriTuyenDuoi', 'ChanDoanBenhVien', 'XuTriBenhVien'];

    List: CDT_KetQuaXuTri[] | undefined;
    ListFilter: CDT_KetQuaXuTri[] | undefined;
    FormData!: CDT_KetQuaXuTri;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CDT_KetQuaXuTri";
    }
}

