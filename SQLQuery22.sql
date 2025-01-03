USE [TournamentTracker]
GO
/****** Object:  StoredProcedure [dbo].[spTournaments_Insert]    Script Date: 12/15/2024 5:55:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[spTournaments_Insert]
	-- Add the parameters for the stored procedure here
	@TournamentName nvarchar(30),
	@EntryFee money,
	@id int = 0  output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	insert into dbo.Tournaments(TournamentName,EntryFee,Active)
	values (@TournamentName,@EntryFee,1);
END
