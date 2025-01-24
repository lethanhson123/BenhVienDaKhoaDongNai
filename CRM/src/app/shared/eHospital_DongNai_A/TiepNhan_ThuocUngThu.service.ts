import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TiepNhan_ThuocUngThu } from './TiepNhan_ThuocUngThu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class TiepNhan_ThuocUngThuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TiepNhan_ThuocUngThu_Id', 'TiepNhan_Id', 'DuocPhepSuDung', 'GiayChungNhan', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: TiepNhan_ThuocUngThu[] | undefined;
    ListFilter: TiepNhan_ThuocUngThu[] | undefined;
    FormData!: TiepNhan_ThuocUngThu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "TiepNhan_ThuocUngThu";
    }
}

