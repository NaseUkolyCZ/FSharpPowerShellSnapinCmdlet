namespace FSharpPowerShellSnapinCmdlet

 open System  
 open System.Management.Automation  
 open System.ComponentModel  

 [<RunInstaller(true)>]  
 type FSharpPowerShellSnapIn() =  
   inherit PSSnapIn()  
   override this.Name with get() = "aa"  
   override this.Vendor with get() = "bb"  
   override this.Description with get() = "dd"  
 
 [<Cmdlet(VerbsCommunications.Write, "Hi")>]  
 type WriteHelp() =   
   inherit Cmdlet()  
   override this.ProcessRecord() =   
     base.WriteObject("help");  


// see http://apollo13cn.blogspot.cz/2013/11/use-f-to-write-powershell-snapin-cmdlet.html
