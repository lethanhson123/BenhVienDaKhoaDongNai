import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_CHAMCONG } from './NS_CHAMCONG.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_CHAMCONGService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'MaNhanVien', 'Ngaylamviec'];

    List: NS_CHAMCONG[] | undefined;
    ListFilter: NS_CHAMCONG[] | undefined;
    FormData!: NS_CHAMCONG;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_CHAMCONG";
    }
}

