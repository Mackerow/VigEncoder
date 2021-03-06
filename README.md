# Vigener Encoder

# Описание
Программа позволяет загрузить текстовый файл, зашифровать русские буквы в тексте с помощью шифра Виженера с возможностью использования ключа, а так же дешифровани.
Есть возможность ввода текста с клавиатуры. Весь результат можно сохранить в текстовый документ.

# Содержимое проекта
Файл MainWindow.xaml
![изображение](https://user-images.githubusercontent.com/75494411/165920026-2d6129b8-812d-491f-ba41-4769aa1cc183.png)

для взаиомдействия с программой было создано 5 кнопок, логика которых описана в MainWindow.xaml.cs

![изображение](https://user-images.githubusercontent.com/75494411/165920339-4659d276-4c7f-4bb8-aa46-ca8ad09ada17.png)

 OpenFile_Click - кнопка для загрузки текстового файла в программу.
 SaveCoding_Click - кнопка для сохранения результата шифрования/дешифрования
 WindowKeyInput_Click - кнопка для ввода ключа 
 Encode_Click - зашифровать введенную строку
 Decode_Click - расшифровать введенную строку 
 Методы Encode_Click и Decode_Click вызывают методы из классса VigenerCode, который содержит реализацию логики шифрования, дешифрования

![изображение](https://user-images.githubusercontent.com/75494411/165921173-cabc5463-ca88-456d-b578-2a276117e8d0.png)

Класс VigenerCode содержит два метода 
Encode -для шифрования строчки по шифру Виженера
Decode -для дешифрования строчки по шифру Виженера
Так же класс VigenerCode наследует абстрактный класс CodeMethods

![изображение](https://user-images.githubusercontent.com/75494411/165921530-e5e7bf3e-9e41-4a8f-93fa-14d2708b0e97.png)

В классе CodeMethods находятся частоиспользуемые методы для шифрования/ дешифрования


# Юнит тесты

![изображение](https://user-images.githubusercontent.com/75494411/165921936-c0f2c0b6-4d4e-4d16-a9a3-4f2b4e5e1e6e.png)
 
 Содержит 2 теста для проверки шифрования и 2 теста для проверки дешифрования. 
 
 # Как использовать 

![изображение](https://user-images.githubusercontent.com/75494411/165922253-6641a8ec-e09e-4fed-bbd1-463bb1fbd2b0.png)

Интерфейс программы интуитивно понятен.
"Загрузить файл"-кнопка для выбора текстого файла для загрузки.
В поле под этой кнопкой можно ввести текст без выбора файла.
"Ввести ключ"- кнопка для ввода ключа
"Дешифровать/Зашифровать" -кнопки для дешифрования/шифрования шифром Виженера соответственно.
"Сохранить результат" -кнопка, позволяющая сохранить результат работы программы на ЭВМ пользователя.
