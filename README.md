# Описание проекта
Игра называется “Угадай число”. Суть игры состоит в следующем:
на сервере загадывается число, пользователь вводит число, в ответ получает один из возможных вариантов ответа (больше/меньше/угадал), в игре предусмотрен механизм авторизации, просмотра статистики (никнейм и количество сыгранных игр) и задачи никнейма.
Клиентская часть реализована средствами .NET (Windows Forms), клиентская часть не содержит  никакой логики все проверки осуществляются с помощью запросов на бэкенд.
Серверная часть реализовывает игровую логику, авторизацию и обработку статистики. Серверную часть реализована на Azure Functions, хранение статистики и данных пользователя реализовано на PostgreSql
Вся система работает локально и ниже есть инструкция, как развернуть 
<a href="https://ibb.co/51Pw6JH"><img src="https://i.ibb.co/51Pw6JH/tsm4.png" alt="tsm4" border="0"></a> <a href="https://ibb.co/mRG3PWg"><img src="https://i.ibb.co/mRG3PWg/tsm3.png" alt="tsm3" border="0"></a> <a href="https://ibb.co/Z66vWSX"><img src="https://i.ibb.co/Z66vWSX/tsm2.png" alt="tsm2" border="0"></a> <a href="https://ibb.co/yW0MWDC"><img src="https://i.ibb.co/yW0MWDC/tsm1.png" alt="tsm1" border="0"></a>





#  Инструкция как развернуть 
В классе setting.cs 
1. Изменить connectionString в классе settings

<a href="https://ibb.co/1vMYh9H"><img src="https://i.ibb.co/SscDWKq/image-Git2.png" alt="image-Git2" border="0"></a>


2. Изменить localHost:http://localhost:7207 в App.config во всех value
<a href="https://ibb.co/yW0MWDC"><img src="https://i.ibb.co/yW0MWDC/tsm1.png" alt="tsm1" border="0"></a>
<a href="https://ibb.co/MNxHVbq"><img src="https://i.ibb.co/KypgqYC/image-Git1-10.png" alt="image-Git1-10" border="0"></a>


3. Создать таблицу в базе данных postgresql следующим скриптом
```
CREATE TABLE public.userinfo
(
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 0 MINVALUE 0 MAXVALUE 5050 ),
    login character varying(50) NOT NULL,
    password character varying(50) NOT NULL,
    gamescount integer DEFAULT 0,
    hidennumber integer DEFAULT 0,
    PRIMARY KEY (id)
);

ALTER TABLE IF EXISTS public.userinfo
    OWNER to postgres;
```
