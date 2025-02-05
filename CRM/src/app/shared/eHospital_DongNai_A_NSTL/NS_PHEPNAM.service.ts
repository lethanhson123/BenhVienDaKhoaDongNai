import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_PHEPNAM } from './NS_PHEPNAM.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_PHEPNAMService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaNhanVien', 'Nam', 'NgayPhep', 'T1', 'T2', 'T3', 'T4', 'T5', 'T6', 'T7', 'T8', 'T9', 'T10', 'T11', 'T12', 'TraLuong', 'PhepDu', 'Du1', 'Du2', 'Du3', 'Du4', 'Du5', 'PhepNamCu', 'PhepNamNay', 'PhepThamNien'];

    List: NS_PHEPNAM[] | undefined;
    ListFilter: NS_PHEPNAM[] | undefined;
    FormData!: NS_PHEPNAM;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_PHEPNAM";
    }
}

