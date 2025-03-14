import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { me_MenuList } from './me_MenuList.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class me_MenuListService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Menu_id', 'Menu_Name'];

    List: me_MenuList[] | undefined;
    ListFilter: me_MenuList[] | undefined;
    FormData!: me_MenuList;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "me_MenuList";
    }
}

