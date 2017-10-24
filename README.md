# CED

CED: Configuration Encryption and Decryption

You can encrypt and decrypt web.config, app.config and config transformation files using a combination of CED, Aspnet_regiis.exe (used for encryption) and the [Config Transformation Tool](https://ctt.codeplex.com/).

CED can work with web.config and app.config files or their transformations. You can choose which option you want by checking or unchecking the `Use Config Transformation` checkbox at the top of the program.

This tool was developed by [SysKit Ltd.](https://www.syskit.com/) and the CED project is licensed under the terms of the MIT license.

##Encrypting .config files.

Here is what you need to do to encrypt configuration files. We recommend highly that you learn more about [web.config transformations](https://msdn.microsoft.com/en-us/library/dd465318(v=vs.100).aspx) before encrypting your data.

1. To encrypt a file, you first need to create an encryption certificate. Run the following command from a Visual Studio command prompt to create a self-signed certificate in .pfx format: `makecert -r -pe -n "CN=YourKeyName" -sky exchange "YourKeyName.cer" -sv "YourKeyName.pvk"`.
1. You will be prompted three times for a password to secure the private key.Enter a password of your choice.
1. Then enter the following command to create the .pfx file. After the –pi switch, enter the password you have chosen: `pvk2pfx -pvk "YourKeyName.pvk" -spc "YourKeyName.cer" -pfx "YourKeyName.pfx" -pi password-entered-in-previous-step`
1. You can verify that the certificate has been created by looking in the current directory in the Visual Studio command prompt.
1. Import the created certificate in .pfx format to the **Local Machine** store in the **My store name** on your machine. To get to the management console:
 * Click Start, type **mmc** in the **Search programs and files box**, and then press **Enter**.
 * On the **File** menu, click **Add/Remove Snap-in**.
 * Under **Available snap-ins**, double-click **Certificates**.
 * Select **Computer account**, and then click **Next**.
 * Click **Local computer**, and then click **Finish**.
 * Right-click in the Personal store. Under **All Tasks**, click **Import**. Browse to the .pfx file and import the certificate.
 * Enter the password chosen in step 2.
1. You will often need the thumbprint of the certificate you just provisioned:
 * Fire up a PowerShell shell and type the following : `Get-ChildItem -path cert:\LocalMachine\My | Where Subject -eq "CN=YourKeyName"`
 * Save the thumbprint value.
1. Make sure you have your certificate, thumbprint and password to the safe place!
1. To able to encrypt and decrypt a section of a config or config transformation file, you need to add a custom provider to the transformation file. You can add one with code like the following example: 
    
    ```
    <configProtectedData>
      <providers>
        <add name="YouCustomProviderName" thumbprint="ThumbprintOfYourCustomCertificate" type="Pkcs12ProtectedConfigurationProvider.Pkcs12ProtectedConfigurationProvider, PKCS12ProtectedConfigurationProvider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=34da007ac91f901d" />
      </providers>
    </configProtectedData>
    
    ```
    
    This code should be placed inside the configuration tags of your config file. If you are adding a provider into a transformation file, be sure to add `xdt:Transform="Insert"` to the opening `configProtectedData` tag.
    
    To be able to use a custom provider with the `Pkcs12ProtectedConfigurationProvider` option, you need to add a .dll file to your solution. The easiest way to achieve this is by using the nuget package manager. Fire up nuget in your project, search for `Pkcs12ProtectedConfigurationProvider` and install it.
    
    ![CED](https://raw.githubusercontent.com/Acceleratio/CED/master/images/provider-package.PNG "CED in action!")
    
    Provider package in nuget manager in VS 2015.

## Screenshots of CED in action.

CED with checked option for encrypting and decrypting configuration transformation.

![CED](https://raw.githubusercontent.com/Acceleratio/CED/master/images/CED-intro.png "CED in action!")

CED with option for encrypting and decrypting web.config and app.config.

![CED](https://raw.githubusercontent.com/Acceleratio/CED/master/images/CED-intro-2.PNG "CED in action!")
