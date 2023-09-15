# GameGuessNumber
С какими проблемами столкнулся

1. Проблема с аккаунтом azure
2. Проблема с привязкой иностранной карты к аккаунту azure
3. Проблема с покупкой аккаунта azure
4. Как итог попытки удивить и развернуть в облаке не увенчались успехом, на это было потрачено 2,5 дня, далее в спешке пришлось делать локально
#  Инструкция как развернуть 
В классе setting.cs 
1. Изменить connectionString
2. Изменить localHost

   
<a href="https://ibb.co/51hPvTt"><img src="https://i.ibb.co/S6wz0NW/Setcs.png" alt="Setcs" border="0"></a>



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
4. Запустить PanGamesGuessNumber и PanGamesFunction одновременно
# Заключение
Можно было сделать намного лучше, я способен на это, если вас не устроит этот вариант тестового задания, прошу предоставьте мне еще немного времени, мне очень понравилась ваша компания и люди, проводившие техническое собеседование и я уверен, вы не ошибетесь, сделав выбор в пользу меня
