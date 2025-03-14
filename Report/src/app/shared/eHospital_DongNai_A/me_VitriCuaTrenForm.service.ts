import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { me_VitriCuaTrenForm } from './me_VitriCuaTrenForm.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class me_VitriCuaTrenFormService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Pos_id', 'KhuVuc_id', 'Cua_id', 'X', 'Y'];

    List: me_VitriCuaTrenForm[] | undefined;
    ListFilter: me_VitriCuaTrenForm[] | undefined;
    FormData!: me_VitriCuaTrenForm;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "me_VitriCuaTrenForm";
    }
}

