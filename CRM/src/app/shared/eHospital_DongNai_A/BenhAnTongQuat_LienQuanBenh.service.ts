import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAnTongQuat_LienQuanBenh } from './BenhAnTongQuat_LienQuanBenh.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAnTongQuat_LienQuanBenhService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnTongQuat_LienQuanBenh_Id', 'BenhAnTongQuat_Id', 'NoiDung_Id', 'KyHieu', 'ThoiGian'];

    List: BenhAnTongQuat_LienQuanBenh[] | undefined;
    ListFilter: BenhAnTongQuat_LienQuanBenh[] | undefined;
    FormData!: BenhAnTongQuat_LienQuanBenh;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAnTongQuat_LienQuanBenh";
    }
}

