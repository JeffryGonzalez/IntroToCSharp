Practice 3: Daily Journal
=========================

The application you create for this practice will allow you to create a simple daily journal. It will write the journal to a file called "journal.txt" in the practices folder you created in the previous exercise.

It is a simple Console application. When it starts, it simply asks you to add a small journal entry. In the spirit of twitter, please limit these entries to 140 characters or less. When you finish entering your entry, it writes it to the bottom of your jounral file, with a date and timestamp. You should be able to read this journal in notepad.

**Variation 1**

Make it so the application reads the file name from the application configuration file instead of having it hard-coded in the application.

**Variation 2**

Make it so that when the application starts, it shows you your last 5 entries (or if you have less than five, all of them.)

The entries should be displayed in the console in reverse chronological order. The latest entry should be displayed at the top.

Each entry should be color coded. The date of the entry should be on the first line, formatted as a long date (Wednesday, September 10, 2014 at 11:45 a.m.) in bright blue. The entry should be displayed starting on the line after that in gray. Then display two blank lines and then the next entry.

Please clear the console when the application starts.

**Variation 3**
*Extra Credit!*

Convert the application to a Windows Forms application. There should be no duplicated code between the two applications. Common functionality should be in a class library (DLL).

