# Парольная защита информации на C#
Программа предназначена для разграничения полномочий пользователей на основе парольной аутентификации с использованием функций криптографического интерфейса Windows для защиты информации

![access_control](https://github.com/kamneva/access_control/blob/main/img/access%20control.gif)

Приложение создано на языке C# в интегрированной среде Microsoft Visual Studio с использованием технологии Window Forms.

Данная программа представляет собой процедуру аутентификации. Для начала работы с программой необходимо ввести пароль для расшифрования базы данных. При первом запуске программы необходимо непосредственно придумать данный пароль.

Кроме того, изначально в программе существует учетная запись администратора без пароля. При первом запуске программы администратору также необходимо придумать пароль для своей учетной записи. Администратор может управлять списком пользователей. Каждый пользователь при первом входе в свою учетную запись обязан придумать новый пароль. Администратор имеет возможность поставить парольное ограничение и (или) заблокировать выбранного пользователя. В случае, если администратор поставит ограничение на пароль пользователя, то пользователь будет обязан при входе заменить старый пароль на новый по всем правилам ограничения пароля.

