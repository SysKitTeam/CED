# CED
CED - .config Encrypt &amp; Decrypt

Use this guide to encrypt and decyrpt your web.config and app.config files using CED and Aspnet_regiis.exe tool.

##Encrypting .config files.

Here is what you need to to in order to encrypt your configuration files. We highly recommend you to learn more about [web.config transformations](https://msdn.microsoft.com/en-us/library/dd465318(v=vs.100).aspx) before encrypting your data.

1. In order to encrypt your files we first need to create an encryption certificate. Run the following commands from a Visual Studio command prompt to create a self-signed certificate in .pfx format. `makecert -r -pe -n "CN=YourKeyName" -sky exchange "YourKeyName.cer" -sv "YourKeyName.pvk"`. 
2. You will be prompted for a password to secure the private key three times. Enter a password of your choice.
3. Then enter the following command to create the .pfx file. After the –pi switch, enter the password you chose. `pvk2pfx -pvk "YourKeyName.pvk" -spc "YourKeyName.cer" -pfx "YourKeyName.pfx" -pi password-entered-in-previous-step`
4. You can verify that the certificate has been created by looking in the current directory in the Visual Studio command prompt.
5.  Import the created certificate in .pfx format to the **Local Machine** store in the **My** store name on your machine. To get to the management console:
 * Click Start, type **mmc** in the Search programs and files box, and then press ENTER.
 * On the File menu, click Add/Remove Snap-in.
 * Under Available snap-ins, double-click Certificates.
 * Select Computer account, and then click Next.
 * Click Local computer, and then click Finish.
 * In the Personal store, right click, under “All Tasks”, click Import. Browse to the .pfx file and import the certificate.
 * Enter the password chosen in step 1.
6.  
