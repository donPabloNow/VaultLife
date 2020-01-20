﻿
CREATE PROC [dbo].[usp_GameDelete] @GameID INT
AS
SET NOCOUNT ON
SET XACT_ABORT ON

BEGIN TRAN

DELETE
FROM [dbo].[Game]
WHERE [GameID] = @GameID

COMMIT
