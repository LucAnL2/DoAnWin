CREATE TABLE [dbo].[Worker2] (
    [ID] NVARCHAR (50) NOT NULL,
    [Ten] NVARCHAR (MAX) NULL,
    [GioiTinh] NVARCHAR (MAX) NULL,
    [SDT] NVARCHAR (MAX) NULL,
    [DiaChi] NVARCHAR (MAX) NULL,
    [CCCD] NVARCHAR (MAX) NULL,
    [NgaySinh] NVARCHAR (MAX) NULL,
    [Email] NVARCHAR (MAX) NULL,
    [STK] NVARCHAR (MAX) NULL,
    [SoDU] NVARCHAR (MAX) NULL,
    [LuotThue] NVARCHAR (MAX) NULL,
    [NgheNghiep] NVARCHAR (MAX) NULL,
    [NgayLamViec] NVARCHAR (MAX) NULL,
    [GioLam] NVARCHAR (MAX) NULL,
    [GiaThue] NVARCHAR (MAX) NULL,
    [NamKinhNghiem] NVARCHAR (MAX) NULL,
    [MoTa] NVARCHAR (MAX) NULL, 
    [TenNguoiDung] NVARCHAR(MAX) NOT NULL, 
    [MatKhau] NVARCHAR(MAX) NOT NULL,
    VaiTro NVARCHAR(MAX) NOT NULL,
    CONSTRAINT [PK_worker] PRIMARY KEY ([ID])
);
INSERT INTO Worker2 (ID, Ten, GioiTinh, SDT, DiaChi, CCCD, NgaySinh, Email, STK, SoDU, LuotThue, NgheNghiep, NgayLamViec, GioLam, GiaThue, NamKinhNghiem, MoTa, TenNguoiDung, MatKhau, VaiTro)
VALUES
    ('1', N'Nguyễn Văn A', N'Nam', '0123456789', N'Hà Nội', '123456789', '1990-01-01', 'nguyenvana@example.com', '1234567890', '5000000', '2', N'Kỹ sư', '2022-01-01', '8', '2000000', '5', N'5 năm kinh nghiệm làm việc trong ngành', N'A', N'@123', N'Người Dùng'),
    ('2', N'Nguyễn Thị B', N'Nữ', '0987654321', N'Hồ Chí Minh', '987654321', '1995-05-05', 'nguyenthib@example.com', '0987654321', '3000000', '3', N'Kế toán', '2022-02-01', '7', '1500000', '3', N'3 năm kinh nghiệm làm kế toán',  N'B', N'@123', N'Người Dùng'),
    ('3', N'Phạm Văn C', N'Nam', '0123456789', N'Hải Phòng', '123456789', '1985-03-15', 'phamvanc@example.com', '1234567890', '4000000', '4', N'Giáo viên', '2022-03-01', '6', '1800000', '6', N'6 năm kinh nghiệm giảng dạy',  N'C', N'@123', N'Người Dùng');
select * from Worker2