import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_The_SuDungPhongCho } from './CSKH_The_SuDungPhongCho.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_The_SuDungPhongChoService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'The_SuDungPhongCho_Id', 'The_Id', 'LoaiKhachHang_Id', 'SuDung', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CSKH_The_SuDungPhongCho[] | undefined;
    ListFilter: CSKH_The_SuDungPhongCho[] | undefined;
    FormData!: CSKH_The_SuDungPhongCho;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_The_SuDungPhongCho";
    }
}

