import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_BacLuong } from './NS_DM_BacLuong.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_BacLuongService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Id', 'MaBac', 'MaNgach', 'HeSoHuong', 'SoNamTangBac', 'KinhDoanh'];

    List: NS_DM_BacLuong[] | undefined;
    ListFilter: NS_DM_BacLuong[] | undefined;
    FormData!: NS_DM_BacLuong;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_BacLuong";
    }
}

