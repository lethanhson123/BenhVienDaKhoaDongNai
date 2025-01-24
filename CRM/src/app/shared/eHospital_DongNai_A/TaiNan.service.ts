import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TaiNan } from './TaiNan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class TaiNanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TaiNan_Id', 'TiepNhan_Id', 'BenhNhan_Id', 'KhamBenh_Id', 'NgayTaiNan', 'DiaDiem_Id', 'NguyenNhan_Id', 'MucDo_Id', 'BoPhan_Id', 'NgoDoc_Id', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'BoPhan'];

    List: TaiNan[] | undefined;
    ListFilter: TaiNan[] | undefined;
    FormData!: TaiNan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "TaiNan";
    }
}

