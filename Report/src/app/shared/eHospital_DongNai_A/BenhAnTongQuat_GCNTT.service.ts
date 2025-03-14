import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAnTongQuat_GCNTT } from './BenhAnTongQuat_GCNTT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAnTongQuat_GCNTTService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnTongQuat_ChiTiet_Id', 'BenhAnTongQuat_Id', 'Field_1', 'Field_2', 'Field_3', 'Field_4', 'Field_5', 'Field_6'];

    List: BenhAnTongQuat_GCNTT[] | undefined;
    ListFilter: BenhAnTongQuat_GCNTT[] | undefined;
    FormData!: BenhAnTongQuat_GCNTT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAnTongQuat_GCNTT";
    }
}

