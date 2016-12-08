 Alter table HoaDon add constraint DA_MaKH_FK FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
Alter table HoaDon add constraint DA_MaNV_FK FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
Alter table HoaDon add constraint DA_MaBan_FK FOREIGN KEY (MaBan) REFERENCES BanAn(MaBan)


Alter table MonAn add constraint MA_MaNhom_FK FOREIGN KEY (MaNhom) REFERENCES NhomMon(MaNhom)

Alter table PhieuGoi add constraint PG_MaMon_FK FOREIGN KEY (MaMon) REFERENCES MonAn(MaMon)

Alter table PhieuGoi add constraint PG_MaHD_FK FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD)

Alter table PhieuNhap add constraint PN_MaNV_FK FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)

Alter table BanAn add constraint PN_MaHD_FK FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD)


	
	
		------------MON AN---------
create proc DanhSachMonAn
as
begin
		select *from MonAn
end
----------
alter proc ThemMonAn(@ma nchar(10),@ten nvarchar(50),@gia decimal(9,0),@manhom nchar(10),@soluong int, @hinhanh nvarchar(50))
as
begin
	insert into MonAn values(@ma,@ten,@gia,@manhom,@soluong,@hinhanh)
end
---------
alter proc SuaMonAn(@ma nchar(10),@ten nvarchar(50),@gia decimal(9,0),@manhom nchar(10), @soluong int, @hinhanh nvarchar(50))
as
begin
	update MonAn
	set TenMon=@ten,DonGia=@gia,MaNhom=@manhom,HinhAnh=@hinhanh, SoLuongDangCo=@soluong
	where MaMon=@ma
end
---------
create proc XoaMonAn(@ma nchar(10))
as
begin
	delete MonAn 
	where MaMon=@ma
end

------------NHOM MON-----------------

create proc DanhSachNhomMon
as
begin
	select *from NhomMon
end

 
------
alter proc ThemNhomMon(@ma nchar(10),@ten nvarchar(50),@tongmon int,@hinhanh nvarchar(50))
as
begin
	insert into NhomMon values (@ma,@ten,@tongmon,@hinhanh)
end
-----
alter proc SuaNhomMon(@ma nchar(10),@ten nvarchar(50),@tongmon int,@hinhanh nvarchar(50))
as
begin
	update NhomMon
	set TenNhom=@ten, HinhAnh=@hinhanh, TongSoMon=@tongmon
	where MaNhom=@ma
end
-----
create proc XoaNhomMon(@ma nchar(10))
as
begin
	delete NhomMon
	where MaNhom=@ma
end
----
---------NGUYENLIEU-----------
create proc DanhSachNguyenLieu
as
begin
	select *from NguyenLieu
end

-----
create proc ThemNguyenLieu(@maNL nchar(10),@tenNL nvarchar(50),@donvi nvarchar(20),@dongia decimal(9,0))
as
begin
	insert into NguyenLieu
	values (@maNL,@tenNL,@donvi,@dongia)
end
-------
create proc SuaNguyenLieu(@maNL nchar(10),@tenNL nvarchar(50),@donvi nvarchar(20),@dongia decimal(9,0))
as
begin
	update NguyenLieu
	set TenNL=@tenNL,DonVi=@donvi,DonGia=@dongia
	where MaNL=@maNL
end
------
create proc XoaNguyenLieu(@ma nchar(10))
as
begin
	delete NguyenLieu
	where MaNL=@ma
end

-----------NhanVien---------------

create proc DanhSachNhanVien
as
begin
	select *from NhanVien
end
----------

alter proc ThemNhanVien(@ma nchar(10),@ten nvarchar(50),@sdt varchar(15),
@dc nvarchar(50),@luong decimal(9,0),@gioitinh nchar(10),@hinhanh nvarchar(50),@chucvu nvarchar(50), @trangthai nvarchar(50))
as
begin
	insert into NhanVien
	values(@ma,@ten,@sdt,@dc,@luong,@gioitinh,@hinhanh,@chucvu,@trangthai)
end
-------------
alter proc SuaNhanVien(@ma nchar(10),@ten nvarchar(50),@sdt varchar(15),
@dc nvarchar(50),@luong decimal(9,0),@gioitinh nchar(10),@hinhanh nvarchar(50),@chucvu nvarchar(50), @trangthai nvarchar(50))
as
begin
	update NhanVien
	set TenNV=@ten, SDT=@sdt,DiaChi=@dc,Luong=@luong,GioiTinh=@gioitinh,HinhAnh=@hinhanh,ChucVu=@chucvu, TrangThai=@trangthai
	where MaNV=@ma
