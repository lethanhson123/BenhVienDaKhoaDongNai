import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { LyDoChuyenKhoa } from './LyDoChuyenKhoa.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class LyDoChuyenKhoaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'LyDoChuyenKhoa_Id', 'LyDoChuyenKhoa_DienGiai'];

    List: LyDoChuyenKhoa[] | undefined;
    ListFilter: LyDoChuyenKhoa[] | undefined;
    FormData!: LyDoChuyenKhoa;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "LyDoChuyenKhoa";
    }
}

