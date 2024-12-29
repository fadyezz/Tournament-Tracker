
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbo.sptournamentPrizes_Insert
	@TournamentId int,
	@PrizeId int,
	@id int = 0 output


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into dbo.TournamentPrizes(TournamentId,PrizeId)
	values (@TournamentId,@PrizeId)
	select @id = SCOPE_IDENTITY();
END
GO
