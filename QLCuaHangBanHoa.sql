use master 
go
if exists (select name from sysdatabases where name = 'QLCuaHangBanHoa')
drop database QLCuaHangBanHoa
go
create database QLCuaHangBanHoa
go
use QLCuaHangBanHoa
go


-- TABLE =======================================================================================================================
create table KHACHHANG 
(
	userName varchar (100) not null primary key,
	pass varchar (100) not null,
	tenKH nvarchar (100),
	diaChi nvarchar (100) not null,
	sDT varchar (10),
	email varchar (100),
	gioiTinh nvarchar (3),
	ngaySinh date
);

create table LOAISP
(
	maLSP varchar (10) not null primary key,
	tenLSP nvarchar (100)
);

create table SANPHAM
(
	maSP varchar (10) not null primary key,
	tenSP nvarchar (100),
	maLSP varchar (10) not null,
	sLTon int,
	donGia money,
	hinhAnh varchar (50),
	moTa nvarchar (500),
	constraint fk_SP_LSP foreign key (maLSP) references LOAISP (maLSP)
);

create table HOADON
(
	maHD int identity (1, 1) not null primary key,
	userName varchar (100) not null,
	ngayDat date,
	ngayGiao date,
	trangThai nvarchar (100),
	constraint fk_HD_KH foreign key (userName) references KHACHHANG (userName)
);

create table CTHOADON
(
	maHD int not null,
	maSP varchar (10) not null,
	soLuong int,
	donGia money,
	primary key (maHD, maSP),
	constraint fk_CTHD_HD foreign key (maHD) references HOADON (maHD),
	constraint fk_CTHD_SP foreign key (maSP) references SANPHAM (maSP)
);


-- DATA ========================================================================================================================
set dateformat dmy
insert into KHACHHANG values ('admin', '123', N'Nguyễn Lê Gia Bảo', 'TP. HCM', '0985938593', 'nlgb2001@gmail.com', 'Nam', '20/06/2001');
insert into KHACHHANG values ('chi', '123', N'Phương Mỹ Chi', 'TP. HCM', '0395939503', 'chi123@gmail.com', N'Nữ', '20/12/1999');
insert into KHACHHANG values ('tung', '123', N'Nguyễn Thanh Tùng', N'Thái Bình', '0195939593', 'tung@gmail.com', 'Nam', '20/01/1998');
insert into KHACHHANG values ('thanh', '123', N'Trấn Thành', 'TP. HCM', '0195995950', 'thanh123@gmail.com', 'Nam', '22/02/1994');
insert into KHACHHANG values ('cris', '123', N'Cris Phan', 'TP. HCM', '0198989859', 'cris7@gmail.com', 'Nam', '20/10/1995');
insert into KHACHHANG values ('teo', '123', N'Nguyễn Văn Tèo', 'TP. HCM', '0293859385', 'teo231@gmail.com', 'Nam', '20/07/2002');
insert into KHACHHANG values ('ti', '123', N'Phan Văn Tí', 'TP. HCM', '0989895939', 'ti231@gmail.com', 'Nam', '23/12/2001');
select * from KHACHHANG;

insert into LOAISP values ('HT', N'Hoa tươi');
insert into LOAISP values ('HTCD', N'Hoa theo chủ đề');
insert into LOAISP values ('CGH', N'Chậu, giỏ hoa');
select * from LOAISP;

