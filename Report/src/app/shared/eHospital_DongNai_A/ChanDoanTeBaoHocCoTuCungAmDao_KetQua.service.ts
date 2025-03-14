import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ChanDoanTeBaoHocCoTuCungAmDao_KetQua } from './ChanDoanTeBaoHocCoTuCungAmDao_KetQua.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ChanDoanTeBaoHocCoTuCungAmDao_KetQuaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhieuChanDoanTeBaoHocCoTuCungAmDao_KetQua_Id', 'PhieuChanDoanTeBaoHocCoTuCungAmDao_Id', 'Field_38', 'Field_39', 'Field_40', 'Field_41', 'Field_42', 'Field_43', 'Field_44', 'Field_45', 'Field_46', 'Field_47', 'Field_48', 'Field_49', 'Field_50', 'Field_51', 'Field_52', 'Field_53', 'Field_54', 'Field_55', 'Field_56', 'Field_57', 'Field_58', 'Field_59', 'Field_60', 'Field_61', 'Field_62', 'Field_63', 'BacSiTeBaoHoc_Id', 'MaSoLam', 'SoMauBenhPham'];

    List: ChanDoanTeBaoHocCoTuCungAmDao_KetQua[] | undefined;
    ListFilter: ChanDoanTeBaoHocCoTuCungAmDao_KetQua[] | undefined;
    FormData!: ChanDoanTeBaoHocCoTuCungAmDao_KetQua;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ChanDoanTeBaoHocCoTuCungAmDao_KetQua";
    }
}

