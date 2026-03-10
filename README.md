# F#_LAB
# Епанова Алина, КМБ-2, Лабораторная №3
## Задание 1. Seq.map
### Текст задачи
Получить список из сумм цифр натуральных чисел, содержащихся в исходном
списке.
### Алгоритм решения
1. Пользователь вводит количество чисел в исходной последоватьльности.
2. Функция inputSeq формирует последовательность введенных пользователем чисел с помощью yield.
3. Далее Seq.map применяет рекурсвную функцию SummDigit (вычисляет сумму цифр числа) к каждому элементу исходной последовательности.
4. Результат - новая последовательность сумм цифр каждого числа.
### Тестирование
<img width="1477" height="205" alt="image" src="https://github.com/user-attachments/assets/0b853e06-0755-4524-ba3f-7e21551a6e40" />
<img width="1469" height="221" alt="image" src="https://github.com/user-attachments/assets/ee988484-c5b3-4477-a845-4a5e6b72cfb1" />
<img width="1473" height="189" alt="image" src="https://github.com/user-attachments/assets/a25d477e-0334-4075-af72-b1a7aab2db71" />
<img width="1470" height="123" alt="image" src="https://github.com/user-attachments/assets/3ce2be7e-6324-4678-8f50-3093be913977" />
<img width="1472" height="129" alt="image" src="https://github.com/user-attachments/assets/372c1569-91a4-4bd3-a347-bbd7beae53fc" />



## Задание 2. Seq.fold
### Текст задачи
Найти сумму тех элементов списка, которые начинаются на заданную цифру.
### Алгоритм решения
1. Пользователь вводит количество чисел в списке.
2. Функция inputSeq формирует последовательность чисел введенных с клавиатуры.
3. Запрос пользователя цифры (0-9), с которой должно начинаться число.
4. Рекурсивная функция firstDigit находит первую цифру числа.
5. Seq.fold проходит по списку, накапливает сумму только тех элементов, у которых первая цифра совпадает с заданной.
6. Вывод итоговой суммы.
### Тестирование
<img width="1467" height="257" alt="image" src="https://github.com/user-attachments/assets/5487fe2b-044d-4a32-b051-7505f8e3119b" />
<img width="1476" height="246" alt="image" src="https://github.com/user-attachments/assets/e3a0e988-406b-461e-9556-539c1abaae00" />
<img width="1475" height="107" alt="image" src="https://github.com/user-attachments/assets/f6d4ebf8-ee7b-4016-91b9-95fb5b8a16fd" />

## Задание 3. Решить с использованием последовательности задачу на обработку файлов/каталогов
### Текст задачи
Вывести список файлов, имя которых начинается с заданного символа, в
указанном каталоге.
### Алгоритм решения

### Тестирование
<img width="1472" height="219" alt="image" src="https://github.com/user-attachments/assets/5b4ae0cb-e556-4d00-acf0-299d3ee27c3b" />
<img width="1474" height="206" alt="image" src="https://github.com/user-attachments/assets/7b9532c5-af47-4a0b-8d84-a7348234046f" />


