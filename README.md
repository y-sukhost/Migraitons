# Migraitons
A simply program that helps to change your files. You can configure what you want to replace in your documents. Here changing only .xml files, but you can change this option.

solution have 2 main files - DirectoryConfiguration.cs and Program.cs

Program.cs
  before your work you should to configure what documents you want to change.
  you can do it in 2 ways:
    - use the DirectoryConfigurator.Replace method where you set the file path (with file name) for every file
    - use the DirectoryConfigurator.GetAllFiles method what gets all files from directory and save this info into list. then you use the Replace method for every string in the list
    
DirectoryConfiguration.cs
  class that contains 2 methods:
    -DirectoryConfigurator.GetAllFiles - gets all Files from directory and returns the files List
    -DirectoryConfigurator.Replace - replace substrings
