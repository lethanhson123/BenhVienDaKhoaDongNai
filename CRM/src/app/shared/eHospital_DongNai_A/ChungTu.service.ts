import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ChungTu } from './ChungTu.model';
import { BaseService } from './Base.service';

import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';

import { Sys_Users } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.model';
import { Sys_UsersService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.service';

import { Lst_Dictionary } from 'src/app/shared/eHospital_DongNai_A_Dictionary/Lst_Dictionary.model';
import { Lst_DictionaryService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/Lst_Dictionary.service';

import { DM_BenhNhan } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhNhan.model';
import { DM_BenhNhanService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_BenhNhan.service';

import { DM_DoiTuong } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DoiTuong.model';
import { DM_DoiTuongService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_DoiTuong.service';

import { NS_NHANVIEN } from 'src/app/shared/eHospital_DongNai_A_NSTL/NS_NHANVIEN.model';
import { NS_NHANVIENService } from 'src/app/shared/eHospital_DongNai_A_NSTL/NS_NHANVIEN.service';

import { DM_KhoDuoc } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_KhoDuoc.model';
import { DM_KhoDuocService } from 'src/app/shared/eHospital_DongNai_A_Dictionary/DM_KhoDuoc.service';

@Injectable({
    providedIn: 'root'
})
export class ChungTuService extends BaseService {
    DisplayColumns001: string[] = ['Save', 'STT', 'ChungTu_Id', 'MaChungTu', 'SoChungTu', 'NgayChungTu', 'LoaiChungTu', 'MucDichChungTu_Id', 'KhoXuat_Id', 'NguoiGiao_Id', 'NguoiGiao', 'KhoNhap_Id', 'NguoiNhan_Id', 'NguoiNhan', 'NguoiKiemTra_Id', 'NguoiKiemTra', 'NguoiDuyet_Id', 'NguoiDuyet', 'KeToanTruong_Id', 'KeToanTruong', 'ThuKho_Id', 'ThuKho', 'SoSeri', 'SoHoaDon', 'DienGiai', 'GiaTri', 'GiaTriThanhToan', 'TyLeVat', 'GiaTriVat', 'ThueSuat', 'GiaTriThue', 'TyleChietKhau', 'GiaTriChietKhau', 'TienTe_Id', 'TyGia', 'SoChungTuGoc', 'NgayChungTuGoc', 'NhaCungCap_Id', 'HinhThucThanhToan_Id', 'NguonDuoc_Id', 'ChungTuLienQuan_Id', 'KhamBenh_Id', 'ToaThuocNoiTru_Id', 'BenhAn_Id', 'DaNhanThuoc', 'NguoiNhap_Id', 'NgayNhap', 'TrangThai', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'PhieuLinh_Id', 'DienGiaiNghiepVuPhatSinh', 'DonViGiao_Id', 'TyLeVATNhapKhau', 'GiaTriVATNhapKhau', 'SoSeriNuocNgoai', 'SoHoaDonNuocNgoai', 'NgayHoaDonNuocNgoai', 'KhoSuDung_Id', 'LoaiVatTu_Id', 'BenhNhan_Id', 'TenBenhNhan', 'GioiTinh', 'NamSinh', 'DiaChi', 'SoDienThoai', 'BacSiGioiThieu_Id', 'DoiTuong_Id', 'IDChuyen', 'ChungTuKeToan', 'Status', 'Transfer_VienPhi_Id', 'PhongBan_Id', 'BacSi_Id', 'TKNo', 'TKCo', 'MaChungTuRef', 'LoaiChungTuRef', 'PhieuLinhCanTru_Id', 'KhoThucHien_Id', 'KhoDoiUng_Id', 'Menu_LoaiDuoc_ID', 'NguoiSuDungMay_Id', 'GoiThau_Id', 'XuatThuocBANgoaiTru', 'NgayGioChungTu', 'NoiDaKham', 'ChuyenChungTuID', 'ChuyenDoanhThuID', 'THANHTOAN_TIMEOUT', 'DATHANHTOAN', 'NGUOITHANHTOAN_ID', 'NGAYTHANHTOAN', 'THOIGIANTHANHTOAN'];
    DisplayColumns002: string[] = ['STT', 'ChungTu_Id', 'SoChungTu', 'XuatThuocBANgoaiTru', 'DaNhanThuoc', 'TrangThai', 'NgayChungTu', 'NgayGioChungTu', 'SoChungTuGoc', 'NgayChungTuGoc', 'LoaiChungTu', 'MucDichChungTu_Id', 'KhoXuat_Id', 'KhoNhap_Id', 'KhoThucHien_Id', 'NguoiNhap_Id', 'NguoiGiao_Id', 'GiaTri', 'GiaTriThanhToan', 'TyLeVat', 'TienTe_Id', 'TyGia', 'BenhNhan_Id', 'TenBenhNhan', 'DoiTuong_Id', 'NoiDaKham', 'DienGiai', 'DienGiaiNghiepVuPhatSinh', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id',];
    DisplayColumns003: string[] = ['STT', 'BenhAn_Id', 'ChungTu_Id', 'SoChungTu', 'XuatThuocBANgoaiTru', 'DaNhanThuoc', 'TrangThai', 'NgayChungTu', 'NgayGioChungTu', 'SoChungTuGoc', 'NgayChungTuGoc', 'LoaiChungTu', 'MucDichChungTu_Id', 'KhoXuat_Id', 'KhoNhap_Id', 'KhoThucHien_Id', 'NguoiNhap_Id', 'NguoiGiao_Id', 'GiaTri', 'GiaTriThanhToan', 'TyLeVat', 'TienTe_Id', 'TyGia', 'BenhNhan_Id', 'TenBenhNhan', 'DoiTuong_Id', 'NoiDaKham', 'DienGiai', 'DienGiaiNghiepVuPhatSinh', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id',];

    List: ChungTu[] | undefined;
    ListFilter: ChungTu[] | undefined;
    FormData!: ChungTu;
    constructor(
        public httpClient: HttpClient,

        public Sys_UsersService: Sys_UsersService,
        public Lst_DictionaryService: Lst_DictionaryService,
        public DM_BenhNhanService: DM_BenhNhanService,
        public DM_DoiTuongService: DM_DoiTuongService,
        public NS_NHANVIENService: NS_NHANVIENService,
        public DM_KhoDuocService: DM_KhoDuocService,
    ) {
        super(httpClient);
        this.Controller = "ChungTu";

        this.Sys_UsersSearch();
        this.Lst_DictionarySearch();
        this.DM_DoiTuongSearch();
        this.NS_NHANVIENSearch();
        this.DM_KhoDuocSearch();
    }
    Sys_UsersSearch() {
        this.Sys_UsersService.ComponentGetAllToListAsync(this.Sys_UsersService);
    }
    Lst_DictionarySearch() {
        this.Lst_DictionaryService.BaseParameter.Dictionary_Type_Id = environment.Lst_Dictionary_TypeIDMucDichChungTu;
        this.Lst_DictionaryService.GetByDictionary_Type_IdToListAsync().subscribe(
            res => {
                this.Lst_DictionaryService.ListMucDichChungTu = (res as Lst_Dictionary[]);
            },
            err => {
            },
            () => {
            }
        );
    }
    DM_DoiTuongSearch() {
        this.DM_DoiTuongService.ComponentGetAllToListAsync(this.DM_DoiTuongService);
    }
    NS_NHANVIENSearch() {
        this.NS_NHANVIENService.ComponentGetAllToListAsync(this.NS_NHANVIENService);
    }
    DM_KhoDuocSearch() {
        this.DM_KhoDuocService.ComponentGetAllToListAsync(this.DM_KhoDuocService);
    }
    RenderToListTransfer(Sort: MatSort, Paginator: MatPaginator) {

        var List = [...new Map(this.List.map(item => [item.KhoThucHien_Id, item])).values()];
        var ListID = List.map(function (a) { return a.KhoThucHien_Id; });
        this.BaseParameter.Note = environment.InitializationString;
        for (let i = 0; i < ListID.length; i++) {
            let ListSub = this.List.filter(item => item.KhoThucHien_Id == ListID[i]);
            if (ListSub) {
                let Model = this.DM_KhoDuocService.List.filter(item => item.KhoDuoc_Id == ListID[i]);
                if (Model) {
                    if (Model.length) {
                        this.BaseParameter.Note = this.BaseParameter.Note + ", " + Model[0].TenKho + " (" + ListSub.length + ")";
                    }
                }
            }
        }

        var List001 = [...new Map(this.List.map(item => [item.MucDichChungTu_Id, item])).values()];
        var ListID001 = List001.map(function (a) { return a.MucDichChungTu_Id; });
        this.BaseParameter.Note001 = environment.InitializationString;
        for (let i = 0; i < ListID001.length; i++) {
            let ListSub = this.List.filter(item => item.MucDichChungTu_Id == ListID001[i]);
            if (ListSub) {
                let Model = this.Lst_DictionaryService.ListMucDichChungTu.filter(item => item.Dictionary_Id == ListID001[i]);
                if (Model) {
                    if (Model.length) {
                        this.BaseParameter.Note001 = this.BaseParameter.Note001 + ", " + Model[0].Dictionary_Name + " (" + ListSub.length + ")";
                    }
                }
            }
        }


        var ListBenhNhan = [...new Map(this.List.map(item => [item.BenhNhan_Id, item])).values()];        
        var ListBenhNhanID = ListBenhNhan.map(function (a) { return a.BenhNhan_Id; });        
        ListBenhNhanID = ListBenhNhanID.filter(item => item > 0);        
        if (ListBenhNhanID) {
            this.IsShowLoading = true;
            this.DM_BenhNhanService.BaseParameter.ListID = ListBenhNhanID;
            this.DM_BenhNhanService.GetByListIDToListAsync().subscribe(
                res => {
                    this.DM_BenhNhanService.List = (res as DM_BenhNhan[]);
                    
                    this.IsShowLoading = true;
                    for (let i = 0; i < this.List.length; i++) {
                        let Sys_Users = this.Sys_UsersService.List.filter(item => item.User_Id == this.List[i].NguoiTao_Id);
                        if (Sys_Users) {
                            if (Sys_Users.length) {
                                this.List[i].NguoiTaoName = Sys_Users[0].User_Name
                            }
                        }
                        Sys_Users = this.Sys_UsersService.List.filter(item => item.User_Id == this.List[i].NguoiCapNhat_Id);
                        if (Sys_Users) {
                            if (Sys_Users.length) {
                                this.List[i].NguoiCapNhatName = Sys_Users[0].User_Name
                            }
                        }
                        let NS_NHANVIEN = this.NS_NHANVIENService.List.filter(item => item.NhanVien_Id == this.List[i].NguoiNhan_Id);
                        this.List[i].NguoiNhapName = "" + this.List[i].NguoiNhan_Id;
                        if (NS_NHANVIEN) {
                            if (NS_NHANVIEN.length) {
                                this.List[i].NguoiNhapName = NS_NHANVIEN[0].Ho + " " + NS_NHANVIEN[0].Ten + " - " + NS_NHANVIEN[0].MaNhanVien;
                            }
                        }
                        NS_NHANVIEN = this.NS_NHANVIENService.List.filter(item => item.NhanVien_Id == this.List[i].NguoiGiao_Id);
                        this.List[i].NguoiGiaoName = "" + this.List[i].NguoiGiao_Id;
                        if (NS_NHANVIEN) {
                            if (NS_NHANVIEN.length) {
                                this.List[i].NguoiGiaoName = NS_NHANVIEN[0].Ho + " " + NS_NHANVIEN[0].Ten + " - " + NS_NHANVIEN[0].MaNhanVien;
                            }
                        }
                        let Lst_Dictionary = this.Lst_DictionaryService.ListMucDichChungTu.filter(item => item.Dictionary_Id == this.List[i].MucDichChungTu_Id);
                        if (Lst_Dictionary) {
                            if (Lst_Dictionary.length) {
                                this.List[i].MucDichChungTuName = Lst_Dictionary[0].Dictionary_Name;
                            }
                        }
                        let DM_BenhNhan = this.DM_BenhNhanService.List.filter(item => item.BenhNhan_Id == this.List[i].BenhNhan_Id);
                        if (DM_BenhNhan) {
                            if (DM_BenhNhan.length) {
                                this.List[i].BenhNhanName = DM_BenhNhan[0].TenBenhNhan + " - " + DM_BenhNhan[0].MaYTe;
                            }
                        }
                        let DM_DoiTuong = this.DM_DoiTuongService.List.filter(item => item.DoiTuong_Id == this.List[i].DoiTuong_Id);
                        if (DM_DoiTuong) {
                            if (DM_DoiTuong.length) {
                                this.List[i].DoiTuongName = DM_DoiTuong[0].TenDoiTuong;
                            }
                        }

                        let DM_KhoDuoc = this.DM_KhoDuocService.List.filter(item => item.KhoDuoc_Id == this.List[i].KhoXuat_Id);
                        if (DM_KhoDuoc) {
                            if (DM_KhoDuoc.length) {
                                this.List[i].KhoXuatName = DM_KhoDuoc[0].TenKho;
                            }
                        }

                        DM_KhoDuoc = this.DM_KhoDuocService.List.filter(item => item.KhoDuoc_Id == this.List[i].KhoNhap_Id);
                        if (DM_KhoDuoc) {
                            if (DM_KhoDuoc.length) {
                                this.List[i].KhoNhapName = DM_KhoDuoc[0].TenKho;
                            }
                        }

                        DM_KhoDuoc = this.DM_KhoDuocService.List.filter(item => item.KhoDuoc_Id == this.List[i].KhoThucHien_Id);
                        if (DM_KhoDuoc) {
                            if (DM_KhoDuoc.length) {
                                this.List[i].KhoThucHienName = DM_KhoDuoc[0].TenKho;
                            }
                        }
                    }
                    this.DataSource = new MatTableDataSource(this.List);
                    this.DataSource.sort = Sort;
                    this.DataSource.paginator = Paginator;
                    this.IsShowLoading = false;
                },
                err => {
                },
                () => {
                }
            );
        }
    }

    GetByChungTu_IdAsync() {
        let url = this.APIURL + this.Controller + '/GetByChungTu_IdAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByNgayChungTu_SearchStringToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByNgayChungTu_SearchStringToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByYear_Month_Day_SearchStringToListAsync() {
        this.BaseParameter.Year = this.BaseParameter.BatDau.getFullYear();
        this.BaseParameter.Month = this.BaseParameter.BatDau.getMonth() + 1;
        this.BaseParameter.Day = this.BaseParameter.BatDau.getDate();
        let url = this.APIURL + this.Controller + '/GetByYear_Month_Day_SearchStringToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

