import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoiChan_BenhLy } from './HoiChan_BenhLy.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoiChan_BenhLyService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HoiChan_BenhLy_Id', 'LoaiBenhLy', 'HoiChan_Id', 'BenhLy_Id', 'GhiChu'];

    List: HoiChan_BenhLy[] | undefined;
    ListFilter: HoiChan_BenhLy[] | undefined;
    FormData!: HoiChan_BenhLy;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoiChan_BenhLy";
    }
}

