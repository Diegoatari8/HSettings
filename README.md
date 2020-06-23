# HSettings (codenamed Helix Settings)
 Simple config file system for Unity. (save & load quality settings)
 
# How to use
  Add the script "Settings" to your main menu (first scene).
  
  To change settings add the Setting Receiver component to your toggle/slider/dropdown and set On Value Changed to change the specific setting you want to change.
  
# Saved data location
  There is an option which allows you to select the location of the saved settings file:

  -Game Directory: The local game directory (The .exe directory if its in a build and the project directory if used in the editor)

  -App Data: AppData/LocalLow/CompanyName/ProductName directory. This folder is the same if the game is a build or in the editor.
  
  
