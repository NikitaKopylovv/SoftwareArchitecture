**Тестирование API**

_1. Запрос: GET http://localhost:5000/api/get/vending-machines_
```javascript
pm.test("Status code is 200", function () {
    pm.response.to.have.status(200);
});

pm.test("Response contains automats", function () {
    pm.response.to.have.jsonBody("length", pm.greaterThan(0));
});
```
_2. Запрос: GET  http://localhost:5000/api/get/employees_
```javascript
pm.test("Status code is 200", function () {
    pm.response.to.have.status(200);
});

pm.test("Response contains employees", function () {
    pm.response.to.have.jsonBody("length", pm.greaterThan(0));
});
```

_3. Запрос: POST http://localhost:5000/api/add/employee_
```javascript
{
    "Name": "Новый",
    "Surname": "Сотрудник"
}

pm.test("Status code is 201", function () {
    pm.response.to.have.status(201);
});

pm.test("Response contains employee data", function () {
    pm.response.to.have.jsonBody("Id");
    pm.response.to.have.jsonBody("Name", "Новый");
    pm.response.to.have.jsonBody("Surname", "Сотрудник");
});
```

_4. Запрос: PUT http://localhost:5000/api/update/vending-machines/2_
```javascript
{
    "id_adress": 7,
    "id_cell": 7,
    "operable": true
}

pm.test("Status code is 200", function () {
    pm.response.to.have.status(200);
});

pm.test("Response contains updated automat data", function () {
    pm.response.to.have.jsonBody("id_adress", 7);
    pm.response.to.have.jsonBody("id_cell", 7);
    pm.response.to.have.jsonBody("operable", true);
});
```

_5. Запрос: DELETE http://localhost:5000/api/delete/vending-machines/2_
```javascript
pm.test("Status code is 200", function () {
    pm.response.to.have.status(200);
});

pm.test("Response contains success message", function () {
    pm.response.to.have.jsonBody("message", "Запись о вендинговом аппарате успешно удалена.");
});
```

_6. Запрос: GET http://localhost:5000/api/get/employee/1_
```javascript
pm.test("Status code is 200", function () {
    pm.response.to.have.status(200);
});

pm.test("Response contains employee data", function () {
    pm.response.to.have.jsonBody("Name");
    pm.response.to.have.jsonBody("Surname");
});
```

_7. Запрос: GET http://localhost:5000/api/get/EmployeByName/Ива_
```javascript
pm.test("Status code is 200", function () {
    pm.response.to.have.status(200);
});

pm.test("Response contains matching employees", function () {
    pm.response.to.have.jsonBody("length", pm.greaterThan(0));
});
```
_8. Запрос: POST http://localhost:5000/api/add_
```javascript
{
    "id_adress": 3,
    "id_cell": 5,
    "operable": true
}

pm.test("Status code is 201", function () {
    pm.response.to.have.status(201);
});

pm.test("Response contains created automat data", function () {
    pm.response.to.have.jsonBody("id_automat");
    pm.response.to.have.jsonBody("id_adress", 3);
    pm.response.to.have.jsonBody("id_cell", 5);
    pm.response.to.have.jsonBody("operable", true);
});
```

**Результаты**
<img width="1319" alt="image" src="https://github.com/NikitaKopylovv/SoftwareArchitecture/assets/74319066/cb5a0961-a7b2-440e-98bb-35970e1eec53">

<img width="1322" alt="image" src="https://github.com/NikitaKopylovv/SoftwareArchitecture/assets/74319066/4acd4cb9-9e2f-4e2b-bab1-d08aaf5b0808">

