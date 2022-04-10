/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
delete from dbo.Doctors
DBCC CHECKIDENT (Doctors, RESEED, 0)
go

DELETE FROM [dbo].Inquiry
go

DELETE FROM [dbo].Sales
DBCC CHECKIDENT (Sales, RESEED, 0)
go

DELETE FROM [dbo].Treatment
DBCC CHECKIDENT (Treatment, RESEED, 0)
go

SET IDENTITY_INSERT [dbo].Doctors ON
INSERT INTO [dbo].[Doctors] ([DoctorID], [DoctorName], [DoctorPhone]) VALUES (1, N'Gamze Savas', 905322751423)
INSERT INTO [dbo].[Doctors] ([DoctorID], [DoctorName], [DoctorPhone]) VALUES (2, N'Selahattin Tulunay', 905432123436)
INSERT INTO [dbo].[Doctors] ([DoctorID], [DoctorName], [DoctorPhone]) VALUES (3, N'Resat Aktug', 905332123435)
INSERT INTO [dbo].[Doctors] ([DoctorID], [DoctorName], [DoctorPhone]) VALUES (4, N'Mjholly', 4475023425)
INSERT INTO [dbo].[Doctors] ([DoctorID], [DoctorName], [DoctorPhone]) VALUES (5, N'Mustafe Bese', 905442326782)
INSERT INTO [dbo].[Doctors] ([DoctorID], [DoctorName], [DoctorPhone]) VALUES (6, N'Esra Drago', 905442326782)
SET IDENTITY_INSERT [dbo].[Doctors] OFF
go

INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (1, N'Hair Transplant', 1550)
INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (2, N'Hair Transplant', 1550)
INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (2, N'Hair Transplant', 1750)
INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (3, N'Hair Transplant', 2000)
INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (4, N'Hair Transplant', 2250)
INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (2, N'Liposuction', 1250)
INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (3, N'Liposuction', 1350)
INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (4, N'Liposuction', 1550)
INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (2, N'Gynecommasty', 1950)
INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (2, N'Breast Reduction', 1700)
INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (2, N'Breast Enlargement', 1700)
INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (2, N'Uplift', 1300)
INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (2, N'Rhinoplasty', 2100)
INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (2, N'Tummy Tuck', 2500)
INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (2, N'Chin Implant', 2000)
INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (2, N'Forehead Lifting', 1900)
INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (5, N'Porcelan Veneer', 1100)
INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (5, N'Dental Implant', 1400)
INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (5, N'Hollywood Smile', 3400)
INSERT INTO [dbo].[Treatment] ([DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (5, N'Dental Cleaning', 300)
go

INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'ehezzynz@gmail.com', N'Ezzedine Hamdallah', 61406571656, N'Active', 'Facebook', 1)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'sarahfaiz99@gmail.com', N'Sara Faiz', 212668023354, N'Treated', N'Website', 1)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'suleyman5555@gmail.com', N'Suleyman', 447840009007, N'Inactive', N'Instagram', 3)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'ghakhar@hotmail.co.uk', N'Azhar', 447791287332, N'Treated', N'WhatsApp', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'jamescs1981@hotmail.co.uk', N'Alize Nal', 4412353123, N'Treated', N'Website', 1)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'homez247@hotmail.co.uk', N'Mlai Aps', 44123512312, N'Active', N'Website', 1)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'munirahmad_786@hotmail.com', N'Munir Ahmad', 331235544, N'Inactive', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'gdr1a@yahoo.it', N'Oplik Mikl', 90213451231, N'Active', N'Instagram', 3)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'cpkumara1@gmail.com', N'Pathmakumar', 445431233, N'Active', N'Website', 4)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', 448987123123, N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'jamiesween@yahoo.co.uk', N'Jamie Swreney', 44406571656, N'Inactive', 'Whatsapp', 0)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'robmattwild@talktalk.net', N'Rob Matt Wild', 44406121636, N'Active', 'Facebook', 3)


 go

insert into [dbo].[Sales] ([PatientEmail], [DoctorID], [TreatmentID], [PatientsFullName], [PhoneNumber], [DepositRequired], [TotalRemainingBalance], [RemainingBalanceToDoctor], [NetProfit], [DoctorAppointedDate]) VALUES (N'sarahfaiz99@gmail.com', 1, 1, N'Sara Faiz', 212668023354, 100, 1450, 700, 850, N'12/11/2012')
insert into [dbo].[Sales] ([PatientEmail], [DoctorID], [TreatmentID], [PatientsFullName], [PhoneNumber], [DepositRequired], [TotalRemainingBalance], [RemainingBalanceToDoctor], [NetProfit], [DoctorAppointedDate]) VALUES (N'ghakhar@hotmail.co.uk', 2, 1, N'Azhar', 447791287332, 100, 1650, 900, 850, N'11/10/2014')
insert into [dbo].[Sales] ([PatientEmail], [DoctorID], [TreatmentID], [PatientsFullName], [PhoneNumber], [DepositRequired], [TotalRemainingBalance], [RemainingBalanceToDoctor], [NetProfit], [DoctorAppointedDate]) VALUES (N'jamescs1981@hotmail.co.uk', 3, 1, N'Alize Nal', 4412353123, 100, 1900, 1100, 900, N'04/03/2017')
insert into [dbo].[Sales] ([PatientEmail], [DoctorID], [TreatmentID], [PatientsFullName], [PhoneNumber], [DepositRequired], [TotalRemainingBalance], [RemainingBalanceToDoctor], [NetProfit], [DoctorAppointedDate]) VALUES (N'jamiesween@yahoo.co.uk', 3, 0, N'Ishtiaq Hussain', 44406571656, 100, 1900, 1100, 900, N'02/03/2019')

GO






