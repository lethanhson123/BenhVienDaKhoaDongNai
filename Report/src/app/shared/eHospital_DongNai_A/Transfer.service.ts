import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Transfer } from './Transfer.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class TransferService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Transfer_Id', 'Transfer_Code', 'Transfer_Type', 'Transfer_Date', 'Transfer_TuNgay', 'Transfer_DenNgay', 'TrangThai', 'GhiChu', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat'];

    List: Transfer[] | undefined;
    ListFilter: Transfer[] | undefined;
    FormData!: Transfer;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Transfer";
    }
}

