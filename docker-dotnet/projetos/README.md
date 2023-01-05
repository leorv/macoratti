# SDKs no Debian

Se houverem problemas do VS Code não encontrar os SDKs do .NET, fazer o seguinte:

Adicionar o seguinte para o .bashrc na pasta do usuário:

```
export MSBuildSDKsPath="/usr/share/dotnet/sdk/$(dotnet --version)/Sdks"
```
