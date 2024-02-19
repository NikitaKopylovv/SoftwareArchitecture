```Yaml
FROM node:20-alpine

RUN apk add --no-cache python3 g++ make

WORKDIR /app

COPY . .

RUN yarn install --production

CMD ["node", "/app/src/index.js"]
```

<img width="526" alt="image" src="https://github.com/NikitaKopylovv/SoftwareArchitecture/assets/74319066/88069287-8590-4b98-be2f-6479c569cc93">

**Стартовая страница для добавления автомата**

<img width="526" alt="image" src="https://github.com/NikitaKopylovv/SoftwareArchitecture/assets/74319066/c3b5fabd-a358-4bb1-954e-7d7cb554057c">

<img width="1397" alt="image" src="https://github.com/NikitaKopylovv/SoftwareArchitecture/assets/74319066/4d46f639-b794-4153-8908-b390f657ae5f">

**Docker образ**

<img width="1179" alt="image" src="https://github.com/NikitaKopylovv/SoftwareArchitecture/assets/74319066/af8a7a07-18e3-4045-b079-2fc3912205d9">

**Сборка контейнера по образу**

<img width="620" alt="image" src="https://github.com/NikitaKopylovv/SoftwareArchitecture/assets/74319066/a85fde21-8110-4422-9ce6-27884f24ac6d">

<img width="1183" alt="image" src="https://github.com/NikitaKopylovv/SoftwareArchitecture/assets/74319066/d31eb78d-8fd1-4059-b532-d154750c411b">

**Docker контейнер**

<img width="504" alt="image" src="https://github.com/NikitaKopylovv/SoftwareArchitecture/assets/74319066/a8f361e8-ea8a-4481-b522-578d809d334a">
