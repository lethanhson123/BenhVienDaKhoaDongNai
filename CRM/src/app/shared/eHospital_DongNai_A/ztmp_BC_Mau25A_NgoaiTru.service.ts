import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BC_Mau25A_NgoaiTru } from './ztmp_BC_Mau25A_NgoaiTru.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BC_Mau25A_NgoaiTruService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NhomDKKCB', 'Column2', 'Ngay', 'TenBenhNhan', 'NamSinh', 'GioiTinh', 'SoBHYT', 'BenhVienDangKyKCBBanDau', 'MaBenh', 'SoPhieuThanhToanNgoaiTru', 'TienKham', 'XN', 'CDHA_TDCN', 'TT_PT', 'DVKT_Cao', 'Mau', 'Thuoc', 'VTYT', 'ThuocK', 'CPVC', 'TongCong', 'NguoiBenhCungChiTra', 'SoTien', 'ChiPhiNgoaiQuy', 'Column1'];

    List: ztmp_BC_Mau25A_NgoaiTru[] | undefined;
    ListFilter: ztmp_BC_Mau25A_NgoaiTru[] | undefined;
    FormData!: ztmp_BC_Mau25A_NgoaiTru;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BC_Mau25A_NgoaiTru";
    }
}