insert into SANPHAM values ('HAD', N'Hoa anh đào', 'HT', 13, 90000, 'hoaAnhDao.jpg', N'Hoa anh đào không đẹp khi đứng một mình, nó chỉ trở nên đẹp đẽ khi nở rộ thành một mảng: mong manh, rực rỡ. Và chính bản thân nó đã mang đến một thông điệp: con người dù ở hoàn cảnh khốn cùng nhất, vẫn luôn phải vươn lên, không bao giờ được đầu hàng số phận.');
insert into SANPHAM values ('HCV', N'Hoa cúc vàng', 'HT', 19, 31000, 'hoaCucVang.jpg', N'Hoa cúc được xem là biểu tượng cho đế vương, sự cao sang quyền quý và sự giàu có khó ai bì kịp bắt nguồn từ cuộc sống của những gia đình quý tộc, nổi tiếng, có thân thích với Nhật Hoàng. Thật vậy, chỉ những gia đình này mới sở hữu con ấn có khắc hình hoa cúc. Nó đại diện cho sức mạnh, quyền uy và vị thế không ai bì kịp cũng như sự cao sang, giàu có họ sở hữu.');
insert into SANPHAM values ('HDT', N'Hoa đồng tiền', 'HT', 18, 13000, 'hoaDongTien.png', N'Loại hoa này thường được lựa chọn rất nhiều trong các kệ hoa khai trương, hoa chúc mừng. Mong người nhận sẽ có nhiều điều may mắn và thành công hơn trong sự nghiệp của mình.');
insert into SANPHAM values ('HHDuong', N'Hoa hải đường', 'HT', 10, 23000, 'hoaHaiDuong.png', N'Hoắc hương núi là một loài hoa mạnh mẽ, tràn đầy nhựa sống. Chúng không mang một vẻ đẹp quá rực rỡ nhưng với mỗi bông hải đường luôn mang lại cho người thưởng thức hoa một cảm giác ấm áp bởi sắc hồng đỏ đặc biệt của nó. Trong phong thủy hoa hải đường tượng trưng cho sự giàu sang, phú quý.');
insert into SANPHAM values ('HHC', N'Hoa hồng cam', 'HT', 21, 52000, 'hoaHongCam.png', N'Ý nghĩa hoa hồng cam mang theo sự mạnh mẽ của màu đỏ và sự chân thành của màu vàng. Nó biểu trưng cho niềm đam mê, nhiệt huyết, sự sáng tạo, thành công. Là biểu tượng của sức mạnh, sự bền bỉ. Hay của những tình cảm chân thành, thuần khiết nhất.');
insert into SANPHAM values ('HHDo', N'Hoa hồng đỏ', 'HT', 23, 53000, 'hoaHongDo.jpg', N'Theo thần thoại Hy Lạp và La Mã thì hoa hồng đỏ chính là loài hoa gắn liền với câu chuyện liên quan đến nữ thần tình yêu. Chính vì thế nên trong nền văn hoá cổ đại, người ta thường dùng hoa hồng đỏ để trang trí không gian hôn lễ, đính kết trang trí lên những bộ hỉ phục.');
insert into SANPHAM values ('HHTim', N'Hoa hồng tím', 'HT', 19, 61000, 'hoaHongTim.jpg', N'Màu tím là màu của sự chung thủy và vĩnh cửu. Hoa hồng tím còn tượng trưng cho mối quan hệ gắn bó bền chặt, đại diện cho tình yêu chân thành và trường tồn mãi thời gian. Chính vì vậy, hoa hồng tím thường được làm hoa cưới hoặc bày trang trí ở đám cưới hay để tặng người mình yêu trong những ngày kỉ niệm hoặc ngày lễ tình yêu.');
insert into SANPHAM values ('HHTrang', N'Hoa hồng trắng', 'HT', 17, 49000, 'hoaHongTrang.jpg', N'Với màu trắng tinh khôi, thuần khiết, hoa hồng trắng là loài hoa tượng trưng cho vẻ đẹp tinh khôi, thuần khiết và đầy trong sáng của những cô gái. Đó không chỉ là vẻ đẹp bên ngoài, mà còn là nét đẹp trong tâm hồn. Bên cạnh đó, hoa hồng trắng cũng đại diện cho những người phụ nữ dịu dàng, đức hạnh.');
insert into SANPHAM values ('HHV', N'Hoa hồng vàng', 'HT', 16, 480000, 'hoaHongVang.png', N'Hoa hồng vàng có vẻ đẹp rực rỡ, quyến rũ nhưng cũng không kém phần gai góc. Hồng vàng được nhiều người yêu thích bởi màu sắc tươi sáng cùng hương thơm dịu nhẹ tự nhiên.');
insert into SANPHAM values ('HLO', N'Hoa lay ơn', 'HT', 19, 29000, 'hoaLayOn.jpg', N'Gladiolus là tên khoa học của hoa lay ơn. Đôi khi chúng được gọi là hoa thanh kiếm do hình dạng thanh kiếm của cả lá và cành hoa. Ngọn nến hoa được cho là xuyên qua trái tim của người nhận với tình yêu.');
insert into SANPHAM values ('HSDC', N'Hoa sống đời cam', 'HT', 13, 30000, 'hoaSongDoiCam.jpg', N'Một loài hoa sống đời nhỏ nhắn nhưng màu sắc lại rực rỡ và sức sống bền bỉ đã mang theo ý nghĩa cầu chúc tốt đẹp cho người ta yêu thương.');
insert into SANPHAM values ('HSDD', N'Hoa sống đời đỏ', 'HT', 13, 30000, 'hoaSongDoiDo.jpg', N'Một loài hoa sống đời nhỏ nhắn nhưng màu sắc lại rực rỡ và sức sống bền bỉ đã mang theo ý nghĩa cầu chúc tốt đẹp cho người ta yêu thương.');
insert into SANPHAM values ('HSDH', N'Hoa sống đời hồng', 'HT', 13, 90000, 'hoaSongDoiHong.png', N'Một loài hoa sống đời nhỏ nhắn nhưng màu sắc lại rực rỡ và sức sống bền bỉ đã mang theo ý nghĩa cầu chúc tốt đẹp cho người ta yêu thương.');
insert into SANPHAM values ('HSDV', N'Hoa sống đời vàng', 'HT', 13, 90000, 'hoaSongDoiVang.jpg', N'Một loài hoa sống đời nhỏ nhắn nhưng màu sắc lại rực rỡ và sức sống bền bỉ đã mang theo ý nghĩa cầu chúc tốt đẹp cho người ta yêu thương.');
insert into SANPHAM values ('HTN', N'Hoa trạng nguyên', 'HT', 15, 39000, 'hoaTrangNguyen.jpg', N'Hoa Trạng Nguyên mang ý nghĩa thể hiện sự thành đạt. Với ý nghĩa đó, việc chưng hoa Trạng Nguyên ngày Tết vừa mang đến vẻ đẹp cho ngôi nhà của bạn vừa là sự thể hiện mong muốn một năm mới thành công và may mắn cho cả gia đình.');
insert into SANPHAM values ('HLDG', N'Hoa lan đùi gà', 'HT', 33, 99000, 'lanDuiGa.jpg', N'Lan đùi gà là cây thuộc họ chi Hoàng Thảo, có danh pháp khoa học là Dendrobium nobile. Loài hoa này còn được gọi bằng nhiều tên khác như hoàng thảo đùi gà, hoàng lan đùi gà, kim hoa thạch hộc, hoàng phi hạc.');
insert into SANPHAM values ('HLGH', N'Hoa lan giáng hương', 'HT', 13, 99000, 'lanGiangHuong.jpg', N'Phong lan Giáng Hương là giống lan có tên khoa học Aerides – Aerides mang ý nghĩa “đứa con của không khí”. Có thân cao khoảng 20-30cm lá dày và dài, nhành hoa dạng chuỗi, sinh sống chủ yếu ở những khu rừng nhiệt đới ẩm thấp. Đây là giống Lan hiếm hoi có mùi hương thoang thoảng dịu nhẹ.');
insert into SANPHAM values ('HLHD', N'Hoa lan hồ điệp', 'HT', 13, 99000, 'lanHoDiep.jpg', N'Lan hồ điệp có tên khoa học là Phalaenopsis Blume, tên tiếng anh là Phalaenopsis hay Moth orchid hoặc Butterfly orchids. Đây là một trong số những loại hoa thích hợp với điều kiện nhiệt đới ẩm, cây đơn thân, ít lá, lá của hoa lớn có hình dáng thuôn nhọn, không có giả hành.');
insert into SANPHAM values ('HLPD', N'Hoa lan phi điệp', 'HT', 13, 99000, 'lanPhiDiep.jpg', N'Lan Phi Điệp hay còn gọi là lan giả hạc ở miền nam đang được biết đến là dòng hoa lan sốt nhất và được nhiều người tìm kiếm nhất. Phi điệp thuộc dòng hoàng thảo ưu thích khí hậu nhiệt đới vì vậy dòng lan này được phân bố chủ yếu ở các nước Đông Nam Á như: Thái Lan, lào, Việt Nam, Cumpuchia,...');
insert into SANPHAM values ('HLTN', N'Hoa lan thiên nga', 'HT', 13, 99000, 'lanThienNga.png', N'Hoa lan thiên nga có tên khoa học là Cycnodes, có nguồn gốc từ Trung Quốc, sau đó được nhân giống ở nhiều nơi trong đó có Việt Nam, và đang dần trở thành 1 trong những dòng lan có sức hấp dẫn nhất hiện nay. Lan thiên nga có màu sắc vô cùng phong phú, mùi hương thường giảm dần từ sáng sớm đến chiều tối.');
insert into SANPHAM values ('HLVN', N'Hoa lan vũ nữ', 'HT', 13, 99000, 'lanVuNu.jpg', N'Hoa lan vũ nữ hay người ta còn gọi là phong lan vũ nữ. Nó có tên tiếng anh là Oncidium. Trong khoa học, nó được gọi là Arachnis Annamensis. Loài hoa này được tìm thấy lần đầu tiên ở các nước Châu Mỹ và sau đó nhân giống rộng ra khắp các nước, trong đó có Việt Nam. Theo như những tài liệu được ghi lại, hiện này có khoảng tận 600 loài lan vũ nữ.');
insert into SANPHAM values ('HCBH', N'Hoa cưới baby hồng', 'HTCD', 15, 180000, 'hoaCuoiBabyHong.jpg', N'Hoa cưới baby và hoa hồng chứa đựng nhiều ý nghĩa mong muốn tình yêu của vợ chồng luôn thủy chung, bền chặt của hoa hướng dương, thể hiện niềm vui mới và hạnh phúc ngập tràn cùng với hoa cẩm chướng,.. Một bó hoa cưới không chỉ để điểm tô cho cô dâu xinh xắn mà nó còn thể hiện quan niệm về tình yêu, hoa cưới cầm tay cô dâu còn mang nhiều ý nghĩa về sự may mắn về phong cách cô dâu.');
insert into SANPHAM values ('HCBT', N'Hoa cưới baby tím', 'HTCD', 12, 210000, 'hoaCuoiBabyTim.jpg', N'Bởi vì mang màu sắc trầm lắng, dịu nhẹ nên ý nghĩa hoa baby tím gắn liền với những câu chuyện tình yêu lãng mạn. Màu tím là màu mang ý nghĩa son sắt, hẹn thề, thủy chung, lãng mạn và đôi khi nó còn là màu của sự chờ đợi. Ngoài ra, nó còn mang ý nghĩa gắn kết các thành viên trong gia đình, tạo cảm giác ấm áp, đằm ấm và thể hiện sự tự do.');
insert into SANPHAM values ('HCBX', N'Hoa cưới baby xanh', 'HTCD', 10, 230000, 'hoaCuoiBabyXanh.jpg', N'Hoa baby màu xanh bình yên và nhớ lại những kỉ niệm xưa, bao nhiêu kí ức tràn về. Ngày ấy nhờ bó hoa baby mà chúng ta gặp nhau ngay giữa cánh đồng baby bất tận. Nhìn hoa baby và nghĩ đến anh, lòng bình yên sau bao nhiêu sóng gió đã trải qua.');
insert into SANPHAM values ('HCHH', N'Hoa cưới hoa hồng', 'HTCD', 13, 130000, 'hoaCuoiHoaHong.jpg', N'Hoa hồng  là loài hoa nổi tiếng xinh đẹp. Tuy có thân gai góc nhưng không thể phủ nhận rằng hoa hồng mang trong mình sức hút triệu người mê đắm biết bao ánh nhìn. Bản thân hoa hồng đỏ có tính triết học rộng rãi như một biểu tượng của tình yêu đích thực. Nhiều bạn trẻ tặng hoa hồng màu đỏ để bày tỏ tình yêu với ai đó.');
insert into SANPHAM values ('HCHLL', N'Hoa cưới hoa linh lan', 'HTCD', 13, 110000, 'hoaCuoiHoaLinhLan.png', N'Sắc trắng của hoa linh lan chính là vẻ đẹp đặc biệt, màu trắng tượng trưng cho những điều thuần khiết, chân thành nhất. Chẳng cần lộng lẫy, kiêu sa, chỉ giản dị, âm thầm mang đến hương sắc cho đời, những bông hoa linh lan mang nhiều ý nghĩa về tình yêu, sự may mắn và sự trở về hạnh phúc.');
insert into SANPHAM values ('HCHT', N'Hoa cưới hoa tulip', 'HTCD', 13, 98000, 'hoaCuoiHoaTulip.jpg', N'Tulip là loài hoa nổi tiếng của Hà Lan được rất nhiều cặp đôi yêu thích để kết thành bó hoa cầm tay cô dâu ngày cưới. Những cánh hoa đầy màu sắc, xếp chồng lên nhau theo dáng thuôn dài tượng trưng cho sự gắn kết, bền lâu.');
insert into SANPHAM values ('HCHLK', N'Hoa cưới hoa loa kèn', 'HTCD', 12, 91000, 'hoaCuoiLoaKen.jpg', N'Hoa loa kèn là loài hoa mang vẻ đẹp trong sáng, tinh khôi, sang trọng và cao quý. Bên cạnh đó nó còn mang ý nghĩa cho sự hạnh phúc, tình cảm thuận hòa, những điều tốt lành. Chính vì thế, hoa loa kèn được rất nhiều cặp đôi yêu thích và lựa chọn để kết thành bó hoa cưới cầm tay hay trang trí tiệc.');
insert into SANPHAM values ('HVC', N'Hoa viếng cúc trắng', 'HTCD', 10, 190000, 'hoaViengCuc.jpg', N'Vòng hoa viếng kết bằng hoa cúc trắng.');
insert into SANPHAM values ('HVLT', N'Hoa viếng lan tím', 'HTCD', 9, 290000, 'hoaViengLanTim.jpg', N'Vòng hoa viếng được kết bằng hoa lan tím.');
insert into SANPHAM values ('GM', N'Giỏ mây', 'CGH', 13, 30000, 'gioMay.jpg', N'Giỏ mây dùng để cắm hoa.');
insert into SANPHAM values ('CH', N'Chậu hoa', 'CGH', 13, 90000, 'chauHoa.png', N'Chậu trồng hoa.');
select * from SANPHAM;


