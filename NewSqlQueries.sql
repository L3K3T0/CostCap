Select * From Category Join CategoryGoals ON Category.Id = CategoryGoals.CategoryID Where Category.CategoryName = 'Misc';
insert into Payments values ('New Payment',0,0.1,21/11/2010,1,0)
SELECT Payments.* FROM Payments JOIN PaymentCategory ON Payments.Id = PaymentCategory.PaymentID WHERE PaymentCategory.CategoryPID= 2;
insert into PaymentCategory values(5,1)
select  *from Accounts;
select  *from PaymentCategory;
select * from CategoryP;
select  *from Goals;
Delete From PaymentCategory where PaymentID = 5;
Delete From Payments where Payments.Id = 5;
--Delete From CategoryGoals where GoalID = 6;
--Delete From Goals where Goals.Id = 6;
--select Top 1 Category.Id from Category where AccountID = 1;
--Select Id From Category Where Category.CategoryName = 'Boom';
--select * from Payments where AccountID = @ID order by PaymentAmount desc;
--Update PaymentCategory Set PaymentCategory.CategoryPID= @CategoryID Where PaymentCategory.PaymentID = @PaymentID;
--UPDATE Payments SET PaymentName = @PaymentName, isSubscription = @isSubscription, PaymentAmount = @PaymentAmount,
--BillingDate = @BillingDate, IsCompleted = @IsCompleted Where Id = @Id;


--Select Top 1 * From CategoryGoals Where GoalID =  Order by Id Desc;
--insert into CategoryGoals values(9,1)
--insert into Category Values ('Boom',1);

Select * From Goals where Goals.AccountID = 1 order by Goals.Priority asc;