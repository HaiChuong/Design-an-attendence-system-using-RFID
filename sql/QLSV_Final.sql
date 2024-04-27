CREATE DATABASE QLSV
GO	
CREATE TABLE Account 
(
	
	UserName NVARCHAR(100) PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Hello',	
	PassWord NVARCHAR(1000)NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0 -- 1 admin, 0 Staff
);



CREATE TABLE Students (
    student_id INT IDENTITY(20230001, 1) PRIMARY KEY,
    card_id VARCHAR(20),
    student_name NVARCHAR(255),
    student_email VARCHAR(255),
    student_phone VARCHAR(20)
);



 
CREATE TABLE Classes (
    class_id INT PRIMARY KEY,
    class_name VARCHAR(255)
);


CREATE TABLE Attendance (
    attendance_id INT IDENTITY PRIMARY KEY,
    student_id INT,
    class_id INT,
    DateCheckIn DATETIME NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATETIME,
    attendance_status NVARCHAR(50), 
    FOREIGN KEY (student_id) REFERENCES Students(student_id),
    FOREIGN KEY (class_id) REFERENCES Classes(class_id)
);



INSERT INTO dbo.Classes
(class_id,class_name)
VALUES
(100,N'Văn')

INSERT INTO dbo.Classes
(class_id,class_name)
VALUES
(101,N'Toán')




CREATE PROCEDURE Update_CheckInOut
    @card_id VARCHAR(20), @thuTrongTuan nvarchar(50)
AS 
BEGIN
    DECLARE @student_id INT;
    DECLARE @temporary_variable NVARCHAR(100);
	DECLARE @checkInDate Datetime;
	 DECLARE   @thoiGianVaoHoc TIME ;
    DECLARE @thoiGianTanHoc TIME ;
	DECLARE @ThoiGianHienTai TIME;
	SET @ThoiGianHienTai = CONVERT(TIME, GETDATE());

	select @thoiGianVaoHoc = ThoiGianVaoHoc, @thoiGianTanHoc = ThoiGianTanHoc  from dbo.ThoiKhoaBieu where ThuTrongTuan  = @thuTrongTuan
    SELECT @student_id = student_id FROM dbo.Students WHERE card_id = @card_id;
	SELECT  @checkInDate = MAX(DateCheckIn)  FROM dbo.Attendance WHERE student_id = @student_id
	SELECT @checkInDate as  CheckInMax
	
	
    IF @student_id IS NOT NULL  
    BEGIN
		IF CONVERT(DATE, @checkInDate) = CONVERT(DATE, GETDATE()) 
		BEGIN
			
				if @ThoiGianHienTai < @thoiGianTanHoc
				begin
					UPDATE Attendance
					SET DateCheckOut = GETDATE(),	attendance_status	= N'Về trước giờ'	
					WHERE student_id = @student_id and CONVERT(DATE, DateCheckIn) = CONVERT(DATE, GETDATE());
				end
				else
				begin
					UPDATE Attendance
					SET DateCheckOut = GETDATE(),	attendance_status	= N'Đã điểm danh ra về'
					WHERE student_id = @student_id and CONVERT(DATE, DateCheckIn) = CONVERT(DATE, GETDATE());
				end
			SET @temporary_variable = N'Đã check in, thực hiện update check out';
		END
		ELSE
		BEGIN
			
			if @ThoiGianHienTai <= @thoiGianVaoHoc
			Begin
				INSERT INTO dbo.Attendance (student_id, class_id, DateCheckIn, DateCheckOut, attendance_status)
				VALUES (@student_id, 100, GETDATE(), NULL,N'Đến sớm');
			end
			else
			Begin
				INSERT INTO dbo.Attendance (student_id, class_id, DateCheckIn, DateCheckOut, attendance_status)
				VALUES (@student_id, 100, GETDATE(), NULL,N'Đến muộn');
			end		


			SET @temporary_variable = N'Đã check in, nhưng k phải ngày hôm này, tạo mới';
		END
    END
    ELSE 
    BEGIN
        
			if @ThoiGianHienTai <= @thoiGianVaoHoc
			Begin
				INSERT INTO dbo.Attendance (student_id, class_id, DateCheckIn, DateCheckOut, attendance_status)
				VALUES (@student_id, 100, GETDATE(), NULL,N'Đến sớm');
			end
			else
			Begin
				INSERT INTO dbo.Attendance (student_id, class_id, DateCheckIn, DateCheckOut, attendance_status)
				VALUES (@student_id, 100, GETDATE(), NULL,N'Đến muộn');
			end	

        SET @temporary_variable = N'Chưa từng điểm danh, tạo mới';
    END

    
    SELECT @temporary_variable AS TemporaryVariable;

    
    SELECT DateCheckIn,DateCheckOut FROM Attendance WHERE student_id = @student_id;
END;






CREATE proc summary_Attendance
@checkIn Date, @checkOut Date
As
Begin
	SELECT stu.student_id,stu.card_id, stu.student_name,att.attendance_status,att.DateCheckIn,att.DateCheckOut
	FROM dbo.Attendance as att,dbo.Students as stu
	where CONVERT(DATE, att.DateCheckIn) >= @checkIn and CONVERT(DATE, att.DateCheckIn) <= @checkOut and stu.student_id = att.student_id 
End
go






CREATE  proc insert_table
@card_id VARCHAR(20), @student_name NVARCHAR(255), @student_phone VARCHAR(20),@student_email VARCHAR(255)
as
begin


		INSERT INTO dbo.Students
		(card_id,student_name,student_email,student_phone)
		VALUES
		(@card_id,@student_name , @student_email,@student_phone)

		


end
go

CREATE  proc Delete_Table
@card_id VARCHAR(20)
as
begin
		DECLARE @student_id INT;	
		SELECT @student_id = student_id FROM dbo.Students WHERE card_id = @card_id;
		delete dbo.Attendance	where student_id = @student_id
	
		delete dbo.Students	where student_id = @student_id

end
go

CREATE TABLE ThoiKhoaBieu (
    ID INT PRIMARY KEY IDENTITY(1,1),
    ThuTrongTuan NVARCHAR(20) NOT NULL,
    ThoiGianVaoHoc TIME NOT NULL,
    ThoiGianTanHoc TIME NOT NULL
);


INSERT INTO ThoiKhoaBieu (ThuTrongTuan, ThoiGianVaoHoc, ThoiGianTanHoc)
VALUES
    (N'Thứ Hai', '08:00:00', '10:00:00'),
    (N'Thứ Ba', '09:30:00', '11:30:00'),
    (N'Thứ Tư', '10:45:00', '12:45:00'),
    (N'Thứ Năm', '14:00:00', '16:00:00'),
    (N'Thứ Sáu', '15:30:00', '17:30:00'),
	(N'Thứ Bảy', '15:30:00', '17:30:00'),
	(N'Chủ nhật', '15:30:00', '17:30:00');

	



