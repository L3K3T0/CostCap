CREATE TABLE [dbo].[Payments]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PaymentName] NVARCHAR(50) NULL, 
    [isSubscription] BIT NULL, 
    [BillingDate] SMALLDATETIME NULL
)
