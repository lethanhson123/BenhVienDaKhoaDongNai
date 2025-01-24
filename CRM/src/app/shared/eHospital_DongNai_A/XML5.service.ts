import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { XML5 } from './XML5.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class XML5Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'XML5_id', 'LoaiKCB', 'IdMaLienKet', 'Loai_DienBien', 'IDRef', 'DIEN_BIEN', 'HOI_CHAN', 'PHAU_THUAT', 'NGAY_YL', 'NgayTao', 'NguoiTao', 'NgayCapNhat', 'NguoiCapNhat'];

    List: XML5[] | undefined;
    ListFilter: XML5[] | undefined;
    FormData!: XML5;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "XML5";
    }
}

