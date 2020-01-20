USE [VaultLifeApplication]
GO
/****** Object:  StoredProcedure [dbo].[MakeGameRules]    Script Date: 2014/09/15 10:50:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[MakeGameRules]
@GameTypeID int,
@GameID int,
@UserName varchar(255) = null
AS 
BEGIN

IF NOT EXISTS(select * from GameRule where GameID = @GameID)
BEGIN

SET @UserName = isnull(@UserName, 'System')

DECLARE 
        @RuleID     INT, 
        @TemplateID INT 

declare @GameRuleCode varchar(255), @GameRuleDetail varchar(255)

declare cr cursor for select 
GameRuleCode, GameRuleDetail, GameTemplateID
from GameTemplate where GameTypeID = @GameTypeID
order by OrderInGame

open cr

fetch next from cr into @GameRuleCode, @GameRuleDetail,@TemplateID
while @@FETCH_STATUS = 0
begin

INSERT INTO [dbo].[gamerule] 
            ([gamerulecode], 
             [gameid], 
             [filtercriteria], 
             [schedule], 
             [chaingameruleid], 
             [gameruledetail], 
             [excecutetime], 
             [dateinserted], 
             [dateupdated], 
             [usr], 
             [gametemplateid]) 
VALUES      (
			 @GameRuleCode,
             @GameID, 
             '',
             1, 
             '', 
             @GameRuleDetail, 
             Dateadd(MINUTE, 4, Getdate()), 
             Getdate(), 
             Getdate(), 
             @UserName, 
             @TemplateID)

fetch next from cr into @GameRuleCode, @GameRuleDetail,@TemplateID
END

close cr
deallocate cr


END 

END



