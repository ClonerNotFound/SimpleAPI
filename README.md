# 📦 Minecraft Server Info API

API на ASP.NET Core для получения информации о Minecraft серверах с помощью публичного API [mcsrvstat.us](https://api.mcsrvstat.us/).

---

## 🔧 Технологии

* ASP.NET Core 5.0+
* C#
* HttpClient
* JSON
* React / Vue (для клиента)

---

## 🚀 Установка и запуск

```bash
# Клонировать репозиторий
$ git clone https://github.com/your-username/minecraft-server-info-api.git
$ cd minecraft-server-info-api

# Установить зависимости
$ dotnet restore

# Запустить API на http://localhost:5000
$ dotnet run
```

---

## 🔍 Использование

### 🔗 Эндпоинт

```http
GET http://localhost:5000/api/server/{server_ip}
```

### ✅ Пример (успешный ответ)

```json
{
  "ip": "127.0.0.1",
  "port": 25565,
  "hostname": "localhost",
  "version": "1.16.5",
  "software": "Spigot",
  "map": "World",
  "motd": "Welcome to the server",
  "playersOnline": 10,
  "playersMax": 100,
  "players": [
    { "name": "Player1", "uuid": "..." }
  ],
  "plugins": [ "Plugin1 v1.0" ],
  "mods": [ "Mod1 v2.0" ]
}
```

### ❌ Пример (сервер оффлайн)

```json
{
  "online": false,
  "ip": "127.0.0.1",
  "port": 25567,
  "hostname": "not-working.mymcserver.tld",
  "debug": {
    "ping": false,
    "query": false,
    "cachehit": false
  }
}
```

---

## 🌐 Поддержка CORS

Для работы с фронтендом (например, React или Vue на `localhost:3000`):

```csharp
services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", builder =>
    {
        builder.WithOrigins("http://localhost:3000") // или замените на нужный домен
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

app.UseCors("AllowSpecificOrigin");
```

---

## 💻 Клиентская часть

Вы можете использовать любой современный фреймворк для обращения к API:

### Пример на Vue

```js
fetch("http://localhost:5000/api/server/hypixel.net")
  .then(res => res.json())
  .then(data => console.log(data));
```

---

## 📄 Лицензия

[MIT License](LICENSE)

---
