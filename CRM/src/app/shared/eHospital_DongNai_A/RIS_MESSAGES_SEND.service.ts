import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { RIS_MESSAGES_SEND } from './RIS_MESSAGES_SEND.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class RIS_MESSAGES_SENDService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Messages_Id', 'Messages_Control_Id', 'Messages_Type', 'Messages_Type_Code', 'Messages_Name', 'BenhNhan_Id', 'TiepNhan_Id', 'BenhAn_Id', 'CLSYeuCau_Id', 'YeuCauChiTiet_Id', 'DichVu_Id', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat'];

    List: RIS_MESSAGES_SEND[] | undefined;
    ListFilter: RIS_MESSAGES_SEND[] | undefined;
    FormData!: RIS_MESSAGES_SEND;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "RIS_MESSAGES_SEND";
    }
}

