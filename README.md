# HSettings (codenamed Helix Settings)
 Simple config file system for Unity. (save & load quality settings)
 
# How to use
  Add the script "Settings" to your main menu.
  
  To change settings use a toggle/dropdown/slider (unity only,textmeshpro support coming soon) and use the OnChangeValue function to reference the Settings script from
  a GameObject and change a specific setting.
 
 AA = AntiAliasing
 
 RR = Realtime Reflection Probes
 
 SQ = Shadow Quality (shadow type)
 
 SR = Shadow Resolution
 
 SP = Soft Particles (deferred only)
 
 LOD = LOD Bias
  
# Saved data location
  There is an option which allows you to select the location of the saved settings file:

  -Game Directory: The local game directory (The .exe directory if its in a build and the project directory if used in the editor)

  -App Data: AppData/LocalLow/CompanyName/ProductName directory. This folder is the same if the game is a build or in the editor.
  
  
# Platform Compatibility
Currently it has only been tested on Windows 10.

If you test it on another platform and you experience any problem,please let me know leaving an Issue with information about what platform you are
having the problems so i can fix them. Thanks! 
  
