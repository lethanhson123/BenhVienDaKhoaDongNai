import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TemplatePhieuLinhChiTiet } from './TemplatePhieuLinhChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class TemplatePhieuLinhChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Template_ChiTiet_Id', 'Template_Id', 'Duoc_Id', 'DonViTinh_Id', 'SoLuongYeuCau', 'NguonHang_Id'];

    List: TemplatePhieuLinhChiTiet[] | undefined;
    ListFilter: TemplatePhieuLinhChiTiet[] | undefined;
    FormData!: TemplatePhieuLinhChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "TemplatePhieuLinhChiTiet";
    }
}

