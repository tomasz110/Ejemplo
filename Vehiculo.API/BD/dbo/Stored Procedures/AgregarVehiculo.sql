﻿CREATE PROCEDURE [dbo].[AgregarVehiculo]
	-- Add the parameters for the stored procedure here
		   @Id as uniqueidentifier,
           @IdModelo as uniqueidentifier, 
           @Placa as varchar(100), 
           @Color as varchar(max),
           @Anio as int,
           @Precio as decimal(18,0),
           @CorreoPropietario as varchar(max),
           @TelefonoPropietario as varchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    BEGIN TRANSACTION
	INSERT INTO [dbo].[Vehiculos]
           ([Id]
           ,[IdModelo]
           ,[Placa]
           ,[Color]
           ,[Anio]
           ,[Precio]
           ,[CorreoPropietario]
           ,[TelefonoPropietario])
     VALUES
           (   @Id ,
           @IdModelo, 
           @Placa, 
           @Color,
           @Anio,
           @Precio,
           @CorreoPropietario,
           @TelefonoPropietario)

    SELECT @Id

    COMMIT TRANSACTION
END