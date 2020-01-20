﻿
CREATE PROC [dbo].[usp_OwnerDelete] @OwnerID INT
AS
SET NOCOUNT ON
SET XACT_ABORT ON

BEGIN TRAN

DELETE
FROM [dbo].[Owner]
WHERE [OwnerID] = @OwnerID

COMMIT
