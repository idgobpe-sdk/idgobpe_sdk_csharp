# IDGOB.PE C# SDK

## 1. Instalación:

```
dotnet add package idgobpe_sdk --version 1.0.3
```

## 2. Gestor de dependecias

[Nuget](https://www.nuget.org/packages/idgobpe_sdk/)

## 3. Configuración

### ACR disponibles

```
Constants.ACR_ONE_FACTOR
Constants.ACR_TWO_FACTOR
Constants.ACR_CERTIFICATE_DNIE
Constants.ACR_CERTIFICATE_TOKEN
Constants.ACR_CERTIFICATE_DNIE_LEGACY
Constants.ACR_CERTIFICATE_TOKEN_LEGACY
```

### Prompt disponibles

```
Constants.PROMPT_NONE
Constants.PROMPT_LOGIN
Constants.PROMPT_CONSENT
```

### Scope disponibles

```
Constants.SCOPE_PROFILE
Constants.SCOPE_EMAIL
Constants.SCOPE_PHONE
Constants.SCOPE_OFFLINE_ACCESS
```

## 4. Documentación de OpenID Connect

[https://openid.net/specs/openid-connect-core-1_0.html](https://openid.net/specs/openid-connect-core-1_0.html)