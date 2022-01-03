
// This application will take command line parameters which will do the following on each directory located where the applciation is run:
//
// Update - change into the directory and do a git pull to retrieve the latest code in each directory
// Restore - in each directory, change into a specified folder and call a batch file passing the "restore" parameter
// Run - in each directory, change into a specified folder and call a batch file passing the "run" parameter
//
// Display a list of warnings any time the specified folder does not exist or the batch file within that folder does not exist
//
// Eventually, the application could take in the parent directory as a parameter or a WPF UI could be added.