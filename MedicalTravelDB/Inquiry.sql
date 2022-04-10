CREATE TABLE [dbo].[Inquiry]
(
	[PatientEmail] NVARCHAR(50) NOT NULL PRIMARY KEY,
	[PatientFullName] NVARCHAR(50) NOT NULL,
	[PhoneNumber] BIGINT NULL,
	[InquiryStatus] NVARCHAR(30) NOT NULL,
	[SourceOfInquiry] NVARCHAR(50) NOT NULL,
	[TreatmentID] INT NOT NULL
	CONSTRAINT [FK_Treatment_Inquiry_TreatmentID] FOREIGN KEY (TreatmentID) REFERENCES [Treatment] ([TreatmentID]) ON DELETE CASCADE,
);
