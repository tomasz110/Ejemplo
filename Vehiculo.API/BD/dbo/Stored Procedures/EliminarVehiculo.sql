﻿CREATE PROCEDURE EliminarVehiculo
	-- Add the parameters for the stored procedure here
	@Id uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	BEGIN TRANSACTION
	DELETE
FROM   Vehiculos 
WHERE (Id = @Id)
SELECT @Id

	COMMIT TRANSACTION
END