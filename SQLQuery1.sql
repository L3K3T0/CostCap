

-- The INNER JOIN keyword selects records that have matching values in both tables.
/*- Aliases are other ways to reference a table or column result
a table alias is usually used to shorten the name of a table for reading purposes e.g 
SELECT e.first_name, d.department_name
FROM employees AS e
INNER JOIN departments AS d ON e.department_id = d.department_id;
a query alias can be used to store the values of  a query e. g:
 SELECT first_name AS "First Name", last_name AS "Last Name"
FROM employees; */ 
/*SELECT a.*  FROM Accounts a
INNER JOIN AccountsGoals b ON a.ID = b.AccountID;

SELECT g.* FROM Goals g --Returns the all goal records from the goal database
INNER JOIN AccountsGoals ag ON g.Id = b.GoalID -- Where a records' ID matches the Associate Tables Goal ID
WHERE ag.AccountID  = 2; -- and the account ID corresponds to John Doe's record (second ID in the accounts table)
INSERT INTO Goals
VALUES ('PS5',1,500,2023-11-12,1); -- this is how you would programatically add values to the Goals table. Note the bit and date datatypes arguements
DELETE FROM AccountsGoals -- how we would remove a record from the table.
where Id = 7;
SELECT ACCOUNTS.Username FROM Accounts WHERE Username = 'yFDE:?$2?6';
--SELECT * FROM ACCOUNTS WHERE Username = 'JustinSane' AND Password = 'Chicken';

INSERT INTO Accounts VALUES('Xyz','zzz','mark','doe');*/
--UPDATE ACCOUNTS SET Password = 'zyz' WHERE Username = 'Xyz';

/*SELECT Goals.* FROM Goals JOIN CategoryGoals ON Goals.ID = CategoryGoals.GoalID WHERE CategoryGoals.CategoryID = 1;
SELECT * -- * on its own will include all the CategoryRows Items asw
FROM Goals
JOIN CategoryGoals ON Goals.ID = CategoryGoals.GoalID
WHERE CategoryGoals.CategoryID = 2; -- Category ID is just the category that's needed
*/
--SELECT *
--FROM Goals
--WHERE DATEDIFF(month, DueDate , GETDATE()) <= 1;
SELECT * FROM Goals WHERE Goals.IsCompleted  = 1 and Goals.DueDate <= GETDATE() and DATEDIFF(month, DueDate , GETDATE()) <= 1;
/*UPDATE Goals
SET GoalName = @GoalName,
    IsSavingGoal = @GoalType,
    DueDate = @DueDate,
    Goals.Priority = @Priority,
    AmountCompleted = @AmountCompleted,
    IsCompleted = @IsCompleted
    SavingAmount = @SavingAmount
WHERE id = @ID; */
--Work on the bin version if possible