end
------------
create proc XoaNhanVien(@ma nchar(10))
as
begin
	delete NhanVien
	where MaNV=@ma
end


/*
select *from NguyenLieu
select *from ChiTietPN

update ChiTietPN
set DonGia=nl.DonGia
from ChiTietPN ct,NguyenLieu nl
where ct.MaNL=nl.MaNL

insert into ChiTietPN(MaPN,MaNL,DonGia,SoLuong) values('PN001','NL003',10000,10)

update ChiTietPN
set ThanhTien=DonGia*SoLuong
*/


select * from BanAn

select * from ChiTietHD

select  MaHD, SoLuong, ThanhTien, TenMon from MonAn,ChiTietHD where MaHD = 'HD0005' and ChiTietHD.MaMon = MonAn.MaMon


select *from ChiTietPN

select *from KhachHang

---- Tao procedure SUA KHACH HANG

alter proc SuaKhachHang(@MaKH char (10), @TenKH nvarchar(50), 
		@DiaChi nvarchar(50), @SDT nvarchar(20), @SoLanAn int, 
		@TongTienDaChi decimal(9,0), @PhanLoaiKH nvarchar (50), @email nchar(50))
as 
begin 
	update KhachHang
	set TenKH = @TenKH, DiaChi = @DiaChi, SDT = @SDT, SoLanAn = @SoLanAn, TongTienDaChi = @TongTienDaChi, PhanLoaiKH = @PhanLoaiKH, Email=@email
	where MaKH = @MaKH
end

select *from KhachHang
SuaKHachHang 'KH001', 'Hoang Thi Thu', 'Viet Nam','23434','3',334553,''

---- THEM KHACH HANG
alter proc ThemKhachHang (@MaKH char (10), @TenKH nvarchar(50), @DiaChi nvarchar(50),
 @SDT nvarchar(20), @SoLanAn int, @TongTienDaChi decimal(9,0), @PhanLoaiKH nvarchar(50), @email nchar(50))
as 
begin
if exists ( select MaKH from KhachHang  where MaKH=@MaKH)
	begin
		 print N' MaKH da ton tai'
	end
else
	begin
		insert into KhachHang(MaKH,TenKH,DiaChi,SDT,Email,SoLanAn,TongTienDaChi,PhanLoaiKH) values(@MaKH,@TenKH,@DiaChi,@SDT,@email,@SoLanAn,@TongTienDaChi,@PhanLoaiKH)
	end
end

---Xem DANH SACH KHACH HANG--------
create proc DanhSachKhachHang
as
begin
	select *from KhachHang
end

---- XoaKH
create proc XoaKhachHang (@MaKH char(10))
as 
begin 
	delete KhachHang
	where MaKH = @MaKH
end

----------------------------
---- proc Them BanAn
create proc DanhSachBanAn
as
begin
	select *from BanAn
end


----Chi can them ma ban. con lai trang thai va maHD se dc cap nhat nen cho no vao phan SUA Ban An 
create proc ThemBanAn(@MaBan char(10))
as
begin 
if exists (select MaBan from BanAn where MaBan = @MaBan)
	begin 
		print 'MaBan da ton tai'
	end
else 
	begin insert into BanAn(MaBan) values (@MaBan)
	end
end 
--- Xoa Ban An
select *from BanAn

create proc XoaBanAn(@MaBan char(10))
as
begin 
	Delete BanAn
	where MaBan = @MaBan
end
--- Sua Ban An
create proc SuaBanAn(@MaBan char(10),@TrangThai nvarchar(50),@MaHD char(10))
as
begin 
	update BanAn
	set TrangThai = @TrangThai , MaHD = @MaHD where MaBan = @MaBan
end

ALTER proc SuaBanAnThanhTrong(@MaBan char(10))
as
 begin
	update BanAn
	set TrangThai = N'Trống' , MaHD = NULL where MaBan = @MaBan
 end


SuaBanAnThanhTrong 'B002'

select * from BanAn

-----------------  Hoa Don
--- Them Hoa Don
alter proc ThemHoaDon(@ThoiGianAn datetime,@MaKH char(10),@MaNV char(10),@ChietKhau float)
as 
	begin
	declare @maHD nchar(10)
	set @maHD = (select dbo.func_ma_next ((select Top 1 MaHD from HoaDon order by MaHD desc),'HD','6'))
		insert into HoaDon(MaHD,ThoiGianAn,MaKH,MaNV,ChietKhau)
		values (@MaHD,@ThoiGianAn,@MaKH,@MaNV,@ChietKhau)
	end
	
	ThemHoaDon '2016-12-01 08:30:00.000','KH001' , 'NV001',0
	delete HoaDon where MaHD = 'HD0008'
