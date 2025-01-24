import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BC_Mau25A_NgoaiTru_E } from './ztmp_BC_Mau25A_NgoaiTru_E.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BC_Mau25A_NgoaiTru_EService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NhomDoiTuong', 'NhomDKKCB', 'Column2', 'Column4', 'Ngay', 'TenBenhNhan', 'NamSinh', 'GioiTinh', 'SoBHYT', 'BenhVienDangKyKCBBanDau', 'MaBenh', 'SoPhieuThanhToanNgoaiTru', 'TienKham', 'XN', 'CDHA_TDCN', 'TT_PT', 'DVKT_Cao', 'Mau', 'Thuoc', 'VTYT', 'CPVC', 'TongCong', 'NguoiBenhCungChiTra', 'SoTien', 'ChiPhiNgoaiQuy', 'Column1', 'gt_tu', 'gt_den', 'noikcb', 'nam_qt', 'thang_qt', 'lydo_vv', 'benhkhac', 'DiaChi', 'KhoaDT', 'ThuocK', 'Column3'];

    List: ztmp_BC_Mau25A_NgoaiTru_E[] | undefined;
    ListFilter: ztmp_BC_Mau25A_NgoaiTru_E[] | undefined;
    FormData!: ztmp_BC_Mau25A_NgoaiTru_E;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BC_Mau25A_NgoaiTru_E";
    }
}

