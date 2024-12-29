
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbo.spTournaments_Insert
	-- Add the parameters for the stored procedure here
	@TournamentName nvarchar(30),
	@EntryFee money
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	insert into dbo.Tournaments(TournamentName,EntryFee,Active)
	values (@TournamentName,@EntryFee,1);
END
GO
