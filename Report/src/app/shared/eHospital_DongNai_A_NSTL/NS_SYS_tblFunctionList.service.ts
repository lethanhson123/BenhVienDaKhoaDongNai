import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_SYS_tblFunctionList } from './NS_SYS_tblFunctionList.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_SYS_tblFunctionListService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'FunctionID', 'FunctionNameV', 'FunctionNameE', 'ModuleID', 'Url', 'Ascx', 'Rank', 'Display', 'Left_Horizontal', 'Parent', 'cssClass', 'TitleV', 'TitleE'];

    List: NS_SYS_tblFunctionList[] | undefined;
    ListFilter: NS_SYS_tblFunctionList[] | undefined;
    FormData!: NS_SYS_tblFunctionList;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_SYS_tblFunctionList";
    }
}

