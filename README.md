# GitMultipleRepos
This application will loop through multiple subdirectories and git pull them all.

The application is designed to first and foremost pull all repositories located in a given directory.
It will then change to a specified directory and call a batch file and pass a restore or run parameter.
The batch file will issue the passed parameter to "dotnet" in a project folder.

## Installation
No installation available at this time

## Future Developments:
* Take Parameters (Update, Restore, Run) to do the following:
  * Update - Updates the repo with a git pull
  * Restore - change to a specified folder, call a batch file passing it the "restore" parameter
  * Run - change to a specified folder, call a batch file passin it the "run" parameter 
* Collect/create a list of warnings when specified folders/batch files do not exist and display at the end of job
* Take a directory as a parameter instead of using the run directory
* Use a GUI instead of command line
