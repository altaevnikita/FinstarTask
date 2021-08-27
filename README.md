# Тестовое задание для Finstar

Этот проект - тестовое задание для компании Finstar

## Требования

* .Net Core 5
* Установленная утилита dotnet-ef
* NodeJS v14.17.3
* NPM v7.5.3
* Angular-cli 10

## Порядок запуска

* Скачать репозиторий
* В директории проекта запустить `dotnet build`
* Перейти в директорию `src\FinstarTask.Web`
* Запустить команду `dotnet ef database update`
* Запустить команду `dotnet run`

## Описание структуры таблицы

В таблице 3 колонки:
* Id - целое число, первичный ключ
* Code - целое число
* Value - строка

```sql
CREATE TABLE "DataRecords" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_DataRecords" PRIMARY KEY AUTOINCREMENT,
    "Code" INTEGER NOT NULL,
    "Value" TEXT NOT NULL
);
```