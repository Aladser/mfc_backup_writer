# Запись МФЦ бэкапов в DOCX-таблицу

## Форма
![форма](/readme/frame.png)

## Конфиг
![конфиг](/readme/config.png)

+ ``BACKUP_FILE`` - путь к файлу бэкапа

+ ``COPY_CONTENT`` - Содержание копии

+ ``STORAGE_NUMBER`` - учетный номер носителя

+ ``STORAGE_PLACE`` - место хранения носителя

+ ``WORKER`` - ФИО, должность лица

+ Для добавления новой резервной копии добавить строку:

``<add key="COPY_CONTENT_{УНИКАЛЬНЫЙ НАБОР СИМВОЛОВ}" value="Название для формы"/>``
+ нового работника:

``<add key="WORKER_{УНИКАЛЬНЫЙ НАБОР СИМВОЛОВ}" value="имя работника"/>``

В поле **Размер резервной копии** можно вводить выражение суммы чисел *ЧИСЛО1 + ЧИСЛО2*