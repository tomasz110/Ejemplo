CREATE PROCEDURE AgregarPersona
    -- Add the parameters for the stored procedure here
    @Id UNIQUEIDENTIFIER,
    @Nombre VARCHAR(MAX),
    @Apellido VARCHAR(MAX),
    @Correo VARCHAR(MAX)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    -- Insert statements for procedure here
    INSERT INTO [dbo].[Persona]
        ([Id], [Nombre], [Apellido], [Correo])
    VALUES
        (@Id, @Nombre, @Apellido, @Correo);
END