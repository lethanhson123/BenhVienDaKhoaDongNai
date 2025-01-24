import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Temp_Id_Ref } from './Temp_Id_Ref.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Temp_Id_RefService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Loai_IDRef', 'Loai_IDRef_Name', 'TableName', 'PhanNhom', 'TenPhanNhom'];

    List: Temp_Id_Ref[] | undefined;
    ListFilter: Temp_Id_Ref[] | undefined;
    FormData!: Temp_Id_Ref;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Temp_Id_Ref";
    }
}

