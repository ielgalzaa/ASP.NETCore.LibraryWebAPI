
CREATE   PROCEDURE dbo.sp_deleteAllLibraryUsers

	@role nvarchar(30)

	AS BEGIN TRY

		BEGIN TRANSACTION
		
		DELETE	
		FROM Users
		WHERE Role like @role

		COMMIT TRAN -- Transaction Success!

	END TRY
	BEGIN CATCH
	
		ROLLBACK TRAN --RollBack in case of Error

	END CATCH