select *from HoaDon
select * from KhachHang
select *from ChiTietHD

/*
	Hóa đơn được update khi gọi món --> lúc đó có chiTietHD --> sẽ lấy Thành tiền ở ChiTietHD update vào TongTien trong HoaDon
*/


 ---- Sua HoaDon
alter proc SuaHoaDon (@MaHD nchar(10),@ThoiGianAn datetime,@MaKH char(10),@MaNV char (10),@ChietKhau float)
as 
begin 
	Update HoaDon
	set ThoiGianAn = @ThoiGianAn,MaKH = @MaKH,MaNV = @MaNV,ChietKhau = @ChietKhau
	where MaHD = @MaHD
end

SuaHoaDon 'HD0007'
select *from HoaDon
SuaHoaDon 'HD0032','2016-12-08 12:30:50.230','KH006','NV001',5

-------------- Xoa Hoa Don
create proc XoaHoaDon (@MaHD char(10))
as 
begin
	Delete HoaDon
	where MaHD = @MaHD
end

create proc  XemThongTinHoaDon (@MaHD nchar(10))
as
 begin
	select * from HoaDon where MaHD = @MaHD
 end

XoaHoaDon 'HD0008'
select *from HoaDon
select *from ChiTietHD
/*
	Chi tiết hóa đơn xuất hiện khi gọi món
	Xóa chi tiết hóa đơn khi hủy món ---> tự động hủy ThanhTien bên HoaDon
	Update Chi tiết hóa đơn khi muốn gọi thêm món ---> tự động update ThanhTien bên HoaDon

*/


select *from HoaDon
select *from ChiTietHD

update ChiTietHD
set SoLuong=10
where MaMon='M001' and MaHD='HD0001'

delete ChiTietHD
where MaHD='HD0005' and MaMon='M001'

insert into ChiTietHD(MaMon,MaHD,SoLuong,GiaMon) values ('M002','HD0004',5,15000)

-- xem thông tin khách hàng theo hóa đơn

alter proc ThongTinKhachHangTheoMaHoaDon (@MaHD nchar(10))
as
	begin
		 select * from KhachHang  where MaKH in (  select MaKH from HoaDon where MaHD = @MaHD) 
	end

	select * from HoaDon
	ThongTinKhachHangTheoMaHoaDon 'HD0001'

	create proc XemThongTinHoaDonTheoMa (@MaHD nchar(10))
	as
	 begin
		select * from HoaDon where MaHD = @MaHD
	 end
------------- Tự động cập nhật ThanhTien vào HoaDon Khi có 1 Phiếu gọi mới

select sum(ThanhTien) from ChiTietHD where MaHD='HD0001'

declare @TongThanhTien decimal(9,0) =(select sum(ThanhTien) from ChiTietHD where MaHD=@mahd)
	Update HoaDon
	set ThanhTien=@TongThanhTien, TongTien=hd.ThanhTien-hd.ThanhTien*ChietKhau
	from HoaDon hd,ChiTietHD ct
	where hd.MaHD=ct.MaHD

	select * from HoaDon
	/*
alter trigger tg_TinhTienHoaDon on ChiTietHD for insert,update,delete
as 
declare @mahd char(10)
begin 	
	select @mahd=MaHD from inserted
	select @mahd=MaHD from deleted
	
	Update ChiTietHD
	set ThanhTien=SoLuong*GiaMon

	Update HoaDon
	set ThanhTien = A.TongThanhTien,TongTien = (A.TongThanhTien - A.TongThanhTien*(ChietKhau/100))
	from (select sum(ThanhTien) as TongThanhTien from ChiTietHD where MaHD = @MaHD)as A
	where MaHD = @MaHD

end*/
------------- Gọi món sẽ tự động cập nhật vào thành tiền trong hóa đơn, khi sửa Số lượng món trong ChiTietPhieuGoi sẽ tự động cập nhật ThanhTien trong ChiTietPhieuGOi 


