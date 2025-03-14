import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TemplatePhieuLinh } from './TemplatePhieuLinh.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class TemplatePhieuLinhService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Template_Id', 'MaTemplate', 'TenTemplate', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'DienGiai', 'NguonHang_Id', 'Kho_Id'];

    List: TemplatePhieuLinh[] | undefined;
    ListFilter: TemplatePhieuLinh[] | undefined;
    FormData!: TemplatePhieuLinh;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "TemplatePhieuLinh";
    }
}

