# CED
CED - .config Encrypt &amp; Decrypt

Use this tool to encrypt and decyrpt your web.config and app.config or config transformation files using CED, Aspnet_regiis.exe (used for encrpytion) and [Config Transformation Tool](https://ctt.codeplex.com/).

This tool can work with web.config/app.config or their transformations. You can choose which option you want by checking or unchecking `Use Config Transformation` checkbox on top of program.

##Encrypting .config files.

Here is what you need to to in order to encrypt your configuration files. We highly recommend you to learn more about [web.config transformations](https://msdn.microsoft.com/en-us/library/dd465318(v=vs.100).aspx) before encrypting your data.

1. In order to encrypt your files we first need to create an encryption certificate. Run the following commands from a Visual Studio command prompt to create a self-signed certificate in .pfx format. `makecert -r -pe -n "CN=YourKeyName" -sky exchange "YourKeyName.cer" -sv "YourKeyName.pvk"`. 
1. You will be prompted for a password to secure the private key three times. Enter a password of your choice.
1. Then enter the following command to create the .pfx file. After the –pi switch, enter the password you chose. `pvk2pfx -pvk "YourKeyName.pvk" -spc "YourKeyName.cer" -pfx "YourKeyName.pfx" -pi password-entered-in-previous-step`
1. You can verify that the certificate has been created by looking in the current directory in the Visual Studio command prompt.
1. Make sure you have your certificate, thumbprint and password to the safe place!
1.  Import the created certificate in .pfx format to the **Local Machine** store in the **My** store name on your machine. To get to the management console:
 * Click Start, type **mmc** in the Search programs and files box, and then press ENTER.
 * On the File menu, click Add/Remove Snap-in.
 * Under Available snap-ins, double-click Certificates.
 * Select Computer account, and then click Next.
 * Click Local computer, and then click Finish.
 * In the Personal store, right click, under “All Tasks”, click Import. Browse to the .pfx file and import the certificate.
 * Enter the password chosen in step 1.
1. In many cases you will need the thumbprint of the certificate you just provisioned
 * Fire up PowerShell shell and type the following: `Get-ChildItem -path cert:\LocalMachine\My | Where Subject -eq "CN=YourKeyName"`
 * Save the thumbprint value.
1. In order to be able to encrypt and decrypt section of config or config transformation file you need to add custom provider to your config or config transformation file. You can add one with the following example code : 
    
    ```
    <configProtectedData>
      <providers>
        <add name="YouCustomProviderName" thumbprint="ThumbprintOfYourCustomCertificate" type="Pkcs12ProtectedConfigurationProvider.Pkcs12ProtectedConfigurationProvider, PKCS12ProtectedConfigurationProvider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=34da007ac91f901d" />
      </providers>
    </configProtectedData>
    
    ```
    This code should be place inside configuration tags of your config file. If you are adding provider in your transformation file be sure to add `xdt:Transform="Insert"` in opening `configProtectedData` tag.
    
    To be able to use custom provider with `Pkcs12ProtectedConfigurationProvider` option you need to add .dll in your Solution. Easiest way to achieve this is by using nuget package manager, fire up nuget in your project, search for `Pkcs12ProtectedConfigurationProvider` and install it. 
    
    Provider package in nuget manager on VS 2015.
    
    ![CED](https://raw.githubusercontent.com/Acceleratio/CED/master/images/provider-package.PNG "CED in action!")

## Screenshots of CED in action.

CED with checked option for encrypting/decrypting config transformation.

![CED](https://raw.githubusercontent.com/Acceleratio/CED/master/images/CED-intro.png "CED in action!")

CED with option for encrypting/decrypting web.config/app.config.

![CED](https://raw.githubusercontent.com/Acceleratio/CED/master/images/CED-intro-2.PNG "CED in action!")
