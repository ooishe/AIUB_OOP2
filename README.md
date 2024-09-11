# AIUB_OOP2 Crud Application Using C#
 
Desktop CRUD App Written In C#(.NET Framework)
 
 
## Preview

![image](https://github.com/user-attachments/assets/42acb806-aeb1-40b2-9b97-22b329398003)

 
### Bulit With
- Programming Language: C#(.Net Framework)
- Database: Microsoft SQL Server
- IDE: Visual Studio
 
 
## Features(Buttons)
 
- **Add:** Add new user data to the database.
- **Delete:** Remove existing user data based on userid.
- **Update:** Modify details of a selected user.
- **Refresh:** Clear input fields for a new operation.
- **Search:** Finds and shows data of a specific user


 ## How to Run
1. Right click on the server and the on properties
   
![Screenshot 2024-09-11 221727](https://github.com/user-attachments/assets/7200dba8-6a62-4683-b980-6c3c7e517f42)

2. Double click to select and copy the Connection String

![Screenshot 2024-09-11 221752](https://github.com/user-attachments/assets/696719a2-262b-41bd-a932-e5408b8d42e8)

4. Paste it in the double qoutation. 
 ![image](https://github.com/user-attachments/assets/5b972da2-e4ae-4c05-a690-1b68f9cd5088)

5. Finally run the code

   ![Screenshot 2024-09-11 221851](https://github.com/user-attachments/assets/08d6da72-8f79-49d0-908b-14ee606f7f09)

 
 
## SQL Query
#### Table Design
```bash
CREATE TABLE [dbo].[Table_1] (
    [ID]         VARCHAR (50) NOT NULL,
    [Name]       VARCHAR (50) NULL,
    [Department] VARCHAR (50) NULL,
    [BookName]   VARCHAR (50) NULL,
    [Date]       VARCHAR (50) NOT NULL,
    [UpdateDate] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED ([ID] ASC)
);

```
#### Add
```bash
"insert into Table_1 values ( '" + int.Parse(textBox1.Text) + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "' , getdate(), getdate() )", con
```
#### Delete
```bash
"Delete Table_1 where ID='" + int.Parse(textBox1.Text) + "' ", con
```
#### Update
```bash
"update Table_1 set Name = '" + textBox3.Text + "', Department = '"+comboBox1.Text+"', BookName='"+textBox4.Text+"', Updatedate= getdate() where ID ='"+ int.Parse(textBox1.Text) + "' ", con)
```
#### Refresh
```bash
textBox1.Clear();
textBox3.Clear();
comboBox1.SelectedIndex = -1;
textBox4.Clear();

```

#### Search
```bash
select * from Table_1 where ID='" + int.Parse(textBox1.Text) + "' "
```


## Tech Stack
 
**Programming Language:** C# <br><br>
**Database:** SQL Server<br><br>
**Framework:** Windows Forms<br><br>
**UI Components:** <br>
    - Text Box for entering data.<br>
    - Button for response.<br>
    - Data Grid View for displaying and managing data
 
 
## 🛠 Skills
- C#
- .NET Framework
- SQL Server
- Windows Forms Development
