CREATE DATABASE Qlbanhang;

go

use Qlbanhang;
--- Default mật khẩu fpt123
CREATE TABLE NhanVien(
	Id int IDENTITY(1,1) NOT NULL,
	MaNv varchar(20) NOT NULL,
	email varchar(50) NOT NULL,
	tenNv nvarchar(50) NOT NULL,
	diaChi nvarchar(100) NOT NULL,
	vaiTro tinyint NOT NULL,
	tinhTrang tinyint NOT NULL,
	matKhau nvarchar(max) CONSTRAINT [DF_tblNhanVien_matKhau]  DEFAULT (('362294414513824030813111198602102132')) NOT NULL,
	CONSTRAINT PK_NhanVien PRIMARY KEY CLUSTERED ([MaNv] ASC)
)

CREATE TABLE Hang(
	MaHang int IDENTITY(1,1) NOT NULL,
	TenHang [nvarchar](50) NOT NULL,
	SoLuong [int] NOT NULL,
	DonGiaNhap [float] NOT NULL,
	DonGiaBan [float] NOT NULL,
	HinhAnh image NOT NULL,
	GhiChu [nvarchar](20) NOT NULL,
	Manv [varchar](20) NOT NULL,
	CONSTRAINT PK_tblHang PRIMARY KEY CLUSTERED (MaHang ASC )
) 

CREATE TABLE Khach(
	DienThoai [varchar](15) NOT NULL,
	TenKhach [nvarchar](50) NOT NULL,
	DiaChi [nvarchar](100) NOT NULL,
	Phai [nvarchar](5) NULL,
	Manv [varchar](20) NOT NULL,
	CONSTRAINT PK_Khach PRIMARY KEY CLUSTERED (DienThoai ASC)
)

ALTER TABLE Khach
ADD CONSTRAINT FK_Khach_nv
FOREIGN KEY (Manv) REFERENCES NhanVien(Manv) ON UPDATE CASCADE;

ALTER TABLE Hang
ADD CONSTRAINT FK_hang_nv
FOREIGN KEY (Manv) REFERENCES NhanVien(Manv)ON UPDATE CASCADE;

-- SP liên quan đến tài khoản
-- Đăng nhập
go
CREATE PROCEDURE sp_DangNhap @email varchar(50),@matKhau nvarchar(50)
AS
BEGIN
      declare @status int

if exists(select * from NhanVien where email=@email and matKhau=@matKhau)
       set @status=1
else
       set @status=0
select @status
END
go
-- Sp quên mật khẩu
CREATE PROCEDURE Sp_QuenMatKhau @email varchar(50)
AS
BEGIN
      declare @status int
if exists(select MaNv from NhanVien where email=@email )
       set @status=1
else
       set @status=0
select @status
END
go
-- tạo mật khẩu mới
Create PROCEDURE Sp_TaoMatKhauMoi
@email nvarchar(50),
@matkhau nvarchar(20)
AS
BEGIN
UPDATE NhanVien SET matKhau = @matkhau
where email  =  @email
END
go
-- Đổi mật khẩu
CREATE procedure Sp_DoiMatKhau
(
@email Varchar(50),
@opwd nVarchar(50),
@npwd nVarchar(50)
)
AS
Begin
declare @op varchar(50)
select @op= matKhau from NhanVien where email=@email
if @op=@opwd
	begin
		update NhanVien set matKhau=@npwd where email=@email
		return 1
	end
	else
		return -1
end
go
-- lấy vai trò
Create PROCEDURE Sp_LayVaiTroNV @email varchar(50)
AS
BEGIN
      SELECT vaitro FROM NhanVien
	  where email = @email
END
go


-- THỦ TỤC QUẢN LÝ NHÂN VIÊN
-- LẤY DANH SÁCH NHÂN VIÊN
Create PROCEDURE Sp_DanhSachNV
AS
BEGIN
      SELECT email, tenNv, diachi,case 
		when vaiTro = 1 then N'Quản lý'
		else N'Nhân viên' end as 'vaitro', case 
		when tinhTrang = 1 then N'Hoạt động'
		else N'Không hoạt động' end as  'tinhtrang' FROM NhanVien
END
go

-- THÊM DỮ LIỆU VÀO BẢNG NHÂN VIÊN
CREATE PROCEDURE Sp_InsertNhanVien
@email nvarchar(50),
@tennv varchar(50),
@diachi nvarchar(100),
@vaiTro tinyint,
@tinhTrang tinyint
AS
BEGIN
DECLARE @Manv VARCHAR(20);
DECLARE @Id INT;

SELECT @Id = ISNULL(MAX(ID),0) + 1 FROM NhanVien
SELECT @Manv = 'NV' + RIGHT('0000' + CAST(@Id AS VARCHAR(4)), 4)
INSERT INTO NhanVien(Manv,email,tenNv, diaChi,vaiTro,tinhTrang) 
VALUES (@Manv, @email, @tennv, @diachi,@vaiTro,@tinhTrang) 
END
go

exec Sp_InsertNhanVien 'duydtps11681@fpt.edu.vn',N'Thanh Duy',N'Tây Ninh',1,1;

