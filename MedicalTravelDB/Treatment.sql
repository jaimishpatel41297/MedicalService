CREATE TABLE [dbo].[Treatment]
(
	[TreatmentID] INT NOT NULL PRIMARY KEY IDENTITY,
	[TreatmentName] NVARCHAR(50) NOT NULL,
	[TreatmentPrice] BIGINT NOT NULL,
	[DoctorID] INT NOT NULL,
	CONSTRAINT [FK_Doctors_Treatment_DoctorID] FOREIGN KEY ([DoctorID]) REFERENCES [Doctors] ([DoctorID]) ON DELETE CASCADE
);
