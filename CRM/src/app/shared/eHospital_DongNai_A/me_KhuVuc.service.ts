import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { me_KhuVuc } from './me_KhuVuc.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class me_KhuVucService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhuVuc_id', 'TenKhuVuc', 'NgayTao', 'NgayCapNhat'];

    List: me_KhuVuc[] | undefined;
    ListFilter: me_KhuVuc[] | undefined;
    FormData!: me_KhuVuc;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "me_KhuVuc";
    }
}

