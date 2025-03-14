import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { me_AppList } from './me_AppList.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class me_AppListService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'APP_id', 'APP_Name'];

    List: me_AppList[] | undefined;
    ListFilter: me_AppList[] | undefined;
    FormData!: me_AppList;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "me_AppList";
    }
}

