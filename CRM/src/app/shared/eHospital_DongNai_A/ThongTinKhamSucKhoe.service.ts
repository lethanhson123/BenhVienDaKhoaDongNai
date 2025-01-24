import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ThongTinKhamSucKhoe } from './ThongTinKhamSucKhoe.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ThongTinKhamSucKhoeService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhamSucKhoe_Id', 'SoPhieu', 'BenhNhan_Id', 'TiepNhan_Id', 'HopDong_BenhNhan_Id', 'NgayKham', 'TienSu', 'ChieuCao', 'CanNang', 'NhipTho', 'BMI', 'Mach', 'HuyetApCao', 'HuyetApThap', 'NhietDo', 'TheLucPhanLoai_Id', 'TuanHoan', 'HoHap', 'TieuHoa', 'ThanTietNieu', 'NoiTiet', 'CoXuongKhop', 'ThanKinh', 'TamThan', 'TuanHoanPhanLoai_Id', 'HoHapPhanLoai_Id', 'TieuHoaPhanLoai_Id', 'ThanTietNieuPhanLoai_Id', 'NoiTietPhanLoai_Id', 'CoXuongKhopPhanLoai_Id', 'ThanKinhPhanLoai_Id', 'TamThanPhanLoai_Id', 'Mat', 'MatPhanLoai_Id', 'ThiLucTraiCoKinh', 'ThiLucPhaiCoKinh', 'ThiLucTraiKhongKinh', 'ThiLucPhaiKhongKinh', 'TMH', 'TMHPhanLoai_Id', 'TaiTraiNoiThuong', 'TaiPhaiNoiThuong', 'TaiTraiNoiTham', 'TaiPhaiNoiTham', 'RHM', 'RHMPhanLoai_Id', 'RHM_HamTren', 'RHM_HamDuoi', 'DaLieu', 'DaLieuPhanLoai_Id', 'CanLamSangKetQua', 'CanLamSangDanhGia', 'SucKhoePhanLoai_Id', 'ThongTinBenhTat', 'BacSiNoi_Id', 'BacSiMat_Id', 'BacSiTMH_Id', 'BacSiRHM_Id', 'BacSiCXK_Id', 'BacSiDaLieu_Id', 'BacSiCLS1_Id', 'BacSiCLS2_Id', 'BacSiKetLuan_Id', 'KhamBenhNoi_Id', 'KhamBenhMat_Id', 'KhamBenhTMH_Id', 'KhamBenhRHM_Id', 'KhamBenhDaLieu_Id', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Loai', 'HoTen', 'NgaySinh', 'TinhThanh_Id', 'QuanHuyen_Id', 'PhuongXa_Id', 'DiaChiThuongTru', 'CCCD', 'CCCD_NgayCap', 'CCCD_NoiCap', 'LX_HangBangLai', 'LX_NongDoCon', 'LX_DViNongDoCon', 'LX_MaTuy', 'LX_NgayKetLuan', 'LX_KetLuan', 'LX_NgayKhamLai', 'LX_LyDo', 'LX_TinhTrangBenh', 'ThaiSan', 'ThaiSanPhanLoai_Id', 'BacSiThaiSan_Id'];

    List: ThongTinKhamSucKhoe[] | undefined;
    ListFilter: ThongTinKhamSucKhoe[] | undefined;
    FormData!: ThongTinKhamSucKhoe;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThongTinKhamSucKhoe";
    }
}

