***First Impression***<br/>
I compiled the project and found no major errors. There were shortcuts for the controls, but when I pressed enter and escape to test the accept and cancel buttons, I found that neither key did anything, though I could understand not having an accept button in this app.
<br/><br/>
***Form1***<br/>
I found that the code for Form1 had no documentation. However, it was simple and easy to understand.
<br/><br/>
***StateDetailscs***<br/>
When I looked at the code for StateDetailscs, I found no comments. However, the code was rather simple and easy to understand. Invalid input was handled in the TextChanged events of the textbox. I think that it would be better to handle it in the textboxes’ Leave event, as it doesn’t look for invalid input until the user is done entering the data.
<br/><br/>
***Testing***<br/>
In the datagrid on Form1, when I entered a non-numeric value into one of the numeric columns, an error message displays that can be hard for a user to read. To fix this, handle the invalid value in the data error event. I also noticed that when a change is made to the data in the on either Form1 or StateDetailcs, it does not save despite clicking the save button in the navbar. Another thing that I found is that all fields except for StateID are nullable.
<br/><br/>
***Comparing Projects***<br/>
Something that I was different from my solution was that queries to the database were performed via the table adapter rather than LINQ or SqlCommands. I would prefer to use LINQ over the table adapter because I find it faster to write a LINQ query than design one within the table adapter.