create trigger tg_TinhTienHoaDon on ChiTietHD for insert,update,delete
as 
declare @MaHD char(10), @MaMon1 char(10), @MaMon2 char(10),@SoLuong1  int, @SoLuong2 int
begin 
	
	select @MaHD = MaHD from inserted
	select @MaHD = MaHD from deleted
	select @MaMon1 = MaMon from inserted 
	select @MaMon2 = MaMon from deleted 
	select @SoLuong1 = SoLuong from inserted
	select @SoLuong2 = SoLuong from deleted
	
	if exists (select MaMon,MaHD from ChiTietHD where MaMon = @MaMon2 and MaHD =@MaHD)  
	
		if exists (select MaMon,MaHD from ChiTietHD where MaMon = @MaMon1 and MaHD = @MaHD)
		begin
			Update ChiTietHD
			set ThanhTien = @SoLuong1 *GiaMon
			where MaHD = @MaHD and MaMon =@MaMon1

		end
		else 
			begin 
				Update HoaDon
				set ThanhTien = ABC.TongThanhTien,TongTien = (ABC.TongThanhTien - ABC.TongThanhTien*(ChietKhau/100))
				from (select sum(ThanhTien) as TongThanhTien from ChiTietHD where MaHD = @MaHD)as ABC
				where MaHD = @MaHD
			end


	Update HoaDon
	set ThanhTien = A.TongThanhTien,TongTien = (A.TongThanhTien - A.TongThanhTien*(ChietKhau/100))
	from (select sum(ThanhTien) as TongThanhTien from ChiTietHD where MaHD = @MaHD)as A
	where MaHD = @MaHD
end


update HoaDon
set ChietKhau=0
select *from MonAn
select *from NhomMon

select *from HoaDon
select *from ChiTietHD


/*	Trigger XoaHoaDon
	Khi xóa 1 hóa đơn thì sẽ tự động xóa hết mã hóa đơn trong phiếu gọi
*/
/*
	instead of sẽ xóa từ bên trong trước rồi mới xóa bên ngoài
	Ở đây nó sẽ xóa chi tiết hóa đơn trc rồi mới xóa tới hóa đơn
	for sẽ xóa từ ngoài vào trong ở đây nó sẽ xóa Hóa đơn trc rồi mới xóa chi tiết hóa đơn
*/
create trigger tg_XoaHoaDon on HoaDon instead of delete
as
declare @MaHD char(10)
begin 
	select @MaHD = MaHD from deleted
	delete ChiTietHD
	where MaHD = @MaHD
	print 'Deleted'
end
------ Tạo 1 chi tiết hóa đơn mới 
------- cách 1 sử dụng exists kiểm tra xem nếu ChiTietHD đó đã tồn tại chưa, nếu tồn tại rồi thì thêm vào, nếu chưa thì thêm mới
create proc ThemChiTietHD(@MaMon char(10), @MaHD char(10),@SoLuong int,@GiaMon decimal(9,0),@GhiChu nvarchar(50))
as
begin 
	if exists (select MaHD from ChiTietHD where MaHD = @MaHD)
	begin
		if exists ( select MaHD,MaMon from ChiTietHD where MaHD = @MaHD and MaMon = @MaMon)
			begin 
				Update ChiTietHD
				set SoLuong =@SoLuong, ThanhTien = @GiaMon*@SoLuong
				where MaHD = @MaHD and MaMon = @MaMon
			end
		else 
			begin 
				insert into ChiTietHD(MaMon,MaHD,SoLuong,GiaMon,GhiChu,ThanhTien) 
				values (@MaMon,@MaHD,@SoLuong,@GiaMon,@GhiChu, @GiaMon*@SoLuong)
			end
	end
	else 
		begin 
			insert into ChiTietHD(MaMon,MaHD,SoLuong,GiaMon,GhiChu,ThanhTien) 
				values(@MaMon,@MaHD,@SoLuong,@GiaMon,@GhiChu, @GiaMon*@SoLuong)
		end
end
ThemChiTietHD 'M001','HD0001',5,'3000',''

--- Thêm mới 1 chi tiết hóa đơn


Delete HoaDon
where MaHD = 'HD0008'

update ChiTietHD
set SoLuong = 4 , ThanhTien = GiaMon *4
where MaMon = 'M002' and MaHD = 'HD0008' 

delete ChiTietHD
where MaMon = 'M003' and MaHD = 'HD0008'

select MaMon, MaHD from ChiTietHD where MaHD = 'HD0008'

insert into ChiTietHD(MaMon,MaHD,SoLuong,GiaMon,ThanhTien) values('M003','HD0008','2','3000','6000')
select *from ChiTietHD 
select *from HoaDon
	select ThanhTien from ChiTietHD where MaHD ='HD0005'
--------------- Chi tiết phiếu nhập 

select *from ChiTietPN




------- update Thanh Tien trong ChiTietHD

Update ChiTietHD
set ThanhTien = SoLuong * GiaMon

------ Update GiaMon trong ChiTietHD theo GiaMon trong MonAn

Update ChiTietHD
set GiaMon =  MonAn.DonGia
from MonAn , ChiTietHD
where ChiTietHD.MaMon = MonAn.MaMon


select *from MonAn
	select *from HoaDon 
	
	select *from ChiTietHD
