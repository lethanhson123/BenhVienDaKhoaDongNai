import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_LyDoNghiViec } from './NS_DM_LyDoNghiViec.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_LyDoNghiViecService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaLyDoNghi', 'TenLyDoNghi'];

    List: NS_DM_LyDoNghiViec[] | undefined;
    ListFilter: NS_DM_LyDoNghiViec[] | undefined;
    FormData!: NS_DM_LyDoNghiViec;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_LyDoNghiViec";
    }
}

