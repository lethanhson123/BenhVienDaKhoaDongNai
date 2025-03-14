import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhSu } from './BenhSu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhSuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Cap', 'Ma', 'MaCapTren', 'Ten', 'TenPhu', 'aspx'];

    List: BenhSu[] | undefined;
    ListFilter: BenhSu[] | undefined;
    FormData!: BenhSu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhSu";
    }
}

