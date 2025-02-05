import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_SYS_HANGSO } from './NS_SYS_HANGSO.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_SYS_HANGSOService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaThongTin', 'GiaTri', 'GhiChu'];

    List: NS_SYS_HANGSO[] | undefined;
    ListFilter: NS_SYS_HANGSO[] | undefined;
    FormData!: NS_SYS_HANGSO;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_SYS_HANGSO";
    }
}

