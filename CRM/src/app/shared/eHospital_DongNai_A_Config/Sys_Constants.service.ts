import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_Constants } from './Sys_Constants.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_ConstantsService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Const_Id', 'Const_Group_Parent', 'Const_Group', 'Const_Code', 'Const_Value', 'Const_Value_1', 'Const_Value_2', 'Const_Value_3', 'Description', 'Const_Value_Default', 'Const_Value_Default_1', 'Const_Value_Default_2', 'Const_Value_Default_3', 'Change_Log'];

    List: Sys_Constants[] | undefined;
    ListFilter: Sys_Constants[] | undefined;
    FormData!: Sys_Constants;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_Constants";
    }
}