-- PROCEDURE ===================================================================================================================
-- Tìm kiếm sản phẩm -----------------------------------------------------------------------------------------------------------
go
create proc timKiemSP
@tenSP nvarchar (100)
as
begin
	select * 
	from SANPHAM
	where tenSP like @tenSP
end

exec timKiemSP N'Hoa anh đào'

-- Thanh toán hóa đơn ----------------------------------------------------------------------------------------------------------
go
create proc thanhToanHD
@maHD int,
@userName varchar(100),
@maSP varchar (10),
@sl int
as
begin
	-- Nếu chưa có hóa đơn -> Tạo mới 1 hóa đơn -> Thêm vào chi tiết hóa đơn
	if(select COUNT(*) from HOADON where maHD = @maHD) = 0 -- (đếm sl hóa đơn = 0)
	begin
		-- tạo mới 1 hóa đơn
		insert into HOADON (ngayDat, trangThai, UserName) values (GETDATE(), N'Đang xử lý', @userName)
		-- lưu lại mã hd vừa tạo
		select @maHD = MAX(maHD) from HOADON -- mã hóa đơn được tạo là tổng số hóa đơn hiện có
		-- lấy đơn giá của sản phâm
		declare @donGia int
		select @donGia = donGia from SANPHAM where maSP = @maSP
		-- thêm vào chi tiết hóa đơn
		insert into CTHOADON values(@maHD, @maSP, @sl, @donGia)
		-- kiểm tra số lượng
		if(select @sl - sLTon from SANPHAM where maSP = @maSP) < 1 -- Còn sản phẩm
		begin
			-- giảm số lượng sản phẩm
			update SANPHAM set sLTon = (sLTon - @sl) where maSP = @maSP
		end
	end

	-- Ngược lại, nếu đã có hóa đơn (maHD > 0) -> thêm vào chi tiết hóa đơn
	else 
	begin 
		-- lấy ra giá bán của sản phâm
		declare @donGiaCTHD int
		select @donGiaCTHD = donGia from SANPHAM where maSP = @maSP
		-- tạo mới 1 chi tiết hóa đơn
		insert into CTHOADON values (@maHD, @maSP, @sl, @donGiaCTHD)
		-- kiểm tra số lượng
		if(select @sl - sLTon from SANPHAM where maSP = @maSP) < 1  
		begin
			-- giảm số lượng sản phẩm
			update SANPHAM set sLTon = (sLTon - @sl) where maSP = @maSP
		end
	end
end

exec thanhToanHD 1, 'cris', 'HHDo', 1;
select * from HOADON;
select * from CTHOADON;
select * from SANPHAM;