exec Sp_InsertNhanVien 'harrysunwhite@gmail.com',N'Thanh Nha',N'Tây Ninh',0,1;
exec Sp_InsertNhanVien 'duydt@gmail.com',N'Thanh Duy',N'Tây Ninh',1,1;
go
-- Xóa Nhân viên
CREATE PROCEDURE Sp_DeleteNhanVien
@email varchar(50)
AS
BEGIN
DELETE FROM NhanVien
WHERE email = @email
END
go
-- cập nhật nhân viên
CREATE PROCEDURE Sp_UpdateNhanVien
@email nvarchar(50),
@tenNv nvarchar(50),
@diaChi nvarchar(50),
@vaiTro tinyint,
@tinhTrang tinyint
AS
BEGIN
UPDATE nhanvien SET TenNv=@tenNv, diaChi=@diaChi,vaiTro=@vaiTro, tinhTrang =@tinhTrang
where email  =  @email
END
go

-- tìm kiếm nhân viên
CREATE PROCEDURE Sp_SearchNhanVien
@tenNv nvarchar(50)
AS
BEGIN
      SET NOCOUNT ON;
      SELECT email, tenNv, diachi,vaitro, tinhtrang 
      FROM nhanvien where tennv like '%' + @tenNv + '%'
END

-- THỦ TỤC QUẢN LÝ KHÁCH HÀNG
--lấy danh sách khach
go
CREATE PROCEDURE Sp_DanhSachKhach
AS
BEGIN
      SET NOCOUNT ON;
      SELECT *
      FROM Khach
END
go
-- thêm thông tin khách
CREATE PROCEDURE Sp_InsertKhach
@dienThoai varchar(15),@tenKhach nvarchar(50),
@diaChi nvarchar(100),@phai nvarchar(5),@email varchar(20)
AS
BEGIN
DECLARE @Manv VARCHAR(20);
select @Manv = manv from NhanVien where email=@email
INSERT INTO Khach(DienThoai, TenKhach,DiaChi,phai,Manv) 
VALUES ( @dienThoai,@tenKhach,@diaChi,@phai,@Manv) 
END
go

-- Xóa Thông tin khách 
CREATE PROCEDURE Sp_DeleteKhach
@dienthoai varchar(15)
AS
BEGIN
DELETE FROM Khach
WHERE DienThoai = @dienthoai
END
go

--cập nhật thông tin Khách
CREATE PROCEDURE Sp_UpdateKhach
@dienThoai varchar(15),
@tenKhach nvarchar(50),
@diaChi nvarchar(100),
@phai nvarchar(5)
AS
BEGIN
UPDATE Khach SET TenKhach=@tenKhach, DiaChi=@diaChi, phai=@phai
where dienThoai  =  @dienThoai
END
go
-- tìm kiếm khách hàng
CREATE PROCEDURE Sp_SearchKhach
@dienthoai varchar(15)
AS
BEGIN
      SET NOCOUNT ON;
      SELECT *
      FROM Khach where DienThoai like + '%' + @dienthoai + '%'
END
go

-- Thủ tục liên quan quản lý hàng hóa
CREATE PROCEDURE Sp_DanhSachHang
AS
BEGIN
      SET NOCOUNT ON;
      SELECT *
      FROM Hang
END
go
-- Thêm mới hàng hóa
CREATE PROCEDURE Sp_InsertHang
@tenHang nvarchar(50),
@soLuong int,
@donGiaNhap float,
@donGiaBan float,
@hinhAnh image,
@ghiChu nvarchar(50),
@email varchar(20)
AS
BEGIN
DECLARE @Manv VARCHAR(20);
select @Manv = manv from NhanVien where email=@email
INSERT INTO Hang(TenHang, SoLuong, DonGiaNhap, DonGiaBan,HinhAnh,GhiChu,Manv) 
VALUES ( @tenHang, @soLuong, @donGiaNhap,@donGiaBan,@hinhAnh,@ghiChu,@Manv) 
END
go
-- cập nhật hàng hóa
CREATE PROCEDURE Sp_UpdateHang
@maHang int,
@tenHang nvarchar(50),
@soLuong int,
@donGiaNhap float,
@donGiaBan float,
@hinhAnh image,
@ghiChu nvarchar(50)
AS
BEGIN
UPDATE hang SET TenHang=@tenHang, SoLuong=@soLuong,
DonGiaNhap=@donGiaNhap,DonGiaBan=@donGiaBan,HinhAnh=@hinhAnh,GhiChu=@ghiChu
where MaHang  =  @maHang
END
go

-- Xóa hàng hóa
CREATE PROCEDURE Sp_DeleteHang
@maHang int
AS
BEGIN
DELETE FROM Hang
WHERE MaHang = @maHang
END
go
-- Tìm kiếm hàng hóa
CREATE PROCEDURE Sp_SearchHang
@tenHang nvarchar(50)
AS
BEGIN
      SET NOCOUNT ON;
      SELECT *
      FROM Hang where TenHang like '%' + @tenHang + '%'
END
go

-- thống kê hàng hoá theo so lượng
CREATE PROCEDURE Sp_ThongKe
AS
BEGIN
	select MaHang, TenHang, SoLuong from Hang;
END

-- thống kê hang hoá sắp xep theo tên nhan vien nhap vao

go
-- thống kê hàng hoá sắp xếp theo tên nhan viên thực hiện nhập kho.
CREATE PROCEDURE Sp_ThongKeNhap
AS
BEGIN
	SELECT tenNv, MaHang, TenHang FROM NhanVien JOIN Hang ON NhanVien.MaNv = Hang.Manv
	GROUP BY NhanVien.tenNv,MaHang,TenHang
	ORDER BY NhanVien.tenNv
END