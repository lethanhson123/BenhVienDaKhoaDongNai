import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAnTongQuat_TongKet } from './BenhAnTongQuat_TongKet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAnTongQuat_TongKetService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnTongQuat_ChiTiet_Id', 'BenhAnTongQuat_Id', 'Field_1', 'Field_2', 'Field_3', 'Field_4', 'Field_5', 'Field_6', 'Field_7', 'Field_8', 'Field_9', 'Field_10'];

    List: BenhAnTongQuat_TongKet[] | undefined;
    ListFilter: BenhAnTongQuat_TongKet[] | undefined;
    FormData!: BenhAnTongQuat_TongKet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAnTongQuat_TongKet";
    }
}

