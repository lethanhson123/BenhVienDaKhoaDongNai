import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BCDP_013 } from './ztmp_BCDP_013.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BCDP_013Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TenDuoc', 'DonViTinh', 'QuyCach', 'Number1', 'Number2', 'Number3', 'Number4', 'Number5', 'Number6', 'Number7', 'Number8', 'Number9', 'Number10', 'Number11', 'Number12', 'Number13', 'Number14', 'Number15', 'DATE1', 'DATE2', 'DATE3', 'DATE4', 'DATE5', 'DATE6', 'DATE7', 'DATE8', 'DATE9', 'DATE10', 'DATE11', 'DATE12', 'DATE13', 'DATE14', 'DATE15'];

    List: ztmp_BCDP_013[] | undefined;
    ListFilter: ztmp_BCDP_013[] | undefined;
    FormData!: ztmp_BCDP_013;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BCDP_013";
    }
}

