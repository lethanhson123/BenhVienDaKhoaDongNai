import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAnTongQuat_TomTat } from './BenhAnTongQuat_TomTat.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAnTongQuat_TomTatService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnTongQuat_ChiTiet_Id', 'BenhAnTongQuat_Id', 'Field_1', 'Field_2', 'Field_3', 'Field_4', 'Field_5', 'Field_6', 'Field_7'];

    List: BenhAnTongQuat_TomTat[] | undefined;
    ListFilter: BenhAnTongQuat_TomTat[] | undefined;
    FormData!: BenhAnTongQuat_TomTat;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAnTongQuat_TomTat";
    }
}

