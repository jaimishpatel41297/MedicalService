CREATE TABLE [dbo].[Sales]
(
	[SalesID] INT NOT NULL PRIMARY KEY IDENTITY,
	[PatientEmail] NVARCHAR(50) NOT NULL,
	[DoctorID] INT NOT NULL,
	[TreatmentID] INT NOT NULL,
	[PatientsFullName] VARCHAR(50) NOT NULL,
	[PhoneNumber] BIGINT NOT NULL,
	[DepositRequired] BIGINT NOT NULL,
	[TotalRemainingBalance] BIGINT NOT NULL,
	[RemainingBalanceToDoctor] BIGINT NOT NULL,
	[NetProfit] BIGINT NOT NULL,
	[DoctorAppointedDate] DATE NOT NULL,
	CONSTRAINT [FK_Inquiry_Sales_PatientEmail] FOREIGN KEY ([PatientEmail]) REFERENCES [Inquiry] ([PatientEmail]) ON DELETE CASCADE,
	CONSTRAINT [FK_Doctor_Sales_DoctorID] FOREIGN KEY ([DoctorID]) REFERENCES [Doctors] ([DoctorID]) ,
	CONSTRAINT [FK_Treatment_Sales_TreatmentID] FOREIGN KEY ([TreatmentID]) REFERENCES [Treatment] ([TreatmentID]) 
);
