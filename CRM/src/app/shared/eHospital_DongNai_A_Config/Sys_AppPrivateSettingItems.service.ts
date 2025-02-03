import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_AppPrivateSettingItems } from './Sys_AppPrivateSettingItems.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_AppPrivateSettingItemsService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Setting_Id', 'SettingCode', 'SettingName', 'ControlName'];

    List: Sys_AppPrivateSettingItems[] | undefined;
    ListFilter: Sys_AppPrivateSettingItems[] | undefined;
    FormData!: Sys_AppPrivateSettingItems;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_AppPrivateSettingItems";
    }
}

