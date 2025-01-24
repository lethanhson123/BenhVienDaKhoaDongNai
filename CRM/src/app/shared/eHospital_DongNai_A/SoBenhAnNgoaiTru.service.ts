import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { SoBenhAnNgoaiTru } from './SoBenhAnNgoaiTru.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class SoBenhAnNgoaiTruService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'SoBenhAnNgoaiTru_Id', 'LoaiBenhAn_Id', 'BenhNhan_Id', 'SoBenhAnNgoaiTru', 'STT', 'NgayCap', 'NgayVao', 'NgayKetThuc', 'TamNgung', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat'];

    List: SoBenhAnNgoaiTru[] | undefined;
    ListFilter: SoBenhAnNgoaiTru[] | undefined;
    FormData!: SoBenhAnNgoaiTru;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "SoBenhAnNgoaiTru";
    }
}

