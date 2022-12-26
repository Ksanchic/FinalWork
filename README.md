 ## Задача

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Алгоритм решения представлен 3 способами: 
Task 1 - с вводом элементов массива с клавиатуры

Task 2 и Task 3  исходный массив задается на старте 
 Общий алгоритм решения:
Внутри цикла проверяем условие - длина строки меньше или равна трем( <=3 ), если да элемент первого массива заносится в count элемент второго массива. 
После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. 
Повторяем пункты до тех пор пока не достигнем конца исходного массива, удовлетворяющего заданным условиям
В результате возвращаем новый заполненый массив 



