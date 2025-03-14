import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAnTongQuat_LienQuanBenh_SanKhoa } from './BenhAnTongQuat_LienQuanBenh_SanKhoa.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAnTongQuat_LienQuanBenh_SanKhoaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnTongQuat_LienQuanBenh_Id', 'BenhAnTongQuat_Id', 'SoLanCoThai', 'Nam', 'DuThang', 'ThieuThang', 'Say', 'Hut', 'Nao', 'CoVAC', 'ChuaNgoaiTC', 'ChuaTrung', 'ThaiChetLuu', 'ConHienSong', 'CanNang', 'PhuongPhapDe', 'TaiBien'];

    List: BenhAnTongQuat_LienQuanBenh_SanKhoa[] | undefined;
    ListFilter: BenhAnTongQuat_LienQuanBenh_SanKhoa[] | undefined;
    FormData!: BenhAnTongQuat_LienQuanBenh_SanKhoa;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAnTongQuat_LienQuanBenh_SanKhoa";
    }
}

