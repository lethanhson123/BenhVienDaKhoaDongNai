import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_GIAHANHOPDONG } from './NS_GIAHANHOPDONG.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_GIAHANHOPDONGService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'id', 'Mahopdong', 'GiahanTungay', 'GiahanDenngay', 'Solangiahan'];

    List: NS_GIAHANHOPDONG[] | undefined;
    ListFilter: NS_GIAHANHOPDONG[] | undefined;
    FormData!: NS_GIAHANHOPDONG;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_GIAHANHOPDONG";
    }
}

