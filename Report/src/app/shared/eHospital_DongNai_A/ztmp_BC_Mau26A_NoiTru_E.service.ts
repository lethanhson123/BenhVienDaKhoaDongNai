import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BC_Mau26A_NoiTru_E } from './ztmp_BC_Mau26A_NoiTru_E.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BC_Mau26A_NoiTru_EService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NhomDoiTuong', 'NhomDKKCB', 'Column2', 'TenBenhNhan', 'NamSinh', 'GioiTinh', 'SoBHYT', 'BenhVienDangKyKCBBanDau', 'SoPhieuThanhToanNgoaiTru', 'TienKham', 'XN', 'CDHA_TDCN', 'TT_PT', 'DVKT_Cao', 'Mau', 'Thuoc', 'VTYT', 'ThuocK', 'CPVC', 'Column6', 'TongCong', 'NguoiBenhCungChiTra', 'SoTien', 'ChiPhiNgoaiQuy', 'Column9', 'Column10', 'Column5', 'Column1', 'MaBenh', 'Thang', 'Nam', 'DiaChi', 'BHYTTuNgay', 'BHYTDenNgay', 'lydo_vv', 'benhkhac', 'noikcb', 'KhoaDT', 'nam_qt', 'thang_qt', 'gt_tu', 'gt_den', 'gt_diachi'];

    List: ztmp_BC_Mau26A_NoiTru_E[] | undefined;
    ListFilter: ztmp_BC_Mau26A_NoiTru_E[] | undefined;
    FormData!: ztmp_BC_Mau26A_NoiTru_E;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BC_Mau26A_NoiTru_E";
    }
}

