# SimpleAPI

SimpleAPI - API(Шаблон) для получения информации о игровых серверах "Minecraft" через сервис [MCSRVSTAT](https://mcsrvstat.us/) с возможность масштабирования под ваши нужны, написанный на ASP.NET.

## Установка
```bash
git clone https://github.com/ClonerNotFound/SimpleAPI
cd SimpleAPI
```

## Пользование
Для кастомных cors существует своя политика
```CorsPolicy
options.AddPolicy("AllowSpecificOrigin", builder =>
                {
                    builder.WithOrigins("http://localhost:3000") // Указываете свой, если порт не 3000
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
```



## Вклад
Если вы хотите внести свой вклад в этот проект, пожалуйста, отправьте pull request
