
CREATE   PROCEDURE dbo.sp_getAllLibraryUsers
	
AS BEGIN
	SET NOCOUNT ON; -- SET NOCOUNT ON prevents the sending of DONEINPROC messages to the client for each statement in a stored procedure
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; --Controls the locking and row versioning behavior of Transact-SQL statements issued by a connection to SQL Server

	SELECT *		
	FROM Users u
	WHERE u.Role like 'test'
	ORDER BY u.Id
END;