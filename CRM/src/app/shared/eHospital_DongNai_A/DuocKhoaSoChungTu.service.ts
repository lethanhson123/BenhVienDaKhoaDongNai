import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuocKhoaSoChungTu } from './DuocKhoaSoChungTu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuocKhoaSoChungTuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DuocKhoaSoChungTu_Id', 'DuocKyTonKho_Id', 'KhoDuoc_Id', 'KhoaSo', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: DuocKhoaSoChungTu[] | undefined;
    ListFilter: DuocKhoaSoChungTu[] | undefined;
    FormData!: DuocKhoaSoChungTu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuocKhoaSoChungTu";
    }
}

