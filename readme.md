# FontLoad
FontLoad is a tiny tool designed to load fonts temporarily in Windows without any installation.  
You can load any type of fonts you want, as long as Windows supports it.  
No UAC is needed.  
  
## Compilation
```bat
csc FontLoad.cs
csc FontUnload.cs
```
The csc.exe executable file usually is located at `C:\Windows\Microsoft.NET\Framework\<Version>\csc.exe`.  
  
## Usage
Load fonts examples:  
```bat
fontload C:\path\to\myfont.ttf
fontload myfont01.ttf myfont02.otf
```
  
Unload fonts examples:  
```bat
fontunload C:\Windows\Fonts\impact.ttf
fontunload myfont01.ttf myfont02.otf
```
