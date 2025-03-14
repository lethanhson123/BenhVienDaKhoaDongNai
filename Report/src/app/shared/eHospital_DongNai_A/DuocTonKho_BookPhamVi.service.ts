import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuocTonKho_BookPhamVi } from './DuocTonKho_BookPhamVi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuocTonKho_BookPhamViService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DuocTonKho_BookPhamVi_ID', 'PhamVi_ID', 'NoiTru_ToaThuoc_ID', 'Duoc_ID', 'SoLuong', 'NguonHang_Id', 'NgayHieuLuc', 'KhoCoSo_Id', 'BenhAnNgoaiTru_ToaThuoc_ID'];

    List: DuocTonKho_BookPhamVi[] | undefined;
    ListFilter: DuocTonKho_BookPhamVi[] | undefined;
    FormData!: DuocTonKho_BookPhamVi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuocTonKho_BookPhamVi";
    }
}

