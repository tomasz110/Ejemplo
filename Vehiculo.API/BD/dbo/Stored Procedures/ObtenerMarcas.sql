﻿Create PROCEDURE [dbo].[ObtenerMarcas]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Marcas.Id, Marcas.Nombre
FROM   Marcas
END