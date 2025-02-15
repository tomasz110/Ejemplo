CREATE PROCEDURE EditarPersona
	-- Add the parameters for the stored procedure here
		   @Id as uniqueidentifier,
           @Nombre as varchar(max),
           @Apellido as varchar(max),
           @Correo as varchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here


 UPDATE [dbo].[Persona]
   SET [Nombre] = @Nombre
      ,[Apellido] = @Apellido
      ,[Correo] = @Correo
 WHERE Id = @Id
END