import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CLSYeuCauBarCode } from './CLSYeuCauBarCode.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CLSYeuCauBarCodeService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CLSYeuCauBarCode_Id', 'CLSYeuCau_Id', 'CLSYeuCauChiTiet_Id', 'BarCodeID', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CLSYeuCauBarCode[] | undefined;
    ListFilter: CLSYeuCauBarCode[] | undefined;
    FormData!: CLSYeuCauBarCode;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CLSYeuCauBarCode";
    }
}

