## EF6 Code first
How to modify the data without droping & re-creating:
https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/migrations/#:~:text=Code%20First%20Migrations%20is%20the,make%20to%20your%20EF%20model

Click Tools -> Package Manager Console & type:
```
Enable-Migrations
```
Go to Employee add new string property Email

Use this command to generate new Migration
```
Add-Migration AdjustEmployeeModel
```

To apply the latest migrations to database, run following command:
```
Update-Database
```