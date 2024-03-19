```Yaml
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/runtime:7.0 AS runtime

WORKDIR /app

COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "lab_4.dll"]
```

**Сборка контейнера по образу**

<img width="498" alt="image" src="https://github.com/NikitaKopylovv/SoftwareArchitecture/assets/74319066/4a878d51-a73b-4208-981e-68248bf0ada7">

<img width="499" alt="image" src="https://github.com/NikitaKopylovv/SoftwareArchitecture/assets/74319066/fa25a3c5-a5c5-4ed8-9c9e-dd129f8a4cec">

**Docker образ**

<img width="1171" alt="image" src="https://github.com/NikitaKopylovv/SoftwareArchitecture/assets/74319066/c045b24e-426c-42e4-859f-46a4af64849c">

**Docker контейнер**

_Подогнал имена: вместо lab4 сделал так же paps_
<img width="1167" alt="image" src="https://github.com/NikitaKopylovv/SoftwareArchitecture/assets/74319066/b5c84f74-728e-4352-a787-92c063e28a05">

```pwsh
2024-02-20 01:47:31 Using sqlite database at /etc/paps/paps.db
2024-02-20 01:47:31 Listening on port 8000
```
