# Palin_Ident
### Palin_Ident is a console-app that identifies wether a input is an palindrome (reads the same back/- forward) or not. 

Got the idea for this by a teacher of mine and wanted to use it to find out what to google to improve.

  - The program gets its string input by user via Console.ReadLine(). 
  - While preseving the original variable the input gets converted to lower case and whitespaces gets erased.
  - A if-loop checkes wether the converted string has more than 0 characters and less than 249. Otherwise returns to input request.
  - Converted input string gets converted to char array.
  - Creating a new instance of the converted char array.
  - One of the Arrays gets reversed.
  - The originl and the reversed array both gets converted to hash.
  - A if-loop compares both hashes by bool and returns proper messages.
  - On any key Clear(); and return to input request.
