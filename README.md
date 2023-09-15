#  Инструкция как развернуть 
В классе setting.cs 
1. Изменить connectionString в классе settings

<a href="https://ibb.co/1vMYh9H"><img src="https://i.ibb.co/SscDWKq/image-Git2.png" alt="image-Git2" border="0"></a>


2. Изменить localHost:http://localhost:7207 в App.config во всех value

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
