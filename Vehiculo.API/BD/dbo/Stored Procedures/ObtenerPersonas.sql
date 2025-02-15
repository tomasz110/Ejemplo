CREATE PROCEDURE ObtenerPersonas
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
    SELECT Id, Nombre, Apellido, Correo
FROM   Persona
END