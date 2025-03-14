import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { XML4 } from './XML4.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class XML4Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'XML4_id', 'LoaiKCB', 'IdMaLienKet', 'Loai_KQ', 'IDRef', 'MA_DICH_VU', 'MA_CHI_SO', 'TEN_CHI_SO', 'GIA_TRI', 'MA_MAY', 'MO_TA', 'KET_LUAN', 'NGAY_KQ', 'NgayTao', 'NguoiTao', 'NgayCapNhat', 'NguoiCapNhat'];

    List: XML4[] | undefined;
    ListFilter: XML4[] | undefined;
    FormData!: XML4;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "XML4";
    }
}

