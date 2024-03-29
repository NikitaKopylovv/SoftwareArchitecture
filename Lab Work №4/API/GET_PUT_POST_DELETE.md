**Базовый URL:** (http://localhost:5000) - базовый адрес запроса, к которому в дальнейшем будем добавлять эндпоинты для соответствующих запросов.

_1. JWT Токенизация (JWT Tokenization)_
Получение JWT-токена

Метод: POST

Путь: /auth/token

Описание: Генерирует JWT-токен для аутентификации клиента.

Параметры запроса:

username (строка, обязательно) - Имя пользователя клиента
password (строка, обязательно) - Пароль пользователя клиента

_Параметры запроса:_

username - имя пользователя,
password - пароль

_Пример ответа:_
```json
{
    "access_token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...",
    "token_type": "Bearer"
}
```

_2. Получение всех автоматов на карте (Get All Vending Machines)_
Получение списка всех автоматов

Метод: GET

Путь: get/vending-machines

Описание: Возвращает список всех вендинговых аппаратов на карте.

Параметры запроса:
Нет

Пример успешного ответа:
```json
[
    {
        "id_automat": 1,
        "id_adress": 3,
        "id_cell": 5,
        "operable": "true"
    },
    {
        "id_automat": 2,
        "id_adress": 3,
        ...
    }
]

```

_3. Получение состояния автомата (Get Vending Machine Status)_
Получение информации о состоянии автомата

Метод: GET

Путь: /vending-machines/{machine_id}/status

Описание: Возвращает информацию о состоянии конкретного вендингового аппарата.

Параметры запроса:

id_automat (целое число, обязательно) - Идентификатор вендингового аппарата

Пример успешного ответа:

```json
{
    "id_automat": 1,
    "operable": "true"
}

```

_4. Получение сотрудника по айди_

Метод: GET

Путь: get/employee/id

Описание: Возвращает сотрудника с введенным id.

Параметры запроса:
Нет

Пример успешного ответа:

```json
    {
        "Name": Виктор,
        "Surname": Иванов
    }
```

_5. Запись нового клиента (Create New Customer)_
Создание новой записи о клиенте

Метод: POST

Путь: add/employee

Описание: Создает новую запись о клиенте.

Параметры запроса:

name (строка, обязательно) - Имя нового клиента

Пример успешного ответа:
```json
{
    "Name": 102,
    "Surname": "Новый Клиент"
}
```

_6. Обновление записи об аппарате (Update Vending Machine Record)_
Обновление информации о вендинговом аппарате

Метод: PUT

Путь: /update/vending-machines/{machine_id}

Описание: Обновляет информацию о конкретном вендинговом аппарате.

Параметры запроса:

machine_id (целое число, обязательно) - Идентификатор вендингового аппарата
location (строка) - Новое местоположение аппарата

Пример успешного ответа:
```json
{
    {
        "id_automat": "Новый айди автомата",
        "id_adress": 3,
        "id_cell": "Новый айди ячейки",
        "operable": "true"
    }
}
```

_7. Удаление записи о вендинговом аппарате (Delete Automat Record)_
Удаление записи о о вендинговом аппарате

Метод: DELETE

Путь: /delete/vending-machines/{machine_id}

Описание: Удаляет запись о вендинговом аппарате.

Параметры запроса:

machine_id (целое число, обязательно) - Идентификатор автомата

Пример успешного ответа:
```json
{
    "message": "Запись о вендинговом аппарате успешно удалена."
}
```

_8. Добавление автомата_
Добавление записи об автомате

Метод: POST

Путь: /add

Описание: Добавляет запись об автомате

Параметры запроса: 

id_cell (массив чисел, обязательно) - айдишники ячеек для возможной проверки работоспособности, operable (булевый признак) - признак работоспособности автомата

Пример успешного ответа: 

```json
{
"id_automat" : 4,
"id_adress" : 3,
"id_cell" : 5,
"operable": true
}
```
